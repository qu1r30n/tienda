using System;
using System.Collections;
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
    public partial class Confirmar_venta : Form
    {
        Operaciones_textos op_text = new Operaciones_textos();
        public ArrayList ids_productos = new ArrayList();
        public ArrayList arra_lis = new ArrayList();
        public ArrayList info_extra = new ArrayList();
        public ArrayList cantidad = new ArrayList();
        
        public decimal Total_costo_venta { get; set; }
        public decimal Cost_comp { get; set; }

        DateTime fecha_hora = DateTime.Now;
        char[] G_parametros = { '|' };

        public Confirmar_venta()
        {
            InitializeComponent();
        }
        private void Btn_pagar_Click(object sender, EventArgs e)
        {
            Tex_base bas = new Tex_base();
            string temp="";
            string cantidades_de_productos="";
            for (int i = 0; i < arra_lis.Count; i++)
            {
                temp = temp + arra_lis[i] + G_parametros[0];
                cantidades_de_productos = cantidades_de_productos + cantidad[i] + G_parametros[0];
                bas.Crear_archivo_y_directorio(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\ventas\\" + fecha_hora.ToString("yyyy-MM-dd") + "_vendidos.Txt");
                bas.Si_existe_suma_sino_agrega(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\ventas\\" + fecha_hora.ToString("yyyy-MM-dd") + "_vendidos.Txt", 2, "" + arra_lis[i], "0","1");
            }
            temp = op_text.Trimend_paresido(temp, G_parametros[0]);
            cantidades_de_productos = op_text.Trimend_paresido(cantidades_de_productos, G_parametros[0]);

            string[] codigos_Barras = temp.Split(G_parametros);
            string[] cant_productos = cantidades_de_productos.Split(G_parametros);
            Modelo_compra_venta mod_com_vent = new Modelo_compra_venta();
            mod_com_vent.Modelo_venta(codigos_Barras, cant_productos);
            
            
            this.Close();
        }


        private void Txt_dinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}