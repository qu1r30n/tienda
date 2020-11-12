using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienda2.desinger
{
    public partial class Inventario : Form
    {
        char[] G_parametros = { '|' };
        public Inventario()
        {
            InitializeComponent();
            Tex_base bas = new Tex_base();
            bas.Crear_archivo_y_directorio("inf\\inventario\\invent.txt","id|producto|precio|codigo|cantidad|compra|marca|");
            string[] imprimir = bas.Leer("inf\\inventario\\invent.txt", "0|1|2|3|4", "" + G_parametros[0]);
            for (int i = 0; i < imprimir.Length; i++)
            {
                Lst_productos.Items.Add(imprimir[i]);
            }

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Txt_edit_id_producto.Hide();
            Txt_edit_nombre.Hide();
            Txt_edit_precio.Hide();
            Txt_edit_codigo.Hide();
            Txt_edit_cantidad.Hide();
            Lbl_edit_id_producto.Hide();
            Lbl_edit_producto.Hide();
            Lbl_edit_precio.Hide();
            Lbl_edit_codigo.Hide();
            Lbl_edit_cantidad.Hide();
            Btn_edit_por.Hide();

            Tex_base bas = new Tex_base();
            bas.Crear_archivo_y_directorio("inf\\inventario\\invent.txt","id|producto|precio|codigo|cantidad|compra|marca|");
            if ("" != Txt_precio.Text && "" != Txt_nombre.Text)
            {
                // este es el antiguo raro agregar estudiar despues bas.agregar("inf\\inventario\\invent.txt", Txt_id_producto.Text + G_parametros[0] + Txt_nombre.Text + G_parametros[0] + Txt_precio.Text + G_parametros[0] + Txt_codigo.Text + G_parametros[0] + Txt_cantidad.Text, "id|producto|precio|codigo|cantidad|compra|marca|");
                bas.Agregar("inf\\inventario\\invent.txt", Txt_id_producto.Text + G_parametros[0] + Txt_nombre.Text + G_parametros[0] + Txt_precio.Text + G_parametros[0] + Txt_codigo.Text + G_parametros[0] + Txt_cantidad.Text);
                Lst_productos.Items.Clear();
                string[] imprimir = bas.Leer("inf\\inventario\\invent.txt", "0|1|2|3|4", "" + G_parametros[0]);
                for (int i = 0; i < imprimir.Length; i++)
                {
                    Lst_productos.Items.Add(imprimir[i]);
                }

            }
            else
            {
                MessageBox.Show("no estan llenas las casillas del producto o el precio");
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Txt_edit_id_producto.Show();
            Txt_edit_nombre.Show();
            Txt_edit_precio.Show();
            Txt_edit_codigo.Show();
            Txt_edit_cantidad.Show();
            Lbl_edit_id_producto.Show();
            Lbl_edit_producto.Show();
            Lbl_edit_precio.Show();
            Lbl_edit_codigo.Show();
            Lbl_edit_cantidad.Show();
            Btn_edit_por.Show();

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Txt_edit_id_producto.Hide();
            Txt_edit_nombre.Hide();
            Txt_edit_precio.Hide();
            Txt_edit_codigo.Hide();
            Txt_edit_cantidad.Hide();
            Lbl_edit_id_producto.Hide();
            Lbl_edit_producto.Hide();
            Lbl_edit_precio.Hide();
            Lbl_edit_codigo.Hide();
            Lbl_edit_cantidad.Hide();
            Btn_edit_por.Hide();

            Tex_base bas = new Tex_base();
            bas.Crear_archivo_y_directorio("inf\\inventario\\invent.txt","id|producto|precio|codigo|cantidad|compra|marca|");
            bas.Eliminar("inf\\inventario\\invent.txt", Txt_nombre.Text);
            Lst_productos.Items.Clear();
            string[] leido = bas.Leer("inf\\inventario\\invent.txt", "0|1|2|3|4", "" + G_parametros[0]);
            foreach (var item in leido)
            {
                Lst_productos.Items.Add(item);
            }
        }


        private void Btn_edit_por_Click(object sender, EventArgs e)
        {
            Tex_base bas = new Tex_base();
            bas.Crear_archivo_y_directorio("inf\\inventario\\invent.txt","id|producto|precio|codigo|cantidad|compra|marca|");
            if ("" != Txt_precio.Text && "" != Txt_nombre.Text)
            {

                MessageBox.Show(bas.Editar("inf\\inventario\\invent.txt", Txt_id_producto.Text + G_parametros[0] + Txt_nombre.Text + G_parametros + Txt_precio.Text + G_parametros + Txt_codigo.Text + G_parametros + Txt_cantidad.Text, Txt_edit_id_producto.Text + G_parametros + Txt_edit_nombre.Text + G_parametros + Txt_edit_precio.Text + G_parametros + Txt_edit_codigo.Text + G_parametros + Txt_edit_cantidad.Text, "0|1|2|3|4"));

                Lst_productos.Items.Clear();

                foreach (var item in bas.Leer("inf\\inventario\\invent.txt", "0|1|2|3|4", "" + G_parametros[0]))
                {
                    Lst_productos.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("no estan llenas las casillas del producto o el precio");
            }
            /*
            Txt_edit_id_producto.Hide();
            Txt_edit_nombre.Hide();
            Txt_edit_precio.Hide();
            Txt_edit_codigo.Hide();
            Txt_edit_cantidad.Hide();
            Lbl_edit_id_producto.Hide();
            Lbl_edit_producto.Hide();
            Lbl_edit_precio.Hide();
            Lbl_edit_codigo.Hide();
            Lbl_edit_cantidad.Hide();
            Btn_edit_por.Hide();
            */
        }

        private void Lst_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = "" + Lst_productos.SelectedItem;
            string[] temp2 = temp.Split(G_parametros);
            Txt_id_producto.Text = temp2[0];
            Txt_nombre.Text = temp2[1];
            Txt_precio.Text = temp2[2];
            Txt_codigo.Text = temp2[3];
            Txt_cantidad.Text = temp2[4];
            Txt_edit_id_producto.Text = temp2[0];
            Txt_edit_nombre.Text = temp2[1];
            Txt_edit_precio.Text = temp2[2];
            Txt_edit_codigo.Text = temp2[3];
            Txt_edit_cantidad.Text = temp2[4];
        }
    }
}
