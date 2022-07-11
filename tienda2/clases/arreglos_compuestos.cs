using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda2.clases
{
    class arreglos_compuestos
    {
        public string[] extraer_ultimo_arreglo_dentro_de_arreglo(string []arreglo_de_arreglos,string colum_comp_string,string comparacion, int[] columna_donde_esta_arreglo, char[] caracteres_separacion)
        {
            //la_estructura_que_puse---------------------------------------------
            //arreglos_compuestos arr_comp = new arreglos_compuestos();
            //string[] arreglo_de_arreglos = new string[] { "1|2|3°4°5°6°7¬8¬9¬10°11°12|13", "2|2|3°4°5°6°7¬8¬9¬10°11°12|13", "3|2|3°4°5°6°7¬8¬9¬10°11°12|13", "4|2|3°4°5°6°7¬8¬9¬10°11°12|13", "5|2|3°4°5°6°7¬8¬9¬10°11°12|13" };
            //int[] columna_donde_esta_arreglo = new int[] { 2, 4 };
            //char[] caracteres_separacion = new char[] { '|', '°', '¬' };
            //string[] arreglo_extraido = arr_comp.extraer_ultimo_arreglo_dentro_de_arreglo(arreglo_de_arreglos, "0", "3", columna_donde_esta_arreglo, caracteres_separacion);
            //--------------------------------------------------------------------

            int columna_comparar = Convert.ToInt32(colum_comp_string);
            bool bandera = false;
            for (int i = 0; i < arreglo_de_arreglos.Length; i++)
            {    
                string[] arreglo_de_arreglos_esplit=arreglo_de_arreglos[i].Split(caracteres_separacion[0]);
                if (arreglo_de_arreglos_esplit[columna_comparar]==comparacion)
                {
                    bandera = true;
                    string[] arreglo_recursivo = arreglo_de_arreglos_esplit;
                    for (int j = 1; j < caracteres_separacion.Length; j++)
                    {
                        string temp = ""+arreglo_recursivo[columna_donde_esta_arreglo[j-1]];
                        arreglo_recursivo = temp.Split(caracteres_separacion[j]);
                    }
                    return arreglo_recursivo;
                }
            }
            if (bandera==false)
            {
                return new string[] { "error"+caracteres_separacion[0]+" no encontro codigo" };
            }

            return new string[] { "error"+caracteres_separacion[0]+"no se" };
        }
    }
}
