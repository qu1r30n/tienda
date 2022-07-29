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
        }
        //funcion btn_eliminar_seleccionado
        private void Btn_eliminar_seleccionado_Click(object sender, EventArgs e)
        {
            funcion_eliminar_seleccionado();
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

            string[] imprimir = bas.Leer("inf\\inventario\\invent.txt", "1|0|2|3|4|5|6|7|8", G_parametros[0]);
            Txt_nom_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < imprimir.Length; k++)
            {
                Txt_nom_producto.AutoCompleteCustomSource.Add("" + imprimir[k]);
            }

            string[] imprimir2 = bas.Leer("inf\\inventario\\invent.txt", "3|0|2|1|4|5|6|7|8", G_parametros[0]);

            for (int k = 1; k < imprimir2.Length; k++)
            {
                G_productos.Add(imprimir2[k]);
                Txt_buscar_producto.AutoCompleteCustomSource.Add("" + imprimir2[k]);
            }
        }

        public void Procesar_codigo(string codigo, string cantidad_a_sumar_o_restar = "1")
        {
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
                    /*
                    if (temp[8] == "")
                    {
                        temp[8] = "1";
                    }
                    */

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

                    else if (grupo[0] == "3")//
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

                Tex_base bas = new Tex_base();
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



                    enviar = new string[] { "2°id°" + info_invent.Length, "1°producto", "1°precio venta°0°2", "2°codigo de barras°" + espliteado[0], "1°cantidad°1°2", "1°costo de compra°0°2", "4°provedor°marinela°°" + G_prov_anterior + '°' + provedores_txt, "4°grupo°2°4°1°1°2°3°4", "2°no poner nada°", "1°cantidad_productos_por_paquete°1°2", "1°productos_elaborados°°3" };
                }
                else
                {

                    enviar = new string[] { "2°id°" + info_invent.Length, "1°producto", "1°precio venta°0°2", "2°codigo de barras°" + espliteado[0], "1°cantidad°1°2", "1°costo de compra°0°2", "4°provedor°" + G_prov_anterior + "°°" + G_prov_anterior + '°' + provedores_txt, "4°grupo°2°4°1°1°2°3°4", "2°no poner nada°", "1°cantidad_productos_por_paquete°1°2", "1°productos_elaborados°°3" };
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

        private void Txt_nom_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
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
                string[] item_spliteado = Lst_ventas.Items[Lst_ventas.SelectedIndex].ToString().Split(G_parametros);
                Procesar_codigo(item_spliteado[0], "1");
            }
            else if (e.KeyValue == (char)(Keys.Subtract))
            {
                string[] item_spliteado = Lst_ventas.Items[Lst_ventas.SelectedIndex].ToString().Split(G_parametros);

                Procesar_codigo(item_spliteado[0], "-1");
                item_spliteado = null;
                item_spliteado = Lst_ventas.Items[Lst_ventas.SelectedIndex].ToString().Split(G_parametros);
                if (Convert.ToDouble(item_spliteado[item_spliteado.Length - 1]) <= 0)//posible error futuro esto lo ago porque nose porque aveses son 9 elementos y aveses 8  luego vemos o el punto talves sea no modificar el ultimo 
                {
                    funcion_eliminar_seleccionado();
                }

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
                string[] item_spliteado = Lst_ventas.Items[Lst_ventas.Items.Count - 1].ToString().Split(G_parametros);
                Procesar_codigo(item_spliteado[0], "1");

                e.KeyChar = '\0';
            }

            else if (e.KeyChar == '-')
            {
                string[] item_spliteado = Lst_ventas.Items[Lst_ventas.Items.Count - 1].ToString().Split(G_parametros);

                Procesar_codigo(item_spliteado[0], "-1");
                item_spliteado = null;
                item_spliteado = Lst_ventas.Items[Lst_ventas.Items.Count - 1].ToString().Split(G_parametros);
                if (Convert.ToDouble(item_spliteado[item_spliteado.Length - 1]) <= 0)//posible error futuro el .length lo tengo que usar por que nose porque aveses tiene 9 elementos y aveses 8
                {
                    funcion_eliminar_ulitimo();
                }


                e.KeyChar = '\0';
            }
        }

        private void Txt_buscar_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
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
    }
}
