using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using tienda2.desinger;
using tienda2.clases;

namespace tienda2
{
    public partial class Form1 : Form
    {
        string g_global = "";
        static public string direccion_programa = Application.ExecutablePath.ToString();

        public Form1()
        {

            InitializeComponent();
            Tex_base bas = new Tex_base(); //clase creada para haser una base de datos con Txt
            pedidos pedi = new pedidos();
            pedi.Show();
            //bas.si_son_menores_a_0_o_mayores_a_1000_los_vuelve_a_cero("inf\\inventario\\invent.txt",4);
            //bas.comp_2_archivos_info_no_esta_vuelve_a_cero("info_tienda\\inf\\inventario\\invent.txt", 3, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\tienda_inventarios\\20220626_compras_durante_invet_e_inventario.txt",1);


            Operaciones_archivos op = new Operaciones_archivos();
            //en esta seccion crearemos los archivos que nesesitaremos para la base
            #region crea los archivos 
            //crea los archivos de compras por si se hace una busqueda y no estan
            DateTime fecha_hora = DateTime.Now; //se usara la variable fecha y hora para sacar el dia de hoy y la hora
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");



            string direccion1, direccion2, direccion3, direccion4, direccion5; //variables de direcciones

            direccion1 = "inf\\inventario\\invent.txt";
            direccion2 = "inf\\inventario\\provedores.txt";

            bas.Crear_archivo_y_directorio(direccion1, "id|producto|precio_de_venta|0|cantidad|costo_compra|marca|grupo|multiusos|cantidad_productos_por_paquete");
            bas.Crear_archivo_y_directorio(direccion2, "provedor|id|");


            direccion2 = "inf\\inventario\\provedores.txt";
            bas.Crear_archivo_y_directorio(direccion2);


            direccion1 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\dias\\" + fecha_hora.ToString("yyyyMMdd") + ".txt"; // direccion1= ventas/2016/11/dias/28-11-2016.Txt
            direccion2 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\" + fecha_hora.ToString("MM") + ".txt"; // direccion2= ventas/2016/11/11.Txt
            direccion3 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("yyyy") + ".txt"; // direccion3 = ventas/2016/2016.Txt
            direccion4 = "ventas\\total_años.txt"; // no hace falta explicacion
            direccion5 = "ventas\\total_en_juego.txt"; // no hace falta explicacion
            bas.Crear_archivo_y_directorio(direccion1);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.Crear_archivo_y_directorio(direccion2);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.Crear_archivo_y_directorio(direccion3);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.Crear_archivo_y_directorio(direccion4);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.Crear_archivo_y_directorio(direccion5);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo

            direccion1 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\dias\\g_" + fecha_hora.ToString("yyyyMMdd") + ".txt"; //aqui lo que cambia es la g_ antes del archivo direccion1= ventas/2016/11/dias/g_28-11-2016.Txt
            direccion2 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\g_" + fecha_hora.ToString("MM") + ".txt";//aqui lo que cambia es la g_ antes del archivo direccion1= ventas/2016/11/g_11.Txt
            direccion3 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\g_" + fecha_hora.ToString("yyyy") + ".txt";//aqui lo que cambia es la g_ antes del archivo direccion1= ventas/2016/g_2016.Txt
            direccion4 = "ventas\\g_total_años.txt";//no hace falta explicacion o si?
            bas.Crear_archivo_y_directorio(direccion1);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.Crear_archivo_y_directorio(direccion2);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.Crear_archivo_y_directorio(direccion3);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.Crear_archivo_y_directorio(direccion4);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo

            direccion1 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\dias\\p_" + fecha_hora.ToString("yyyyMMdd") + ".txt";//aqui lo que cambia es la p_ antes del archivo direccion1= ventas/2016/11/dias/p_28-11-2016.Txt
            direccion2 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\p_" + fecha_hora.ToString("MM") + ".txt";//aqui lo que cambia es la p_ antes del archivo direccion1= ventas/2016/11/p_11.Txt
            direccion3 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\p_" + fecha_hora.ToString("yyyy") + ".txt";//aqui lo que cambia es la p_ antes del archivo direccion1= ventas/2016/p_2016.Txt
            direccion4 = "ventas\\p_total_años.txt";
            bas.Crear_archivo_y_directorio(direccion1);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.Crear_archivo_y_directorio(direccion2);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.Crear_archivo_y_directorio(direccion3);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.Crear_archivo_y_directorio(direccion4);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo

            direccion1 = "inf\\inventario\\img\\";
            bas.Crear_archivo_y_directorio(direccion1);//crear la carpeta que contendra las imagenes de codigos de barras

            direccion1 = "inf\\us\\ad.txt";
            bas.Crear_archivo_y_directorio(direccion1);

            direccion1 = "inf\\us\\encargado.txt";
            bas.Crear_archivo_y_directorio(direccion1);

            direccion1 = "inf\\us\\usuario.txt";
            bas.Crear_archivo_y_directorio(direccion1);

            direccion1 = "inf\\us\\invitado.txt";
            bas.Crear_archivo_y_directorio(direccion1);

            direccion1 = "inf\\us\\simul.txt";
            bas.Crear_archivo_y_directorio(direccion1);

            //
            #endregion
            //ordenar informacion de mayor a menor
            #region ordenar datos
            //meses dentro de años
            op.Ordenar("ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("yyyy") + ".txt", 0, "numero");
            op.Ordenar("ventas\\" + fecha_hora.ToString("yyyy") + "\\g_" + fecha_hora.ToString("yyyy") + ".txt", 0, "numero");
            op.Ordenar("ventas\\" + fecha_hora.ToString("yyyy") + "\\p_" + fecha_hora.ToString("yyyy") + ".txt", 1, "numero");

            //dias dentro de meses
            op.Ordenar("ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\" + fecha_hora.ToString("MM") + ".txt", 0, "numero");
            op.Ordenar("ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\g_" + fecha_hora.ToString("MM") + ".txt", 0, "numero");
            op.Ordenar("ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\p_" + fecha_hora.ToString("MM") + ".txt", 1, "numero");
            #endregion

            //crear archivo_banderas_contadores y agregar dia


            direccion3 = "inf\\banderas_cont\\band_cont.txt";
            bas.Crear_archivo_y_directorio(direccion3, "con_dia_sem|1");
            string dir_ranking_dia = "inf\\ranking\\dia\\" + fecha_hora.ToString("yyyyMMdd") + "_ranking.txt";

            if (bas.existe_archivo(dir_ranking_dia))
            {
                bas.Crear_archivo_y_directorio(dir_ranking_dia);
                bas.si_existe_suma_sino_agega_extra(direccion3, 0, "con_dia_sem", "1", "1", "con_dia_sem|1");
            }

            string dir_ranking_año = "inf\\ranking\\" + fecha_hora.ToString("yyyy") + "_ranking.txt";
            bas.Crear_archivo_y_directorio(dir_ranking_año);
            string info_con_dia = bas.Seleccionar(direccion3, 0, "con_dia_sem", "1");
            int num_dia = Convert.ToInt32(info_con_dia);
            if (num_dia >= 7)
            {

                bas.Editar_espesifico(direccion3, 0, "con_dia_sem", "1", "1");
                bas.Editar_una_columna(dir_ranking_año, 2, "0");
                string[] info_ranking = bas.Leer(dir_ranking_año);

                for (int i = 0; i < info_ranking.Length; i++)
                {
                    string[] info_producto = info_ranking[i].Split('|');
                    string[] historial_ranking = info_producto[4].Split('°');
                    for (int j = historial_ranking.Length - 2; j >= 0; j--)
                    {
                        historial_ranking[j + 1] = historial_ranking[j];
                    }
                    historial_ranking[0] = "0";
                    info_producto[4] = string.Join("°", historial_ranking);
                    bas.Editar_fila(dir_ranking_año, 0, info_producto[0], string.Join("|", info_producto));

                }
                bas.Editar_espesifico(direccion3, 0, "con_dia_sem", "1", "0");

            }


            //---------------------------------
        }

        private void Btn_admin_Click(object sender, EventArgs e)
        {
            Tex_base adm = new Tex_base();//llamamos a la clase tex_base
            Area_principal area = new Area_principal();//este es el form Area_principal y es al que entrara si pone el usuario y contraseña bien
            string temp = adm.Seleccionar("inf\\us\\ad.txt", 0, Txt_usuario.Text, "1");//guarda el id del usuario pas y datos en texto
            if (temp == "")
            {
                temp = null;
            }
            if (temp == Txt_pass.Text)
            {
                g_global = adm.Seleccionar_invertida_extraccion_columnas("inf\\us\\ad.txt", 0, Txt_usuario.Text, "1");
                Txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                Txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                area.Show();//muestra el form Area_principal

            }
            else
            {
                Txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                Txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                Txt_usuario.Focus();
                MessageBox.Show("incorrecto");//habre una ventanita diciendo incorrecto
            }


        }

        private void Btn_usuario_Click(object sender, EventArgs e)
        {


            Tex_base user = new Tex_base();//llamamos a la clase tex_base
            Ventas vent = new Ventas();//este es el form ventas y es al que entrara si pone el usuario y contraseña bien
            string temp = user.Seleccionar("inf\\us\\usuario.txt", 0, Txt_usuario.Text, "1");
            if (temp == "")
            {
                temp = null;
            }
            if (temp == Txt_pass.Text)
            {
                g_global = user.Seleccionar_invertida_extraccion_columnas("inf\\us\\usuario.txt", 0, Txt_usuario.Text, "1");
                Txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                Txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                vent.Show();//muestra el form ventas
            }
            else
            {
                Txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                Txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                Txt_usuario.Focus();
                MessageBox.Show("incorrecto");//muestra el form ventas
            }

        }

        private void Btn_invitado_Click(object sender, EventArgs e)
        {
            Tex_base invitado = new Tex_base();//llamamos a la clase tex_base
            Ventas vent = new Ventas();//este es el form ventas y es al que entrara si pone el usuario y contraseña bien
            string temp = invitado.Seleccionar("inf\\us\\invitado.txt", 0, Txt_usuario.Text, "1");
            if (temp == "")
            {
                temp = null;
            }
            if (temp == Txt_pass.Text)
            {
                g_global = invitado.Seleccionar_invertida_extraccion_columnas("inf\\us\\invitado.txt", 0, Txt_usuario.Text, "1");
                Txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                Txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                vent.Show();//muestra el form ventas
            }
            else
            {
                Txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                Txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                Txt_usuario.Focus();
                MessageBox.Show("incorrecto");//muestra el form ventas
            }
        }

        private void btn_proy_Click(object sender, EventArgs e)
        {
            Tex_base bas_simul = new Tex_base();//llamamos a la clase tex_base
            simul simul_ventana = new simul();//este es el form ventas y es al que entrara si pone el usuario y contraseña bien
            string temp = bas_simul.Seleccionar("inf\\us\\simul.txt", 0, Txt_usuario.Text, "1");
            if (temp == "")
            {
                temp = null;
            }
            if (temp == Txt_pass.Text)
            {
                g_global = bas_simul.Seleccionar_invertida_extraccion_columnas("inf\\us\\invitado.txt", 0, Txt_usuario.Text, "1");
                Txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                Txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                simul_ventana.Show();//muestra el form ventas
            }
            else
            {
                Txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                Txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                Txt_usuario.Focus();
                MessageBox.Show("incorrecto");//muestra el form ventas
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //si se cierra formulario hacer esta accion
        }
    }
}
