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
    public partial class Empleados : Form
    {
        Tex_base bas = new Tex_base();
        public Empleados()
        {
            InitializeComponent();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_contrasenia.Text == txt_conf_contr.Text)
            {


                string texto_introducir = lbl_id.Text + "|" + txt_conf_contr.Text + "|" + txt_nom.Text + "|" + txt_apllido_pat.Text + "|" + txt_apllido_materno.Text + "|" + txt_sueldo.Text + "|" + txt_fecha_ingreso.Text;
                switch (cmb_cargo.Text)
                {
                    case "admin":
                        break;
                    case "usuario":
                        break;
                    case "invitado":
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("las contraseñas son no coinciden");
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void Lst_empleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
