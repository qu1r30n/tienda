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
    public partial class Respaldo : Form
    {
        string direccion = "";
        bool dec = false;
        char[] G_parametros = { '|' };
        public Respaldo()
        {
            InitializeComponent();
        }

        private void Btn_donde_guardar_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(fbd.SelectedPath);
                direccion = fbd.SelectedPath;
                Lbl_direccion.Text = direccion;
                dec = true;
                fbd.Reset();
            }
            else
            {
                return;
            }
        }

        private void Btn_respaldar_Click(object sender, EventArgs e)
        {
            DateTime fecha_hora = DateTime.Now;
            if (dec == true)
            {
                Operaciones_archivos op = new Operaciones_archivos();
                op.Respaldos_ventas("ventas", direccion + "\\respaldo_" + fecha_hora.ToString("yyyy-MM-dd") + "\\ventas");
                op.Respaldo_inventario("inf\\inventario", direccion + "\\respaldo\\inf\\inventario");
                Lbl_direccion.Text = "oprime boton donde guararlos para buscar donde poner el respaldo";
                dec = false;
            }
        }

        private void Btn_usar_respaldo_Click(object sender, EventArgs e)
        {
            if (dec == true)
            {
                Operaciones_archivos op = new Operaciones_archivos();
                op.Eliminar_carpeta(".\\ventas");
                op.Eliminar_carpeta(".\\inf\\inventario");
                op.Respaldos_ventas(direccion, "" + G_parametros[0]);
                op.Respaldo_inventario(direccion, "inf");
                Lbl_direccion.Text = "oprime boton donde guararlos para buscar donde poner el respaldo";
                dec = false;
            }
        }
    }
}
