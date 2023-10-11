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
    public partial class prestamos : Form
    {
        List<string> g_cursos = new List<string>();
        string g_cursos_texto = "";
        Tex_base bas = new Tex_base();


        public prestamos()
        {
            InitializeComponent();

            string directorio_actual = Directory.GetCurrentDirectory();
            string direccion_cursos = directorio_actual + "\\deu\\";
            string[] direccion_cursos_cada1 = Directory.GetFiles(direccion_cursos);

            for (int i = 0; i < direccion_cursos_cada1.Length; i++)
            {
                string[] temp = direccion_cursos_cada1[i].Split('\\');
                string[] temp2 = temp[temp.Length - 1].Split('.');
                string nombre_deudor = temp2[0];
                cmb_nombre.Items.Add(nombre_deudor);
                cmb_nombre.AutoCompleteCustomSource.Add(nombre_deudor);
                g_cursos.Add(nombre_deudor);
                g_cursos_texto = g_cursos_texto + nombre_deudor + "°";
            }
            g_cursos_texto = bas.Trimend_paresido(g_cursos_texto, '°');


        }
    }
}
