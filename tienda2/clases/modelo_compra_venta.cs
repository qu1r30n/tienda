﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace tienda2.clases
{
    class Modelo_compra_venta
    {
        char[] G_parametros = { '|', '°', '¬', '^' };

        public void Modelo_compra(string codigo, string costo_compra, string cantidad, string provedor, string nom_producto, string id_producto, string info_extra = null, bool compra_directa = true, string cantidad_pagada_de_caja = "0")
        {
            DateTime fecha_hora = DateTime.Now;
            //string hora_min_seg = fecha_hora.ToString("HH:mm:ss");
            string hora_min = fecha_hora.ToString("HH:mm");
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            string dia = fecha_hora.ToString("dd");
            string mes = fecha_hora.ToString("MM");
            string año = fecha_hora.ToString("yyyy");
            Tex_base bas = new Tex_base();
            Operaciones_archivos op = new Operaciones_archivos();


            if (compra_directa == true)
            {
                string dir_arch = "inf\\inventario\\invent.txt";
                bas.Editar_espesifico(dir_arch, 3, codigo, "6", provedor);
                op.Actualisar_inventario(dir_arch, "" + codigo, Convert.ToDecimal(cantidad));


                bas.si_existe_suma_sino_agega_extra("inf\\inventario\\ven\\vent.txt", 0, año_mes_dia, "2", "" + cantidad_pagada_de_caja, año_mes_dia + "|0|" + cantidad);


                dir_arch = "ventas\\" + año + "\\" + mes + "\\dias\\g_" + año_mes_dia + ".txt";
                //se me olvido para que es el ultimo 0 bas.agregar(dir_arch, hora + "|" + codigo + "|" + cantidad + "|" + nom_producto + "|"+ provedor + "|" + "0");
                bas.Agregar(dir_arch, hora_min + "|" + codigo + "|" + cantidad + "|" + nom_producto + "|" + provedor + "|" + costo_compra + "|" + (Convert.ToDecimal(costo_compra) * Convert.ToInt32(cantidad)) + "|" + info_extra);//muestra total cada horas

                dir_arch = "ventas\\" + año + "\\" + mes + "\\g_" + mes + ".txt";
                op.Actualisar_resumen_compras(dir_arch, dia, Convert.ToDecimal(cantidad) * Convert.ToDecimal(costo_compra));//muestra total de cada dias

                dir_arch = "ventas\\" + año + "\\g_" + año + ".txt";
                op.Actualisar_resumen_compras(dir_arch, mes, Convert.ToDecimal(cantidad) * Convert.ToDecimal(costo_compra));//muestra total de cada mes

                dir_arch = "ventas\\g_total_años.txt";
                op.Actualisar_resumen_compras(dir_arch, año, Convert.ToDecimal(cantidad) * Convert.ToDecimal(costo_compra));//muestra total de cada año

                dir_arch = "ventas\\total_en_juego.txt";
                op.Actualisar_resumen_compras(dir_arch, "dinero_hay: ", -1 * Convert.ToDecimal(cantidad) * Convert.ToDecimal(costo_compra));//muestra total de cada año

                dir_arch = "ventas\\ganancia_real.txt";
                op.Actualisar_ganancia_real(dir_arch, "dinero_hay: ", -1 * Convert.ToDecimal(cantidad) * Convert.ToDecimal(costo_compra));//muestra ganancia real

                //-----------------mensaje de se esta acabando el dinero o ya se acabo y no se sabe de donde agarra -----------------------------------------------------------------------------------------------------------------------
                string[] cantidades_en_juego = bas.Leer("ventas\\total_en_juego.txt"), cantidades_en_juego_espliteada;
                Decimal dinero_ganado;
                decimal dinero_gastado = 0;
                cantidades_en_juego_espliteada = cantidades_en_juego[0].Split(G_parametros[0]);
                dinero_ganado = Convert.ToDecimal(cantidades_en_juego_espliteada[1]);

                if (dinero_ganado >= dinero_gastado)
                {
                    //mensaje de que se esta acabando el dinero o ya se acabo y no se sabe de donde agarra
                }
                //-------------------- fin de mensaje de se esta acabando el dinero o ya se acabo y no se sabe de donde agarra -----------------------------------------------------------------------------------------------------------------------


            }

            else
            {

                string dir_arch = "pedidos/" + año_mes_dia + "_" + provedor + ".txt";


                bas.si_existe_suma_sino_agega_extra(dir_arch, 0, codigo, "1", cantidad, codigo + "|" + cantidad + "|" + costo_compra);

            }



        }
        public void Modelo_venta(string[] codigo, string[] cantidades_vendidas, string[] promo)
        {
            string codigos_unidos = "";
            for (int i = 0; i < promo.Length; i++)
            {
                if (promo[i]=="1")
                {
                    string[] cantidad_codigos=codigo[i].Split('°');
                    for (int k = 0; k < cantidad_codigos.Length; k++)
                    {
                        string[] cod_prom=cantidad_codigos[k].Split('¬');
                        codigos_unidos = codigos_unidos + cod_prom[0] + "°";
                    }
                }
                else
                {
                    codigos_unidos = codigos_unidos + codigo[i] + "°";
                }
            }
            Tex_base bas = new Tex_base();
            codigos_unidos = bas.Trimend_paresido(codigos_unidos, '°');
            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            string hora_min_seg = fecha_hora.ToString("HH:mm:ss");
            string dia = fecha_hora.ToString("dd");
            string mes = fecha_hora.ToString("MM");
            string año = fecha_hora.ToString("yyyy");
            
            Operaciones_archivos op = new Operaciones_archivos();

            string[] productos = bas.Leer("inf\\inventario\\invent.txt");
            decimal acum_costo_venta = 0, acum_costo_compra = 0;
            string[] nom_productos = new string[codigo.Length];
            string[] provedores = new string[codigo.Length];





            for (int i = 0; i < codigo.Length; i++)
            {
                if (promo[i]=="1")
                {
                    string[] promo_split = codigo[i].Split('°');
                    for (int k = 0; k < promo_split.Length; k++)
                    {
                        string[] cod_prom = promo_split[k].Split('¬');
                        for (int j = 0; j < productos.Length; j++)
                        {
                            string[] prod_esplit = productos[j].Split(G_parametros[0]);

                            if (prod_esplit[3] == cod_prom[0])
                            {
                                if (cantidades_vendidas[i] == "")//con esto se pone la cantidad que se vendio por cada cosa si no tiene cantidad le pone 1 para que sea un producto 
                                {
                                    cantidades_vendidas[i] = "1";
                                }

                                acum_costo_venta = acum_costo_venta + (Convert.ToDecimal(cod_prom[3]) * Convert.ToDecimal(cod_prom[1]));
                                acum_costo_compra = acum_costo_compra + (Convert.ToDecimal(cod_prom[3]) * Convert.ToDecimal(cod_prom[1]));
                                nom_productos[i] = cod_prom[2];
                                provedores[i] = prod_esplit[6];

                            }
                        }
                    }
                    
                }

                else if (promo[i] == "")
                {
                    for (int j = 0; j < productos.Length; j++)
                    {
                        string[] prod_esplit = productos[j].Split(G_parametros[0]);

                        if (prod_esplit[3] == codigo[i])
                        {
                            if (cantidades_vendidas[i] == "")//con esto se pone la cantidad que se vendio por cada cosa si no tiene cantidad le pone 1 para que sea un producto 
                            {
                                cantidades_vendidas[i] = "1";
                            }

                            acum_costo_venta = acum_costo_venta + (Convert.ToDecimal(prod_esplit[2]) * Convert.ToDecimal(cantidades_vendidas[i]));
                            acum_costo_compra = acum_costo_compra + (Convert.ToDecimal(prod_esplit[5]) * Convert.ToDecimal(cantidades_vendidas[i]));
                            nom_productos[i] = prod_esplit[1];
                            provedores[i] = prod_esplit[6];

                        }
                    }
                }


                else
                {

                }


            }





        

            string direccion = "ventas\\" + año + "\\" + mes + "\\dias\\" + año_mes_dia + ".txt";
            string info = hora_min_seg + " |" + codigos_unidos + " |" + acum_costo_venta + " |" + string.Join("°", nom_productos) + " |" + acum_costo_compra + "|" + string.Join("°", provedores);
            bas.Agregar(direccion, info);//la hora de compra lo que compro el costo 

            direccion = "ventas\\" + año + "\\" + mes + "\\" + mes + ".txt";
            op.Actualisar_resumen_venta(direccion, dia, acum_costo_venta, acum_costo_compra);//actualisa total de cada dias

            direccion = "ventas\\" + año + "\\" + año + ".txt";
            op.Actualisar_resumen_venta(direccion, mes, acum_costo_venta, acum_costo_compra);//actualisa total de cada mes

            direccion = "ventas\\total_años.txt";
            op.Actualisar_resumen_venta(direccion, año, acum_costo_venta, acum_costo_compra);//muestra total de cada año

            direccion = "ventas\\total_en_juego.txt";
            op.Actualisar_resumen_venta(direccion, "dinero_hay: ", acum_costo_venta, acum_costo_compra);//muestra total de cada año

            direccion = "ventas\\ganancia_real.txt";
            op.Actualisar_ganancia_real(direccion, "dinero_hay: ", acum_costo_venta, acum_costo_compra);//muestra ganancia real

            bas.si_existe_suma_sino_agega_extra("inf\\inventario\\ven\\vent.txt", 0, año_mes_dia, "1", "" + acum_costo_venta, año_mes_dia + "|" + acum_costo_venta + "|0");


            for (int i = 0; i < codigo.Length; i++)
            {
                direccion = "inf\\inventario\\invent.txt";
                if (promo[i]=="1")
                {
                    string[] prom_spliteado = codigo[i].Split('°');
                    for (int j = 0; j < prom_spliteado.Length; j++)
                    {
                        string[] cod_insertar = prom_spliteado[j].Split('¬');
                        op.Actualisar_inventario(direccion, "" + cod_insertar[0], Convert.ToDecimal(cod_insertar[1]) * -1);
                    }
                }
                else
                {
                    
                    op.Actualisar_inventario(direccion, "" + codigo[i], Convert.ToDecimal(cantidades_vendidas[i]) * -1);
                }
                

                direccion = "ventas\\" + año + "\\" + mes + "\\dias\\p_" + año_mes_dia + ".txt";
                op.Actualisar_resumen_venta_productos(direccion, "" + codigo[i], Convert.ToDecimal(cantidades_vendidas[i]), nom_productos[i]);

                direccion = "ventas\\" + año + "\\" + mes + "\\p_" + mes + ".txt";
                op.Actualisar_resumen_venta_productos(direccion, "" + codigo[i], Convert.ToDecimal(cantidades_vendidas[i]), nom_productos[i]);//muestra total de cada dias

                direccion = "ventas\\" + año + "\\p_" + año + ".txt";
                op.Actualisar_resumen_venta_productos(direccion, "" + codigo[i], Convert.ToDecimal(cantidades_vendidas[i]), nom_productos[i]);//muestra total de cada mes

                direccion = "ventas\\p_total_años.txt";
                op.Actualisar_resumen_venta_productos(direccion, "" + codigo[i], Convert.ToDecimal(cantidades_vendidas[i]), nom_productos[i]);//muestra total de cada año

            }
        }


        private PrintDocument doc = new PrintDocument();
        private PrintPreviewDialog vista = new PrintPreviewDialog();



        string[] texto;
        public void imp_tiket(string[] texto_linea)
        {
            texto = texto_linea;
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(imprimir_tiket);
            vista.Document = doc;
            vista.Show();
            //doc.Print();

            texto=null;
            
        }

        public void imprimir_tiket(object sender,PrintPageEventArgs e)
        {
            int posx = 10, posy = 100;
            
            try
            {

                for (int i = 0; i < texto.Length; i++)
                {
                    Font fuente = new Font("consola", 15);
                    e.Graphics.DrawString(texto[i], fuente, Brushes.Black, posx, posy);
                    posy += 20;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
