using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BarcodeLib;

namespace tienda2.desinger
{
    public partial class crear_codigo_barras : Form
    {
        Barcode codigo = new Barcode();
        public crear_codigo_barras()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            
            codigo.IncludeLabel = true;
            codigo.Alignment = AlignmentPositions.CENTER;
            codigo.LabelFont = new Font(FontFamily.GenericMonospace, 14, FontStyle.Regular);
            
            Image img = codigo.Encode(TYPE.CODE128, txt_codigo_barras.Text, Color.Black, Color.White, 200, 100);
            pctb_codigo_barras.Image = img;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            codigo.SaveImage("inf\\inventario\\img\\" + txt_codigo_barras.Text + ".JPG", SaveTypes.JPG);
        }
    }
}
