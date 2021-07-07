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
            sismul sism = new sismul();
            sism.ingreso_de_din_comp(cmb_curso.Text, txt_id.Text, Convert.ToDouble(txt_dinero.Text));
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Ventana_emergente vent_emergent = new Ventana_emergente();
            Tex_base bas = new Tex_base();

            string[] enviar;
            enviar = new string[] { "1°id_patrocinador", "1°tabla_patrocinador","1°id_encargado", "1°tabla_encargado", "1°nombre", "1°apellido_paterno", "1°apellido_materno", "1°numero_de_cuenta°0°2", "1°banco", "1°curp", "1°numero_celular°0°2", "1°direccion", "1°colonia", "1°municipio", "1°estado", "1°correo"}; 
            string resultado=vent_emergent.Proceso_ventana_emergente(enviar);
            string[] resultado_spliteado = resultado.Split('|');
            
            string datos_personales="";
            for (int i = 4; i < resultado_spliteado.Length; i++)
            {
                datos_personales = datos_personales + resultado_spliteado[i] + "|";
            }
            datos_personales = datos_personales.TrimEnd('|');
            string[] datos_personales_spliteados = datos_personales.Split('|');
            
            string dat_pat = bas.Seleccionar("sismul\\" + resultado_spliteado[1] + "_inf.txt", 0, resultado_spliteado[0]);
            string[] dat_pat_split = dat_pat.Split('|');
            string dat_enc = bas.Seleccionar("sismul\\" + resultado_spliteado[3] + "_inf.txt", 0, resultado_spliteado[2]);
            string[] dat_enc_split = dat_enc.Split('|');
            sismul sism = new sismul();
            sism.registro_compuesto(resultado_spliteado[0], resultado_spliteado[1], resultado_spliteado[3], resultado_spliteado[2], datos_personales_spliteados);


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
    }
}
