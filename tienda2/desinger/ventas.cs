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
using tienda2.clases;

namespace tienda2.desinger
{
    public partial class Ventas : Form
    {
        char[] G_parametros = { '|' };
        List<string> G_productos = new List<string>();
        string G_prov_anterior = null;//si el provedor trajera varios productos nuevos para no estar escribe y escribe el provedor solo se guarda temporalmente 

        public Ventas()
        {
            InitializeComponent();
            Recargar_texbox();
        }
        
        private void Btn_eliminar_todo_Click(object sender, EventArgs e)
        {
            string temporal;
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;

            try
            {
                Lst_ventas.Items.Clear();
                for (int coll = 0; coll < Lst_ventas.Items.Count; coll++)
                {
                    temporal = "" + Lst_ventas.Items[coll];
                    temporal_s = temporal.Split(G_parametros);

                    if (temporal_s[0] != "")
                    {
                        total = total + Convert.ToDecimal(temporal_s[2]);
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                Lbl_cuenta.Text = "" + total;
                Lbl_nom_product_list.Text = "nombre del producto";
                Lbl_costo_product_list.Text = "$";
            }
            catch (Exception)
            {

                throw;
            }
            Txt_buscar_producto.Focus();
        }
        
        private void Btn_eliminar_seleccionado_Click(object sender, EventArgs e)
        {
            string temporal;
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;

            try
            {
                Lst_ventas.Items.RemoveAt(Lst_ventas.SelectedIndex);
                for (int coll = 0; coll < Lst_ventas.Items.Count; coll++)
                {
                    temporal = "" + Lst_ventas.Items[coll];
                    temporal_s = temporal.Split(G_parametros);

                    if (temporal_s[0] != "")
                    {
                        total = total + Convert.ToDecimal(temporal_s[2]);
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                Lbl_cuenta.Text = "" + total;
                Lbl_nom_product_list.Text = "nombre del producto";
                Lbl_costo_product_list.Text = "$";
            }
            catch (Exception)
            {

                throw;
            }

            Txt_buscar_producto.Focus();
        }
        
        private void Txt_buscar_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = Txt_buscar_producto.Text.Split(G_parametros);
                Procesar_codigo(info[0]);
            }
        }
        
        private void Btn_elim_ultimo_Click(object sender, EventArgs e)
        {
            string temporal;
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;
            try
            {
                Lst_ventas.Items.Remove(Lst_ventas.Items[Lst_ventas.Items.Count - 1]);
                for (int coll = 0; coll < Lst_ventas.Items.Count; coll++)
                {
                    temporal = "" + Lst_ventas.Items[coll];
                    temporal_s = temporal.Split(G_parametros);

                    if (temporal_s[0] != "")
                    {
                        total = total + Convert.ToDecimal(temporal_s[2]);
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                Lbl_cuenta.Text = "" + total;
                Lbl_nom_product_list.Text = "nombre del producto";
                Lbl_costo_product_list.Text = "$";
            }
            catch (Exception)
            {

                throw;
            }
            Txt_buscar_producto.Focus();
        }
        
        private void Btn_procesar_venta_Click(object sender, EventArgs e)
        {
            string temporal;
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;

            Confirmar_venta cv = new Confirmar_venta();

            cv.codigo_barras_list.Clear();
            cv.nombre_productos.Clear();
            
            for (int coll = 0; coll < Lst_ventas.Items.Count; coll++)
            {
                temporal = "" + Lst_ventas.Items[coll];
                temporal_s = temporal.Split(G_parametros);


                cv.codigo_barras_list.Add("" + temporal_s[0]);
                cv.nombre_productos.Add("" + temporal_s[3]);
                if (temporal_s[0] != "")
                {
                    total = total + Convert.ToDecimal(temporal_s[2]);
                    total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                }
                cv.cantidad.Add("" + temporal_s[8]);

            }

            
            cv.Total_costo_venta = total;
            cv.Cost_comp = total_cost_com;
            cv.Lbl_total.Text = "" + total;
            cv.Txt_dinero.Text = "" + total;


            Lst_ventas.Items.Clear();
            Lbl_nom_product_list.Text = "nombre del producto";
            Lbl_costo_product_list.Text = "$";

            Txt_buscar_producto.Focus();
            cv.Show();
            
        }
        
        private void Recargar_texbox()
        {
            
            Tex_base bas = new Tex_base();
            
            string[] imprimir = bas.Leer("inf\\inventario\\invent.txt", "1|0|2|3|4|5|6|7|8", "" + G_parametros[0]);
            Txt_nom_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < imprimir.Length; k++)
            {
                Txt_nom_producto.AutoCompleteCustomSource.Add("" + imprimir[k]);
            }

            string[] imprimir2 = bas.Leer("inf\\inventario\\invent.txt", "3|0|2|1|4|5|6|7|8", "" + G_parametros[0]);

            for (int k = 1; k < imprimir2.Length; k++)
            {
                G_productos.Add(imprimir2[k]);
                Txt_buscar_producto.AutoCompleteCustomSource.Add("" + imprimir2[k]);
            }
        }
        
        private void Procesar_codigo(string codigo)
        {
            string temporal;
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

                    Ventana_emergente vent_emergent = new Ventana_emergente();
                    if (grupo[0]=="1")
                    {
                        Lst_ventas.Items.Add(G_productos[i]);
                        Txt_buscar_producto.Text = "";
                        Txt_nom_producto.Text = "";

                        Lbl_costo_product_list.Text = temp[2];
                        Lbl_nom_product_list.Text = temp[3];

                    }
                    else if (grupo[0] == "2")//litros
                    {
                        string[] enviar = { "2°producto°"+ temp[3],"1°cantidad en litros(se puede decimal)" };
                        string mensage = vent_emergent.Proceso_ventana_emergente(enviar);
                        string[] informacion_vent_eme = mensage.Split(G_parametros);//lo espliteo para cambiar el orden de la informacion y adaptarlo a como lo tiene el textbox
                        if (informacion_vent_eme[1]!="")
                        {
                            temp[2] = "" + (Convert.ToDecimal(temp[2]) * Convert.ToDecimal(informacion_vent_eme[1]));
                            temp[8] = informacion_vent_eme[1];
                            Lst_ventas.Items.Add(string.Join("|", temp));
                            Lbl_costo_product_list.Text = temp[2] + " CANTIDAD: " + informacion_vent_eme[1];
                            Lbl_nom_product_list.Text = temp[3];
                        }
                        Txt_buscar_producto.Text = "";
                        Txt_buscar_producto.Focus();
                        
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
                        Lst_ventas.Items.Add(G_productos[i]);
                        Txt_buscar_producto.Text = "";
                        Txt_nom_producto.Text = "";

                        Lbl_costo_product_list.Text = temp[2];
                        Lbl_nom_product_list.Text = temp[3];
                        //------------------------------------------------------
                    }
                    
                    bandera = true;
                    break;
                }
            }


            if (bandera == false)
            {

                Tex_base bas = new Tex_base();
                string[] info_invent = bas.Leer("inf\\inventario\\invent.txt");
                string[] espliteado = Txt_buscar_producto.Text.Split(G_parametros);
                string[] provedores = bas.Leer("inf\\inventario\\provedores.txt", "0", "" + G_parametros[0]);//este regresa los provedores
                Operaciones_textos op_text = new Operaciones_textos();
                string provedores_txt = op_text.join_paresido('°', provedores);
                
                //------------------------------------------------------------
                Ventana_emergente vent_emergent = new Ventana_emergente();
                //-------------------------------------------------------------
                string[] enviar;
                if (G_prov_anterior==null)
                {
                    if (provedores.Length<0)
                    {
                        G_prov_anterior = provedores[0];
                    }
                    
                    enviar = new string[] { "2°id°" + (info_invent.Length), "1°producto", "1°precio venta°0", "2°codigo de barras°" + espliteado[0], "1°cantidad°1", "1°costo de compra°0", "4°provedor°" + G_prov_anterior + '°' + provedores_txt, "1°grupo", "2°no poner nada°", "1°cantidad_productos_por_paquete°1" };
                }
                else
                {
                    enviar = new string[] { "2°id°" + (info_invent.Length), "1°producto", "1°precio venta°0", "2°codigo de barras°" + espliteado[0], "1°cantidad°1", "1°costo de compra°0", "4°provedor°" + G_prov_anterior + '°' + provedores_txt, "1°grupo", "2°no poner nada°", "1°cantidad_productos_por_paquete°1" };
                }

                
                string mensage = vent_emergent.Proceso_ventana_emergente(enviar, 1);//el uno significa que modificara el inventario
                string[] temp = mensage.Split(G_parametros);//lo espliteo para cambiar el orden de la informacion y adaptarlo a como lo tiene el textbox



                string[] temp2;
                string temp3 = "";

                if (temp.Length >= 3)//por si cierra la ventana no agregue a los text box
                {
                    G_prov_anterior = temp[6];
                    temp2 = new[] { temp[3], temp[0], temp[2], temp[1], temp[4], temp[5], temp[6], temp[7], temp[8], temp[9] };//aqui lo pongo en el orden que deve llevar
                    temp3 = string.Join(G_parametros[0] + "", temp2);//uno todo en un string conforme al parametro o caracter de separacion
                    G_productos.Add(temp3);//agrego en lista de productos
                    Txt_buscar_producto.AutoCompleteCustomSource.Add(temp3);//agrego en el autocompletar

                    temp2 = new[] { temp[1], temp[0], temp[2], temp[3], temp[4], temp[5], temp[6], temp[7], temp[8], temp[9] };//aqui lo pongo en el orden que deve llevar
                    temp3 = string.Join(G_parametros[0] + "", temp2);//uno todo en un string conforme al parametro o caracter de separacion
                    Txt_nom_producto.AutoCompleteCustomSource.Add(temp3);

                    bas.si_no_existe_agega_comparacion("inf\\inventario\\provedores.txt", temp[6]);

                }


                Txt_buscar_producto.Text = "";
            }


            for (int coll = 0; coll < Lst_ventas.Items.Count; coll++)
            {
                temporal = "" + Lst_ventas.Items[coll].ToString();
                temporal_s = temporal.Split(G_parametros);

                if (temporal_s[0] != "")
                {
                    total = total + Convert.ToDecimal(temporal_s[2]);
                    total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                }
            }
            Lbl_cuenta.Text = "" + total;
        }
        
        private void Txt_nom_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = Txt_nom_producto.Text.Split(G_parametros);
                Procesar_codigo2(info[0]);
                Txt_buscar_producto.Focus();

            }
        }
        
        private void Procesar_codigo2(string codigo)
        {

            for (int i = 0; i < G_productos.Count; i++)
            {
                String[] temp = G_productos[i].Split(G_parametros);
                if (codigo == temp[3])
                {
                    Txt_buscar_producto.Text = temp[0];
                    Txt_nom_producto.Text = temp[3];
                    break;
                }
            }
        }
        
        private void Lst_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lst_ventas.SelectedItem != null)
            {
                string[] info_producto_lista = Lst_ventas.SelectedItem.ToString().Split(G_parametros[0]);
                Lbl_costo_product_list.Text = info_producto_lista[2];
                Lbl_nom_product_list.Text = info_producto_lista[3];
            }
            
        }
    }
}

