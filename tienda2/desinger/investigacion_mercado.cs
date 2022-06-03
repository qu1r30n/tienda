using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tienda2.clases;

using System.IO;

namespace tienda2.desinger
{
    public partial class investigacion_mercado : Form
    {
        string prov_actual;
        char[] G_parametros = { '|', '°', '¬', '^' };
        string año_mes_dia;

        Tex_base bas = new Tex_base();
        public investigacion_mercado()
        {
            InitializeComponent();
            DateTime fecha_hora = DateTime.Now;
            año_mes_dia= fecha_hora.ToString("yyyyMMdd");

            string[] provedores = bas.Leer("inf\\inventario\\provedores.txt", "0");//este regresa los provedores

            Operaciones_textos op_text = new Operaciones_textos();
            string provedores_txt = op_text.join_paresido('°', provedores);

            Ventana_emergente vent_emergent = new Ventana_emergente();
            string [] enviar = new string[] { "4°provedor°marinela°°marinela°" + provedores_txt };
            prov_actual=vent_emergent.Proceso_ventana_emergente(enviar);
            bas.si_no_existe_agega_extra("inf\\inventario\\provedores.txt", 0, prov_actual,prov_actual + '|');

        }

        private void btn_carg_investigacion_Click(object sender, EventArgs e)
        {
            bas.Crear_archivo_y_directorio(Directory.GetCurrentDirectory() + "\\investigacion_mercado");
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.InitialDirectory = Directory.GetCurrentDirectory() + "\\investigacion_mercado";
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                string[] info_compra = bas.Leer(opfd.FileName);
                for (int i = 0; i < info_compra.Length; i++)
                {
                    lstb_carga_investigacion.Items.Add(info_compra[i]);
                }
            }
        }

        

        private void Btn_eliminar_seleccionado_Click(object sender, EventArgs e)
        {
            lstb_carga_investigacion.Items.RemoveAt(lstb_carga_investigacion.SelectedIndex);
            txt_codigo_de_barras.Focus();
        }

        private void Btn_eliminar_todo_Click(object sender, EventArgs e)
        {
            lstb_carga_investigacion.Items.Clear();
            lstb_carga_investigacion.Focus();
        }

        private void Btn_elim_ultimo_Click(object sender, EventArgs e)
        {
            lstb_carga_investigacion.Items.Remove(lstb_carga_investigacion.Items[lstb_carga_investigacion.Items.Count - 1]);
            txt_codigo_de_barras.Focus();
        }


        private void Btn_verificar_his_Click(object sender, EventArgs e)
        {
            lst_mejor_opciones.Items.Clear();
            for (int i = 0; i < lstb_carga_investigacion.Items.Count; i++)
            {
                string[] item_espliteado = lstb_carga_investigacion.Items[i].ToString().Split('|');
                agregar_nuevo_precio_hist_produc(item_espliteado[1], 0, item_espliteado[0], 1, item_espliteado[2] + "°" + item_espliteado[3]);

            }
        }

        public void agregar_nuevo_precio_hist_produc(string cod_bar, int col_comp_prov, string provedor, int colum_editar, string info_agregar, char caracter_separacion1 = '|', char caracter_separacion2 = '°')
        {
            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            string direccion = "inf\\historial_provedores\\" + año_mes_dia + "\\" + cod_bar + ".txt";
            string direccion_temp = "inf\\historial_provedores\\" + año_mes_dia + "\\" + cod_bar + "_temp.txt";
            bas.Crear_archivo_y_directorio(direccion);
            string[] productos=bas.Leer(direccion);

            Operaciones_textos op_tex = new Operaciones_textos();

            bool bandera = false;
            for (int i = 0; i < productos.Length; i++)
            {
                string[] producto_espliteados = productos[i].Split(caracter_separacion1);
                if (producto_espliteados[col_comp_prov]==provedor)
                {
                    bandera = true;
                    producto_espliteados[colum_editar] = producto_espliteados[colum_editar] +caracter_separacion2 +info_agregar;
                    productos[i]=op_tex.join_paresido(caracter_separacion1, producto_espliteados);
                }
            }
            if (bandera==false)
            {
                bas.Agregar(direccion, provedor + caracter_separacion1 + info_agregar);
            }

            productos = bas.Leer(direccion);

            //ordenar-------------------------------------------------------------------------------------------------------------------------


            for (int i = 0; i < productos.Length; i++)
            {
                string[] producto_espliteados = productos[i].Split(caracter_separacion1);
                string[] precios = producto_espliteados[colum_editar].Split(caracter_separacion2);
                double precios_a_ordenar1 = Convert.ToDouble(precios[0]);

                for (int j = i+1; j < productos.Length; j++)
                {
                    string[] producto_espliteados2 = productos[i].Split(caracter_separacion1);
                    string[] precios2 = producto_espliteados2[colum_editar].Split(caracter_separacion2);
                    double precios_a_ordenar2 = Convert.ToDouble(precios2[precios.Length]);
                    string tem_intercambio;
                    if (precios_a_ordenar1<precios_a_ordenar2)
                    {
                        tem_intercambio=productos[i];
                        productos[i] = productos[j];
                        productos[j] = tem_intercambio;
                    }

                }
            }

            //pasar a archivo-------------------------------------------------------------------------------------------------------------------------
            
            for (int i = 0; i < productos.Length; i++)
            {
                bas.Agregar(direccion_temp, productos[i]);
            }

            Operaciones_archivos op = new Operaciones_archivos();
            op.remplasar_archivo(direccion, direccion_temp);

            

            MessageBox.Show("fin");
        }

        private void lstb_carga_investigacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_mejor_opciones.Items.Clear();
            if (lstb_carga_investigacion.SelectedItem != null)
            {
                string[] info_producto_lista = lstb_carga_investigacion.SelectedItem.ToString().Split(G_parametros[0]);
                string direccion = "inf\\historial_provedores\\" + año_mes_dia + "\\" + info_producto_lista[1] + ".txt";

                if (!bas.existe_archivo(direccion))
                {
                    MessageBox.Show("creara archivo: " + info_producto_lista[1]);
                }

                bas.Crear_archivo_y_directorio(direccion);
                string[] productos = bas.Leer(direccion);
                for (int i = 0; i < productos.Length; i++)
                {
                    lst_mejor_opciones.Items.Add(productos[i]);
                }
            }
        }

        private void txt_codigo_de_barras_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                Ventana_emergente vent_emergent = new Ventana_emergente();
                string[] enviar = new string[] { "1°precio°0°2" };
                string precio = vent_emergent.Proceso_ventana_emergente(enviar);
                
                lstb_carga_investigacion.Items.Add(prov_actual+ txt_codigo_de_barras.Text+"|" + precio + año_mes_dia);


            }
        }
    }
}
