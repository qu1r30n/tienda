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
    public partial class simul : Form
    {
        public simul()
        {
            InitializeComponent();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            simul2 sim = new simul2();
            sim.entrada_dinero_compuesto_metodo_sin_lista_de_patrocinadores(cmb_curso.Text, txt_id.Text, txt_dinero.Text);
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
            enviar = new string[] { "1°id_patrocinador", "1°tabla_patrocinador", "1°id_encargado", "1°tabla_encargado", "1°nombre", "1°apellido_paterno", "1°apellido_materno", "1°numero_de_cuenta°0°2", "1°banco", "1°curp", "1°numero_celular°0°2", "1°direccion", "1°colonia", "1°municipio", "1°estado", "1°correo" };
            Ventana_emergente vent_emergent = new Ventana_emergente();
            string resultado_string = vent_emergent.Proceso_ventana_emergente(enviar);
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
            enviar = new string[] {"1°id_encargado", "1°tabla_encargado", "1°nombre", "1°apellido_paterno", "1°apellido_materno", "1°numero_de_cuenta°0°2", "1°banco", "1°curp", "1°numero_celular°0°2", "1°direccion", "1°colonia", "1°municipio", "1°estado", "1°correo" };
            Ventana_emergente vent_emergent = new Ventana_emergente();
            string resultado_string = vent_emergent.Proceso_ventana_emergente(enviar);
            resultado_string = resultado_string.TrimEnd('|');
            string[] resultado = resultado_string.Split('|');

            string info_usuario = "";
            for (int i = 4; i < resultado.Length; i++)
            {
                info_usuario = info_usuario + resultado[i] + "°";
            }

            simul2 sim2 = new simul2();
            
            sim2.registro_simple(resultado[0] + "", resultado[1] + "", info_usuario);
        }

    }
}
