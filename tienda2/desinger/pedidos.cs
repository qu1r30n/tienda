using System;
using System.Collections.Generic;
using System.Windows.Forms;
using tienda2.clases;

using System.IO;

namespace tienda2.desinger
{
    public partial class Pedidos : Form
    {

        char[] G_parametros = { '|', '°', '¬', '^' };
        List<string> G_productos = new List<string>();
        Tex_base bas = new Tex_base();
        string G_prov_anterior = null;//si el provedor trajera varios productos nuevos para no estar escribe y escribe el provedor solo se guarda temporalmente 
        public Pedidos()
        {
            InitializeComponent();
            Recargar_texbox();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            
            Ventana_emergente ven_emer = new Ventana_emergente();
            //a = 2;
            string[] enviar = {"3°es_paquete°1°0", "3°es_por_pieza°2°0" };//el 3 del inicio es para saver que es boton y el final es su valor
            string datos_ventana_emerg = ven_emer.Proceso_ventana_emergente(enviar);//mandamos a llamar a ventana emergente
            string temp;
            //zb = 0;
            
            if (datos_ventana_emerg=="1")//si el valor del boton que apreto es 1 es que va a ser un paquete
            {
                DateTime fecha_hora = DateTime.Now;
                string hora_min = fecha_hora.ToString("HH:mm");

                string cantidad_por_pakete=bas.Seleccionar("inf\\inventario\\invent.txt",3,Txt_buscar_producto.Text,"9");

                Ventana_emergente ven_emer2 = new Ventana_emergente();
                //a = 3;
                string[] enviar2 = { "1°costo°" + Txt_costo_compra.Text + "°2", "1°numero paketes°" + Txt_cantidad.Text + "°2", "1°cantidad_por_paquete°" + cantidad_por_pakete + "°2" };
                string datos_ventana_emergente2 = ven_emer2.Proceso_ventana_emergente(enviar2);
                string[] mensaje2_espli = datos_ventana_emergente2.Split(G_parametros[0]);
                bas.Editar_espesifico("inf\\inventario\\invent.txt",3,Txt_buscar_producto.Text,"9",mensaje2_espli[2]);
                string total_de_productos_por_paquetes = ""+(Convert.ToDouble(mensaje2_espli[1])* Convert.ToDouble(mensaje2_espli[2]));
                string costo_por_producto = "" + Math.Round((Convert.ToDouble(mensaje2_espli[0])/Convert.ToDouble(total_de_productos_por_paquetes)),2);

                Txt_cantidad.Text = total_de_productos_por_paquetes;
                Txt_costo_compra.Text = costo_por_producto;
                temp = Txt_buscar_producto.Text + "|" + Lbl_nombre_producto.Text + "|" + Txt_cantidad.Text + "|" + Txt_costo_compra.Text + "|" + cmb_provedor.Text + "|" + Lbl_id.Text + "|" + mensaje2_espli[1]+"°paketes_de°"+mensaje2_espli[2];
            }
            
            else
            {
                temp = Txt_buscar_producto.Text + "|" + Lbl_nombre_producto.Text + "|" + Txt_cantidad.Text + "|" + Txt_costo_compra.Text + "|" + cmb_provedor.Text + "|" + Lbl_id.Text + "|";
            }

            bas.si_no_existe_agega_comparacion("inf\\inventario\\provedores.txt",cmb_provedor.Text);

            Lbl_nom_product_list.Text = Lbl_nombre_producto.Text + "costo por pieza:" + Txt_costo_compra.Text + " costo por paquetes:  $" + (Convert.ToInt32(Txt_cantidad.Text) * Convert.ToDecimal(Txt_costo_compra.Text));
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

        private void Recargar_texbox()
        {
            string[] imprimir = bas.Leer("inf\\inventario\\invent.txt", "3|0|2|1|4|5|6|7", "" + G_parametros[0]);
            Txt_buscar_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < imprimir.Length; k++)
            {
                G_productos.Add(imprimir[k]);
                Txt_buscar_producto.AutoCompleteCustomSource.Add(imprimir[k]);
            }

            string[] imprimir2 = bas.Leer("inf\\inventario\\invent.txt", "1|0|2|3|4|5|6|7", "" + G_parametros[0]);
            Txt_nom_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < imprimir2.Length; k++)
            {
                Txt_nom_producto.AutoCompleteCustomSource.Add("" + imprimir2[k]);
            }

