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
        public ArrayList nombre_productos = new ArrayList();
        public ArrayList codigo_barras_list = new ArrayList();
        public ArrayList info_extra = new ArrayList();
        public ArrayList cantidad = new ArrayList();
        public ArrayList precio_venta = new ArrayList();
        public ArrayList provedor = new ArrayList();


        public decimal Total_costo_venta { get; set; }
        public decimal Cost_comp { get; set; }

        DateTime fecha_hora = DateTime.Now;
        char[] G_parametros = { '|', '°', '¬', '^' };

        public Confirmar_venta()
        {
            InitializeComponent();
        }
        private void Btn_pagar_Click(object sender, EventArgs e)
        {
            decimal total_a_pagar = Convert.ToDecimal(Lbl_total.Text), dinero_pagado = Convert.ToDecimal(Txt_dinero.Text);

            if (total_a_pagar <= dinero_pagado)
            {
                if (total_a_pagar < dinero_pagado)
                {
                    MessageBox.Show("cambio: "+(dinero_pagado-total_a_pagar));
                }
                Tex_base bas = new Tex_base();
                string temp = "";
                string cantidades_de_productos = "";

                string direccion = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\ventas\\" + fecha_hora.ToString("yyyyMMdd") + "_vendidos.txt";
                string direccion2 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\ventas\\provedores\\";
                string direccion3 = "provedores\\ventas_en_dinero.txt";

                for (int i = 0; i < codigo_barras_list.Count; i++)
                {
                    temp = temp + codigo_barras_list[i] + G_parametros[0];
                    cantidades_de_productos = cantidades_de_productos + cantidad[i] + G_parametros[0];

                    bas.Si_existe_suma_sino_desde_el_inventario_agrega(direccion, 3, "" + codigo_barras_list[i], "0|1", cantidad[i] + "|" + precio_venta[i]);
                    bas.Si_existe_suma_sino_desde_el_inventario_las_columnas_agrega(direccion2 + provedor[i] + ".txt", 3, "" + codigo_barras_list[i], "0|1", cantidad[i] + "|" + precio_venta[i], "1|3|0|6|8|2");
                    bas.si_existe_suma_sino_agega_extra(direccion3,0,""+provedor[i], "1", "" +precio_venta[i],provedor[i]+"|"+precio_venta[i]);

                }

                temp = op_text.Trimend_paresido(temp, G_parametros[0]);
                cantidades_de_productos = op_text.Trimend_paresido(cantidades_de_productos, G_parametros[0]);


                string[] codigos_Barras = temp.Split(G_parametros[0]);
                string[] cant_productos = cantidades_de_productos.Split(G_parametros[0]);

                Modelo_compra_venta mod_com_vent = new Modelo_compra_venta();
                mod_com_vent.Modelo_venta(codigos_Barras, cant_productos);
                this.Close();
            }
            else
            {
                MessageBox.Show("falta de dinero: " + (total_a_pagar - dinero_pagado));
            }
        }


        private void Txt_dinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txt_dinero_keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || '.' == e.KeyChar || '\b' == e.KeyChar)
            {

            }
            /*
            else if (char.IsLetter(e.KeyChar))//checa si lo introducido fue letra o no chart.IsLetter devuelve true o falce
            {
                e.KeyChar = '\0';
            }
            */
            else
            {
                e.KeyChar = '\0';
            }
        }

    }
}