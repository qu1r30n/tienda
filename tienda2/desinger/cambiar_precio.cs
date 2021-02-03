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
    public partial class Cambiar_precio : Form
    {
        char[] G_parametros = { '|' };
        List<string> G_productos = new List<string>();
        Tex_base bas = new Tex_base();
        Operaciones_textos op_text = new Operaciones_textos();

        string G_prov_anterior = null;//si el provedor trajera varios productos nuevos para no estar escribe y escribe el provedor solo se guarda temporalmente 

        public Cambiar_precio()
        {
            InitializeComponent();
            Recargar_texbox();
            
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            DateTime fecha_hora = DateTime.Now; //se usara la variable fecha y hora para sacar el dia de hoy y la hora

            if (chb_no_vacio.Checked)
            {
                if (Txt_remplazo.Text!="")
                {
                    if (Lbl_precio_compra_canb.Text != "$")
                    {
                        
                        if (Rdb_producto.Checked == true)
                        {
                            bas.Editar_espesifico("inf\\inventario\\invent.txt", 3, Txt_buscar_producto.Text, "1", Txt_remplazo.Text);
                            Actualisar_Txt(0, Txt_buscar_producto.Text, "3", Txt_remplazo.Text);
                            Lbl_nombre_producto_camb.Text = "";
                            Lbl_precio_compra_canb.Text = "$";
                            Lbl_precio_venta_camb.Text = "$";
                            Lbl_cantidad_canb.Text = "$";
                            Txt_buscar_producto.Text = "";
                            Txt_remplazo.Text = "";
                            Lbl_provedor_camb.Text = "nombre del provedor";
                            Txt_buscar_producto.Focus();
                        }

                        else if (Rdb_compra.Checked == true)
                        {
                            bas.Editar_espesifico("inf\\inventario\\invent.txt", 3, Txt_buscar_producto.Text, "5", Txt_remplazo.Text);
                            Actualisar_Txt(0, Txt_buscar_producto.Text, "5", Txt_remplazo.Text);
                            Lbl_nombre_producto_camb.Text = "";
                            Lbl_precio_compra_canb.Text = "$";
                            Lbl_precio_venta_camb.Text = "$";
                            Lbl_cantidad_canb.Text = "$";
                            Txt_buscar_producto.Text = "";
                            Txt_remplazo.Text = "";
                            Lbl_provedor_camb.Text = "nombre del provedor";
                            Txt_buscar_producto.Focus();

                        }

                        else if (Rdb_venta.Checked == true)
                        {
                            bas.Editar_espesifico("inf\\inventario\\invent.txt", 3, Txt_buscar_producto.Text, "2", Txt_remplazo.Text);
                            Actualisar_Txt(0, Txt_buscar_producto.Text, "2", Txt_remplazo.Text);
                            Lbl_nombre_producto_camb.Text = "";
                            Lbl_precio_compra_canb.Text = "$";
                            Lbl_precio_venta_camb.Text = "$";
                            Lbl_cantidad_canb.Text = "$";
                            Txt_buscar_producto.Text = "";
                            Txt_remplazo.Text = "";
                            Lbl_provedor_camb.Text = "nombre del provedor";
                            Txt_buscar_producto.Focus();
                        }

                        else if (Rdb_inventario.Checked == true)
                        {

                            if (chb_suma_si_ya_paso_producto.Checked==true)
                            {
                                string direccion = "inf\\inventario\\temp_para_sumas_en_inventario\\temporal_codigos_suma_info_para_invetario_" + fecha_hora.ToString("yyyy - MM - dd") + ".txt";
                                bas.Crear_archivo_y_directorio(direccion);
                                string[] codigos_ya_leidos = bas.Leer(direccion);
                                bool bandera = false;
                                for (int i = 0; i < codigos_ya_leidos.Length; i++)
                                {
                                    codigos_ya_leidos[i] = bas.Trimend_paresido(codigos_ya_leidos[i]);
                                    if (codigos_ya_leidos[i] == Txt_buscar_producto.Text)
                                    {
                                        decimal cantidad_anterionr = Convert.ToDecimal(Lbl_cantidad_canb.Text);
                                        decimal cantidad_a_sumar = Convert.ToDecimal(Txt_remplazo.Text);
                                        Txt_remplazo.Text = "" + (cantidad_anterionr + cantidad_a_sumar);
                                        bandera = true;
                                    }
                                }

                                if (bandera == false)
                                {
                                    bas.si_no_existe_agega_comparacion(direccion, Txt_buscar_producto.Text);
                                }

                            }

                            bas.Editar_espesifico("inf\\inventario\\invent.txt", 3, Txt_buscar_producto.Text, "4", Txt_remplazo.Text);
                            Actualisar_Txt(0, Txt_buscar_producto.Text, "4", Txt_remplazo.Text);
                            Lbl_nombre_producto_camb.Text = "";
                            Lbl_precio_compra_canb.Text = "$";
                            Lbl_precio_venta_camb.Text = "$";
                            Lbl_cantidad_canb.Text = "$";
                            Txt_buscar_producto.Text = "";
                            Txt_remplazo.Text = "";
                            Lbl_provedor_camb.Text = "nombre del provedor";
                            Txt_buscar_producto.Focus();
                        }

                        else if (Rdb_provedor.Checked == true)
                        {
                            bas.Editar_espesifico("inf\\inventario\\invent.txt", 3, Txt_buscar_producto.Text, "6", Txt_remplazo.Text);
                            Actualisar_Txt(0, Txt_buscar_producto.Text, "6", Txt_remplazo.Text);

                            bas.si_no_existe_agega_comparacion("inf\\inventario\\provedores.txt", Txt_remplazo.Text);

                            Lbl_nombre_producto_camb.Text = "";
                            Lbl_precio_compra_canb.Text = "$";
                            Lbl_precio_venta_camb.Text = "$";
                            Lbl_cantidad_canb.Text = "$";
                            Txt_buscar_producto.Text = "";
                            Txt_remplazo.Text = "";
                            Lbl_provedor_camb.Text = "nombre del provedor";
                            Txt_buscar_producto.Focus();
                        }


                        else
                        {
                            MessageBox.Show("elige el dato que quieres cambiar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("no se encontro producto dentro del inventario");
                    }
                }

                else
                {
                    MessageBox.Show("falta llenar informacion");
                }
            }
            
            else
            {
                if (Lbl_precio_compra_canb.Text != "$")
                {
                    if (Rdb_producto.Checked == true)
                    {
                        bas.Editar_espesifico("inf\\inventario\\invent.txt", 3, Txt_buscar_producto.Text, "1", Txt_remplazo.Text);
                        Actualisar_Txt(0, Txt_buscar_producto.Text, "3", Txt_remplazo.Text);
                        Lbl_nombre_producto_camb.Text = "";
                        Lbl_precio_compra_canb.Text = "$";
                        Lbl_precio_venta_camb.Text = "$";
                        Lbl_cantidad_canb.Text = "$";
                        Txt_buscar_producto.Text = "";
                        Txt_remplazo.Text = "";
                        Lbl_provedor_camb.Text = "nombre del provedor";
                        Txt_buscar_producto.Focus();
                    }

                    else if (Rdb_compra.Checked == true)
                    {
                        bas.Editar_espesifico("inf\\inventario\\invent.txt", 3, Txt_buscar_producto.Text, "5", Txt_remplazo.Text);
                        Actualisar_Txt(0, Txt_buscar_producto.Text, "5", Txt_remplazo.Text);
                        Lbl_nombre_producto_camb.Text = "";
                        Lbl_precio_compra_canb.Text = "$";
                        Lbl_precio_venta_camb.Text = "$";
                        Lbl_cantidad_canb.Text = "$";
                        Txt_buscar_producto.Text = "";
                        Txt_remplazo.Text = "";
                        Lbl_provedor_camb.Text = "nombre del provedor";
                        Txt_buscar_producto.Focus();

                    }

                    else if (Rdb_venta.Checked == true)
                    {
                        bas.Editar_espesifico("inf\\inventario\\invent.txt", 3, Txt_buscar_producto.Text, "2", Txt_remplazo.Text);
                        Actualisar_Txt(0, Txt_buscar_producto.Text, "2", Txt_remplazo.Text);
                        Lbl_nombre_producto_camb.Text = "";
                        Lbl_precio_compra_canb.Text = "$";
                        Lbl_precio_venta_camb.Text = "$";
                        Lbl_cantidad_canb.Text = "$";
                        Txt_buscar_producto.Text = "";
                        Txt_remplazo.Text = "";
                        Lbl_provedor_camb.Text = "nombre del provedor";
                        Txt_buscar_producto.Focus();
                    }

                    else if (Rdb_inventario.Checked == true)
                    {

                        if (chb_suma_si_ya_paso_producto.Checked == true)
                        {
                            string direccion = "inf\\inventario\\temp_para_sumas_en_inventario\\temporal_codigos_suma_info_para_invetario_" + fecha_hora.ToString("yyyy - MM - dd") + ".txt";
                            bas.Crear_archivo_y_directorio(direccion);
                            string[] codigos_ya_leidos = bas.Leer(direccion);
                            bool bandera = false;
                            for (int i = 0; i < codigos_ya_leidos.Length; i++)
                            {
                                codigos_ya_leidos[i] = bas.Trimend_paresido(codigos_ya_leidos[i]);
                                if (codigos_ya_leidos[i] == Txt_buscar_producto.Text)
                                {
                                    decimal cantidad_anterionr = Convert.ToDecimal(Lbl_cantidad_canb.Text);
                                    decimal cantidad_a_sumar = Convert.ToDecimal(Txt_remplazo.Text);
                                    Txt_remplazo.Text = "" + (cantidad_anterionr + cantidad_a_sumar);
                                    bandera = true;
                                }
                            }

                            if (bandera == false)
                            {
                                bas.si_no_existe_agega_comparacion(direccion, Txt_buscar_producto.Text);
                            }

                        }


                        bas.Editar_espesifico("inf\\inventario\\invent.txt", 3, Txt_buscar_producto.Text, "4", Txt_remplazo.Text);
                        Actualisar_Txt(0, Txt_buscar_producto.Text, "4", Txt_remplazo.Text);
                        Lbl_nombre_producto_camb.Text = "";
                        Lbl_precio_compra_canb.Text = "$";
                        Lbl_precio_venta_camb.Text = "$";
                        Lbl_cantidad_canb.Text = "$";
                        Txt_buscar_producto.Text = "";
                        Txt_remplazo.Text = "";
                        Lbl_provedor_camb.Text = "nombre del provedor";
                        Txt_buscar_producto.Focus();
                    }

                    else if (Rdb_provedor.Checked == true)
                    {
                        bas.Editar_espesifico("inf\\inventario\\invent.txt", 3, Txt_buscar_producto.Text, "6", Txt_remplazo.Text);
                        Actualisar_Txt(0, Txt_buscar_producto.Text, "6", Txt_remplazo.Text);

                        bas.si_no_existe_agega_comparacion("inf\\inventario\\provedores.txt", Txt_remplazo.Text);

                        Lbl_nombre_producto_camb.Text = "";
                        Lbl_precio_compra_canb.Text = "$";
                        Lbl_precio_venta_camb.Text = "$";
                        Lbl_cantidad_canb.Text = "$";
                        Txt_buscar_producto.Text = "";
                        Txt_remplazo.Text = "";
                        Lbl_provedor_camb.Text = "nombre del provedor";
                        Txt_buscar_producto.Focus();
                    }


                    else
                    {
                        MessageBox.Show("elige el dato que quieres cambiar");
                    }
                }
                else
                {
                    MessageBox.Show("no se encontro producto dentro del inventario");
                }
            }
            
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
        }

        private void Procesar_codigo(string codigo)
        {

            bool bandera = false;
            for (int i = 0; i < G_productos.Count; i++)
            {
                String[] temp = G_productos[i].Split(G_parametros);
                if (codigo == temp[0])
                {
                    Txt_buscar_producto.Text = temp[0];
                    Lbl_nombre_producto_camb.Text = temp[3];
                    Lbl_precio_compra_canb.Text = temp[5];
                    Lbl_precio_venta_camb.Text = temp[2];
                    Lbl_cantidad_canb.Text = temp[4];
                    Lbl_provedor_camb.Text = temp[6];

                    bandera = true;
                    break;
                }
            }

            if (bandera == false)
            {

                Tex_base bas = new Tex_base();
                string[] cantidad_produc = bas.Leer("inf\\inventario\\invent.txt", "0", "" + G_parametros[0]);//el 0 solo regresa la primera columna que creo es el id
                string[] espliteado = Txt_buscar_producto.Text.Split(G_parametros);
                string[] provedores = bas.Leer("inf\\inventario\\provedores.txt", "0", "" + G_parametros[0]);
                Operaciones_textos op_text = new Operaciones_textos();
                string provedores_txt = op_text.join_paresido('°', provedores);


                //------------------------------------------------------------
                Ventana_emergente vent_emergent = new Ventana_emergente();
                //-------------------------------------------------------------
                //a = 1;


                string[] enviar;

                if (G_prov_anterior == null)
                {
                    if (provedores.Length < 0)
                    {
                        G_prov_anterior = provedores[0];
                    }

                    enviar = new string[] { "2°id°" + (cantidad_produc.Length), "1°producto", "1°precio venta°0°2", "2°codigo de barras°" + espliteado[0], "1°cantidad°1°2", "1°costo de compra°0°2", "4°provedor°marinela°°" + G_prov_anterior + '°' + provedores_txt, "4°grupo°2°4°1°1°2", "2°no poner nada°", "1°cantidad_productos_por_paquete°1°2", "1°productos_elaborados°°3" };
                }
                else
                {
                    enviar = new string[] { "2°id°" + (cantidad_produc.Length), "1°producto", "1°precio venta°0°2", "2°codigo de barras°" + espliteado[0], "1°cantidad°1°2", "1°costo de compra°0°2", "4°provedor°" + G_prov_anterior + "°°" + G_prov_anterior + '°' + provedores_txt, "4°grupo°2°4°1°1°2", "2°no poner nada°", "1°cantidad_productos_por_paquete°1°2", "1°productos_elaborados°°3" };
                }
                string mensage = vent_emergent.Proceso_ventana_emergente(enviar, 1);//el uno significa que modificara el inventario
                string[] temp = mensage.Split(G_parametros);//lo espliteo para cambiar el orden de la informacion y adaptarlo a como lo tiene el textbox
                
                string[] temp2;
                string temp3 = "";

                if (temp.Length >= 3)//por si cierra la ventana no agregue a los text box
                {
                    MessageBox.Show("ya se agrego el producto: " + mensage);
                    
                    G_prov_anterior = temp[6];
                    temp2 = new[] { temp[3], temp[0], temp[2], temp[1], temp[4], temp[5], temp[6], temp[7]};//aqui lo pongo en el orden que deve llevar
                    temp3 = string.Join(G_parametros[0] + "", temp2);//uno todo en un string conforme al parametro o caracter de separacion
                    G_productos.Add(temp3);//agrego en lista de productos
                    Txt_buscar_producto.AutoCompleteCustomSource.Add(temp3);//agrego en el autocompletar

                    bas.si_no_existe_agega_comparacion("inf\\inventario\\provedores.txt", temp[6]);

                }
                Txt_buscar_producto.Text = "";
            }

        }

        private void Txt_buscar_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = Txt_buscar_producto.Text.Split(G_parametros);
                Procesar_codigo(info[0]);
                Txt_remplazo.Focus();
            }
        }

        private void Txt_remplazo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyValue == (char)(Keys.Escape))
            {
                Txt_buscar_producto.Text = "";
                Lbl_nombre_producto_camb.Text = "nombre producto";
                Lbl_precio_compra_canb.Text = "$";
                Lbl_precio_venta_camb.Text = "$";
                Lbl_cantidad_canb.Text = "$";
                Lbl_provedor_camb.Text = "nombre del provedor";
                Txt_remplazo.Text = "";
                Txt_buscar_producto.Focus();
            }
        }

        private void Actualisar_Txt(int num_column_comp, string comparar, string numero_columnas_editar, string editar_columna, char caracter_separacion = '|')
        {
            for (int i = 0; i < Txt_buscar_producto.AutoCompleteCustomSource.Count; i++)
            {
                string[] palabra = Txt_buscar_producto.AutoCompleteCustomSource[i].Split(caracter_separacion);

                if (palabra[num_column_comp] == comparar)
                {
                    string linea_editada = "";
                    string[] columnas_editar = numero_columnas_editar.Split(caracter_separacion);
                    string[] remplaso_dato = editar_columna.Split(caracter_separacion);
                    for (int j = 0; j < columnas_editar.Length; j++)
                    {
                        palabra[Convert.ToInt32(columnas_editar[j])] = remplaso_dato[j];
                    }
                    for (int k = 0; k < palabra.Length; k++)
                    {
                        linea_editada = linea_editada + palabra[k] + caracter_separacion;
                    }
                    linea_editada = op_text.Trimend_paresido(linea_editada, caracter_separacion);
                    Txt_buscar_producto.AutoCompleteCustomSource[i] = linea_editada;
                    G_productos[i] = linea_editada;
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Txt_buscar_producto.Text = "";
            Lbl_nombre_producto_camb.Text = "nombre producto";
            Lbl_precio_compra_canb.Text = "$";
            Lbl_precio_venta_camb.Text = "$";
            Lbl_cantidad_canb.Text = "$";
            Lbl_provedor_camb.Text = "nombre del provedor";
            Txt_remplazo.Text = "";
            Txt_buscar_producto.Focus();
        }

        private void Rdb_producto_CheckedChanged(object sender, EventArgs e)
        {
            //chb_suma_si_ya_paso_producto.Checked = false;
            chb_suma_si_ya_paso_producto.Visible = false;
        }

        private void Rdb_compra_CheckedChanged(object sender, EventArgs e)
        {
            //chb_suma_si_ya_paso_producto.Checked = false;
            chb_suma_si_ya_paso_producto.Visible = false;
        }

        private void Rdb_venta_CheckedChanged(object sender, EventArgs e)
        {
            //chb_suma_si_ya_paso_producto.Checked = false;
            chb_suma_si_ya_paso_producto.Visible = false;
        }

        private void Rdb_inventario_CheckedChanged(object sender, EventArgs e)
        {
            chb_suma_si_ya_paso_producto.Visible = true;
        }

        private void Rdb_provedor_CheckedChanged(object sender, EventArgs e)
        {
            //chb_suma_si_ya_paso_producto.Checked = false;
            chb_suma_si_ya_paso_producto.Visible = false;
        }
    }
}