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
    public partial class igualar_provedores : Form
    {
        Tex_base bas = new Tex_base();
        char[] G_parametros = { '|', '°', '¬', '^' };
        public igualar_provedores()
        {
            InitializeComponent();
            Recargar_texbox();



        }

        private void Recargar_texbox()
        {

            string[] imprimir3 = bas.Leer("inf\\inventario\\provedores.txt", "0", G_parametros[0]);
            cmb_provedor.Items.Clear();
            cmb_provedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_provedor.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cmb_provedor_editar.Items.Clear();
            cmb_provedor_editar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_provedor_editar.AutoCompleteSource = AutoCompleteSource.CustomSource;

            for (int k = 0; k < imprimir3.Length; k++)
            {
                cmb_provedor.Items.Add("" + imprimir3[k]);
                cmb_provedor.AutoCompleteCustomSource.Add("" + imprimir3[k]);

                cmb_provedor_editar.Items.Add("" + imprimir3[k]);
                cmb_provedor_editar.AutoCompleteCustomSource.Add("" + imprimir3[k]);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            bas.Editar_espesifico("inf\\inventario\\provedores.txt",0,cmb_provedor.Text,"0",cmb_provedor_editar.Text);
            bas.Editar_espesifico("inf\\inventario\\invent.txt", 6, cmb_provedor.Text, "6", cmb_provedor_editar.Text);
            bas.Editar_espesifico("provedores\\ventas_en_dinero.txt", 0, cmb_provedor.Text, "0", cmb_provedor_editar.Text);
            MessageBox.Show("LISTO");
            cmb_provedor.Text = "";
            cmb_provedor.Focus();
        }
    }
}
