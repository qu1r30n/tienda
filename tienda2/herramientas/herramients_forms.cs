using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienda2.herramientas
{
    public partial class herramients_forms : Form
    {
        public herramients_forms()
        {
            InitializeComponent();
        }

        public void ordenar_lisbox(ListBox lista_a_ordenar,int numero_columna,string orden = "menor_mayor",char caracter_separacion='|')
        {
            
            if (orden == "menor_mayor")
            {
                for (int i = 0; i < lista_a_ordenar.Items.Count; i++)
                {
                    for (int j = i + 1; j < lista_a_ordenar.Items.Count; j++)
                    {

                        string[] arreglo_espliteado = lista_a_ordenar.Items[i].ToString().ToString().Split(caracter_separacion);
                        double arriba = Convert.ToDouble(arreglo_espliteado[numero_columna]);
                        string[] arreglo_espliteado2 = lista_a_ordenar.Items[j].ToString().Split(caracter_separacion);
                        double abajo = Convert.ToDouble(arreglo_espliteado2[numero_columna]);
                        string temp;
                        if (arriba > abajo)
                        {
                            temp = lista_a_ordenar.Items[i]+"";
                            lista_a_ordenar.Items[i] = lista_a_ordenar.Items[j];
                            lista_a_ordenar.Items[j] = temp;
                        }
                    }
                }
            }


            else if (orden == "mayor_menor")
            {
                for (int i = 0; i < lista_a_ordenar.Items.Count; i++)
                {
                    for (int j = i + 1; j < lista_a_ordenar.Items.Count; j++)
                    {

                        string[] arreglo_espliteado = lista_a_ordenar.Items[i].ToString().Split(caracter_separacion);
                        double arriba = Convert.ToDouble(arreglo_espliteado[numero_columna]);
                        string[] arreglo_espliteado2 = lista_a_ordenar.Items[j].ToString().Split(caracter_separacion);
                        double abajo = Convert.ToDouble(arreglo_espliteado2[numero_columna]);
                        string temp;
                        if (arriba < abajo)
                        {
                            temp = lista_a_ordenar.Items[i]+"";
                            lista_a_ordenar.Items[i] = lista_a_ordenar.Items[j];
                            lista_a_ordenar.Items[j] = temp;
                        }
                    }
                }
            }
        }

        public void editar_colum_listbox(ListBox list_box, int index_fila_modificar, int columna, string nueva_info, char caracter_separacion = '|')
        {

            string[] info_mod = list_box.Items[index_fila_modificar].ToString().Split(caracter_separacion);
            info_mod[columna] = nueva_info;
            list_box.Items[index_fila_modificar] = string.Join(caracter_separacion + "", info_mod);
        }
    }
}
