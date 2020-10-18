using System;
using System.Collections.Generic;
using System.Collections;
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
        static public string direccion_programa = Application.ExecutablePath.ToString();
        char[] G_parametros = { '|' };
        public Form1()
        {

            InitializeComponent();
            
            //ventana_emergente vent_emergent = new ventana_emergente();
            //string[] enviar = { "3°id°9", "3°marca°1", "3°ned°5" };
            //string[] info = { "solo_botones" };
            //string mensage = vent_emergent.proceso_ventana_emergente(enviar, 0,info);//el uno significa que modificara el inventario
            
            

            //en esta seccion crearemos los archivos que nesesitaremos para la base
            #region crea los archivos 
            //crea los archivos de compras por si se hace una busqueda y no estan
            DateTime fecha_hora = DateTime.Now; //se usara la variable fecha y hora para sacar el dia de hoy y la hora
            tex_base bas = new tex_base(); //clase creada para haser una base de datos con txt

            
            string direccion1, direccion2, direccion3, direccion4, direccion5; //variables de direcciones

            direccion1 = "inf\\inventario\\invent.txt";
            direccion2 = "inf\\inventario\\provedores.txt";
            bas.crear_archivo_y_directorio(direccion1, "id|producto|precio_de_venta|0|cantidad|costo_compra|marca|grupo|multiusos|cantidad_productos_por_paquete");
            bas.crear_archivo_y_directorio(direccion2, "provedor|id|");


            direccion1 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\dias\\" + fecha_hora.ToString("yyyy-MM-dd") + ".txt"; // direccion1= ventas/2016/11/dias/28-11-2016.txt
            direccion2 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\" + fecha_hora.ToString("MM") + ".txt"; // direccion2= ventas/2016/11/11.txt
            direccion3 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("yyyy") + ".txt"; // direccion3 = ventas/2016/2016.txt
            direccion4 = "ventas\\total_años.txt"; // no hace falta explicacion
            direccion5 = "ventas\\total_en_juego.txt"; // no hace falta explicacion
            bas.crear_archivo_y_directorio(direccion1);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.crear_archivo_y_directorio(direccion2);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.crear_archivo_y_directorio(direccion3);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.crear_archivo_y_directorio(direccion4);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.crear_archivo_y_directorio(direccion5);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo

            direccion1 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\dias\\g_" + fecha_hora.ToString("yyyy-MM-dd") + ".txt"; //aqui lo que cambia es la g_ antes del archivo direccion1= ventas/2016/11/dias/g_28-11-2016.txt
            direccion2 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\g_" + fecha_hora.ToString("MM") + ".txt";//aqui lo que cambia es la g_ antes del archivo direccion1= ventas/2016/11/g_11.txt
            direccion3 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\g_" + fecha_hora.ToString("yyyy") + ".txt";//aqui lo que cambia es la g_ antes del archivo direccion1= ventas/2016/g_2016.txt
            direccion4 = "ventas\\g_total_años.txt";//no hace falta explicacion o si?
            bas.crear_archivo_y_directorio(direccion1);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.crear_archivo_y_directorio(direccion2);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.crear_archivo_y_directorio(direccion3);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.crear_archivo_y_directorio(direccion4);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo

            direccion1 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\dias\\p_" + fecha_hora.ToString("yyyy-MM-dd") + ".txt";//aqui lo que cambia es la p_ antes del archivo direccion1= ventas/2016/11/dias/p_28-11-2016.txt
            direccion2 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\p_" + fecha_hora.ToString("MM") + ".txt";//aqui lo que cambia es la p_ antes del archivo direccion1= ventas/2016/11/p_11.txt
            direccion3 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\p_" + fecha_hora.ToString("yyyy") + ".txt";//aqui lo que cambia es la p_ antes del archivo direccion1= ventas/2016/p_2016.txt
            direccion4 = "ventas\\p_total_años.txt";
            bas.crear_archivo_y_directorio(direccion1);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.crear_archivo_y_directorio(direccion2);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.crear_archivo_y_directorio(direccion3);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo
            bas.crear_archivo_y_directorio(direccion4);//aqui si no existe los directorios  los crea y si existen entra  lo mismo con el archivo

            

            //
            #endregion



        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            tex_base adm = new tex_base();//llamamos a la clase tex_base
            area_principal area = new area_principal();//este es el form area_principal y es al que entrara si pone el usuario y contraseña bien
            string temp = adm.seleccionar("inf\\us\\ad.txt",0,txt_usuario.Text,"1");//guarda el id del usuario pas y datos en texto
            if (temp=="")
            {
                temp=null;
            }
            if (temp == txt_pass.Text)
            {
                txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                area.Show();//muestra el form area_principal
            }
            else
            {
                txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                txt_usuario.Focus();
                MessageBox.Show("incorrecto");//habre una ventanita diciendo incorrecto
            }


        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            tex_base user = new tex_base();//llamamos a la clase tex_base
            ventas vent = new ventas();//este es el form ventas y es al que entrara si pone el usuario y contraseña bien
            string temp = user.seleccionar("inf\\us\\user.txt", 0, txt_usuario.Text, "1");
            if (temp == "")
            {
                temp = null;
            }
            if (temp == txt_pass.Text)
            {
                txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                vent.Show();//muestra el form ventas
            }
            else
            {
                txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                txt_usuario.Focus();
                MessageBox.Show("incorrecto");//muestra el form ventas
            }

        }

        private void btn_invitado_Click(object sender, EventArgs e)
        {
            tex_base invitado = new tex_base();//llamamos a la clase tex_base
            ventas vent = new ventas();//este es el form ventas y es al que entrara si pone el usuario y contraseña bien
            string temp = invitado.seleccionar("inf\\us\\invitado.txt", 0, txt_usuario.Text, "1");
            if (temp == "")
            {
                temp = null;
            }
            if (temp == txt_pass.Text)
            {
                txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                vent.Show();//muestra el form ventas
            }
            else
            {
                txt_usuario.Text = "";//bora lo que tiene el textbox usuario
                txt_pass.Text = "";//bora lo que tiene el textbox contraseña
                txt_usuario.Focus();
                MessageBox.Show("incorrecto");//muestra el form ventas
            }
        }
    }
}
