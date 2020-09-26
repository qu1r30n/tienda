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

namespace tienda2.desinger
{
    public partial class cambiar_precio : Form
    {
        char[] G_parametros = { '|' };
        List<string> G_productos = new List<string>();
        tex_base bas = new tex_base();
        operaciones_textos op_text = new operaciones_textos();

        public cambiar_precio()
        {
            InitializeComponent();
            recargar_texbox();
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lbl_precio_compra_cant.Text != "$")
            {
                if (rdb_producto.Checked == true)
                {
                    bas.editar_espesifico("inf\\inventario\\invent.txt", 3, txt_buscar_producto.Text, "1", txt_remplazo.Text);
                    actualisar_txt(0, txt_buscar_producto.Text, "3", txt_remplazo.Text);
                    lbl_nombre_producto.Text = "";
                    lbl_precio_compra_cant.Text = "$";
                    lbl_precio_venta.Text = "$";
                    lbl_cantidad_cant.Text = "$";
                    txt_buscar_producto.Text = "";
                    txt_remplazo.Text = "";
                    txt_buscar_producto.Focus();
                }

                else if (rdb_compra.Checked == true)
                {
                    bas.editar_espesifico("inf\\inventario\\invent.txt",3,txt_buscar_producto.Text,"5",txt_remplazo.Text);
                    actualisar_txt(0, txt_buscar_producto.Text, "5", txt_remplazo.Text);
                    lbl_nombre_producto.Text = "";
                    lbl_precio_compra_cant.Text = "$";
                    lbl_precio_venta.Text = "$";
                    lbl_cantidad_cant.Text = "$";
                    txt_buscar_producto.Text = "";
                    txt_remplazo.Text = "";
                    txt_buscar_producto.Focus();

                }

                else if (rdb_venta.Checked == true)
                {
                    bas.editar_espesifico("inf\\inventario\\invent.txt", 3, txt_buscar_producto.Text, "2", txt_remplazo.Text);
                    actualisar_txt(0, txt_buscar_producto.Text, "2", txt_remplazo.Text);
                    lbl_nombre_producto.Text = "";
                    lbl_precio_compra_cant.Text = "$";
                    lbl_precio_venta.Text = "$";
                    lbl_cantidad_cant.Text = "$";
                    txt_buscar_producto.Text = "";
                    txt_remplazo.Text = "";
                    txt_buscar_producto.Focus();
                }

                else if (rdb_inventario.Checked == true)
                {
                    bas.editar_espesifico("inf\\inventario\\invent.txt", 3, txt_buscar_producto.Text, "4", txt_remplazo.Text);
                    actualisar_txt(0, txt_buscar_producto.Text, "4", txt_remplazo.Text);
                    lbl_nombre_producto.Text = "";
                    lbl_precio_compra_cant.Text = "$";
                    lbl_precio_venta.Text = "$";
                    lbl_cantidad_cant.Text = "$";
                    txt_buscar_producto.Text = "";
                    txt_remplazo.Text = "";
                    txt_buscar_producto.Focus();
                }

                else
                {
                    MessageBox.Show("elige el dato que quieres cambiar");
                }
            }
            else
            {
                MessageBox.Show("no se encontro producto dentro del inventario");
            }
        }
        private void recargar_texbox()
        {
            string[] imprimir = bas.leer("inf\\inventario\\invent.txt", "3|0|2|1|4|5|6|7", "" + G_parametros[0]);
            txt_buscar_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < imprimir.Length; k++)
            {
                G_productos.Add(imprimir[k]);
                txt_buscar_producto.AutoCompleteCustomSource.Add(imprimir[k]);
            }
        }

        private void procesar_codigo(string codigo)
        {
            
            bool bandera = false;
            for (int i = 0; i < G_productos.Count; i++)
            {
                String[] temp = G_productos[i].Split(G_parametros);
                if (codigo == temp[0])
                {
                    txt_buscar_producto.Text = temp[0];
                    lbl_nombre_producto.Text = temp[3];
                    lbl_precio_compra_cant.Text = temp[5];
                    lbl_precio_venta.Text = temp[2];
                    lbl_cantidad_cant.Text = temp[4];

                    bandera = true;
                    break;
                }
            }

            if (bandera == false)
            {

                tex_base bas = new tex_base();
                string[] cantidad_produc = bas.leer("inf\\inventario\\invent.txt", "0", "" + G_parametros[0]);//el 0 solo regresa la primera columna que creo es el id
                string[] espliteado = txt_buscar_producto.Text.Split(G_parametros);
                //------------------------------------------------------------
                ventana_emergente vent_emergent = new ventana_emergente();
                //-------------------------------------------------------------
                string[] enviar = { "1°id°" + (cantidad_produc.Length), "1°producto", "1°precio", "1°codigo°" + espliteado[0], "1°cantidad", "1°compra", "1°marca" };
                string mensage = vent_emergent.proceso_ventana_emergente(enviar, 1);//el uno significa que modificara el inventario
                MessageBox.Show("ya se agrego el producto: " + mensage);
                txt_buscar_producto.Text = "";
            }

        }

        private void txt_buscar_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = txt_buscar_producto.Text.Split(G_parametros);
                procesar_codigo(info[0]);
                txt_remplazo.Focus();
            }
        }

        private void txt_remplazo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void actualisar_txt(int num_column_comp, string comparar, string numero_columnas_editar, string editar_columna, char caracter_separacion = '|')
        {
            for (int i = 0; i < txt_buscar_producto.AutoCompleteCustomSource.Count; i++)
            {
                string[] palabra = txt_buscar_producto.AutoCompleteCustomSource[i].Split(caracter_separacion);

                if (palabra[num_column_comp] == comparar)
                {
                    string linea_editada = "";
                    string[] columnas_editar = numero_columnas_editar.Split(caracter_separacion);
                    string[] remplaso_dato = editar_columna.Split(caracter_separacion);
                    for (int j = 0; j < columnas_editar.Length; j++)
                    {
                        palabra[Convert.ToInt32(columnas_editar[j])] = remplaso_dato[j];
                    }
                    for (int k = 0; k < palabra.Length; k++)
                    {
                        linea_editada = linea_editada + palabra[k] + caracter_separacion;
                    }
                    linea_editada= op_text.trimend_paresido(linea_editada, caracter_separacion);
                    txt_buscar_producto.AutoCompleteCustomSource[i] = linea_editada;
                    G_productos[i] = linea_editada;
                }
            }
        }

    }
}