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
    public partial class Compras_control_provedores : Form
    {
        Tex_base bas = new Tex_base();
        string direccion = "provedores\\ventas_en_dinero.txt";
        string[] provedores_info;
        char[] G_parametros = { '|', '°', '¬', '^' };

        public Compras_control_provedores()
        {
            InitializeComponent();
            provedores_info = bas.Leer(direccion);
            for (int i = 0; i < provedores_info.Length; i++)
            {
                lst_venta_provedor.Items.Add(provedores_info[i]);
            }

            Recargar_texbox();
        }

        private void btn_procesar_provedor_Click(object sender, EventArgs e)
        {
            if (txt_sugerencia_compra.Text == "")
            {
                MessageBox.Show("falta que pongas en compra lo que vas a comprar");
            }

            else
            {

                try
                {


                    Ventana_emergente vent_emer = new Ventana_emergente();
                    string[] enviar = new string[] { "3°reinvertir°1°0", "3°tomar_ganancia°2°0" };
                    string res = vent_emer.Proceso_ventana_emergente(enviar);
                    double cantidad_a_comprar = Convert.ToDouble(txt_sugerencia_compra.Text);

                    if (cantidad_a_comprar >= 0)
                    {

                        if (res == "1")
                        {
                            double din_vendido_prov = Convert.ToDouble(lbl_venta_provedor);
                            if (cantidad_a_comprar <= din_vendido_prov)
                            {
                                bas.Incrementa_celda(direccion, 0, lbl_provedor.Text, "1", "" + (cantidad_a_comprar * -1));
                            }
                            else
                            {
                                DialogResult desision = MessageBox.Show("Seguro quieres pagar mas dinero del que a ganado el provedor?", "invertir?", MessageBoxButtons.YesNo);
                                if (desision == DialogResult.Yes)
                                {
                                    bas.Incrementa_celda(direccion, 0, lbl_provedor.Text, "1", "" + (cantidad_a_comprar * -1));
                                }

                            }

                        }
                        else if (res == "2")
                        {
                            bas.Editar_espesifico(direccion, 0, lbl_provedor.Text, "1", "0");
                        }


                        Compras compras = new Compras(lbl_provedor.Text);

                        compras.Show();
                    }

                    else
                    {
                        MessageBox.Show("no puede ser numeros negativos");
                    }

                }

                catch (Exception)
                {
                    MessageBox.Show("caracteres invalidos en cantidad a  comprar");
                    throw;
                }
                this.Close();
            }
        }

        private void btn_buscar_provedor_Click(object sender, EventArgs e)
        {
            Ventana_emergente vent_emergent = new Ventana_emergente();

            string[] enviar = new string[] { "1°nombre_provedor" };

            string mensage = vent_emergent.Proceso_ventana_emergente(enviar);//el uno significa que modificara el inventario

            mensage = bas.Trimend_paresido(mensage);

            bas.si_no_existe_agega_comparacion("inf\\inventario\\provedores.txt", mensage);

            this.Close();
        }

        private void lst_venta_provedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_venta_provedor.SelectedItem != null)
            {
                string[] info_producto_lista = lst_venta_provedor.SelectedItem.ToString().Split(G_parametros[0]);
                lbl_provedor.Text = info_producto_lista[0];
                lbl_venta_provedor.Text = info_producto_lista[1];
                double precio = Convert.ToDouble(info_producto_lista[1]);
                txt_sugerencia_compra.Text = "" + (precio - (precio * 0.1));
            }
        }

        private void Recargar_texbox()
        {

            Tex_base bas = new Tex_base();

            string[] imprimir = bas.Leer(direccion, null, G_parametros[0]);
            txt_buscar_provedor.AutoCompleteCustomSource.Clear();
            for (int k = 0; k < imprimir.Length; k++)
            {
                txt_buscar_provedor.AutoCompleteCustomSource.Add("" + imprimir[k]);
            }
        }

        private void txt_buscar_provedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                busqueda_de_prov(txt_buscar_provedor.Text);

                if (txt_buscar_provedor.Text != "")
                {
                    busqueda_de_prov(txt_buscar_provedor.Text);
                }
                else
                {
                    for (int i = 0; i < provedores_info.Length; i++)
                    {
                        lst_venta_provedor.Items.Add(provedores_info[i]);
                    }
                }

                lst_venta_provedor.Focus();

            }
        }

        private void busqueda_de_prov(string info_buscar)
        {
            lst_venta_provedor.Items.Clear();
            for (int i = 0; i < provedores_info.Length; i++)
            {
                if (info_buscar == provedores_info[i])
                {
                    lst_venta_provedor.Items.Add(info_buscar);
                }
            }
        }

    }
}
