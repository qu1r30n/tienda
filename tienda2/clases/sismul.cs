using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda2.clases
{
    class sismul
    {

        string G_sucursal = "";
        string G_compu = "";



        public void registro_compuesto(string num_pat, string tab_pat, string tab_encargado, string encargado_1, string[] datos_de_la_persona, double dinero_registro = 0, int num_niv_encargados = 3, char caracter_separacion = '|')
        {

            //0_id|1_din|2_se_pag|3_numero_de_niveles|4_donde_termino_dat_us|5_nombre|6_ap|7_am|
            //8_num_cu|9_ban|10_curp|11_numero tel|12_direccion|13_barrio|14_municipio|
            //15_estado|16_correo|17_tabla_us|18_tabla_pat|19_patr|20_nivel|
            //21_encargado_1|22_encargado_2|23_encargado_3|


            int num_dat_p = datos_de_la_persona.Length + 5;
            Tex_base bas = new Tex_base();
            string direccion_tab_enc = "sismul\\" + G_sucursal + G_compu + tab_encargado + "_inf.txt";
            //bas.Crear_archivo_y_directorio("sismul\\" + tab_usuario + "_inf.txt");
            string datos_joineados_de_persona = string.Join(caracter_separacion + "", datos_de_la_persona);
            string[] leidos = bas.Leer(direccion_tab_enc, null, caracter_separacion);
            string dat_n1 = bas.Seleccionar(direccion_tab_enc, 0, encargado_1, null, caracter_separacion);
            string[] dat_n1_spliteado = dat_n1.Split(caracter_separacion);

            int numero_empiesa_niveles = Convert.ToInt32(dat_n1_spliteado[4]) + 4;
            int cant_niv_tiene_n1 = Convert.ToInt32(dat_n1_spliteado[3]);



            string espacios_niveles = "";
            for (int i = 0; i < num_niv_encargados - 1; i++)
            {
                if (cant_niv_tiene_n1 > i)
                {
                    espacios_niveles = espacios_niveles + dat_n1_spliteado[numero_empiesa_niveles + i] + "" + caracter_separacion;
                }
                else
                {
                    espacios_niveles = espacios_niveles + "0" + caracter_separacion;
                }
            }
            string nivel_us = "" + (Convert.ToInt32(dat_n1_spliteado[num_dat_p + 3]) + 1);
            string datos_a_agregar = (leidos.Length + "") + caracter_separacion + dinero_registro
                + caracter_separacion + "0" + caracter_separacion + num_niv_encargados + caracter_separacion + ("" + num_dat_p) + caracter_separacion + datos_joineados_de_persona + caracter_separacion +
                tab_encargado + caracter_separacion + tab_pat + caracter_separacion + num_pat + caracter_separacion + nivel_us +
                caracter_separacion + encargado_1 + caracter_separacion + espacios_niveles;


            bas.Agregar("sismul\\" + tab_encargado + "_inf.txt", datos_a_agregar);
        }

        public void registro_simple(string tab_encargado, string encargado_1, string[] datos_de_la_persona, double dinero_registro = 0, int num_niv_encargados = 3, char caracter_separacion = '|')
        {

            //0_id|1_din|2_se_pag|3_numero_de_niveles|4_donde_termino_dat_us|5_nombre|6_ap|7_am|
            //8_num_cu|9_ban|10_curp|11_numero tel|12_direccion|13_barrio|14_municipio|
            //15_estado|16_correo|17_tabla_us|18_tabla_pat|19_patr|20_nivel|
            //21_encargado_1|22_encargado_2|23_encargado_3|


            int num_dat_p = datos_de_la_persona.Length + 5;
            Tex_base bas = new Tex_base();
            string direccion_tab_enc = "sismul\\" + G_sucursal + G_compu + tab_encargado + "_inf.txt";
            //bas.Crear_archivo_y_directorio("sismul\\" + tab_usuario + "_inf.txt");
            string datos_joineados_de_persona = string.Join(caracter_separacion + "", datos_de_la_persona);
            string[] leidos = bas.Leer(direccion_tab_enc, null, caracter_separacion);
            string dat_n1 = bas.Seleccionar(direccion_tab_enc, 0, encargado_1, null, caracter_separacion);
            string[] dat_n1_spliteado = dat_n1.Split(caracter_separacion);

            int numero_empiesa_niveles = Convert.ToInt32(dat_n1_spliteado[4]) + 4;
            int cant_niv_tiene_n1 = Convert.ToInt32(dat_n1_spliteado[3]);



            string espacios_niveles = "";
            for (int i = 0; i < num_niv_encargados - 1; i++)
            {
                if (cant_niv_tiene_n1 >= i)
                {
                    espacios_niveles = espacios_niveles + dat_n1_spliteado[numero_empiesa_niveles + i] + "" + caracter_separacion;
                }
                else
                {
                    espacios_niveles = espacios_niveles + "0" + caracter_separacion;
                }
            }
            string nivel_us = "" + (Convert.ToInt32(dat_n1_spliteado[num_dat_p + 3]) + 1);
            string datos_a_agregar = (leidos.Length + "") + caracter_separacion + dinero_registro
                + caracter_separacion + "0" + caracter_separacion + num_niv_encargados + caracter_separacion + ("" + num_dat_p) + caracter_separacion + datos_joineados_de_persona + caracter_separacion +
                tab_encargado + caracter_separacion + "" + caracter_separacion + "" + caracter_separacion + nivel_us +
                caracter_separacion + encargado_1 + caracter_separacion + espacios_niveles;


            bas.Agregar("sismul\\" + tab_encargado + "_inf.txt", datos_a_agregar);
        }

        public void ingreso_de_din_simple(string tab_usuario, string id_usuario, Double din, int cant_niv_a_pagar = 3, Double porcentage_reparticion = 10, char caracter_de_separacion = '|')
        {
            Tex_base bas = new Tex_base();
            // int num_enc = 3;//la cantidad ser igual o menor la cantidad de encargados osea lo de los niveles que estan arriba
            string direccion_tab_us = "sismul\\" + G_sucursal + G_compu + tab_usuario + "_inf.txt";
            string dat_usuarios = bas.Seleccionar(direccion_tab_us, 0, id_usuario, null, caracter_de_separacion);

            string[] dat_usu_split = dat_usuarios.Split(caracter_de_separacion);
            bas.Incrementa_celda(direccion_tab_us, 0, id_usuario, "1", din + "", caracter_de_separacion);

            int empiesan_niveles = Convert.ToInt32(dat_usu_split[4]) + 4;
            double pagar = din * (porcentage_reparticion / 100);

            if ((empiesan_niveles - dat_usu_split.Length) <= cant_niv_a_pagar)
            {
                for (int i = 0; i < cant_niv_a_pagar; i++)
                {
                    bas.Incrementa_celda(direccion_tab_us, 0, dat_usu_split[empiesan_niveles + i], "2", pagar + "", caracter_de_separacion);
                }

            }




        }

        public void ingreso_de_din_comp(string tab_usuario, string id_usuario, Double din, int cant_niv_a_pagar = 3, Double porcentage_reparticion = 10, char caracter_de_separacion = '|')
        {
            Tex_base bas = new Tex_base();
            ingreso_de_din_simple(tab_usuario, id_usuario, din, cant_niv_a_pagar, porcentage_reparticion, caracter_de_separacion);


            string direccion_tab_us = "sismul\\" + G_sucursal + G_compu + tab_usuario + "_inf.txt";
            string dat_usuario = bas.Seleccionar(direccion_tab_us, 0, id_usuario);
            string[] dat_us_split = dat_usuario.Split(caracter_de_separacion);
            int posision_tab_pat = Convert.ToInt32(dat_us_split[4]) + 1;
            double din_para_pat = din * (porcentage_reparticion / 100);

            ingreso_de_din_simple(dat_us_split[posision_tab_pat], dat_us_split[posision_tab_pat + 1], din_para_pat, cant_niv_a_pagar, porcentage_reparticion, caracter_de_separacion);



        }
        public void sis_nor()
        {

        }
        public void sis_nor_2()
        {

        }
        public void sis_desde_abajo()//normalmente no usar por que es muy tardado
        {

        }

    }
}
