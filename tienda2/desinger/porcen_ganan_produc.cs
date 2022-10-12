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
    public partial class porcen_ganan_produc : Form
    {
        Tex_base bas = new Tex_base();
        public porcen_ganan_produc()
        {
            InitializeComponent();
            string dir_arch = "inf\\inventario\\invent.txt";
            string[] productos = bas.Leer(dir_arch, "3|1|5|2|8|8");
            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            string dir_res_comp = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\info_tienda\\cant_ganancia\\" + año_mes_dia + "_porcentajes_ganancia_de_producto.txt";
            for (int i = 0; i < productos.Length; i++)
            {
                string[] produc_espliteado = productos[i].Split('|');
                if (produc_espliteado[2]!="")
                {
                    double costo_compra = Convert.ToDouble(produc_espliteado[2]);
                    double costo_venta = Convert.ToDouble(produc_espliteado[3]);
                    double cantidad_ganancia = costo_venta - costo_compra;
                    double porcentage_ganancia = (costo_compra + costo_venta) / (100 * costo_compra);
                    bas.Agregar(dir_res_comp, produc_espliteado[0] + "|" + produc_espliteado[1] + "|" + produc_espliteado[2] + "|" + produc_espliteado[3] + "|" + cantidad_ganancia + "|" + porcentage_ganancia);
                }
            }
            
        }

        private void lstb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
