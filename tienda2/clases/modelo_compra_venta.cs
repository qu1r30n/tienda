using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda2.clases
{
    class modelo_compra_venta
    {

        char[] G_parametros = { '|' };

        public void modelo_compra(string codigo, string costo_compra, string cantidad, string provedor,string nom_producto,string id_producto,string info_extra=null,bool compra_directa=true)
        {
            DateTime fecha_hora = DateTime.Now;
            string hora_min_seg = fecha_hora.ToString("HH:mm:ss");
            string hora_min = fecha_hora.ToString("HH:mm");
            string dia_mes_año = fecha_hora.ToString("dd-MM-yyyy");
            string dia = fecha_hora.ToString("dd");
            string mes = fecha_hora.ToString("MM");
            string año = fecha_hora.ToString("yyyy");
            tex_base bas = new tex_base();
            operaciones_archivos op = new operaciones_archivos();
            

            if (compra_directa==true)
            {
                string dir_arch = "inf\\inventario\\invent.txt";
                bas.editar_espesifico(dir_arch, 0, id_producto, "6", provedor);
                op.actualisar_inventario(dir_arch, "" + id_producto, Convert.ToInt32(cantidad));
                
                dir_arch = "ventas\\" + año + "\\" + mes + "\\dias\\g_" + dia_mes_año + ".txt";
                //no se para que es el ultimo 0 bas.agregar(dir_arch, hora + "|" + codigo + "|" + cantidad + "|" + nom_producto + "|"+ provedor + "|" + "0");
                bas.agregar(dir_arch, hora_min + "|" + codigo + "|" + cantidad + "|" + nom_producto + "|"+ provedor + "|" + costo_compra + "|" + (Convert.ToDecimal(costo_compra)*Convert.ToInt32(cantidad)) + "|" + info_extra );//muestra total cada horas

                dir_arch = "ventas\\" + año + "\\" + mes + "\\g_" + mes + ".txt";
                op.actualisar_resumen_compras(dir_arch, dia, Convert.ToDecimal(costo_compra));//muestra total de cada dias

                dir_arch = "ventas\\" + año + "\\g_" + año + ".txt";
                op.actualisar_resumen_compras(dir_arch, mes, Convert.ToDecimal(costo_compra));//muestra total de cada mes

                dir_arch = "ventas\\g_total_años.txt";
                op.actualisar_resumen_compras(dir_arch, año, Convert.ToDecimal(costo_compra));//muestra total de cada año

                dir_arch = "ventas\\total_en_juego.txt";
                op.actualisar_resumen_compras(dir_arch, "dinero_hay: ", -1 * Convert.ToDecimal(costo_compra));//muestra total de cada año

                dir_arch = "ventas\\ganancia_real.txt";
                op.actualisar_ganancia_real(dir_arch, "dinero_hay: ", -1 * Convert.ToDecimal(costo_compra));//muestra ganancia real
                
                
                
                


//-----------------mensaje de se esta acabando el dinero o ya se acabo y no se sabe de donde agarra -----------------------------------------------------------------------------------------------------------------------
                string[] cantidades_en_juego = bas.leer("ventas\\total_en_juego.txt"), cantidades_en_juego_espliteada;
                Decimal dinero_ganado = 0, dinero_gastado = 0;
                cantidades_en_juego_espliteada = cantidades_en_juego[0].Split(G_parametros);
                dinero_ganado = Convert.ToDecimal(cantidades_en_juego_espliteada[1]);

                if (dinero_ganado >= dinero_gastado)
                {
                    //mensaje de que se esta acabando el dinero o ya se acabo y no se sabe de donde agarra
                }
//-------------------- fin de mensaje de se esta acabando el dinero o ya se acabo y no se sabe de donde agarra -----------------------------------------------------------------------------------------------------------------------


            }

            else
            {
                string dir_arch = "inf\\inventario\\invent.txt";
                bas.editar_espesifico(dir_arch, 0, id_producto, "6", provedor);

                dir_arch = "pedidos/" + dia_mes_año + "_" + provedor + ".txt";
                bas.si_existe_suma_sino_agrega(dir_arch,2,codigo,"0",cantidad, "1|" + costo_compra +"|"+(Convert.ToDecimal(costo_compra)*Convert.ToInt32(cantidad)) + "|" + info_extra);
                
                
                

            }



        }
        public void modelo_venta(string [] codigo)
        {
            string codigos_unidos = string.Join("°",codigo);
            DateTime fecha_hora = DateTime.Now;
            string hora_min_seg = fecha_hora.ToString("HH:mm:ss");
            string dia_mes_año = fecha_hora.ToString("dd-MM-yyyy");
            string dia = fecha_hora.ToString("dd");
            string mes = fecha_hora.ToString("MM");
            string año = fecha_hora.ToString("yyyy");
            tex_base bas = new tex_base();
            operaciones_archivos op = new operaciones_archivos();
            operaciones_textos op_tex = new operaciones_textos();


            string[] productos = bas.leer("inf\\inventario\\invent.txt", "0|1|2|3|4|5|6|7");
            decimal acum_costo_venta=0,acum_costo_compra=0;
            string nom_product = "", ids_unidos = "";
            for (int j = 0; j < productos.Length; j++)
            {
                string[] prod_esplit = productos[j].Split(G_parametros);
                for (int i = 0; i < codigo.Length; i++)
                {

                    if (prod_esplit[3] == codigo[i])
                    {
                        acum_costo_venta = acum_costo_venta + Convert.ToDecimal(prod_esplit[2]);
                        acum_costo_compra= acum_costo_compra + Convert.ToDecimal(prod_esplit[5]);
                        nom_product = nom_product + prod_esplit[1]+"°";
                        ids_unidos = ids_unidos + prod_esplit[3] + "°";
                    }
                }
            }

            nom_product = op_tex.trimend_paresido(nom_product, '°');
            ids_unidos = op_tex.trimend_paresido(ids_unidos, '°');
            string[] ids_productos = ids_unidos.Split('°');

            bas.agregar("ventas\\" + año + "\\" + mes + "\\dias\\" + dia_mes_año + ".txt", hora_min_seg+ " |" +codigos_unidos + " |" +acum_costo_venta + " |" +nom_product + " |" +acum_costo_compra);//la hora de compra lo que compro el costo 
            op.actualisar_resumen_venta("ventas\\" + año + "\\" + mes + "\\" + mes + ".txt", dia, acum_costo_venta, acum_costo_compra);//actualisa total de cada dias
            op.actualisar_resumen_venta("ventas\\" + año + "\\" + año + ".txt", mes, acum_costo_venta, acum_costo_compra);//actualisa total de cada mes
            op.actualisar_resumen_venta("ventas\\total_años.txt", año, acum_costo_venta, acum_costo_compra);//muestra total de cada año
            op.actualisar_resumen_venta("ventas\\total_en_juego.txt", "dinero_hay: ", acum_costo_venta, acum_costo_compra);//muestra total de cada año
            op.actualisar_ganancia_real("ventas\\ganancia_real.txt", "dinero_hay: ", acum_costo_venta, acum_costo_compra);//muestra ganancia real

            for (int i = 0; i < ids_productos.Length; i++)
            {
                op.actualisar_inventario("inf\\inventario\\invent.txt", "" + ids_productos[i], -1);
                op.actualisar_resumen_venta("ventas\\" + año + "\\" + mes + "\\dias\\p_" + dia_mes_año + ".txt", "" + ids_productos[i], 1);
                op.actualisar_resumen_venta("ventas\\" + año + "\\" + mes + "\\p_" + mes + ".txt", "" + ids_productos[i], 1);//muestra total de cada dias
                op.actualisar_resumen_venta("ventas\\" + año + "\\p_" + año + ".txt", "" + ids_productos[i], 1);//muestra total de cada mes
                op.actualisar_resumen_venta("ventas\\p_total_años.txt", "" + ids_productos[i], 1);//muestra total de cada año
                
            }


        }

        
    }
}
