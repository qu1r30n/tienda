using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda2.clases
{
    class Operaciones_textos
    {
        public string Trimend_paresido(string texto, char caracter_separacion = '|')
        {
            string texto_editado = "";
            string[] texto_spliteado = texto.Split(caracter_separacion);

            if (texto_spliteado[texto_spliteado.Length - 1] == "")
            {
                for (int i = 0; i < texto_spliteado.Length; i++)
                {
                    if (i < texto_spliteado.Length - 2)
                    {
                        texto_editado = texto_editado + texto_spliteado[i] + caracter_separacion;
                    }
                    else
                    {
                        texto_editado = texto_editado + texto_spliteado[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < texto_spliteado.Length; i++)
                {
                    if (i < texto_spliteado.Length - 1)
                    {
                        texto_editado = texto_editado + texto_spliteado[i] + caracter_separacion;
                    }

                    else
                    {
                        texto_editado = texto_editado + texto_spliteado[i];
                    }
                }
            }


            return texto_editado;
        }
    }
}
