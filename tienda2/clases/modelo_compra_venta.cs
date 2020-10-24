using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda2.clases
{
    class Modelo_compra_venta
    {

        char[] G_parametros = { '|' };

        public void Modelo_compra(string codigo, string costo_compra, string cantidad, string provedor,string nom_producto,string id_producto,string info_extra=null,bool compra_directa=true)
        {
            DateTime fecha_hora = DateTime.Now;
            //string hora_min_seg = fecha_hora.ToString("HH:mm:ss");
            string hora_min = fecha_hora.ToString("HH:mm");
            string dia_mes_año = fecha_hora.ToString("yyyy-MM-dd");
            string dia = fecha_hora.ToString("dd");
            string mes = fecha_hora.ToString("MM");
            string año = fecha_hora.ToString("yyyy");
            Tex_base bas = new Tex_base();
            Operaciones_archivos op = new Operaciones_archivos();
            

            if (compra_directa==true)
            {
                string dir_arch = "inf\\inventario\\invent.Txt";
                bas.Editar_espesifico(dir_arch, 3, codigo, "6", provedor);
                op.Actualisar_inventario(dir_arch, "" + codigo, Convert.ToInt32(cantidad));
                
                dir_arch = "ventas\\" + año + "\\" + mes + "\\dias\\g_" + dia_mes_año + ".Txt";
                //no se para que es el ultimo 0 bas.agregar(dir_arch, hora + "|" + codigo + "|" + cantidad + "|" + nom_producto + "|"+ provedor + "|" + "0");
                bas.Agregar(dir_arch, hora_min + "|" + codigo + "|" + cantidad + "|" + nom_producto + "|"+ provedor + "|" + costo_compra + "|" + (Convert.ToDecimal(costo_compra)*Convert.ToInt32(cantidad)) + "|" + info_extra );//muestra total cada horas

                dir_arch = "ventas\\" + año + "\\" + mes + "\\g_" + mes + ".Txt";
                op.Actualisar_resumen_compras(dir_arch, dia, Convert.ToDecimal(costo_compra));//muestra total de cada dias

                dir_arch = "ventas\\" + año + "\\g_" + año + ".Txt";
                op.Actualisar_resumen_compras(dir_arch, mes, Convert.ToDecimal(costo_compra));//muestra total de cada mes

                dir_arch = "ventas\\g_total_años.Txt";
                op.Actualisar_resumen_compras(dir_arch, año, Convert.ToDecimal(costo_compra));//muestra total de cada año

                dir_arch = "ventas\\total_en_juego.Txt";
                op.Actualisar_resumen_compras(dir_arch, "dinero_hay: ", -1 * Convert.ToDecimal(costo_compra));//muestra total de cada año

                dir_arch = "ventas\\ganancia_real.Txt";
                op.Actualisar_ganancia_real(dir_arch, "dinero_hay: ", -1 * Convert.ToDecimal(costo_compra));//muestra ganancia real
                


//-----------------mensaje de se esta acabando el dinero o ya se acabo y no se sabe de donde agarra -----------------------------------------------------------------------------------------------------------------------
                string[] cantidades_en_juego = bas.Leer("ventas\\total_en_juego.Txt"), cantidades_en_juego_espliteada;
                Decimal dinero_ganado;
                decimal dinero_gastado = 0;
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
                string dir_arch = "inf\\inventario\\invent.Txt";
                bas.Editar_espesifico(dir_arch, 0, id_producto, "6", provedor);

                dir_arch = "pedidos/" + dia_mes_año + "_" + provedor + ".Txt";
                bas.Si_existe_suma_sino_agrega(dir_arch,2,codigo,"0",cantidad, "1|" + costo_compra +"|"+(Convert.ToDecimal(costo_compra)*Convert.ToInt32(cantidad)) + "|" + info_extra);
                
                
                

            }



        }
        public void Modelo_venta(string [] codigo,string [] cantidades_vendidas)
        {
            string codigos_unidos = string.Join("°",codigo);
            DateTime fecha_hora = DateTime.Now;
            string hora_min_seg = fecha_hora.ToString("HH:mm:ss");
            string dia_mes_año = fecha_hora.ToString("yyyy-MM-dd");
            string dia = fecha_hora.ToString("dd");
            string mes = fecha_hora.ToString("MM");
            string año = fecha_hora.ToString("yyyy");
            Tex_base bas = new Tex_base();
            Operaciones_archivos op = new Operaciones_archivos();
            Operaciones_textos op_tex = new Operaciones_textos();


            string[] productos = bas.Leer("inf\\inventario\\invent.Txt", "0|1|2|3|4|5|6|7");
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

            nom_product = op_tex.Trimend_paresido(nom_product, '°');
            ids_unidos = op_tex.Trimend_paresido(ids_unidos, '°');
            string[] codigo_de_barras = ids_unidos.Split('°');

            string direccion= "ventas\\" + año + "\\" + mes + "\\dias\\" + dia_mes_año + ".Txt";
            string info = hora_min_seg + " |" + codigos_unidos + " |" + acum_costo_venta + " |" + nom_product + " |" + acum_costo_compra;
            bas.Agregar(direccion, info);//la hora de compra lo que compro el costo 

            direccion = "ventas\\" + año + "\\" + mes + "\\" + mes + ".Txt";
            op.Actualisar_resumen_venta(direccion, dia, acum_costo_venta, acum_costo_compra);//actualisa total de cada dias
            
            direccion = "ventas\\" + año + "\\" + año + ".Txt";
            op.Actualisar_resumen_venta(direccion, mes, acum_costo_venta, acum_costo_compra);//actualisa total de cada mes
            
            direccion = "ventas\\total_años.Txt";
            op.Actualisar_resumen_venta(direccion, año, acum_costo_venta, acum_costo_compra);//muestra total de cada año
            
            direccion = "ventas\\total_en_juego.Txt";
            op.Actualisar_resumen_venta(direccion, "dinero_hay: ", acum_costo_venta, acum_costo_compra);//muestra total de cada año
            
            direccion = "ventas\\ganancia_real.Txt";
            op.Actualisar_ganancia_real(direccion, "dinero_hay: ", acum_costo_venta, acum_costo_compra);//muestra ganancia real

            for (int i = 0; i < codigo_de_barras.Length; i++)
            {
                if (cantidades_vendidas[i]=="")
                {
                    cantidades_vendidas[i] = "1";
                }
                
                direccion = "inf\\inventario\\invent.Txt";
                op.Actualisar_inventario(direccion, "" + codigo_de_barras[i], Convert.ToDecimal(cantidades_vendidas[i]) * -1);

                direccion = "ventas\\" + año + "\\" + mes + "\\dias\\p_" + dia_mes_año + ".Txt";
                op.Actualisar_resumen_venta(direccion, "" + codigo_de_barras[i], Convert.ToDecimal(cantidades_vendidas[i]));

                direccion = "ventas\\" + año + "\\" + mes + "\\p_" + mes + ".Txt";
                op.Actualisar_resumen_venta(direccion, "" + codigo_de_barras[i], Convert.ToDecimal(cantidades_vendidas[i]));//muestra total de cada dias

                direccion = "ventas\\" + año + "\\p_" + año + ".Txt";
                op.Actualisar_resumen_venta(direccion, "" + codigo_de_barras[i], Convert.ToDecimal(cantidades_vendidas[i]));//muestra total de cada mes

                direccion = "ventas\\p_total_años.Txt";
                op.Actualisar_resumen_venta(direccion, "" + codigo_de_barras[i], Convert.ToDecimal(cantidades_vendidas[i]));//muestra total de cada año
                
            }
        }
    }
}
