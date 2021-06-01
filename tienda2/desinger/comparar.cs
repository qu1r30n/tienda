using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienda2.desinger
{
    public partial class Comparar : Form
    {
        char[] G_parametros = { '|', '°', '¬', '^' };

        //string direc_tem = "";

        public string Direccion_grafica { get; set; }

        public string Palabra_reconocimiento { get; set; }

        public static string Checkbox_en_uso;

        //----------------------------------------------
        private Area_principal _parent;
        public Comparar(Area_principal parent)
        {

            _parent = parent;
            //---------------------------------------------------

            InitializeComponent();
            Rdb_ventas.Checked = true;
            try
            {
                DateTime fecha_hora = DateTime.Now;
                cmb_año.Text = fecha_hora.ToString("yyyy");
                cmb_mes.Text = fecha_hora.ToString("MM");

                Combo_a("ventas\\total_años.txt");
                Combo_m("ventas\\" + cmb_año.Text + "\\" + cmb_año.Text + ".txt");
                Combo_d("ventas\\" + cmb_año.Text + "\\" + cmb_mes.Text + "\\" + cmb_mes.Text + ".txt");

                //direc_tem = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\" + fecha_hora.ToString("MM") + ".txt";

                if (cmb_año.Items.Count == 0)
                {
                    MessageBox.Show("no estan los archivos as una venta y reinicia el programa para ver los graficos");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Btn_comparar_Click(object sender, EventArgs e)
        {

            if (Rdb_ventas.Checked)
            {
                if (Checkbox_en_uso == "0")
                {
                    Modelo_grafica(cmb_año.Text, cmb_mes.Text, cmb_dia.Text, true);
                }
                else
                {
                    MessageBox.Show("tienen que ser del mismo tipo las graficas ejemplo ventas y ventas");
                }

            }
            else if (Rdb_productos.Checked)
            {
                if (Checkbox_en_uso == "1")
                {
                    Modelo_grafica_productos(cmb_año.Text, cmb_mes.Text, cmb_dia.Text, true);
                }
                else
                {
                    MessageBox.Show("tienen que ser del mismo tipo las graficas ejemplo ventas y ventas");
                }
            }


            else if (Rdb_gastos.Checked)
            {
                if (Checkbox_en_uso == "2")
                {
                    Modelo_grafica_gastos(cmb_año.Text, cmb_mes.Text, cmb_dia.Text, true);
                }
                else
                {
                    MessageBox.Show("tienen que ser del mismo tipo las graficas ejemplo ventas y ventas");
                }
            }
            this.Close();
        }

        public void Combo_a(string direccion_archivo)
        {
            string temp;
            cmb_año.Items.Clear();
            
            //elim9_combo_a = 0;
            Tex_base bas = new Tex_base();
            string[] archivos = bas.Leer(direccion_archivo);
            string[] espliteado;
            for (int i = 0; i < archivos.Length; i++)
            {
                temp = archivos[i];
                espliteado = temp.Split(G_parametros[0]);
                cmb_año.Items.Add(espliteado[0]);
            }
        }

        private void Cmb_año_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combo_m("ventas\\" + cmb_año.Text + "\\" + cmb_año.Text + ".txt");
        }

        private void Cmb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combo_d("ventas\\" + cmb_año.Text + "\\" + cmb_mes.Text + "\\" + cmb_mes.Text + ".txt");
        }

        public void Combo_m(string direccion_archivo)
        {
            string temp;
            cmb_mes.Items.Clear();
            //elim10_combo_m = 0;
            Tex_base bas = new Tex_base();
            string[] archivos = bas.Leer(direccion_archivo);
            string[] espliteado;
            for (int i = 0; i < archivos.Length; i++)
            {
                temp = archivos[i];
                espliteado = temp.Split(G_parametros[0]);
                cmb_mes.Items.Add(espliteado[0]);
            }

        }

        public void Combo_d(string direccion_archivo)
        {
            string temp;
            cmb_dia.Items.Clear();
            //elim11_combo_d = 0;
            Tex_base bas = new Tex_base();
            string[] archivos = bas.Leer(direccion_archivo);
            string[] espliteado;
            for (int i = 0; i < archivos.Length; i++)
            {
                temp = archivos[i];
                espliteado = temp.Split(G_parametros[0]);
                cmb_dia.Items.Add(espliteado[0]);
            }
        }


        public void Modelo_grafica(string c_año = "", string c_mes = "", string c_dia = "", bool comparacion = true)
        {

            _parent.Lst_ventas.Items.Clear();
            if (c_año == "" && c_mes == "" && c_dia == "")
            {
                _parent.Grafica_para_comparacion(Direccion_grafica, "ventas\\total_años.txt", Palabra_reconocimiento, "total_años", comparacion);
            }

            else if (c_año != "" && c_mes == "" && c_dia == "")
            {
                _parent.Grafica_para_comparacion(Direccion_grafica, "ventas\\" + c_año + "\\" + c_año + ".txt", Palabra_reconocimiento, c_año, comparacion);
            }
            else if (c_año != "" && c_mes != "" && c_dia == "")
            {
                _parent.Grafica_para_comparacion(Direccion_grafica, "ventas\\" + c_año + "\\" + c_mes + "\\" + c_mes + ".txt", Palabra_reconocimiento, c_año + "" + c_mes, comparacion);
            }
            else if (c_año != "" && c_mes != "" && c_dia != "")
            {
                _parent.Grafica_horas_para_comparar(Direccion_grafica, "ventas\\" + c_año + "\\" + c_mes + "\\" + "dias\\" + c_dia + "" + c_mes + "" + c_año + ".txt", Palabra_reconocimiento, c_año + "" + c_mes + "" + c_dia, 0, comparacion);
            }
            else
            {
                MessageBox.Show("error verifica que los combobox");
            }
        }

        public void Modelo_grafica_productos(string c_año = "", string c_mes = "", string c_dia = "", bool comparacion = false)
        {
            _parent.Lst_ventas.Items.Clear();
            if (c_año == "" && c_mes == "" && c_dia == "")
            {
                _parent.Grafica_para_comparacion(Direccion_grafica, "ventas\\p_total_años.txt", Palabra_reconocimiento, "p_total_años", comparacion);
            }

            else if (c_año != "" && c_mes == "" && c_dia == "")
            {
                _parent.Grafica_para_comparacion(Direccion_grafica, "ventas\\" + c_año + "\\p_" + c_año + ".txt", Palabra_reconocimiento, "p_" + c_año, comparacion);
            }
            else if (c_año != "" && c_mes != "" && c_dia == "")
            {
                _parent.Grafica_para_comparacion(Direccion_grafica, "ventas\\" + c_año + "\\" + c_mes + "\\p_" + c_mes + ".txt", Palabra_reconocimiento, "p_" + c_año + "" + c_mes, comparacion);
            }
            else if (c_año != "" && c_mes != "" && c_dia != "")
            {
                _parent.Grafica_horas_para_comparar(Direccion_grafica, "ventas\\" + c_año + "\\" + c_mes + "\\" + "dias\\p_" + c_dia + "" + c_mes + "" + c_año + ".txt", Palabra_reconocimiento, "p_" + c_año + "" + c_mes + "" + c_dia, 0, comparacion);
            }
            else
            {
                MessageBox.Show("error verifica que los combobox");
            }
        }

        public void Modelo_grafica_gastos(string c_año = "", string c_mes = "", string c_dia = "", bool comparacion = false)
        {
            _parent.Lst_ventas.Items.Clear();
            if (c_año == "" && c_mes == "" && c_dia == "")
            {
                _parent.Grafica_para_comparacion(Direccion_grafica, "ventas\\g_total_años.txt", Palabra_reconocimiento, "g_total_años", comparacion);
            }

            else if (c_año != "" && c_mes == "" && c_dia == "")
            {
                _parent.Grafica_para_comparacion(Direccion_grafica, "ventas\\" + c_año + "\\g_" + c_año + ".txt", Palabra_reconocimiento, "g_" + c_año, comparacion);
            }
            else if (c_año != "" && c_mes != "" && c_dia == "")
            {
                _parent.Grafica_para_comparacion(Direccion_grafica, "ventas\\" + c_año + "\\" + c_mes + "\\g_" + c_mes + ".txt", Palabra_reconocimiento, "g_" + c_año + "" + c_mes, comparacion);
            }
            else if (c_año != "" && c_mes != "" && c_dia != "")
            {
                _parent.Grafica_horas_para_comparar(Direccion_grafica, "ventas\\" + c_año + "\\" + c_mes + "\\" + "dias\\g_" + c_dia + "" + c_mes + "" + c_año + ".txt", Palabra_reconocimiento, "g_" + c_año + "" + c_mes + "" + c_dia, 1, comparacion);
            }
            else
            {
                MessageBox.Show("error verifica que los combobox");
            }
        }

    }
}

