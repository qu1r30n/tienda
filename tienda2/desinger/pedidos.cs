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
        public pedidos()
        {
            InitializeComponent();
            DateTime fecha = DateTime.Now;
            direccion_ranking = "inf\\ranking\\" + fecha.ToString("yyyy") + "_ranking.txt";
            string[] resultado = pre.compra(direccion_ranking, 4, 5, 6, 7);
            
            carga_info_arreglo(resultado);
        }

        private void lstb_sugerencia_DoubleClick(object sender, EventArgs e)
        {
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
                string[]datos_item_a_pedir=lstb_a_pedir.SelectedItem.ToString().Split('#');
                int posicion_item_a_pedir = Convert.ToInt32(datos_item_a_pedir[0]);
                List<string> lista_productos=new List<string>();
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
                    string[]datos_item_sugerencia=lista_productos[i].Split('#');
                    int posicion_item_sugerencia = Convert.ToInt32(datos_item_sugerencia[0]);
                    
                    if (posicion_item_a_pedir < posicion_item_sugerencia) 
                    {
                        
                        
                        if (puesto_anterior_mente==false)
                        {
                            lstb_sugerencia.Items.Add(lstb_a_pedir.SelectedItem);
                            lstb_a_pedir.Items.RemoveAt(lstb_a_pedir.SelectedIndex);
                            puesto_anterior_mente = true;
                        }
                        encontro_otro_mayor = true;
                    }
                    string chequeo_temp = lista_productos[i];
                    lstb_sugerencia.Items.Add(chequeo_temp);
                }
                if (encontro_otro_mayor==false)
                {
                    lstb_sugerencia.Items.Add(lstb_a_pedir.SelectedItem);
                    lstb_a_pedir.Items.RemoveAt(lstb_a_pedir.SelectedIndex);
                }
                
                
            }
        }

        private void carga_info(string cargas,char caracter_separacion='|')
        {
            string[] cargas_2 = cargas.Split(caracter_separacion);
            for (int i = 0; i < cargas_2.Length; i++)
            {
                lstb_sugerencia.Items.Add(i + "#" + cargas_2[i]);

            }

        }
        private void carga_info_arreglo(string[] cargas)
        {
            
            for (int i = 0; i < cargas.Length; i++)
            {
                lstb_sugerencia.Items.Add(i + "#" + cargas[i]);

            }

        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            if (lstb_a_pedir.Items.Count>0)
            {
                string direccion = "";
                bas.Crear_archivo_y_directorio(direccion);
                for (int i = 0; i < lstb_a_pedir.Items.Count; i++)
                {
                    string[] items_a_pedir=lstb_a_pedir.Items[i].ToString().Split('#');
                    bas.Agregar(direccion, items_a_pedir[1]);
                }

            }
        }
    }
}
