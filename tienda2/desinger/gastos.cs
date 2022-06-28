using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienda2.desinger
{
    public partial class gastos : Form
    {
        char[] G_parametros = { '|', '°', '¬', '^' };


        public gastos()
        {
            InitializeComponent();
        }

        private void Btn_guardar_compra_Click(object sender, EventArgs e)
        {
            Tex_base bas = new Tex_base();
            Operaciones_archivos op = new Operaciones_archivos();
            DateTime fecha_hora = DateTime.Now;
            Decimal cantidad = Convert.ToDecimal(Txt_cantidad_gastada.Text);
            string poductos_ya_unidos = Txt_razon.Text + G_parametros[0] + Txt_quien_facturo.Text;
            string direccion1 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\dias\\g_" + fecha_hora.ToString("yyyyMMdd") + ".txt",
                   direccion2 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\g_" + fecha_hora.ToString("MM") + ".txt",
                   direccion3 = "ventas\\" + fecha_hora.ToString("yyyy") + "\\g_" + fecha_hora.ToString("yyyy") + ".txt",
                   direccion4 = "ventas\\g_total_años.txt",
                   direccion5 = "ventas\\total_en_juego.txt";

            DialogResult boton = MessageBox.Show("seguro que quieres realisar la compra de:   " + Txt_cantidad_gastada.Text + "   ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                string[] cantidades_en_juego = bas.Leer(direccion5), cantidades_en_juego_espliteada;
                Decimal dinero_ganado, dinero_gastado = 0;

                cantidades_en_juego_espliteada = cantidades_en_juego[0].Split(G_parametros[0]);
                dinero_ganado = Convert.ToInt32(cantidades_en_juego_espliteada[1]);

                if (dinero_ganado >= dinero_gastado + cantidad)
                {
                    bas.Agregar(direccion1, fecha_hora.ToString("dd-MM-yyyy HH:mm:ss") + G_parametros[0] + poductos_ya_unidos + G_parametros[0] + cantidad);//muestra total cada horas
                    op.Actualisar_resumen_venta(direccion2, fecha_hora.ToString("dd"), cantidad);//muestra total de cada dias
                    op.Actualisar_resumen_venta(direccion3, fecha_hora.ToString("MM"), cantidad);//muestra total de cada mes
                    op.Actualisar_resumen_venta(direccion4, fecha_hora.ToString("yyyy"), cantidad);//muestra total de cada año
                    op.Actualisar_resumen_venta(direccion5, "dinero_gastado: ", cantidad);//muestra total de cada año
                }
                else
                {
                    MessageBox.Show("no se tiene tanto dinero en juego");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("cancelado");
                this.Close();
            }

        }

    }
}
