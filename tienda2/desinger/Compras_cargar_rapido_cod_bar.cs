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
    public partial class Compras_cargar_rapido_cod_bar : Form
    {
        Tex_base bas = new Tex_base();
        char[] G_parametros = { '|', '°', '¬', '^' };
        List<string> G_productos = new List<string>();

        private Compras _parent;
        public Compras_cargar_rapido_cod_bar(Compras parent)
        {
            _parent = parent;
            InitializeComponent();


        }

        private void Btn_procesar_venta_Click(object sender, EventArgs e)
        {

            string[] productos = bas.Leer("inf\\inventario\\invent.txt");

            bool hubo_repetidos = false;
            for (int i = 0; i < lst_cod_bar.Items.Count; i++)
            {

                bool esta = false;

                for (int j = 0; j < i; j++)
                {
                    if ("" + lst_cod_bar.Items[i] == "" + lst_cod_bar.Items[j])
                    {
                        esta = true;
                        hubo_repetidos = true;
                    }

                }
                if (esta == false)
                {
                    bool bandera = false;
                    for (int k = 0; k < productos.Length; k++)
                    {
                        string[] produc_esplit = productos[k].Split('|');
                        if (produc_esplit[3] == "" + lst_cod_bar.Items[i])
                        {
                            _parent.lst_carga.Items.Add(produc_esplit[3] + "|" + produc_esplit[1] + "|1");
                            bandera = true;
                        }

                    }
                    if (bandera==false)
                    {
                        _parent.lst_carga.Items.Add(lst_cod_bar.Items[i]);
                    }

                }
            }
            if (hubo_repetidos == true)
            {
                MessageBox.Show("hubo codigos de barra repetidos se eliminaron los repetidos");
            }
            this.Close();

        }

        private void Btn_elim_ultimo_Click(object sender, EventArgs e)
        {
            lst_cod_bar.Items.Remove(lst_cod_bar.Items[lst_cod_bar.Items.Count - 1]);
        }

        private void Btn_eliminar_todo_Click(object sender, EventArgs e)
        {
            lst_cod_bar.Items.Clear();
        }

        private void Btn_eliminar_seleccionado_Click(object sender, EventArgs e)
        {
            lst_cod_bar.Items.RemoveAt(lst_cod_bar.SelectedIndex);
        }

        private void txt_cod_bar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txt_cod_bar.Text != "")
                {
                    lst_cod_bar.Items.Add(txt_cod_bar.Text);
                    txt_cod_bar.Text = "";
                }
            }
        }

        private void btn_carga_archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            //opfd.InitialDirectory = Directory.GetCurrentDirectory() + "\\pedidos";
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                string[] info_compra = bas.Leer(opfd.FileName);
                for (int i = 0; i < info_compra.Length; i++)
                {
                    lst_cod_bar.Items.Add(info_compra[i]);
                    
                }
            }
        }
    }
}
