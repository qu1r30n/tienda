using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda2.clases
{
    class simul2
    {


        arreglos_compuestos_y_simples arr_com_sim = new arreglos_compuestos_y_simples();
        Tex_base bas = new Tex_base();
        string G_sucursal = "";
        string G_compu = "";

        public void registro_simple(string id_patrocinador, string tabla, string datos, char caracter_separacion = '|', char caracter_separacion2 = '°')
        {
            datos = bas.Trimend_paresido(datos, '°');

            string direccion_tab_enc = "sismul2\\" + G_sucursal + G_compu + tabla + ".txt";
            //0_id_usuario|1_id_patrocinador|2_tabla_patrocinador|3_id_encargado|5_tabla_encargado|5_diner|6_a_pagar|7_datos|8_encargados|
            bas.Crear_archivo_y_directorio(direccion_tab_enc, "0|||0|0|0|0|nom°ap°etc|0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°|");
            string[] info_base = bas.Leer(direccion_tab_enc);
            string patrocinadores = "";
            for (int i = 0; i < info_base.Length; i++)
            {
                string[] info_base_split = info_base[i].Split(caracter_separacion);
                //en registro simple en la base el id_encargado el el id_patrocinador
                if (info_base_split[0] == id_patrocinador)
                {
                    patrocinadores = info_base_split[8];

                }
            }

            //0_id_usuario|1_id_patrocinador|2_tabla_patrocinador|3_id_encargado|5_tabla_encargado|5_diner|6_a_pagar|7_datos|8_encargados|
            string info_a_agregar = info_base.Length + "" + caracter_separacion + caracter_separacion + caracter_separacion + ("" +id_patrocinador) + caracter_separacion + tabla + caracter_separacion + "0" + caracter_separacion + "0" + caracter_separacion + datos + caracter_separacion + patrocinadores + caracter_separacion;
            bas.Agregar(direccion_tab_enc, info_a_agregar);

        }

        public string registro_complejo(string id_patrocinador, string tabla_patrocinador, string id_encargado, string tabla_usuario, string datos, char caracter_separacion = '|', char caracter_separacion2 = '°')
        {
            datos=bas.Trimend_paresido(datos,'°');
            //0_id_usuario|1_id_patrocinador|2_tabla_patrocinador|3_id_encargado|4_tabla_encargado|5_diner|6_a_pagar|7_datos|8_encargados|
            string direccion_tab_pat = "sismul2\\" + G_sucursal + G_compu + tabla_patrocinador + ".txt";
            bas.Crear_archivo_y_directorio(direccion_tab_pat, "0|0|ventas|0|tabla_encargado|0|0|nom°ap°etc|0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0|");

            //0_id_usuario|1_id_patrocinador|2_tabla_patrocinador|3_id_encargado|4_tabla_encargado|5_diner|6_a_pagar|7_datos|8_encargados|
            string direccion_tab_enc = "sismul2\\" + G_sucursal + G_compu + tabla_usuario + ".txt";
            bas.Crear_archivo_y_directorio(direccion_tab_enc, "0|0|ventas|0|tabla_encargado|0|0|nom°ap°etc|0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0°0|");
            string[] info_base = bas.Leer(direccion_tab_enc);


            string patrocinadores = "";
            for (int i = 0; i < info_base.Length; i++)
            {
                string[] info_base_split = info_base[i].Split(caracter_separacion);
                //en registro simple en la base el id_encargado el el id_patrocinador
                if (info_base_split[3] == id_patrocinador)
                {
                    patrocinadores = info_base_split[8];
                    
                }
            }

            string info_a_agregar = info_base.Length+ "" + caracter_separacion + id_patrocinador + caracter_separacion + tabla_patrocinador + caracter_separacion + id_encargado + caracter_separacion + tabla_usuario + caracter_separacion + "0" + caracter_separacion + "0" + caracter_separacion + datos + caracter_separacion + patrocinadores + caracter_separacion;
            bas.Agregar(direccion_tab_enc, info_a_agregar);

            return info_base.Length+"";
        }

        public void entrada_dinero_simple_metodo_sin_lista_de_patrocinadores(string tabla_usuario, string id_usuario, string cantidad_dinero_string, string porsentajes_de_comision = "10|10|10", char caracter_separacion = '|')
        {

            string direccion_tab_enc = "sismul2\\" + G_sucursal + G_compu + tabla_usuario + ".txt";
            double cantidad_dinero = Convert.ToDouble(cantidad_dinero_string);

            string[] comiciones = porsentajes_de_comision.Split(caracter_separacion);
            //0_id_usuario|1_id_patrocinador|2_tabla_patrocinador|3_id_encargado|5_tabla_encargado|5_diner|6_a_pagar|7_datos|8_encargados|
            string usu = bas.Seleccionar(direccion_tab_enc, 0, id_usuario);
            string[] usu_esp = usu.Split(caracter_separacion);
            string id_a_pagar = usu_esp[3];
            for (int i = 0; i < comiciones.Length; i++)
            {
                bas.Incrementa_celda(direccion_tab_enc, 0, id_a_pagar, "6", "" + (cantidad_dinero * (Convert.ToDouble(comiciones[i]) / 100)));
                usu = bas.Seleccionar(direccion_tab_enc, 0, id_a_pagar);
                usu_esp = usu.Split(caracter_separacion);
                id_a_pagar = usu_esp[3];
            }

        }

        public void entrada_dinero_compuesto_metodo_sin_lista_de_patrocinadores(string tabla_usuario, string id_usuario, string cantidad_dinero_string, string porcentaje_pat_directo = "10", string porsentajes_de_comision_pat = "10|10|10", string porcentajes_de_comision_encargados = "10|10|10", char caracter_separacion = '|')
        {

            string direccion_tab_enc = "sismul2\\" + G_sucursal + G_compu + tabla_usuario + ".txt";
            //0_id_usuario|1_id_patrocinador|2_tabla_patrocinador|3_id_encargado|4_tabla_encargado|5_diner|6_a_pagar|7_datos|8_encargados|
            string datos_usuario_string = bas.Seleccionar(direccion_tab_enc, 0, id_usuario);
            string[] datos_usuario_spliteados = datos_usuario_string.Split('|');


            double cantidad_dinero = Convert.ToDouble(cantidad_dinero_string);

            string[] comiciones = porcentajes_de_comision_encargados.Split(caracter_separacion);
            //0_id_usuario|1_id_patrocinador|2_tabla_patrocinador|3_id_encargado|5_tabla_encargado|5_diner|6_a_pagar|7_datos|8_encargados|
            string id_a_pagar = datos_usuario_spliteados[3]
                ;
            for (int i = 0; i < comiciones.Length; i++)
            {
                bas.Incrementa_celda(direccion_tab_enc, 0, id_a_pagar, "6", "" + (cantidad_dinero * (Convert.ToDouble(comiciones[i]) / 100)));
                string usu = bas.Seleccionar(direccion_tab_enc, 0, id_a_pagar);
                string[] usu_esp = usu.Split(caracter_separacion);
                id_a_pagar = usu_esp[3];
            }

            string direccion_tab_pat = "sismul2\\" + G_sucursal + G_compu + datos_usuario_spliteados[2] + ".txt";
            bas.Incrementa_celda(direccion_tab_pat, 0, datos_usuario_spliteados[1], "6", "" + (cantidad_dinero * (Convert.ToDouble(porcentaje_pat_directo) / 100)));
            entrada_dinero_simple_metodo_sin_lista_de_patrocinadores(datos_usuario_spliteados[2], datos_usuario_spliteados[1], "" + (cantidad_dinero * (Convert.ToDouble(porcentaje_pat_directo) / 100)), porsentajes_de_comision_pat);

            

        }

        public void retiro_de_dinero(string tabla_usuario, string id_usuario, string cantidad_dinero_string)
        {
            string direccion_tab_enc = "sismul2\\" + G_sucursal + G_compu + tabla_usuario + ".txt";
            double cantidad_dinero = Convert.ToDouble(cantidad_dinero_string);
            bas.Incrementa_celda(direccion_tab_enc, 0, id_usuario, "6", "" + (cantidad_dinero * -1));


        }

    }
}
