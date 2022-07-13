using System;
using System.Collections.Generic;
using System.Windows.Forms;
using tienda2.clases;

using System.IO;

namespace tienda2.desinger
{
    public partial class Compras : Form
    {
        string direccion_inventario = "inf\\inventario\\invent.txt";
        char[] G_parametros = { '|', '°', '¬', '^' };
        List<string> G_productos = new List<string>();
        Tex_base bas = new Tex_base();
        string G_prov_anterior = null;//si el provedor trajera varios productos nuevos para no estar escribe y escribe el provedor solo se guarda temporalmente 



        public Compras(string provedor_elegido = null)
        {
            InitializeComponent();
            G_prov_anterior = provedor_elegido;
            Recargar_texbox();
            recarga_ranking(G_prov_anterior);

        }
        private void Recargar_texbox()
        {

            string[] codigo_productos = bas.Leer(direccion_inventario, "3|0|2|1|4|5|6|7", G_parametros[0]);
            Txt_buscar_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < codigo_productos.Length; k++)
            {
                G_productos.Add(codigo_productos[k]);
                Txt_buscar_producto.AutoCompleteCustomSource.Add(codigo_productos[k]);
            }

            string[] imprimir2 = bas.Leer(direccion_inventario, "1|0|2|3|4|5|6|7", G_parametros[0]);
            Txt_nom_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < imprimir2.Length; k++)
            {
                Txt_nom_producto.AutoCompleteCustomSource.Add("" + imprimir2[k]);
            }