            string[] imprimir3 = bas.Leer("inf\\inventario\\provedores.txt", "0", "" + G_parametros[0]);
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
                Txt_cantidad.Focus();
            }
        }

        private void Procesar_codigo(string codigo)
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
                    Txt_costo_compra.Text = temp[5];

                    bandera = true;
                    break;
                }
            }

            if (bandera == false)
            {

                Tex_base bas = new Tex_base();
                string[] info_invent = bas.Leer("inf\\inventario\\invent.txt");
                string[] espliteado = Txt_buscar_producto.Text.Split(G_parametros[0]);
                string[] provedores = bas.Leer("inf\\inventario\\provedores.txt", "0", "" + G_parametros[0]);//este regresa los provedores
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
            }


        }

        private void Txt_nom_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = Txt_nom_producto.Text.Split(G_parametros[0]);
                Procesar_codigo2(info[0]);
                Txt_cantidad.Focus();
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
            string valor_devuelto=ventana_emerg.Proceso_ventana_emergente(enviar);
            bool compra_directa;
            
            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            if (valor_devuelto != "")
            {


                if (valor_devuelto == "1")
                {
                    compra_directa = true;

                    
                    string[] provedores = bas.Leer("inf\\inventario\\pru\\provedores_pru_cmb.txt", null);//este regresa los provedores
                    string provedores_en_una_linea = "";
                    for (int i = 0; i < provedores.Length; i++)
                    {
                        string[] linea_prov_espliteado = provedores[i].Split(G_parametros[0]);
                        provedores_en_una_linea = provedores_en_una_linea + linea_prov_espliteado[0] + G_parametros[1];
                    }
                    provedores_en_una_linea = bas.Trimend_paresido(provedores_en_una_linea, G_parametros[1]);

                    Ventana_emergente ventana_emerg2 = new Ventana_emergente();
                    string[] enviar2 = { "2°cantidad_a_pagar°" + Lbl_cuenta.Text, "1°se_paga_de_caja°0°2", "2°°", "4°provedor°°°°" + provedores_en_una_linea };
                    
                    string se_paga_de_caja = ventana_emerg2.Proceso_ventana_emergente(enviar2);
                    Operaciones_textos op_text = new Operaciones_textos();
                    se_paga_de_caja = op_text.cambiar_caracter(se_paga_de_caja, '|', '°');

                    string[] se_paga_de_caja_spliteado = se_paga_de_caja.Split(G_parametros[1]);
                    double pago_de_caja_a_deuda = Convert.ToDouble(se_paga_de_caja_spliteado[0]) - Convert.ToDouble(se_paga_de_caja_spliteado[1]);
                    if (pago_de_caja_a_deuda<0)
                    {
                        DialogResult dialogResult = MessageBox.Show("no puede ser mayor lo que se paga se igualara","error", MessageBoxButtons.YesNo);
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
                        string direccion_pru = "inf\\inventario\\pru\\";
                        bas.si_no_existe_agega_comparacion(direccion_pru+"provedores_pru_cmb.txt", se_paga_de_caja_spliteado[3]);
                        bas.si_existe_suma_sino_agega_extra(direccion_pru + año_mes_dia + "_provedores_pru.txt", 3, se_paga_de_caja_spliteado[3],"0°1°2", se_paga_de_caja_spliteado[0] + "°"+ se_paga_de_caja_spliteado[1] + "°" + se_paga_de_caja_spliteado[2], compra_joineada,'°');
                        bas.si_existe_suma_sino_agega_extra("inf\\inventario\\ven\\vent.txt", 0, año_mes_dia, "2", "" + se_paga_de_caja_spliteado[1], año_mes_dia + "|0|" + se_paga_de_caja_spliteado[1]);
                        Modelo_compra_venta mod_com_ven = new Modelo_compra_venta();

                        for (int i = 0; i < Lst_compras.Items.Count; i++)
                        {
                            string[] item_spliteado = Lst_compras.Items[i].ToString().Split(G_parametros[0]);
                            mod_com_ven.Modelo_compra(item_spliteado[0], item_spliteado[3], item_spliteado[2], item_spliteado[4], item_spliteado[1], item_spliteado[5], item_spliteado[6], compra_directa);
                            bas.si_no_existe_agega_extra(direccion_pru + "para_cambiar_de_provedor\\" + se_paga_de_caja_spliteado[3] + ".txt", 0, item_spliteado[0], item_spliteado[0] + "|" + item_spliteado[1]);
                            Lbl_nom_product_list.Text = "";
                            Lst_compras.Items.Clear();
                            Lbl_cuenta.Text = "0";
                        }
                    }

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
            opfd.InitialDirectory= Directory.GetCurrentDirectory() +"\\pedidos";
            if (opfd.ShowDialog()== DialogResult.OK)
            {
                string[] info_compra = bas.Leer(opfd.FileName, "2|0|8");
                for (int i = 0; i < info_compra.Length; i++)
                {
                    string[] info_producto_comp_spliteada = info_compra[i].Split(G_parametros[0]);
                    Procesar_codigo(info_producto_comp_spliteada[0]);
                    //za = 1;
                    string temp = Txt_buscar_producto.Text + "|" + Lbl_nombre_producto.Text + "|" + info_producto_comp_spliteada[1] + "|" + info_producto_comp_spliteada[2] + "|" + cmb_provedor.Text + "|" + Lbl_id.Text + "|";


                    bas.si_no_existe_agega_comparacion("inf\\inventario\\provedores.txt", cmb_provedor.Text);

                    Lbl_nom_product_list.Text = Lbl_nombre_producto.Text + "costo por pieza:" + Txt_costo_compra.Text + " costo por paquetes:  $" + (Convert.ToDecimal(info_producto_comp_spliteada[2]) * Convert.ToDecimal(info_producto_comp_spliteada[1]));
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
                Lbl_nom_product_list.Text = info_producto_lista[1]+" $"+ (Convert.ToInt32(info_producto_lista[2])*Convert.ToDecimal(info_producto_lista[3]) );
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
            Txt_cantidad.Text = "";
            Txt_costo_compra.Text = "";
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

    }
}
