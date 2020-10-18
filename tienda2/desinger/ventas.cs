using System;
using System.Collections;
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
    public partial class ventas : Form
    {
        char[] G_parametros = { '|' };
        List<string> G_productos = new List<string>();

        public ventas()
        {
            InitializeComponent();
            recargar_texbox();
        }
        
        private void btn_eliminar_todo_Click(object sender, EventArgs e)
        {
            string temporal = "";
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;

            try
            {
                lst_ventas.Items.Clear();
                for (int coll = 0; coll < lst_ventas.Items.Count; coll++)
                {
                    temporal = "" + lst_ventas.Items[coll];
                    temporal_s = temporal.Split(G_parametros);

                    if (temporal_s[0] != "")
                    {
                        total = total + Convert.ToDecimal(temporal_s[2]);
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                lbl_cuenta.Text = "" + total;
                lbl_nom_product_list.Text = "nombre del producto";
                lbl_costo_product_list.Text = "$";
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
                lst_ventas.Items.RemoveAt(lst_ventas.SelectedIndex);
                for (int coll = 0; coll < lst_ventas.Items.Count; coll++)
                {
                    temporal = "" + lst_ventas.Items[coll];
                    temporal_s = temporal.Split(G_parametros);

                    if (temporal_s[0] != "")
                    {
                        total = total + Convert.ToDecimal(temporal_s[2]);
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                lbl_cuenta.Text = "" + total;
                lbl_nom_product_list.Text = "nombre del producto";
                lbl_costo_product_list.Text = "$";
            }
            catch (Exception)
            {

                throw;
            }

            txt_buscar_producto.Focus();
        }
        
        private void txt_buscar_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = txt_buscar_producto.Text.Split(G_parametros);
                procesar_codigo(info[0]);
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
                lst_ventas.Items.Remove(lst_ventas.Items[lst_ventas.Items.Count - 1]);
                for (int coll = 0; coll < lst_ventas.Items.Count; coll++)
                {
                    temporal = "" + lst_ventas.Items[coll];
                    temporal_s = temporal.Split(G_parametros);

                    if (temporal_s[0] != "")
                    {
                        total = total + Convert.ToDecimal(temporal_s[2]);
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                lbl_cuenta.Text = "" + total;
                lbl_nom_product_list.Text = "nombre del producto";
                lbl_costo_product_list.Text = "$";
            }
            catch (Exception)
            {

                throw;
            }
            txt_buscar_producto.Focus();
        }
        
        private void btn_procesar_venta_Click(object sender, EventArgs e)
        {
            string temporal = "";
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;

            DateTime fecha_hora = DateTime.Now;
            confirmar_venta cv = new confirmar_venta();
            operaciones_archivos op = new operaciones_archivos();
            cv.arra_lis.Clear();
            cv.ids_productos.Clear();
            
            for (int coll = 0; coll < lst_ventas.Items.Count; coll++)
            {
                temporal = "" + lst_ventas.Items[coll];
                temporal_s = temporal.Split(G_parametros);


                cv.arra_lis.Add("" + temporal_s[0]);
                cv.ids_productos.Add("" + temporal_s[1]);
                if (temporal_s[0] != "")
                {
                    total = total + Convert.ToDecimal(temporal_s[2]);
                    total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                }
                cv.cantidad.Add("" + temporal_s[8]);

            }

            
            cv.total_costo_venta = total;
            cv.cost_comp = total_cost_com;
            cv.lbl_total.Text = "" + total;
            cv.txt_dinero.Text = "" + total;


            lst_ventas.Items.Clear();
            lbl_nom_product_list.Text = "nombre del producto";
            lbl_costo_product_list.Text = "$";

            txt_buscar_producto.Focus();
            cv.Show();
            
        }
        
        private void recargar_texbox()
        {
            
            tex_base bas = new tex_base();
            
            string[] imprimir = bas.leer("inf\\inventario\\invent.txt", "1|0|2|3|4|5|6|7|8", "" + G_parametros[0]);
            txt_nom_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < imprimir.Length; k++)
            {
                txt_nom_producto.AutoCompleteCustomSource.Add("" + imprimir[k]);
            }

            string[] imprimir2 = bas.leer("inf\\inventario\\invent.txt", "3|0|2|1|4|5|6|7|8", "" + G_parametros[0]);

            for (int k = 1; k < imprimir2.Length; k++)
            {
                G_productos.Add(imprimir2[k]);
                txt_buscar_producto.AutoCompleteCustomSource.Add("" + imprimir2[k]);
            }
        }
        
        private void procesar_codigo(string codigo)
        {
            string temporal = "";
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;
            bool bandera = false;

            for (int i = 0; i < G_productos.Count; i++)
            {
                String[]temp=G_productos[i].Split(G_parametros);
                
                if (codigo==temp[0])//productos
                {
                    string[] grupo = temp[7].Split('°');

                    ventana_emergente vent_emergent = new ventana_emergente();
                    if (grupo[0]=="1")
                    {
                        lst_ventas.Items.Add(G_productos[i]);
                        txt_buscar_producto.Text = "";
                        txt_nom_producto.Text = "";

                        lbl_costo_product_list.Text = temp[2];
                        lbl_nom_product_list.Text = temp[3];

                    }
                    else if (grupo[0] == "2")//litros
                    {
                        string[] enviar = { "2°producto°"+ temp[3],"1°cantidad en litros(se puede decimal)" };
                        string mensage = vent_emergent.proceso_ventana_emergente(enviar);
                        string[] informacion_vent_eme = mensage.Split(G_parametros);//lo espliteo para cambiar el orden de la informacion y adaptarlo a como lo tiene el textbox
                        if (informacion_vent_eme[1]!="")
                        {
                            temp[2] = "" + (Convert.ToDecimal(temp[2]) * Convert.ToDecimal(informacion_vent_eme[1]));
                            temp[8] = informacion_vent_eme[1];
                            lst_ventas.Items.Add(string.Join("|", temp));
                            lbl_costo_product_list.Text = temp[2] + " CANTIDAD: " + informacion_vent_eme[1];
                            lbl_nom_product_list.Text = temp[3];
                        }
                        txt_buscar_producto.Text = "";
                        txt_buscar_producto.Focus();
                        
                    }

                    else if (grupo[0] == "3")//kilos
                    {

                    }
                    else if (grupo[0] == "4")//tiempo
                    {

                    }
                    else//error
                    {
                        //cambiarlo por otra cosa despues es el mismo que que el 1---------------------------------------------------
                        lst_ventas.Items.Add(G_productos[i]);
                        txt_buscar_producto.Text = "";
                        txt_nom_producto.Text = "";

                        lbl_costo_product_list.Text = temp[2];
                        lbl_nom_product_list.Text = temp[3];
                        //------------------------------------------------------
                    }
                    
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
                string[] enviar = { "2°id°" + (cantidad_produc.Length), "1°producto", "1°precio venta°0", "2°codigo de barras°" + espliteado[0], "1°cantidad°1", "1°costo de compra°0", "1°provedor", "1°grupo", "2°no poner nada°", "1°cantidad_productos_por_paquete°1" };
                string mensage = vent_emergent.proceso_ventana_emergente(enviar, 1);//el uno significa que modificara el inventario
                string[] temp = mensage.Split(G_parametros);//lo espliteo para cambiar el orden de la informacion y adaptarlo a como lo tiene el textbox
                string[] temp2;
                string temp3="";
                if (temp.Length>2)
                {
                    temp2 = new [] { temp[3], temp[0], temp[2], temp[1], temp[4], temp[5], temp[6], temp[7], temp[8], temp[9] };//aqui lo pongo en el orden que deve llevar
                    temp3 = string.Join(G_parametros[0] + "", temp2);//uno todo en un string conforme al parametro o caracter de separacion
                    G_productos.Add(temp3);//agrego en lista de productos
                }
                
                
                txt_buscar_producto.AutoCompleteCustomSource.Add(temp3);//agrego en el autocompletar
                
                txt_buscar_producto.Text = "";
            }


            for (int coll = 0; coll < lst_ventas.Items.Count; coll++)
            {
                temporal = "" + lst_ventas.Items[coll].ToString();
                temporal_s = temporal.Split(G_parametros);

                if (temporal_s[0] != "")
                {
                    total = total + Convert.ToDecimal(temporal_s[2]);
                    total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                }
            }
            lbl_cuenta.Text = "" + total;
        }
        
        private void txt_nom_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = txt_nom_producto.Text.Split(G_parametros);
                procesar_codigo2(info[0]);
                txt_buscar_producto.Focus();

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
                    txt_nom_producto.Text = temp[3];
                    break;
                }
            }
        }
        
        private void lst_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_ventas.SelectedItem != null)
            {
                string[] info_producto_lista = lst_ventas.SelectedItem.ToString().Split(G_parametros[0]);
                lbl_costo_product_list.Text = info_producto_lista[2];
                lbl_nom_product_list.Text = info_producto_lista[3];
            }
            
        }
    }
}

