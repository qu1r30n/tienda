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
    public partial class Ventas_confirmar : Form
    {
        Operaciones_textos op_text = new Operaciones_textos();
        public ArrayList nombre_productos = new ArrayList();
        public ArrayList codigo_barras_list = new ArrayList();
        public ArrayList info_extra = new ArrayList();
        public ArrayList cantidad = new ArrayList();
        public ArrayList precio_venta = new ArrayList();
        public ArrayList provedor = new ArrayList();
        public ArrayList promo = new ArrayList();


        public decimal Total_costo_venta { get; set; }
        public decimal Cost_comp { get; set; }

        DateTime fecha_hora = DateTime.Now;
        char[] G_parametros = { '|', '°', '¬', '^' };

        public Ventas_confirmar()
        {
            InitializeComponent();
        }
        private void Btn_pagar_Click(object sender, EventArgs e)
        {
            decimal total_a_pagar = Convert.ToDecimal(Lbl_total.Text), dinero_pagado = Convert.ToDecimal(Txt_dinero.Text);

            if (true)
            {
                if (total_a_pagar <= dinero_pagado)
                {
                    if (total_a_pagar < dinero_pagado)
                    {
                        MessageBox.Show("cambio: " + (dinero_pagado - total_a_pagar));
                    }
                    Tex_base bas = new Tex_base();
                    string temp = "";
                    string cantidades_de_productos = "";

                    string direccion = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\info_tienda\\ventas\\" + fecha_hora.ToString("yyyyMMdd") + "_vendidos.txt";
                    string direccion2 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\info_tienda\\ventas\\provedores\\";
                    string direccion3 = "provedores\\ventas_en_dinero.txt";

                    for (int i = 0; i < codigo_barras_list.Count; i++)
                    {
                        temp = temp + codigo_barras_list[i] + G_parametros[0];
                        cantidades_de_productos = cantidades_de_productos + cantidad[i] + G_parametros[0];

                        string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
                        string direccion_inventario_hacer = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\info_tienda\\tienda_inventarios\\" + año_mes_dia + "_todo_tienda.txt";

                        string mod_inv = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\info_tienda\\tienda_inventarios\\mod_inv\\" + año_mes_dia + "mod_inv.txt";
                        if (bas.existe_archivo(mod_inv))
                        {
                            DateTime fecha_hora = DateTime.Now;

                            string hora_min_seg = fecha_hora.ToString("HHmmss");
                            string dir_venta_rest_invent = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\info_tienda\\tienda_inventarios\\" + año_mes_dia + "_compras_durante_invet_e_inventario.txt";
                            bas.Crear_archivo_y_directorio(dir_venta_rest_invent);
                            bas.Agregar(dir_venta_rest_invent, codigo_barras_list[i] + "|" + nombre_productos[i] + "|" + (Convert.ToDouble(cantidad[i]) * -1) + "|" + hora_min_seg + "|");
                            //bas.si_existe_suma_sino_agega_extra(dir_venta_rest_invent, 0, ""+codigo_barras_list[i], "2", ""+(Convert.ToDouble(cantidad[i])*-1), codigo_barras_list[i] + "|" + nombre_productos[i] + "|" + (Convert.ToDouble(cantidad[i]) * -1) + "|" + hora_min_seg);
                        }
                        //ranking---------------------------------------------------------------------------------------------------------

                        //0_codigo|1_nombre_producto|2_cantidad_vendida_estos_7_dias|3_provedores|4_historial_por_semana°|5_ranking|6_promedio_normal|7_cantidad_veses|8_uso_multiple|9_usomulti_tipo_de_producto|10_multi_costo_compra|
                        string dir_ranking_año = "inf\\ranking\\" + fecha_hora.ToString("yyyy") + "_ranking.txt";
                        string dir_ranking_dia = "inf\\ranking\\dia\\" + fecha_hora.ToString("yyyyMMdd") + "_ranking.txt";

                        int solo_dia = Convert.ToInt32(fecha_hora.ToString("dd"));



                        bas.Crear_archivo_y_directorio(dir_ranking_dia);
                        bas.Crear_archivo_y_directorio(dir_ranking_año);

                        bas.si_existe_suma_sino_agega_extra(dir_ranking_dia, 0, "" + codigo_barras_list[i], "2|5", cantidad[i] + "|" + cantidad[i], codigo_barras_list[i] + "|" + nombre_productos[i] + "|" + cantidad[i] + "|" + provedor[i] + "||" + cantidad[i] + "|0|0|0|0|0|0|");
                        bas.si_existe_suma_sino_agega_extra(dir_ranking_año, 0, "" + codigo_barras_list[i], "2|5|11", cantidad[i] + "|" + cantidad[i] + "|" + cantidad[i], codigo_barras_list[i] + "|" + nombre_productos[i] + "|" + cantidad[i] + "|" + provedor[i] + "|" + cantidad[i] + "°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°|" + cantidad[i] + "|0|0|0|0|0|0|");
                        string info_producto = bas.Seleccionar(dir_ranking_año, 0, "" + codigo_barras_list[i]);
                        string[] inf_pro_split = info_producto.Split('|');
                        string[] historial_ranking = inf_pro_split[4].Split('°');
                        historial_ranking[0] = "" + (Convert.ToDouble(historial_ranking[0]) + Convert.ToDouble(cantidad[i]));
                        inf_pro_split[4] = string.Join("°", historial_ranking);
                        bas.Editar_espesifico(dir_ranking_año, 0, "" + codigo_barras_list[i], "4", "" + inf_pro_split[4]);




                        //ranking_fin------------------------------------------------------------------------------------------------
                        //resumen----------------------------------------------------------------------------------------------------
                        string direccion_resumen = "inf\\resumen\\resumen_" + año_mes_dia + ".txt";
                        bas.Crear_archivo_y_directorio(direccion_resumen, "0_res_inverciones|0\n1_res_venta|0\n2_res_compra|0\n3_res_pag_emp|0");
                        bas.Incrementa_celda(direccion_resumen, 0, "1_res_venta", "1", "" + total_a_pagar);
                        //resumen----------------------------------------------------------------------------------------------------
                        bas.Si_existe_suma_sino_desde_el_inventario_agrega(direccion, 3, "" + codigo_barras_list[i], "0|1", cantidad[i] + "|" + precio_venta[i]);
                        bas.Si_existe_suma_sino_desde_el_inventario_las_columnas_agrega(direccion2 + provedor[i] + ".txt", 3, "" + codigo_barras_list[i], "0|1", cantidad[i] + "|" + precio_venta[i], "1|3|0|6|8|2");
                        bas.si_existe_suma_sino_agega_extra(direccion3, 0, "" + provedor[i], "1", "" + precio_venta[i], provedor[i] + "|" + precio_venta[i]);

                    }

                    temp = op_text.Trimend_paresido(temp, G_parametros[0]);
                    cantidades_de_productos = op_text.Trimend_paresido(cantidades_de_productos, G_parametros[0]);


                    string[] codigos_Barras = temp.Split(G_parametros[0]);
                    string[] cant_productos = cantidades_de_productos.Split(G_parametros[0]);

                    Modelo_compra_venta mod_com_vent = new Modelo_compra_venta();
                    mod_com_vent.Modelo_venta(codigos_Barras, cant_productos);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("falta de dinero: " + (total_a_pagar - dinero_pagado));
                }
            }
            else
            {

            }
        }




        private void Txt_dinero_keypress(object sender, KeyPressEventArgs e)
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



    }
}
