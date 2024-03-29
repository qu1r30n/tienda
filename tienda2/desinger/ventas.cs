﻿using System;
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

        char[] G_parametros = { '|', '°', '¬', '^' };
        List<string> G_productos = new List<string>();
        string G_prov_anterior = null;//si el provedor trajera varios productos nuevos para no estar escribe y escribe el provedor solo se guarda temporalmente 

        public Ventas()
        {
            InitializeComponent();
            Recargar_texbox();

            //ordenar_ranking_-------------------------------------------------------------------------------------
            DateTime fecha_hora = DateTime.Now;
            Tex_base bas = new Tex_base();
            string dir_ranking_año = "inf\\ranking\\" + fecha_hora.ToString("yyyy") + "_ranking.txt";
            string dir_ranking_dia = "inf\\ranking\\dia\\" + fecha_hora.ToString("yyyyMMdd") + "_ranking.txt";
            bas.Crear_archivo_y_directorio(dir_ranking_año);
            bas.Crear_archivo_y_directorio(dir_ranking_dia);
            bas.Ordenar(dir_ranking_dia, 5);
            bas.Ordenar(dir_ranking_año, 5);
            //-------------------------------------------------------------------------------------


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
                    temporal_s = temporal.Split(G_parametros[0]);

                    if (temporal_s[0] != "")
                    {
                        total = total + Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[8]);
                        total_cost_com = total_cost_com + (Convert.ToDecimal(temporal_s[5]) * Convert.ToDecimal(temporal_s[8]));
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
            promociones();
        }


        //funcion btn_eliminar_seleccionado
        private void Btn_eliminar_seleccionado_Click(object sender, EventArgs e)
        {
            funcion_eliminar_seleccionado();
            promociones();
        }

        private void funcion_eliminar_seleccionado()
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
                    temporal_s = temporal.Split(G_parametros[0]);

                    if (temporal_s[0] != "")
                    {
                        total = total + Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[8]);
                        total_cost_com = total_cost_com + (Convert.ToDecimal(temporal_s[5]) * Convert.ToDecimal(temporal_s[8]));
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

        private void funcion_eliminar_ulitimo()
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
                    temporal_s = temporal.Split(G_parametros[0]);

                    if (temporal_s[0] != "")
                    {
                        total = total + Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[8]);
                        total_cost_com = total_cost_com + (Convert.ToDecimal(temporal_s[5]) * Convert.ToDecimal(temporal_s[8]));
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

        //----------------------------------------------------------------------------




        private void Btn_elim_ultimo_Click(object sender, EventArgs e)
        {
            funcion_eliminar_ulitimo();
            promociones();
        }

        private void Btn_procesar_venta_Click(object sender, EventArgs e)
        {

            string temporal;
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;

            Ventas_confirmar cv = new Ventas_confirmar();

            cv.codigo_barras_list.Clear();
            cv.nombre_productos.Clear();

            for (int coll = 0; coll < Lst_ventas.Items.Count; coll++)
            {
                temporal = "" + Lst_ventas.Items[coll];
                temporal_s = temporal.Split(G_parametros[0]);


                cv.codigo_barras_list.Add("" + temporal_s[0]);
                cv.nombre_productos.Add("" + temporal_s[3]);
                cv.provedor.Add("" + temporal_s[6]);
                cv.promo.Add(temporal_s[9]);

                decimal total_precio_productos = Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[8]);
                if (temporal_s[0] != "")
                {
                    //total = total + Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[8]);
                    total = total + total_precio_productos;
                    total_cost_com = total_cost_com + (Convert.ToDecimal(temporal_s[5]) * Convert.ToDecimal(temporal_s[8]));
                }
                cv.cantidad.Add("" + temporal_s[8]);
                cv.precio_venta.Add("" + total_precio_productos);

            }


            cv.Total_costo_venta = total;
            cv.Cost_comp = total_cost_com;
            cv.Lbl_total.Text = "" + total;
            cv.Txt_dinero.Text = "" + total;


            Lst_ventas.Items.Clear();
            Lbl_nom_product_list.Text = "nombre del producto";
            Lbl_costo_product_list.Text = "$";
            Lbl_cuenta.Text = "$";

            Txt_buscar_producto.Focus();
            cv.Show();

        }

        private void Recargar_texbox()
        {

            Tex_base bas = new Tex_base();

            string[] imprimir = bas.Leer("inf\\inventario\\invent.txt", "1|0|2|3|4|5|6|7|8|8", G_parametros[0]);
            Txt_nom_producto.AutoCompleteCustomSource.Clear();
            
            for (int k = 1; k < imprimir.Length; k++)
            {
                Txt_nom_producto.AutoCompleteCustomSource.Add("" + imprimir[k]);
            }

            string[] imprimir2 = bas.Leer("inf\\inventario\\invent.txt", "3|0|2|1|4|5|6|7|8|8", G_parametros[0]);
            Txt_buscar_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < imprimir2.Length; k++)
            {
                G_productos.Add(imprimir2[k]);
                Txt_buscar_producto.AutoCompleteCustomSource.Add("" + imprimir2[k]);
            }
        }


        //9999999999999999999999999999999999999999999999999999999999999999999999999
        public void Procesar_codigo(string codigo, string cantidad_a_sumar_o_restar = "1")
        {
            Tex_base bas = new Tex_base();
            double cant_sum_res = Convert.ToDouble(cantidad_a_sumar_o_restar);
            string temporal;
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;
            bool bandera = false;

            for (int i = 0; i < G_productos.Count; i++)
            {
                String[] temp = G_productos[i].Split(G_parametros[0]);

                if (codigo == temp[0])//productos
                {
                    
                    temp[8] = cantidad_a_sumar_o_restar;
                    string[] grupo = temp[7].Split('°');

                    Ventana_emergente vent_emergent = new Ventana_emergente();

                    if (grupo[0] == "1")
                    {
                        bool esta_libre_la_lista_de_repeticiones_de_producto = true;

                        Txt_buscar_producto.Text = "";
                        Txt_nom_producto.Text = "";
                        Lbl_costo_product_list.Text = temp[8] + " COSTO: " + temp[2];
                        Lbl_nom_product_list.Text = temp[3] + "    PRECIO UNITARIO: " + temp[2];

                        for (int j = 0; j < Lst_ventas.Items.Count; j++)
                        {
                            string[] item_espliteado = Lst_ventas.Items[j].ToString().Split(G_parametros[0]);
                            if (codigo == item_espliteado[0])
                            {
                                item_espliteado[8] = "" + (Convert.ToDecimal(item_espliteado[8]) + Convert.ToDecimal(temp[8]));
                                Lbl_costo_product_list.Text = item_espliteado[8] + " COSTO: " + (Convert.ToDecimal(item_espliteado[2]) * Convert.ToDecimal(item_espliteado[8]));
                                Lst_ventas.Items[j] = string.Join("" + G_parametros[0], item_espliteado);
                                esta_libre_la_lista_de_repeticiones_de_producto = false;
                            }
                        }

                        if (esta_libre_la_lista_de_repeticiones_de_producto)
                        {
                            Lst_ventas.Items.Add(string.Join("" + G_parametros[0], temp));
                        }

                    }

                    else if (grupo[0] == "2")//litros o kilos
                    {
                        bool esta_libre_la_lista_de_repeticiones_de_producto = true;
                        //a = 6;
                        string[] enviar = { "2°producto°" + temp[3], "1°cantidad en litros o kilos(se puede decimal)°°2" };
                        string mensage = vent_emergent.Proceso_ventana_emergente(enviar);
                        string[] informacion_vent_eme = mensage.Split(G_parametros[0]);//lo espliteo para cambiar el orden de la informacion y adaptarlo a como lo tiene el textbox
                        temp[8] = "" + (Convert.ToDouble(informacion_vent_eme[1]) * Convert.ToDouble(cantidad_a_sumar_o_restar));

                        if (informacion_vent_eme[1] != "")
                        {
                            for (int j = 0; j < Lst_ventas.Items.Count; j++)
                            {
                                string[] item_espliteado = Lst_ventas.Items[j].ToString().Split(G_parametros[0]);
                                if (codigo == item_espliteado[0])
                                {
                                    item_espliteado[8] = "" + (Convert.ToDecimal(item_espliteado[8]) + Convert.ToDecimal(temp[8]));
                                    Lbl_costo_product_list.Text = item_espliteado[8] + " COSTO: " + (Convert.ToDecimal(item_espliteado[2]) * Convert.ToDecimal(item_espliteado[8]));
                                    Lst_ventas.Items[j] = string.Join("" + G_parametros[0], item_espliteado);
                                    esta_libre_la_lista_de_repeticiones_de_producto = false;
                                }
                            }
                            if (esta_libre_la_lista_de_repeticiones_de_producto)
                            {
                                Lst_ventas.Items.Add(string.Join("" + G_parametros[0], temp));
                                Lbl_costo_product_list.Text = informacion_vent_eme[1] + " COSTO: " + Convert.ToDecimal(temp[2]) * Convert.ToDecimal(informacion_vent_eme[1]);
                            }
                            Lbl_nom_product_list.Text = temp[3] + "   PRECIO UNITARIO: " + temp[2];



                        }
                        Txt_buscar_producto.Text = "";
                        Txt_buscar_producto.Focus();

                    }

                    else if (grupo[0] == "3")//productos elaborados
                    {

                    }

                    else if (grupo[0] == "4")//tiempo
                    {

                    }

                    else//error o default
                    {
                        //cambiarlo por otra cosa despues es el mismo que que el 1---------------------------------------------------
                        //Lst_ventas.Items.Add(G_productos[i]);
                        //Txt_buscar_producto.Text = "";
                        //Txt_nom_producto.Text = "";

                        //Lbl_costo_product_list.Text = temp[2];
                        //Lbl_nom_product_list.Text = temp[3];
                        //------------------------------------------------------




                        bool esta_libre_la_lista_de_repeticiones_de_producto = true;

                        Txt_buscar_producto.Text = "";
                        Txt_nom_producto.Text = "";
                        Lbl_costo_product_list.Text = temp[8] + " COSTO: " + temp[2];
                        Lbl_nom_product_list.Text = temp[3] + "    PRECIO UNITARIO: " + temp[2];

                        for (int j = 0; j < Lst_ventas.Items.Count; j++)
                        {
                            string[] item_espliteado = Lst_ventas.Items[j].ToString().Split(G_parametros[0]);
                            if (codigo == item_espliteado[0])
                            {
                                item_espliteado[8] = "" + (Convert.ToDecimal(item_espliteado[8]) + Convert.ToDecimal(temp[8]));
                                Lbl_costo_product_list.Text = item_espliteado[8] + " COSTO: " + (Convert.ToDecimal(item_espliteado[2]) * Convert.ToDecimal(item_espliteado[8]));
                                Lst_ventas.Items[j] = string.Join("" + G_parametros[0], item_espliteado);
                                esta_libre_la_lista_de_repeticiones_de_producto = false;
                            }
                        }
                        if (esta_libre_la_lista_de_repeticiones_de_producto)
                        {
                            Lst_ventas.Items.Add(string.Join("" + G_parametros[0], temp));
                        }


                    }

                    bandera = true;
                    break;
                }
            }


            if (bandera == false)
            {


                string[] info_invent = bas.Leer("inf\\inventario\\invent.txt");
                string[] espliteado = Txt_buscar_producto.Text.Split(G_parametros[0]);
                string[] provedores = bas.Leer("inf\\inventario\\provedores.txt", "0", G_parametros[0]);//este regresa los provedores
                Operaciones_textos op_text = new Operaciones_textos();
                string provedores_txt = op_text.join_paresido('°', provedores);

                //------------------------------------------------------------
                Ventana_emergente vent_emergent = new Ventana_emergente();
                //-------------------------------------------------------------
                string[] enviar;
                if (G_prov_anterior == null)
                {
                    if (provedores.Length < 0)
                    {
                        G_prov_anterior = provedores[0];
                    }


                                          //"2°id°1",                     "1°producto", "1°precio venta°0°2", "2°cod_bar         °asd"             , "1°cantidad°1°2", "1°costo de compra°0°2", "4°provedor°nose°°nose                   °    provedor_0   ", "4°grupo°2°4°1°1°2°3°4", "2°multiusos    °", "1°cantidad_productos_por_paquete°1°2", "1°ligar_productos_para_sabor°°","1°impuesto°0°2","1°tipo_producto_para_impuesto°"
                    enviar = new string[] { "2°id°" + info_invent.Length, "1°producto", "1°precio venta°0°2", "2°codigo de barras°" + espliteado[0], "1°cantidad°1°2", "1°costo de compra°0°2", "4°provedor°nose°°" + G_prov_anterior + '°' + provedores_txt, "4°grupo°2°4°1°1°2°3°4", "2°no poner nada°", "1°cantidad_productos_por_paquete°1°2", "1°productos_elaborados°°3", "1°ligar_productos_sabor", "1°precio impuesto°0°2", "4°tipo_producto_para_impuesto°nose°°" /* + tipo_impuesto_anterior* +'°' + todos los impuestos anteriores */ };
                }
                else
                {

                    enviar = new string[] { "2°id°" + info_invent.Length, "1°producto", "1°precio venta°0°2", "2°codigo de barras°" + espliteado[0], "1°cantidad°1°2", "1°costo de compra°0°2", "4°provedor°" + G_prov_anterior + "°°" + G_prov_anterior + '°' + provedores_txt, "4°grupo°2°4°1°1°2°3°4", "2°no poner nada°", "1°cantidad_productos_por_paquete°1°2", "1°productos_elaborados°°3", "1°ligar_productos_para_sabor", "1°precio impuesto°0°2", "4°tipo_producto_para_impuesto°nose°°" /* + tipo_impuesto_anterior* +'°' + todos los impuestos anteriores */ };
                }

                //a = 7;
                string mensage = vent_emergent.Proceso_ventana_emergente(enviar, 1);//el uno significa que modificara el inventario
                string[] temp = mensage.Split(G_parametros[0]);//lo espliteo para cambiar el orden de la informacion y adaptarlo a como lo tiene el textbox



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

            promociones();

            for (int fila = 0; fila < Lst_ventas.Items.Count; fila++)
            {
                temporal = "" + Lst_ventas.Items[fila].ToString();
                temporal_s = temporal.Split(G_parametros[0]);

                if (temporal_s[0] != "")
                {
                    total = total + Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[8]);
                    total_cost_com = total_cost_com + (Convert.ToDecimal(temporal_s[5]) * Convert.ToDecimal(temporal_s[8]));
                    
                    if (Convert.ToDouble(temporal_s[8])<=0)
                    {
                        Lst_ventas.Items.RemoveAt(fila);
                        
                        Lbl_nom_product_list.Text = "nombre del producto";
                        Lbl_costo_product_list.Text = "$";
                    }
                }
            }

            Lbl_cuenta.Text = "" + total;
        }

        //99999999999999999999999999999999999999999999999999999999999999999999999999
        //888888888888888888888888888888888888888888888888888888888888888888888888888

        public void Procesar_codigo_promos(string la_promo, string cantidad_a_sumar_o_restar = "1")
        {
            double cant_sum_res = Convert.ToDouble(cantidad_a_sumar_o_restar);
            string temporal;
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;

            String[] temp = la_promo.Split(G_parametros[0]);




            temp[8] = cantidad_a_sumar_o_restar;
            string[] grupo = temp[7].Split('°');

            Ventana_emergente vent_emergent = new Ventana_emergente();

            if (grupo[0] == "1")
            {
                bool esta_libre_la_lista_de_repeticiones_de_producto = true;

                Txt_buscar_producto.Text = "";
                Txt_nom_producto.Text = "";
                Lbl_costo_product_list.Text = temp[8] + " COSTO: " + temp[2];
                Lbl_nom_product_list.Text = temp[3] + "    PRECIO UNITARIO: " + temp[2];

                for (int j = 0; j < Lst_ventas.Items.Count; j++)
                {
                    string[] item_espliteado = Lst_ventas.Items[j].ToString().Split(G_parametros[0]);
                    if (temp[0] == item_espliteado[0])
                    {
                        item_espliteado[8] = "" + (Convert.ToDecimal(item_espliteado[8]) + Convert.ToDecimal(temp[8]));
                        Lbl_costo_product_list.Text = item_espliteado[8] + " COSTO: " + (Convert.ToDecimal(item_espliteado[2]) * Convert.ToDecimal(item_espliteado[8]));
                        Lst_ventas.Items[j] = string.Join("" + G_parametros[0], item_espliteado);
                        esta_libre_la_lista_de_repeticiones_de_producto = false;
                    }
                }
                if (esta_libre_la_lista_de_repeticiones_de_producto)
                {
                    Lst_ventas.Items.Add(string.Join("" + G_parametros[0], temp));
                }
                string[] produ_esplit = temp[0].Split(G_parametros[1]);
                for (int i = 0; i < produ_esplit.Length; i++)
                {
                    string[] detalles_produc= produ_esplit[i].Split(G_parametros[2]);
                    Procesar_codigo(detalles_produc[0], "-" + detalles_produc[1]);
                    
                }
                
            }








            promociones();

            for (int coll = 0; coll < Lst_ventas.Items.Count; coll++)
            {
                temporal = "" + Lst_ventas.Items[coll].ToString();
                temporal_s = temporal.Split(G_parametros[0]);

                if (temporal_s[0] != "")
                {
                    total = total + Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[8]);
                    total_cost_com = total_cost_com + (Convert.ToDecimal(temporal_s[5]) * Convert.ToDecimal(temporal_s[8]));
                }
            }

            Lbl_cuenta.Text = "" + total;
        }
        
        //888888888888888888888888888888888888888888888888888888888888888888888888888

        private void Txt_nom_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                Txt_nom_producto.Text = Txt_nom_producto.Text.ToUpper();
                string[] info = Txt_nom_producto.Text.Split(G_parametros[0]);
                Procesar_codigo2(info[0]);
                Txt_buscar_producto.Focus();

            }
        }

        private void Procesar_codigo2(string codigo)
        {

            for (int i = 0; i < G_productos.Count; i++)
            {
                String[] temp = G_productos[i].Split(G_parametros[0]);
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
                
                txt_movimiento.Text = Lst_ventas.SelectedItem.ToString();
                
                
                string[] info_producto_lista = Lst_ventas.SelectedItem.ToString().Split(G_parametros[0]);
                Lbl_costo_product_list.Text = info_producto_lista[8] + " COSTO: " + (Convert.ToDecimal(info_producto_lista[2]) * Convert.ToDecimal(info_producto_lista[8]));
                Lbl_nom_product_list.Text = info_producto_lista[3] + "    PRECIO UNITARIO: " + info_producto_lista[2];
            }

        }

        private void chb_ventas_compras_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ventas_compras.Checked == false)
            {
                lbl_ventas_compras_resultado.Visible = true;
            }
            else
            {
                lbl_ventas_compras_resultado.Visible = false;
            }
            Txt_buscar_producto.Focus();
        }


        private void Ventas_Activated(object sender, EventArgs e)
        {
            DateTime fecha_hora = DateTime.Now;
            //string hora_min_seg = fecha_hora.ToString("HH:mm:ss");
            string hora_min = fecha_hora.ToString("HH:mm");
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            string dia = fecha_hora.ToString("dd");
            string mes = fecha_hora.ToString("MM");
            string año = fecha_hora.ToString("yyyy");

            Tex_base bas = new Tex_base();
            string vent_comp = bas.Seleccionar("inf\\inventario\\ven\\vent.txt", 0, año_mes_dia, "1|2");
            if (vent_comp == "")
            {
                bas.Agregar("inf\\inventario\\ven\\vent.txt", año_mes_dia + "|0|0");
                vent_comp = bas.Seleccionar("inf\\inventario\\ven\\vent.txt", 0, año_mes_dia, "1|2");
            }

            string[] vent_comp_espliteado = vent_comp.Split(G_parametros[0]);
            decimal ventas = Convert.ToDecimal(vent_comp_espliteado[0]);
            decimal compras = Convert.ToDecimal(vent_comp_espliteado[1]);
            decimal resultado = ventas - compras;

            lbl_ventas_compras_resultado.Text = ventas + "-" + compras + "=" + resultado;


            string mod_inv = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\info_tienda\\tienda_inventarios\\mod_inv\\" + año_mes_dia + "mod_inv.txt";
            if (bas.existe_archivo(mod_inv))
            {
                lbl_modo_inventario.Text = "modo_inv";
            }
            else
            {
                lbl_modo_inventario.Text = ".";
            }

            Txt_buscar_producto.Focus();
        }

        
        private void provedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras_control_provedores cont_prov = new Compras_control_provedores();
            cont_prov.Show();
        }

        private void Lst_ventas_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Add))
            {
                
                string[] item_spliteado = Lst_ventas.Items[Lst_ventas.SelectedIndex].ToString().Split(G_parametros[0]);
                Procesar_codigo(item_spliteado[0], "1");
            }
            else if (e.KeyValue == (char)(Keys.Subtract))
            {
                string[] item_spliteado = Lst_ventas.Items[Lst_ventas.SelectedIndex].ToString().Split(G_parametros[0]);

                Procesar_codigo(item_spliteado[0], "-1");
                

            }
        }

        private void restaurarGuardadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_guardar_venta_Click(object sender, EventArgs e)
        {
            Tex_base bas = new Tex_base();
            string dir_guardado = "inf\\guardada_vent_temporal.txt";
            bas.Crear_archivo_y_directorio(dir_guardado);
            string juntado_items = "";
            for (int i = 0; i < Lst_ventas.Items.Count; i++)
            {
                string[] item_espliteado = Lst_ventas.Items[i].ToString().Split('|');
                juntado_items = juntado_items + item_espliteado[0] + "°" + item_espliteado[8] + "|";

            }
            bas.Agregar(dir_guardado, juntado_items);

            //eliminar lo del listbox---------------------------------------------------------------------
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
                    temporal_s = temporal.Split(G_parametros[0]);

                    if (temporal_s[0] != "")
                    {
                        total = total + Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[8]);
                        total_cost_com = total_cost_com + (Convert.ToDecimal(temporal_s[5]) * Convert.ToDecimal(temporal_s[8]));
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
            //----------------------------------------------------------------------------------------
        }

        

        
        

        private void Txt_buscar_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                string[] item_spliteado = Lst_ventas.Items[Lst_ventas.Items.Count - 1].ToString().Split(G_parametros[0]);
                Procesar_codigo(item_spliteado[0], "1");

                e.KeyChar = '\0';
            }

            else if (e.KeyChar == '-')
            {
                string[] item_spliteado = Lst_ventas.Items[Lst_ventas.Items.Count - 1].ToString().Split(G_parametros[0]);

                Procesar_codigo(item_spliteado[0], "-1");
                

                e.KeyChar = '\0';
            }
        }

        private void Txt_buscar_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                Txt_buscar_producto.Text = Txt_buscar_producto.Text.ToUpper();
                string[] info = Txt_buscar_producto.Text.Split(G_parametros[0]);
                Procesar_codigo(info[0]);
            }
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            ventas_cargar_venta_temporal_guardada cargador_ventas_guardadas = new ventas_cargar_venta_temporal_guardada(this);
            cargador_ventas_guardadas.Show();
        }

        private void prestamosdeproddinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasabajoarribaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string[] enviar = new string[] { "1°motivo_compra", "1°arriba°0°2", "1°abajo°0°2" };
            Ventana_emergente vent_emergent = new Ventana_emergente();
            string mensage = vent_emergent.Proceso_ventana_emergente(enviar);//el uno significa que modificara el inventario
            
            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            string dir_compras = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\info_tienda\\compras\\" + año_mes_dia + "compras.txt";
            Tex_base bas = new Tex_base();
            bas.Agregar(dir_compras, mensage);

        }

        private void lstb_promociones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstb_promociones.SelectedItem != null)
            {
                txt_movimiento.Text = lstb_promociones.SelectedItem.ToString();

                string[] primer_espliteo_prom = lstb_promociones.SelectedItem.ToString().Split('|');
                string[] productos = primer_espliteo_prom[1].Split('°');
                lstb_descripcion_promo.Items.Clear();
                for (int i = 0; i < productos.Length; i++)
                {
                    lstb_descripcion_promo.Items.Add(productos[i]);
                }
            }
        }

        private void lstb_descripcion_promo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstb_descripcion_promo.SelectedItem != null)
            {
                txt_movimiento.Text = lstb_descripcion_promo.SelectedItem.ToString();
            }
        }


        private void promociones()
        {
            lstb_descripcion_promo.Items.Clear();
            Tex_base bas = new Tex_base();
            //promociones-----------------------------------------------------------------------------------------------------------
            //"nombre_promocion|codigo_barras_1¬cantidad_del_producto¬nombre¬precio_comp¬precio_vent°codigo_barras_2¬cantidad_del_producto¬nombre¬precio_comp¬precio_vent|precio|
            string[] promos = bas.Leer("promosiones\\promos.txt");

            for (int i = 1; i < promos.Length; i++)
            {


                string[] promo_1_nom_produc_precio = promos[i].Split('|');
                string[] promo_produc = promo_1_nom_produc_precio[1].Split('°');

                string[] si_cumple_cantidad_pa_promo = new string[promo_produc.Length];

                for (int j = 0; j < promo_produc.Length; j++)
                {
                    string[] datos_producto_promo = promo_produc[j].Split('¬');


                    //chequeo_lista_ventas-----------------------------------------------------------------------------------
                    for (int k = 0; k < Lst_ventas.Items.Count; k++)
                    {
                        string[] produc_list_split = Lst_ventas.Items[k].ToString().Split('|');
                        double dato_list_comparar = Convert.ToDouble(produc_list_split[8]);
                        double dato_promo_comparar = Convert.ToDouble(datos_producto_promo[1]);
                        if (produc_list_split[0] == datos_producto_promo[0] && dato_promo_comparar <= dato_list_comparar)
                        {
                            si_cumple_cantidad_pa_promo[j] = "1";
                        }

                    }

                    bool estan_todos_produc = false;
                    for (int l = 0; l < si_cumple_cantidad_pa_promo.Length; l++)
                    {
                        if (si_cumple_cantidad_pa_promo[l] == "1")
                        {
                            estan_todos_produc = true;

                        }
                        else
                        {
                            estan_todos_produc = false;
                            break;
                        }

                    }
                    if (estan_todos_produc == true)
                    {

                        promo_1_nom_produc_precio[3] = "1";
                        promos[i] = string.Join("|", promo_1_nom_produc_precio);

                    }
                    //-------------------------------------------------------------------------------------------
                }
            }
            //colocar en listbox promociones------------------------------------------------------------------
            lstb_promociones.Items.Clear();
            for (int i = 1; i < promos.Length; i++)
            {
                string[] pro_split = promos[i].Split('|');
                if (pro_split[3] == "1")
                {
                    lstb_promociones.Items.Add(promos[i]);
                }


            }
            //------------------------------------------------------------------------------------------------


            //promociones fin-----------------------------------------------------------------------------------------------------------
        }

        arreglos_compuestos_y_simples arr_cs = new arreglos_compuestos_y_simples();
        private void lstb_promociones_DoubleClick(object sender, EventArgs e)
        {

            if (lstb_promociones.SelectedItem != null)
            {
                char[] caracteres_arreglos = { '|', '°' };
                string[] primer_splietep = lstb_promociones.SelectedItem.ToString().Split('|');
                string[] temp = {lstb_promociones.SelectedItem+""};
                string[] info_producto = arr_cs.extraer_ultimo_arreglo_dentro_de_arreglo(temp, 0, primer_splietep[0], "1", caracteres_arreglos);
                
                string cadena_a_insertar = primer_splietep[1] + "|" + primer_splietep[0] + "|" + primer_splietep[2] + "|" + primer_splietep[0] + "|1|"+ primer_splietep[2]+"|promocion|1||"+1;
                Procesar_codigo_promos(cadena_a_insertar, "1");
                
            }
        }
    }
}
