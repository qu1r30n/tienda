using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

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
            if (txt_nom.Text != "" && txt_apllido_pat.Text != "" && txt_apllido_materno.Text != "" && txt_fecha_ingreso.Text != "" && txt_sueldo.Text != "" && cmb_cargo.Text != "" && txt_imag.Text != "" && txt_comentarios.Text != "" && lbl_id.Text != "#") 
            {
                if (txt_contrasenia.Text == txt_conf_contr.Text)
                {


                    string texto_introducir = lbl_id.Text + "|" + txt_conf_contr.Text + "|" + txt_nom.Text + "|" + txt_apllido_pat.Text + "|" + txt_apllido_materno.Text + "|" + txt_sueldo.Text + "|" + txt_fecha_ingreso.Text;
                    switch (cmb_cargo.Text)
                    {
                        case "admin":
                            bas.si_no_existe_agega_extra("inf\\us\\ad.txt", 0, txt_usuario.Text, txt_usuario.Text + "|" + txt_contrasenia.Text + "|" + lbl_id.Text + "|" + txt_nom.Text + "|" + txt_apllido_pat.Text + "|" + txt_apllido_materno.Text + "|" + txt_fecha_ingreso.Text + "|" + txt_sueldo.Text + "|" + cmb_cargo.Text + "|" + txt_imag.Text + "|" + txt_comentarios.Text + "|");
                            break;
                        case "encargado":
                            bas.si_no_existe_agega_extra("inf\\us\\encargado.txt", 0, txt_usuario.Text, txt_usuario.Text + "|" + txt_contrasenia.Text + "|" + lbl_id.Text + "|" + txt_nom.Text + "|" + txt_apllido_pat.Text + "|" + txt_apllido_materno.Text + "|" + txt_fecha_ingreso.Text + "|" + txt_sueldo.Text + "|" + cmb_cargo.Text + "|" + txt_imag.Text + "|" + txt_comentarios.Text + "|");
                            break;
                        case "usuario":
                            bas.si_no_existe_agega_extra("inf\\us\\usuario.txt", 0, txt_usuario.Text, txt_usuario.Text + "|" + txt_contrasenia.Text + "|" + lbl_id.Text + "|" + txt_nom.Text + "|" + txt_apllido_pat.Text + "|" + txt_apllido_materno.Text + "|" + txt_fecha_ingreso.Text + "|" + txt_sueldo.Text + "|" + cmb_cargo.Text + "|" + txt_imag.Text + "|" + txt_comentarios.Text + "|");
                            break;
                        case "invitado":
                            bas.si_no_existe_agega_extra("inf\\us\\invitado.txt", 0, txt_usuario.Text, txt_usuario.Text + "|" + txt_contrasenia.Text + "|" + lbl_id.Text + "|" + txt_nom.Text + "|" + txt_apllido_pat.Text + "|" + txt_apllido_materno.Text + "|" + txt_fecha_ingreso.Text + "|" + txt_sueldo.Text + "|" + cmb_cargo.Text + "|" + txt_imag.Text + "|" + txt_comentarios.Text + "|");
                            break;
                        default:
                            MessageBox.Show("no existe este cargo: " + cmb_cargo.Text);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("las contraseñas son no coinciden");
                }
            }
            else
            {
                MessageBox.Show("falta informacion");
            }

            
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void Lst_empleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tot= { };
            switch (cmb_cargo.SelectedItem)
            {
                case "admin":
                    tot = bas.Leer("inf\\us\\ad.txt");
                    break;
                case "encargado":
                    tot = bas.Leer("inf\\us\\encargado.txt");
                    break;
                case "usuario":
                    tot = bas.Leer("inf\\us\\usuario.txt");
                    break;
                case "invitado":
                    tot = bas.Leer("inf\\us\\invitado.txt");
                    break;
                default:
                    MessageBox.Show("no existe esa opcion");
                    break;
            }
            lbl_id.Text = "" + (tot.Length);
        }

        private void btn_img_fondo_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.InitialDirectory = Directory.GetCurrentDirectory() + "\\img";
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                string direccion_archivo = opfd.FileName;
                string[] direccion_spliteado = direccion_archivo.Split('\\');

                string direccion_verificar = "img\\" + direccion_spliteado[direccion_spliteado.Length - 1];
                if (!File.Exists(direccion_verificar))
                {
                    File.Copy(direccion_archivo, direccion_verificar);
                    txt_imag.Text = direccion_spliteado[direccion_spliteado.Length - 1];
                }
                else
                {
                    txt_imag.Text = direccion_spliteado[direccion_spliteado.Length - 1];
                }
            }
        }
    }
}