            string[] imprimir3 = bas.Leer("inf\\inventario\\provedores.txt", "0", G_parametros[0]);
            cmb_provedor.Items.Clear();
            cmb_provedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_provedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            for (int k = 0; k < imprimir3.Length; k++)
            {
                cmb_provedor.Items.Add("" + imprimir3[k]);
                cmb_provedor.AutoCompleteCustomSource.Add("" + imprimir3[k]);
            }


        }

        private void Txt_buscar_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = Txt_buscar_producto.Text.Split(G_parametros[0]);
                Procesar_codigo(info[0]);
                //Txt_cantidad.Focus();
            }
        }

        public void Procesar_codigo(string codigo)
        {

            bool bandera = false;
            for (int i = 0; i < G_productos.Count; i++)
            {
                String[] temp = G_productos[i].Split(G_parametros[0]);
                if (codigo == temp[0])
                {
                    Txt_buscar_producto.Text = temp[0];
                    Lbl_id.Text = temp[1];
                    Lbl_nombre_producto.Text = temp[3];
                    Lbl_precio_compra_cant.Text = temp[5];
                    Lbl_precio_venta.Text = temp[2];
                    Lbl_cantidad_cant.Text = temp[4];
                    cmb_provedor.Text = temp[6];


                    bandera = true;
                    break;
                }
            }

            if (bandera == false)
            {

                Tex_base bas = new Tex_base();
                string[] info_invent = bas.Leer(direccion_inventario);
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

                    enviar = new string[] { "2°id°" + (info_invent.Length), "1°producto", "1°precio venta°0°2", "2°codigo de barras°" + espliteado[0], "1°cantidad°1°2", "1°costo de compra°0°2", "4°provedor°marinela°°" + G_prov_anterior + '°' + provedores_txt, "4°grupo°2°4°1°1°2°3°4", "2°no poner nada°", "1°cantidad_productos_por_paquete°1°2", "1°productos_elaborados°°3" };
                }
                else
                {
                    enviar = new string[] { "2°id°" + (info_invent.Length), "1°producto", "1°precio venta°0°2", "2°codigo de barras°" + espliteado[0], "1°cantidad°1°2", "1°costo de compra°0°2", "4°provedor°" + G_prov_anterior + "°°" + G_prov_anterior + '°' + provedores_txt, "4°grupo°2°4°1°1°2°3°4", "2°no poner nada°", "1°cantidad_productos_por_paquete°1°2", "1°productos_elaborados°°3" };
                }

                //a = 4;
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
                }


                Txt_buscar_producto.Text = "";
                Procesar_codigo(codigo);
            }


        }

        private void Txt_nom_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = Txt_nom_producto.Text.Split(G_parametros[0]);
                Procesar_codigo2(info[0]);
                //Txt_cantidad.Focus();
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
                    Lbl_id.Text = temp[1];
                    Lbl_nombre_producto.Text = temp[3];
                    Lbl_precio_compra_cant.Text = temp[5];
                    Lbl_precio_venta.Text = temp[2];
                    Lbl_cantidad_cant.Text = temp[4];
                    cmb_provedor.Text = temp[6];
                    Txt_nom_producto.Text = temp[3];
                    break;
                }
            }



        }

        private void Btn_procesar_venta_Click(object sender, EventArgs e)
        {
            Ventana_emergente ventana_emerg = new Ventana_emergente();
            //a = 5;
            string[] enviar = { "3°venta_directa°1°0", "3°preVenta°2°0" };
            string valor_devuelto = ventana_emerg.Proceso_ventana_emergente(enviar);
            bool compra_directa;

            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            if (valor_devuelto != "")
            {

                if (valor_devuelto == "1")
                {
                    compra_directa = true;


                    Ventana_emergente ventana_emerg2 = new Ventana_emergente();
                    string[] enviar2 = { "2°cantidad_a_pagar°" + Lbl_cuenta.Text, "1°se_paga_de_caja°0°2", "2°°"};
                    string se_paga_de_caja = ventana_emerg2.Proceso_ventana_emergente(enviar2);

                    Operaciones_textos op_text = new Operaciones_textos();
                    se_paga_de_caja = op_text.cambiar_caracter(se_paga_de_caja, '|', '°');

                    string[] se_paga_de_caja_spliteado = se_paga_de_caja.Split(G_parametros[1]);
                    double pago_de_caja_a_deuda = Convert.ToDouble(se_paga_de_caja_spliteado[0]) - Convert.ToDouble(se_paga_de_caja_spliteado[1]);
                    if (pago_de_caja_a_deuda < 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("no puede ser mayor lo que se paga se igualara", "error", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            se_paga_de_caja_spliteado[1] = se_paga_de_caja_spliteado[0];
                            se_paga_de_caja_spliteado[2] = "0";
                        }
                        else
                        {
                            return;
                        }
                        se_paga_de_caja_spliteado[2] = "0";
                    }
                    else
                    {
                        se_paga_de_caja_spliteado[2] = "" + pago_de_caja_a_deuda;
                    }

                    string compra_joineada = string.Join("°", se_paga_de_caja_spliteado);
                    if (se_paga_de_caja_spliteado.Length > 2)
                    {


                        Modelo_compra_venta mod_com_ven = new Modelo_compra_venta();

                        for (int i = 0; i < Lst_compras.Items.Count; i++)
                        {


                            string[] item_spliteado = Lst_compras.Items[i].ToString().Split(G_parametros[0]);
                            mod_com_ven.Modelo_compra(item_spliteado[0], item_spliteado[3], item_spliteado[2], item_spliteado[4], item_spliteado[1], item_spliteado[5], item_spliteado[6], compra_directa);
                            //decrementa ranking de necesidad-----------------------------------------
                            string dir_ranking = Directory.GetCurrentDirectory() + "\\inf\\ranking\\" + fecha_hora.ToString("yyyy") + "_ranking.txt";
                            bas.si_existe_suma_sino_agega_extra(dir_ranking, 0, item_spliteado[0], "2", "" + (Convert.ToDouble(item_spliteado[2]) * -1), "");
                            //fin ranking de necesidad-------------------------------------------
                        }
                        Lbl_nom_product_list.Text = "";
                        Lst_compras.Items.Clear();
                        Lbl_cuenta.Text = "0";

                    }

                }

                if (valor_devuelto == "2")
                {
                    ////bas.Crear_archivo_y_directorio()

                    //70330724341_0|rastrillo bic confort 3 hojas_1|5_2|8_3|bic_4|148_5|1°paketes_de°5_6
                    //0|2|3

                    Modelo_compra_venta mod_comp_ven = new Modelo_compra_venta();

                    Ventana_emergente vent_emergent = new Ventana_emergente();
                    string [] enviar2 = new string[] { "1°nombre_provedor" };
                    string mensage = vent_emergent.Proceso_ventana_emergente(enviar2);
                    mensage = bas.Trimend_paresido(mensage);
                    for (int i = 0; i < Lst_compras.Items.Count; i++)
                    {
                        string[] item_spliteado = Lst_compras.Items[i].ToString().Split(G_parametros[0]);
                        mod_comp_ven.Modelo_compra(item_spliteado[0], item_spliteado[3], item_spliteado[2], mensage, item_spliteado[1], item_spliteado[5], item_spliteado[6], false);

                    }
                    Lst_compras.Items.Clear();
                }

                else
                {
                    compra_directa = false;
                    Modelo_compra_venta mod_com_ven = new Modelo_compra_venta();
                    for (int i = 0; i < Lst_compras.Items.Count; i++)
                    {
                        string[] item_spliteado = Lst_compras.Items[i].ToString().Split(G_parametros[0]);
                        mod_com_ven.Modelo_compra(item_spliteado[0], item_spliteado[3], item_spliteado[2], item_spliteado[4], item_spliteado[1], item_spliteado[5], item_spliteado[6], compra_directa);
                        Lbl_nom_product_list.Text = "";
                        Lst_compras.Items.Clear();
                        Lbl_cuenta.Text = "0";
                    }
                }
            }

        }

        private void Btn_cargar_pedido_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.InitialDirectory = Directory.GetCurrentDirectory() + "\\pedidos";
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                string[] info_compra = bas.Leer(opfd.FileName);
                for (int i = 0; i < info_compra.Length; i++)
                {
                    string [] info_comp_esplit=info_compra[i].Split('|');
                    procesar_codigo_para_listbox(info_comp_esplit[0], info_comp_esplit[1], info_comp_esplit[2]);
                }
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

                Lst_compras.Items.Remove(Lst_compras.Items[Lst_compras.Items.Count - 1]);
                for (int coll = 0; coll < Lst_compras.Items.Count; coll++)
                {
                    temporal = "" + Lst_compras.Items[coll];
                    temporal_s = temporal.Split(G_parametros[0]);

                    if (temporal_s[0] != "")
                    {
                        total = total + (Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[3]));
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                Lbl_cuenta.Text = "" + total;
            }
            catch (Exception)
            {

                throw;
            }
            Lbl_nom_product_list.Text = "";
            Txt_buscar_producto.Focus();
        }

        private void Btn_eliminar_todo_Click(object sender, EventArgs e)
        {
            string temporal;
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;

            try
            {
                Lst_compras.Items.Clear();
                for (int coll = 0; coll < Lst_compras.Items.Count; coll++)
                {
                    temporal = "" + Lst_compras.Items[coll];
                    temporal_s = temporal.Split(G_parametros[0]);

                    if (temporal_s[0] != "")
                    {
                        total = total + (Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[3]));
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                Lbl_cuenta.Text = "" + total;
            }
            catch (Exception)
            {

                throw;
            }
            Lbl_nom_product_list.Text = "";
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
                Lst_compras.Items.RemoveAt(Lst_compras.SelectedIndex);
                for (int coll = 0; coll < Lst_compras.Items.Count; coll++)
                {
                    temporal = "" + Lst_compras.Items[coll];
                    temporal_s = temporal.Split(G_parametros[0]);

                    if (temporal_s[0] != "")
                    {
                        total = total + (Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[3]));
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                Lbl_cuenta.Text = "" + total;
            }
            catch (Exception)
            {

                throw;
            }
            Lbl_nom_product_list.Text = "";
            Txt_buscar_producto.Focus();
        }

        private void Lst_compras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lst_compras.SelectedItem != null)
            {
                string[] info_producto_lista = Lst_compras.SelectedItem.ToString().Split(G_parametros[0]);
                Lbl_nom_product_list.Text = info_producto_lista[1] + " $" + (Convert.ToInt32(info_producto_lista[2]) * Convert.ToDecimal(info_producto_lista[3]));
            }
        }

        private void Txt_cantidad_keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || '.' == e.KeyChar || '\b' == e.KeyChar)
            {

            }
            /*
            else if (char.IsLetter(e.KeyChar))//checa si lo introducido fue letra o no chart.IsLetter devuelve true o falce
            {
                e.KeyChar = '\0';
            }
            */
            else
            {
                e.KeyChar = '\0';
            }
        }

        private void Txt_costo_compra_keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || '.' == e.KeyChar || '\b' == e.KeyChar)
            {

            }
            /*
            else if (char.IsLetter(e.KeyChar))//checa si lo introducido fue letra o no chart.IsLetter devuelve true o falce
            {
                e.KeyChar = '\0';
            }
            */
            else
            {
                e.KeyChar = '\0';
            }
        }

        private void limpiar()
        {
            Txt_buscar_producto.Focus();
            Lbl_id.Text = "";
            Lbl_nombre_producto.Text = "";
            Lbl_precio_compra_cant.Text = "";
            Lbl_precio_venta.Text = "";
            Lbl_cantidad_cant.Text = "";

            Txt_buscar_producto.Text = "";
            Txt_nom_producto.Text = "";
            cmb_provedor.Text = "";
            if (Rdb_codigo_barras.Checked)
            {
                Txt_buscar_producto.Focus();
            }
            else if (Rdb_producto.Checked)
            {
                Txt_nom_producto.Focus();
            }
            else
            {
                Txt_nom_producto.Focus();
            }
        }

        //---------------------------------------------------------------------------

        private void btn_paquete_Click(object sender, EventArgs e)
        {
            funcion_click_paquete();
        }

        public void funcion_click_paquete(string cantidad_productos_unidad = "1")
        {
            double cant_prod_uni_double = Convert.ToDouble(cantidad_productos_unidad);

            DateTime fecha_hora = DateTime.Now;
            string hora_min = fecha_hora.ToString("HH:mm");

            string cantidad_por_pakete = bas.Seleccionar(direccion_inventario, 3, Txt_buscar_producto.Text, "9");
            double costo_compra_invent = Convert.ToDouble(Lbl_precio_compra_cant.Text);

            double paquetes_a_comprar=1;
            if (cantidad_por_pakete != "")
            {
                double cantidad_por_pakete_double = Convert.ToDouble(cantidad_por_pakete);
                paquetes_a_comprar = Math.Floor(cant_prod_uni_double / cantidad_por_pakete_double);
                
            }
            else
            {
                cantidad_por_pakete = "1";
            }
            Ventana_emergente ven_emer2 = new Ventana_emergente();
            //a = 3;
            string[] enviar2 = { "1°costo°" + Lbl_precio_compra_cant.Text + "°2", "1°numero paketes°"+paquetes_a_comprar+"°2", "1°cantidad_por_paquete°" + cantidad_por_pakete + "°2" };
            string datos_ventana_emergente2 = ven_emer2.Proceso_ventana_emergente(enviar2, 0, Lbl_nombre_producto.Text);
            if (datos_ventana_emergente2 == "|")
            {
                return;
            }
            string[] mensaje2_espli = datos_ventana_emergente2.Split(G_parametros[0]);

            string total_de_productos = "" + (Convert.ToDouble(mensaje2_espli[1]) * Convert.ToDouble(mensaje2_espli[2]));
            double costo_por_producto = Math.Round((Convert.ToDouble(mensaje2_espli[0]) / Convert.ToDouble(total_de_productos)), 2);
            procesar_codigo_para_listbox(Txt_buscar_producto.Text, "" + costo_por_producto, total_de_productos,mensaje2_espli[1]);

        }



        //--------------------------------------------------------------------------

        private void btn_individual_Click(object sender, EventArgs e)
        {
            funcion_click_individual();
        }


        public void funcion_click_individual(string cantidad_productos_unidad = "1")
        {
            Ventana_emergente ven_emer2 = new Ventana_emergente();
            //a = 3;
            string[] enviar2 = { "1°costo°" + Lbl_precio_compra_cant.Text + "°2", "1°cantidad°"+cantidad_productos_unidad+"°2" };
            string datos_ventana_emergente2 = ven_emer2.Proceso_ventana_emergente(enviar2, 0, Lbl_nombre_producto.Text);
            if (datos_ventana_emergente2 == "|")
            {
                return;
            }
            string[] mensaje2_espli = datos_ventana_emergente2.Split(G_parametros[0]);
            procesar_codigo_para_listbox(Txt_buscar_producto.Text, mensaje2_espli[0], mensaje2_espli[1]);

        }

        private void procesar_codigo_para_listbox(string codigo_bar, string costo_compra, string cantidad_individualmente, string cantidad_de_paquetes="0")
        {
            //id_0|producto_1|precio_de_venta_2|0_3|cantidad_4|costo_compra_5|provedor_6|grupo_7|multiusos_8|cantidad_productos_por_paquete_9|
            string[] produc_inf = bas.Leer(direccion_inventario);
            string[] produc_inf_esplit = { };
            for (int i = 0; i < produc_inf.Length; i++)
            {
                produc_inf_esplit = produc_inf[i].Split('|');
                if (produc_inf_esplit[3] == codigo_bar)
                {
                    break;
                }
            }
            

            double costo_compra_invent = Convert.ToDouble(produc_inf_esplit[5]);
            double costo_por_producto = Convert.ToDouble(costo_compra);
            string temp = "";
            if (cantidad_de_paquetes == "0" || cantidad_de_paquetes == "") 
            {
                temp = codigo_bar + "|" + produc_inf_esplit[1] + "|" + cantidad_individualmente + "|" + costo_por_producto + "|" + produc_inf_esplit[6] + "|" + produc_inf_esplit[0] + "|";
            }
            else
            {
                temp = codigo_bar + "|" + produc_inf_esplit[1] + "|" + cantidad_individualmente + "|" + costo_por_producto + "|" + produc_inf_esplit[6] + "|" + produc_inf_esplit[0] + "|" + cantidad_de_paquetes + "°paketes_de°" + cantidad_individualmente;
            }
            
            //---------------------------------------
            if (costo_por_producto > costo_compra_invent)
            {
                MessageBox.Show("subio:" + (costo_por_producto - costo_compra_invent));
                double costo_venta = Convert.ToDouble(produc_inf_esplit[2]);
                if (costo_por_producto > costo_venta)
                {
                    MessageBox.Show("nuevo_precio_de_venta: " + (costo_por_producto + (costo_por_producto * 0.1)));
                    bas.Editar_espesifico(direccion_inventario, 3, Txt_buscar_producto.Text, "2", "" + (costo_por_producto + (costo_por_producto * 0.1)));
                }
            }

            bas.Editar_espesifico(direccion_inventario, 3, Txt_buscar_producto.Text, "5", "" + costo_por_producto); 



            bas.si_no_existe_agega_comparacion("inf\\inventario\\provedores.txt", cmb_provedor.Text);
            //id_0|producto_1|precio_de_venta_2|0_3|cantidad_4|costo_compra_5|provedor_6|grupo_7|multiusos_8|cantidad_productos_por_paquete_9|
            Lbl_nom_product_list.Text = produc_inf_esplit[1] + " costo por pieza:" + costo_por_producto + " total:  $" + (Convert.ToDecimal(cantidad_individualmente) * Convert.ToDecimal(costo_por_producto));
            Lst_compras.Items.Add(temp);


            string temporal;
            string[] temporal_s;
            decimal total = 0;
            decimal total_cost_com = 0;
            try
            {
                for (int coll = 0; coll < Lst_compras.Items.Count; coll++)
                {
                    temporal = "" + Lst_compras.Items[coll];
                    temporal_s = temporal.Split(G_parametros[0]);

                    if (temporal_s[0] != "")
                    {
                        total = total + (Convert.ToDecimal(temporal_s[2]) * Convert.ToDecimal(temporal_s[3]));
                        total_cost_com = total_cost_com + Convert.ToDecimal(temporal_s[5]);
                    }

                }
                Lbl_cuenta.Text = "" + total;
            }
            catch (Exception)
            {

                throw;
            }

            limpiar();
        }

        //-----------------------------------------------------------------------------
        private void Pedidos_Load(object sender, EventArgs e)
        {

        }




        private void igualarProvedpresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            igualar_provedores igp = new igualar_provedores();
            igp.Show();
            
        }

        private void cargarRapidoCodigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras_cargar_rapido_cod_bar ventana_carg_rap = new Compras_cargar_rapido_cod_bar(this);
            ventana_carg_rap.Show();
        }




        private void btn_cargar_lst_comprar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_carga.Items.Count; i++)
            {

                Txt_buscar_producto.Text= "" + lst_carga.Items[i];

                string[] item_carga=lst_carga.Items[i].ToString().Split('|');
                Procesar_codigo(item_carga[0]);
                Ventana_emergente vent_emerg = new Ventana_emergente();
                string[] enviar = { "3°paquete°1°0", "3°individual°2°0" };
                string respuesta=vent_emerg.Proceso_ventana_emergente(enviar);
                string[] producto_esplit_a_cargar = lst_carga.Items[i].ToString().Split('|');

                if (respuesta=="1")
                {
                    funcion_click_paquete(producto_esplit_a_cargar[2]);
                }
                else if (respuesta=="2")
                {
                    funcion_click_individual(producto_esplit_a_cargar[2]);
                }
            }
        }

        private void btn_elim_ultimo_carga_Click(object sender, EventArgs e)
        {
            lst_carga.Items.Remove(lst_carga.Items[lst_carga.Items.Count - 1]);
        }

        private void btn_elim_todos_carga_Click(object sender, EventArgs e)
        {
            lst_carga.Items.Clear();
        }

        private void btn_elim_selec_carga_Click(object sender, EventArgs e)
        {
            lst_carga.Items.RemoveAt(lst_carga.SelectedIndex);
        }

        private void lst_carga_DoubleClick(object sender, EventArgs e)
        {

        }

        private void recarga_ranking(string provedor)
        {
            string[] inventario=bas.Leer(direccion_inventario);
            
            List<string> produc_prov_invent=new List<string>();
            //id_0|producto_1|precio_de_venta_2|0_3|cantidad_4|costo_compra_5|provedor_6|grupo_7|multiusos_8|cantidad_productos_por_paquete_9|
            for (int i = 0; i < inventario.Length; i++)
            {
                string[] invent_esplit = inventario[i].Split('|');
                if (provedor==invent_esplit[6])
                {
                    produc_prov_invent.Add(invent_esplit[3]+G_parametros[0]+ invent_esplit[1] + G_parametros[0] + invent_esplit[4]);
                }
            }
            arreglos_compuestos_y_simples arr_comp_simp = new arreglos_compuestos_y_simples();
           string [] arreglo_ordenado_invent_prov= arr_comp_simp.ordenar_arreglo_simple(produc_prov_invent.ToArray(), 2);

            DateTime fecha_hora = DateTime.Now;
            string dir_ranking = Directory.GetCurrentDirectory() + "\\inf\\ranking\\"+fecha_hora.ToString("yyyy")+ "_ranking.txt";
                string[] info_compra = bas.Leer(dir_ranking);
                List<string> arreglo_ranking = new List<string>();
                for (int i = 0; i < info_compra.Length; i++)
                {
                    string[] info_comp_esplit = info_compra[i].Split('|');
                    if (info_comp_esplit[3]==provedor)
                    {
                        arreglo_ranking.Add(info_compra[i]);
                    }
                }
                string[] arreglo_ordenado= arr_comp_simp.ordenar_arreglo_simple(arreglo_ranking.ToArray(), 2,"mayor_menor");

                for (int i = 0; i < arreglo_ordenado.Length; i++)
                {
                    //prediccion compra global  rango y cantidad en inventario para sacar y dependiendo del promedio  se vera si es urgente o no pero luego se checa
                    /*
                    double acum = 0;
                    int cantidades_historial = 0;
                    string[] historial_produc=arreglo_ordenado[4].Split('°');
                    for (int j = 0; j < historial_produc.Length; j++)
                    {
                        if (historial_produc[j]==null)
                        {
                            break;
                        }
                        acum = acum + Convert.ToDouble(historial_produc[i]);
                        cantidades_historial = j;
                    }

                    for (int k = 0; k < produc_prov_invent.Count; k++)
                    {
                    }
                    */
                    //-------------------------------------------------------------------------------------------------------
                    string[] prod_esplit=arreglo_ordenado[i].Split('|');
                    lst_carga.Items.Add(prod_esplit[0]+"|"+ prod_esplit[1] + "|" + prod_esplit[2] + "|");
                    
                }

            
            

        }
        
    }
}
