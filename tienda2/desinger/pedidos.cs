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
    public partial class pedidos : Form
    {
        char[] G_parametros = { '|' };
        List<string> G_productos = new List<string>();
        tex_base bas = new tex_base();
        public pedidos()
        {
            InitializeComponent();
            recargar_texbox();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string temp = txt_buscar_producto.Text + "|" + lbl_nombre_producto.Text + "|" + txt_cantidad.Text + "|" + txt_costo_compra.Text + "|" + txt_provedor.Text + "|" + lbl_id.Text;
            lst_compras.Items.Add(temp);
            
            
            string temporal = "";
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;
            try
            {
                for (int coll = 0; coll < lst_compras.Items.Count; coll++)
                {
                    temporal = "" + lst_compras.Items[coll];
                    temporal_s = temporal.Split(G_parametros);

                    if (temporal_s[0] != "")
                    {
                        total = total + (Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[3]));
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                lbl_cuenta.Text = "" + total;
            }
            catch (Exception)
            {

                throw;
            }

            txt_buscar_producto.Focus();

            txt_buscar_producto.Text = "";
            txt_cantidad.Text = "";
            txt_costo_compra.Text = "";
            txt_nom_producto.Text = "";
            txt_provedor.Text = "";
            if (rdb_codigo_barras.Checked)
            {
                txt_buscar_producto.Focus();
            }
            else if (rdb_producto.Checked)
            {
                txt_nom_producto.Focus();
            }
            else
            {
                txt_nom_producto.Focus();
            }

        }

        private void recargar_texbox()
        {
            string[] imprimir = bas.leer("inf\\inventario\\invent.txt", "3|0|2|1|4|5|6|7", "" + G_parametros[0]);
            txt_buscar_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < imprimir.Length; k++)
            {
                G_productos.Add(imprimir[k]);
                txt_buscar_producto.AutoCompleteCustomSource.Add(imprimir[k]);
            }

            string[] imprimir2 = bas.leer("inf\\inventario\\invent.txt", "1|0|2|3|4|5|6|7", "" + G_parametros[0]);
            txt_nom_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < imprimir2.Length; k++)
            {
                txt_nom_producto.AutoCompleteCustomSource.Add("" + imprimir2[k]);
            }
        }

        private void txt_buscar_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = txt_buscar_producto.Text.Split(G_parametros);
                procesar_codigo(info[0]);
                txt_cantidad.Focus();
            }
        }

        private void procesar_codigo(string codigo,string info_extra=null)
        {
            
            bool bandera = false;
            for (int i = 0; i < G_productos.Count; i++)
            {
                String[] temp = G_productos[i].Split(G_parametros);
                if (codigo == temp[0])
                {
                    txt_buscar_producto.Text = temp[0];
                    lbl_id.Text = temp[1];
                    lbl_nombre_producto.Text = temp[3];
                    lbl_precio_compra_cant.Text = temp[5];
                    lbl_precio_venta.Text = temp[2];
                    lbl_cantidad_cant.Text = temp[4];
                    txt_provedor.Text = temp[6];
                    

                    bandera = true;
                    break;
                }
            }

            if (bandera == false)
            {

                tex_base bas = new tex_base();
                string[] cantidad_produc = bas.leer("inf\\inventario\\invent.txt", "0", "" + G_parametros[0]);//el 0 solo regresa la primera columna que creo es el id
                string[] espliteado = txt_buscar_producto.Text.Split(G_parametros);
                //------------------------------------------------------------
                ventana_emergente vent_emergent = new ventana_emergente();
                //-------------------------------------------------------------
                string[] enviar = { "1°id°" + (cantidad_produc.Length), "1°producto", "1°precio", "1°codigo°" + espliteado[0], "1°cantidad", "1°compra", "1°marca" };
                string mensage = vent_emergent.proceso_ventana_emergente(enviar, 1);//el uno significa que modificara el inventario
                MessageBox.Show("ya se agrego el producto: " + mensage);
                txt_buscar_producto.Text = "";
            }

        }

        private void txt_nom_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = txt_nom_producto.Text.Split(G_parametros);
                procesar_codigo2(info[0]);
                txt_cantidad.Focus();
            }
        }
        private void procesar_codigo2(string codigo)
        {
            
            for (int i = 0; i < G_productos.Count; i++)
            {
                String[] temp = G_productos[i].Split(G_parametros);
                if (codigo == temp[3])
                {
                    txt_buscar_producto.Text = temp[0];
                    lbl_nombre_producto.Text = temp[3];
                    lbl_precio_compra_cant.Text = temp[5];
                    lbl_precio_venta.Text = temp[2];
                    lbl_cantidad_cant.Text = temp[4];
                    txt_provedor.Text = temp[6];
                    txt_nom_producto.Text = temp[3];
                    break;
                }
            }

            

        }

        private void btn_procesar_venta_Click(object sender, EventArgs e)
        {
            ventana_emergente ventana_emerg = new ventana_emergente();
            string[] enviar = { "3°venta_directa°1", "3°preVenta°2" };
            string valor_devuelto=ventana_emerg.proceso_ventana_emergente(enviar,0);
            bool compra_directa;
            if (valor_devuelto=="1")
            {
                compra_directa = true;
            }
            else
            {
                compra_directa = false;
            }
            modelo_compra_venta mod_com_ven = new modelo_compra_venta();
            for (int i = 0; i < lst_compras.Items.Count; i++)
            {
                string[] item_spliteado = lst_compras.Items[i].ToString().Split(G_parametros);
                mod_com_ven.modelo_compra(item_spliteado[0], item_spliteado[3], item_spliteado[2], item_spliteado[4], item_spliteado[1],item_spliteado[5],compra_directa);
            }

        }

        private void btn_cargar_pedido_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.InitialDirectory= Directory.GetCurrentDirectory() +"\\pedidos";
            if (opfd.ShowDialog()== DialogResult.OK)
            {
                string[] info_compra = bas.leer(opfd.FileName, "2|0|6");
                for (int i = 0; i < info_compra.Length; i++)
                {
                    string[] info_producto_comp_spliteada = info_compra[i].Split(G_parametros);
                    procesar_codigo(info_producto_comp_spliteada[0]);
                    txt_cantidad.Text = info_producto_comp_spliteada[1];
                    txt_costo_compra.Text= info_producto_comp_spliteada[2];
                    string temp = txt_buscar_producto.Text + "|" + lbl_nombre_producto.Text + "|" + txt_cantidad.Text + "|" + txt_costo_compra.Text + "|" + txt_provedor.Text + "|" + lbl_id.Text;
                    lst_compras.Items.Add(temp);
                }
            }
            
        }

        private void btn_elim_ultimo_Click(object sender, EventArgs e)
        {
            string temporal = "";
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;
            try
            {
                
                lst_compras.Items.Remove(lst_compras.Items[lst_compras.Items.Count - 1]);
                for (int coll = 0; coll < lst_compras.Items.Count; coll++)
                {
                    temporal = "" + lst_compras.Items[coll];
                    temporal_s = temporal.Split(G_parametros);

                    if (temporal_s[0] != "")
                    {
                        total = total + (Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[3]));
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                lbl_cuenta.Text = "" + total;
            }
            catch (Exception)
            {

                throw;
            }
            txt_buscar_producto.Focus();
        }

        private void btn_eliminar_todo_Click(object sender, EventArgs e)
        {
            string temporal = "";
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;

            try
            {
                lst_compras.Items.Clear();
                for (int coll = 0; coll < lst_compras.Items.Count; coll++)
                {
                    temporal = "" + lst_compras.Items[coll];
                    temporal_s = temporal.Split(G_parametros);

                    if (temporal_s[0] != "")
                    {
                        total = total + (Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[3]));
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                lbl_cuenta.Text = "" + total;
            }
            catch (Exception)
            {

                throw;
            }
            txt_buscar_producto.Focus();
        }

        private void btn_eliminar_seleccionado_Click(object sender, EventArgs e)
        {
            string temporal = "";
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;

            try
            {
                lst_compras.Items.RemoveAt(lst_compras.SelectedIndex);
                for (int coll = 0; coll < lst_compras.Items.Count; coll++)
                {
                    temporal = "" + lst_compras.Items[coll];
                    temporal_s = temporal.Split(G_parametros);

                    if (temporal_s[0] != "")
                    {
                        total = total + (Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[3]));
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                lbl_cuenta.Text = "" + total;
            }
            catch (Exception)
            {

                throw;
            }

            txt_buscar_producto.Focus();
        }
    }
}