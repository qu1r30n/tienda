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
    public partial class confirmar_venta : Form
    {
        operaciones_textos op_text = new operaciones_textos();
        public ArrayList ids_productos = new ArrayList();
        public ArrayList arra_lis = new ArrayList();
        public ArrayList info_extra = new ArrayList();
        public decimal cantidad { get; set; }
        public decimal cost_comp { get; set; }

        DateTime fecha_hora = DateTime.Now;
        char[] G_parametros = { '|' };

        public confirmar_venta()
        {
            InitializeComponent();
        }
        private void btn_pagar_Click(object sender, EventArgs e)
        {
            tex_base bas = new tex_base();
            string temp="";
            for (int i = 0; i < arra_lis.Count; i++)
            {
                temp = temp + arra_lis[i] + G_parametros[0];
                bas.si_existe_suma_sino_agrega(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + fecha_hora.ToString("dd-MM-yyyy") + "_vendidos.txt", 2, "" + arra_lis[i], "0","1");
            }
            temp = op_text.trimend_paresido(temp, G_parametros[0]);
            string[] codigos_Barras = temp.Split(G_parametros);
            modelo_compra_venta mod_com_vent = new modelo_compra_venta();
            mod_com_vent.modelo_venta(codigos_Barras);
            
            
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