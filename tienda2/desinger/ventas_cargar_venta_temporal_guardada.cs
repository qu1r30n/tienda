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
    public partial class ventas_cargar_venta_temporal_guardada : Form
    {
        Tex_base bas = new Tex_base();
        string dir_guardado = "inf\\guardada_vent_temporal.txt";
        Ventas _parent;
        public ventas_cargar_venta_temporal_guardada(Ventas form_ventas)
        {
            _parent = form_ventas;
            InitializeComponent();
            string[] ventas_guardadas = bas.Leer(dir_guardado);
            for (int i = 0; i < ventas_guardadas.Length; i++)
            {
                lstbx_ventas_guardadas.Items.Add(ventas_guardadas[i]);
            }
        }



        private void lstbx_ventas_guardadas_DoubleClick(object sender, EventArgs e)
        {
            if (lstbx_ventas_guardadas.SelectedItem != null)
            {
                int num_item_seleccionado = lstbx_ventas_guardadas.SelectedIndex;
                string[] info_producto_lista = lstbx_ventas_guardadas.SelectedItem.ToString().Split('|');
                for (int i = 0; i < info_producto_lista.Length - 1; i++)
                {
                    string[] codigo_cantidad = info_producto_lista[i].Split('°');
                    _parent.Procesar_codigo(codigo_cantidad[0], codigo_cantidad[1]);
                }

                bas.Eliminar_fila_porn_numero_de_fila(dir_guardado, num_item_seleccionado);
                this.Close();
            }
        }
    }
}
