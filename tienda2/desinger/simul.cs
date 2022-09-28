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
    public partial class simul : Form
    {
        arreglos_compuestos_y_simples arr_c_y = new arreglos_compuestos_y_simples();
        Tex_base bas = new Tex_base();
        string G_sucursal = "";
        string G_compu = "";
        List<string> g_cursos=new List<string>();
        string g_cursos_texto="";
        public simul()
        {
            
            
            InitializeComponent();
            
            string directorio_actual= Directory.GetCurrentDirectory();
            string direccion_cursos= directorio_actual + "\\sismul2\\";
            string[] direccion_cursos_cada1 = Directory.GetFiles(direccion_cursos);

            

            for (int i = 0; i < direccion_cursos_cada1.Length; i++)
            {
                string[] temp= direccion_cursos_cada1[i].Split('\\');
                string[] temp2 = temp[temp.Length - 1].Split('.');
                string nombre_curso = temp2[0];
                cmb_curso.Items.Add(nombre_curso);
                cmb_curso.AutoCompleteCustomSource.Add(nombre_curso);
                g_cursos.Add(nombre_curso);
                g_cursos_texto = g_cursos_texto + nombre_curso + "°";
            }
            g_cursos_texto = bas.Trimend_paresido(g_cursos_texto, '°');
            
        }

        private void btn_ingresar_dinero_Click(object sender, EventArgs e)
        {
            string datos = "entrada_dinero|" + cmb_curso.Text + "|" + txt_id.Text + "|" + txt_dinero.Text;
            registro_movimiento(datos);

            simul2 sim = new simul2();
            sim.entrada_dinero_compuesto_metodo_sin_lista_de_patrocinadores(cmb_curso.Text, txt_id.Text, txt_dinero.Text);
            
            MessageBox.Show("listo");
            cmb_curso.Text = "";
            txt_dinero.Text = "";
            txt_id.Text = "";
            txt_id.Focus();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            
            //modelo_registro_simple();
            modelo_registro_complejo();
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_dinero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cmb_curso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        
        private void modelo_registro_complejo()
        {

            string[] enviar;
            string cursos = "";
            for (int i = 0; i < g_cursos.Count; i++)
            {
                cursos = cursos + g_cursos[i] + "°";
            }
            cursos = cursos.TrimEnd('°');
            enviar = new string[] { "1°id_patrocinador", "4°tabla_patrocinador°°°°" + cursos, "1°id_encargado", "4°tabla_encargado°°°°" + cursos, "1°nombre", "1°apellido_paterno", "1°apellido_materno", "1°numero_de_cuenta°0°2", "1°banco", "1°curp", "1°numero_celular°0°2", "1°direccion", "1°colonia", "1°municipio", "1°estado", "1°correo" };
            Ventana_emergente vent_emergent = new Ventana_emergente();
            string resultado_string = vent_emergent.Proceso_ventana_emergente(enviar);
            registro_movimiento("registro_complejo|"+resultado_string);
            resultado_string = resultado_string.TrimEnd('|');
            string[] resultado = resultado_string.Split('|');

            string info_usuario = "";
            for (int i = 4; i < resultado.Length; i++)
            {
                info_usuario = info_usuario + resultado[i] + "°";
            }

            simul2 sim2 = new simul2();

            sim2.registro_complejo(resultado[0] + "", resultado[1] + "", resultado[2] + "", resultado[3] + "", info_usuario);
        }

        private void modelo_registro_simple()
        {
            string[] enviar;
            string cursos = "";
            for (int i = 0; i < g_cursos.Count; i++)
            {
                cursos = cursos + g_cursos[i] + "°";
            }
            cursos = cursos.TrimEnd('°');
            enviar = new string[] { "1°id_encargado", "4°tabla_encargado°°°°" + cursos, "1°nombre", "1°apellido_paterno", "1°apellido_materno", "1°numero_de_cuenta°0°2", "1°banco", "1°curp", "1°numero_celular°0°2", "1°direccion", "1°colonia", "1°municipio", "1°estado", "1°correo" };
            Ventana_emergente vent_emergent = new Ventana_emergente();
            string resultado_string = vent_emergent.Proceso_ventana_emergente(enviar);
            registro_movimiento("registro_simple|"+resultado_string);
            resultado_string = resultado_string.TrimEnd('|');
            string[] resultado = resultado_string.Split('|');

            string info_usuario = "";
            for (int i = 2; i < resultado.Length; i++)
            {
                info_usuario = info_usuario + resultado[i] + "°";
            }

            simul2 sim2 = new simul2();
            
            sim2.registro_simple(resultado[0] + "", resultado[1] + "", info_usuario);
        }

        private void registroVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modelo_registro_simple();
        }

        private void registro_movimiento(string movimiento)
        {
            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            string dir = "sismul2\\mov\\mov_diario_det\\" + año_mes_dia + "_mov.txt";
            bas.Crear_archivo_y_directorio(dir);
            bas.Agregar(dir, movimiento);

        }

        private void btn_retirar_dineri_Click(object sender, EventArgs e)
        {
            simul2 sim2 = new simul2();
            string dir_tabla = "sismul2\\" + G_sucursal + G_compu + cmb_curso.Text + ".txt";
            string datos_usuario = bas.Seleccionar(dir_tabla, 0, txt_id.Text);
            string[] arreglo_de_arreglo = { datos_usuario };
            
            char[] caracteres = { '|','°' };
            string[] datos_comunes_us = arr_c_y.extraer_ultimo_arreglo_dentro_de_arreglo(arreglo_de_arreglo, 0, txt_id.Text, "7", caracteres);

            DialogResult resultado_de_dialog = MessageBox.Show("nombre: "+datos_comunes_us[0] + " " + datos_comunes_us[1]+ datos_comunes_us[2] + "\ncurp: "+datos_comunes_us[5]+"\n es correcto:", "info usuario", MessageBoxButtons.YesNo);
            if (resultado_de_dialog==DialogResult.Yes)
            {

                sim2.retiro_de_dinero(cmb_curso.Text, txt_id.Text, txt_dinero.Text);
                registro_movimiento("retiro|" + cmb_curso.Text + "|" + txt_id.Text + "|" + txt_dinero.Text);
                cmb_curso.Text = "";
                txt_dinero.Text = "";
                txt_id.Text = "";
            }
            
        }

        private void pruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tienda2.desinger.Ventana_emergente vent_emergent = new Ventana_emergente();
            string[] enviar;
            enviar = new string[] { "4°curso°°1°" + g_cursos_texto, "1°a", "1°b°0°2", "4°curso°°1°" + g_cursos_texto, "1°c" };
            string mensage = vent_emergent.Proceso_ventana_emergente(enviar);
            string[] temp = mensage.Split('|');
            string dir1 = "sismul2\\" + G_sucursal + G_compu + temp[0] + ".txt";
            string dir2 = "sismul2\\" + G_sucursal + G_compu + temp[3] + ".txt";
            string a = bas.Seleccionar(dir1, 0, temp[1]);
            string c = bas.Seleccionar(dir2, 0, temp[4]);
            if (true)
            {


                string[] tod_dat_a = { a };
                string[] tod_dat_c = { c };

                char[] caracteres = { '|', '°' };
                string[] a_dat = arr_c_y.extraer_ultimo_arreglo_dentro_de_arreglo(tod_dat_a, 0, temp[1], "7", caracteres);
                string[] c_dat = arr_c_y.extraer_ultimo_arreglo_dentro_de_arreglo(tod_dat_c, 0, temp[4], "7", caracteres);


                DialogResult resultado_dialog = MessageBox.Show("a: " + temp[1] + " " + a_dat[0] + a_dat[1] + a_dat[2] + "\nb: " + temp[2] + "\nc: " + temp[4] + " " + c_dat[0] + c_dat[1] + c_dat[2] + "\nestas seguro?: ", "estas seguro?", MessageBoxButtons.YesNo);


                if (resultado_dialog == DialogResult.Yes)
                {
                    string[] a_spliteado = a.Split('|');
                    double cant_a = Convert.ToDouble(a_spliteado[6]);
                    double cant_tr = Convert.ToDouble(temp[2]);
                    if (cant_a >= cant_tr)
                    {
                        registro_movimiento("pru|" + temp[0] + "|" + temp[1] + "|" + temp[2] + "|" + temp[3] + "|" + temp[4] + "|");
                        bas.Incrementa_celda(dir1, 0, temp[1], "6", "" + (cant_tr * -1));
                        bas.Incrementa_celda(dir2, 0, temp[4], "6", cant_tr + "");
                        MessageBox.Show("exitoso");

                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
            }
        }
    }
}
