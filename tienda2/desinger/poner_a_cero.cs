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
    public partial class poner_a_cero : Form
    {
        Tex_base bas = new Tex_base();
        public poner_a_cero()
        {
            InitializeComponent();
        }

        private void btn_reiniciar_a_cero_Click(object sender, EventArgs e)
        {
            DialogResult resultado_de_la_pregunta = MessageBox.Show("estas seguro?", "estas seguro?", MessageBoxButtons.YesNo);
            if (resultado_de_la_pregunta == DialogResult.Yes)
            {
                if (rdb_inventario.Checked)
                {
                    bas.Editar_una_columna("inf\\inventario\\invent.txt", 4, "0");
                }
                else if (rdb_ranking.Checked)
                {
                    DateTime fecha = DateTime.Now;
                    string dir_ranking = "inf\\ranking\\" + fecha.ToString("yyyy") + "_ranking.txt";
                    bas.Editar_una_columna(dir_ranking, 2, "0");
                    bas.Editar_una_columna(dir_ranking, 4, "°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                    bas.Editar_una_columna(dir_ranking, 5, "0");
                    bas.Editar_una_columna(dir_ranking, 6, "0");
                    bas.Editar_una_columna(dir_ranking, 7, "0");
                    bas.Editar_una_columna(dir_ranking, 8, "0");
                    bas.Editar_una_columna(dir_ranking, 9, "0");
                    bas.Editar_una_columna(dir_ranking, 10, "0");
                    bas.Editar_una_columna(dir_ranking, 11, "0");

                }
                else if (rdb_ventas.Checked)
                {
                    Operaciones_archivos op_arch = new Operaciones_archivos();


                    string dir_papelera_directorios = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\info_tienda\\papelera_resiclaje\\";
                    bas.Crear_archivo_y_directorio(dir_papelera_directorios);

                    string direccion_dir = "ventas";
                    string dir_a_mover = "ventas2";

                    op_arch.mover_dir(direccion_dir, dir_a_mover);
                    
                    
                    //-----------------------------------------------------------------
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


                    #endregion
                    //-----------------------------------------------------------------


                }
                else if (rdb_todo_junto.Checked)
                {
                    MessageBox.Show("todavia no sirve esta opcion");
                }
                MessageBox.Show("listo");
            }
        }
    }
}