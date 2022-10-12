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
    public partial class pedidos : Form
    {
        Tex_base bas = new Tex_base();
        prediccion pre = new prediccion();
        string direccion_ranking;

        string[] provedores;
        List<string> lst_productos=new List<string>();
        public pedidos()
        {
            InitializeComponent();
            Recargar_texbox();

            DateTime fecha = DateTime.Now;
            direccion_ranking = "inf\\ranking\\" + fecha.ToString("yyyy") + "_ranking.txt";
            string[] resultado = pre.compra(direccion_ranking, 4, 5, 6, 7);

            carga_info_arreglo(resultado);
        }

        private void lstb_sugerencia_DoubleClick(object sender, EventArgs e)
        {
            string[] num_de_item_lstb = lstb_sugerencia.SelectedItem.ToString().Split('#');
            bool hay_un_num_item_igual = false;
            for (int i = 0; i < lstb_a_pedir.Items.Count; i++)
            {
                string[] numero_de_item_lista_productos = lstb_a_pedir.Items[i].ToString().Split('#');
                if (num_de_item_lstb[0] == numero_de_item_lista_productos[0])
                {
                    hay_un_num_item_igual = true;
                    lstb_sugerencia.Items.RemoveAt(lstb_sugerencia.SelectedIndex);
                }
            }

            
            if (hay_un_num_item_igual == false)
            {
                pasar_de_sugerencia_a_lsbapedir(lstb_sugerencia.SelectedItem + "");
            }

            if (lstb_sugerencia.SelectedItem != null)
            {
                lstb_a_pedir.Items.Add(lstb_sugerencia.SelectedItem);
                lstb_sugerencia.Items.RemoveAt(lstb_sugerencia.SelectedIndex);
            }

            
        }

        private void lstb_a_pedir_DoubleClick(object sender, EventArgs e)
        {
            if (lstb_a_pedir.SelectedItem != null)
            {
                string[] num_de_item_lstb = lstb_a_pedir.SelectedItem.ToString().Split('#');
                bool hay_un_num_item_igual = false;
                for (int i = 0; i < lstb_sugerencia.Items.Count; i++)
                {
                    string[] numero_de_item_lista_productos = lstb_sugerencia.Items[i].ToString().Split('#');
                    if (num_de_item_lstb[0]==numero_de_item_lista_productos[0])
                    {
                        hay_un_num_item_igual = true;
                        lstb_a_pedir.Items.RemoveAt(lstb_a_pedir.SelectedIndex);
                    }
                }
                if (hay_un_num_item_igual==false)
                {
                    pasar_de_lsbapedir_a_sugerencia(lstb_a_pedir.SelectedItem + "");
                }
                
            }
        }

        private void carga_info(string cargas, char caracter_separacion = '|')
        {
            string[] cargas_2 = cargas.Split(caracter_separacion);
            for (int i = 0; i < cargas_2.Length; i++)
            {
                lstb_sugerencia.Items.Add(i + "#" + cargas_2[i]);

            }

        }
        private void carga_info_arreglo(string[] cargas)
        {
            lstb_sugerencia.Items.Clear();
            for (int i = 0; i < cargas.Length; i++)
            {
                //el string "||"es porque hai va a ser el espacio donde la aplicacion retorne precio y cantida
                lstb_sugerencia.Items.Add(i + "#" + cargas[i] + "||");
                lst_productos.Add(i + "#" + cargas[i] + "||");
            }

        }

        private void pasar_de_lsbapedir_a_sugerencia(string item_seleccionado)
        {

            string[] datos_item_a_pedir = item_seleccionado.Split('#');
            int posicion_item_a_pedir = Convert.ToInt32(datos_item_a_pedir[0]);
            List<string> lista_productos = new List<string>();
            for (int i = 0; i < lstb_sugerencia.Items.Count; i++)
            {
                lista_productos.Add(lstb_sugerencia.Items[i] + "");
            }
            lstb_sugerencia.Items.Clear();
            int fin_del_listbox = lista_productos.Count;
            bool encontro_otro_mayor = false;
            bool puesto_anterior_mente = false;
            for (int i = 0; i < fin_del_listbox; i++)
            {
                string[] datos_item_sugerencia = lista_productos[i].Split('#');
                int posicion_item_sugerencia = Convert.ToInt32(datos_item_sugerencia[0]);

                if (posicion_item_a_pedir < posicion_item_sugerencia)
                {


                    if (puesto_anterior_mente == false)
                    {
                        lstb_sugerencia.Items.Add(item_seleccionado);
                        lstb_a_pedir.Items.RemoveAt(lstb_a_pedir.SelectedIndex);
                        puesto_anterior_mente = true;
                    }
                    encontro_otro_mayor = true;
                }
                string chequeo_temp = lista_productos[i];
                lstb_sugerencia.Items.Add(chequeo_temp);
            }
            if (encontro_otro_mayor == false)
            {
                lstb_sugerencia.Items.Add(item_seleccionado);
                lstb_a_pedir.Items.RemoveAt(lstb_a_pedir.SelectedIndex);
            }


        }

        private void pasar_de_sugerencia_a_lsbapedir(string item_seleccionado)
        {

            string[] datos_item_a_pedir = item_seleccionado.Split('#');
            int posicion_item_a_pedir = Convert.ToInt32(datos_item_a_pedir[0]);
            List<string> lista_productos = new List<string>();
            for (int i = 0; i < lstb_a_pedir.Items.Count; i++)
            {
                lista_productos.Add(lstb_a_pedir.Items[i] + "");
            }
            lstb_a_pedir.Items.Clear();
            int fin_del_listbox = lista_productos.Count;
            bool encontro_otro_mayor = false;
            bool puesto_anterior_mente = false;
            for (int i = 0; i < fin_del_listbox; i++)
            {
                string[] datos_item_sugerencia = lista_productos[i].Split('#');
                int posicion_item_sugerencia = Convert.ToInt32(datos_item_sugerencia[0]);

                if (posicion_item_a_pedir < posicion_item_sugerencia)
                {


                    if (puesto_anterior_mente == false)
                    {
                        lstb_a_pedir.Items.Add(item_seleccionado);
                        lstb_sugerencia.Items.RemoveAt(lstb_sugerencia.SelectedIndex);
                        puesto_anterior_mente = true;
                    }
                    encontro_otro_mayor = true;
                }
                string chequeo_temp = lista_productos[i];
                lstb_a_pedir.Items.Add(chequeo_temp);
            }
            if (encontro_otro_mayor == false)
            {
                lstb_a_pedir.Items.Add(item_seleccionado);
                lstb_sugerencia.Items.RemoveAt(lstb_sugerencia.SelectedIndex);
            }


        }
        private void btn_procesar_Click(object sender, EventArgs e)
        {
            arreglos_compuestos_y_simples arr_comp_simp = new arreglos_compuestos_y_simples();

            DateTime fecha = DateTime.Now;
            string año_mes_dia = fecha.ToString("yyyyMMdd");
            if (lstb_a_pedir.Items.Count > 0)
            {
                string direccion = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\info_tienda\\pedidos\\" + año_mes_dia + "_pedido.txt";
                bas.Crear_archivo_y_directorio(direccion);

                for (int k = 0; k < lstb_a_pedir.Items.Count; k++)
                {
                    string[] items_a_pedir = lstb_a_pedir.Items[k].ToString().Split('#');
                    bas.Agregar(direccion, items_a_pedir[1]);
                }
                lstb_a_pedir.Items.Clear();

                //string[] resultado = pre.compra(direccion_ranking, 4, 5, 6, 7);
                //carga_info_arreglo(resultado);

                MessageBox.Show("listo");
            }
        }


        private void Recargar_texbox()
        {
            
            string[] provedores_sin_split= bas.Leer("inf\\inventario\\provedores.txt");
            for (int i = 0; i < provedores_sin_split.Length; i++)
            {
                provedores = provedores_sin_split[i].Split('|');
                txt_buscar_provedor.AutoCompleteCustomSource.Add("" + provedores[0]);

            }
            
        }

        private void txt_buscar_provedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                busqueda_de_prov(txt_buscar_provedor.Text);

                if (txt_buscar_provedor.Text != "")
                {
                    busqueda_de_prov(txt_buscar_provedor.Text);
                }
                else
                {
                    for (int i = 0; i < lst_productos.Count; i++)
                    {
                        lstb_sugerencia.Items.Add(lst_productos[i]);
                    }
                }

                lstb_sugerencia.Focus();

            }
        }

        private void busqueda_de_prov(string info_buscar)
        {
            lstb_sugerencia.Items.Clear();

            for (int i = 0; i < lst_productos.Count; i++)
            {
                string[] inf_prod = lst_productos[i].Split('|');

                if (info_buscar == inf_prod[3])
                {
                    lstb_sugerencia.Items.Add(lst_productos[i]);
                }
            }
            
        }

    }
}
