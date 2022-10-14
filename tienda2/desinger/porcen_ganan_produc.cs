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
        string dir_invent = "inf\\inventario\\invent.txt";
        public porcen_ganan_produc()
        {
            InitializeComponent();
            
            string[] productos = bas.Leer(dir_invent, "3|1|5|2|8|8|4|6");
            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            string dir_res_comp = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\info_tienda\\cant_ganancia\\" + año_mes_dia + "_porcentajes_ganancia_de_producto.txt";

            bool recargar_denuevo = false;
            bool existe_archivo = bas.existe_archivo(dir_res_comp);
            if (existe_archivo)
            {
                DialogResult respuesta = MessageBox.Show("recargar_todo", "recargar_todo", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    recargar_denuevo = true;
                }
            }

            if (recargar_denuevo || !existe_archivo)
            {

                if (existe_archivo)
                {
                    Operaciones_archivos op_arc = new Operaciones_archivos();
                    op_arc.Eliminar_archivo(dir_res_comp);
                }


                bas.Crear_archivo_y_directorio(dir_res_comp, "0_0|producto_1|costo_compra_2|precio_de_venta_3|cantidad_ganancia_4|porcentage_ganancia_5|cantidad_inventario_6|provedor_7|");

                for (int i = 1; i < productos.Length; i++)
                {
                    string[] produc_espliteado = productos[i].Split('|');
                    if (produc_espliteado[2] != "")
                    {
                        double costo_compra = Convert.ToDouble(produc_espliteado[2]);
                        double costo_venta = Convert.ToDouble(produc_espliteado[3]);
                        double cantidad_ganancia = costo_venta - costo_compra;
                        double porcentage_ganancia = (100 * (costo_venta - costo_compra)) / (costo_compra + costo_venta);
                        if (costo_venta == 0 && costo_compra == 0)
                        {
                            porcentage_ganancia = 0;
                        }
                        Operaciones_textos op_tex = new Operaciones_textos();
                        porcentage_ganancia = op_tex.cantidad_decimales(porcentage_ganancia, 2);
                        bas.Agregar(dir_res_comp, produc_espliteado[0] + "|" + produc_espliteado[1] + "|" + produc_espliteado[2] + "|" + produc_espliteado[3] + "|" + cantidad_ganancia + "|" + porcentage_ganancia + "|" + produc_espliteado[6] + "|" + produc_espliteado[7] + "|");
                    }
                }
                bas.Ordenar(dir_res_comp, 5, fila_donde_comiensa: 1);

            }

            string[] tod=bas.Leer(dir_res_comp);
            for (int i = 1; i < tod.Length; i++)
            {
                lstb_productos.Items.Add(tod[i]);
            }




        }

        private void lstb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstb_productos.SelectedItem != null)
            {
                //0_0|producto_1|costo_compra_2|precio_de_venta_3|cantidad_ganancia_4|porcentage_ganancia_5|cantidad_inventario_6|provedor_7|
                string info = lstb_productos.SelectedItem.ToString();
                txt_movimiento.Text = info;
                string[] info_spliteado = info.Split('|');
                lbl_nom_producto.Text = info_spliteado[1];
                lbl_cost_compra.Text = info_spliteado[2];
                lbl_precio_venta.Text = info_spliteado[3];
                lbl_cant_ganancia.Text = info_spliteado[4];
                lbl_porcen_ganan.Text = info_spliteado[5];
                lbl_cant_invent.Text = info_spliteado[6];
                lbl_provedor.Text = info_spliteado[7];

            }
        }

        private void btn_edit_nom_Click(object sender, EventArgs e)
        {
            //id_0|producto_1|precio_de_venta_2|0_3|cantidad_4|costo_compra_5|provedor_6|grupo_7|multiusos_8|cantidad_productos_por_paquete_9|
            bas.Editar_espesifico(dir_invent,1,)
        }

        private void btn_edit_compr_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_venta_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_cant_ganancia_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_porcent_ganada_Click(object sender, EventArgs e)
        {

        }

        private void edit_cant_inventario_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_provedor_Click(object sender, EventArgs e)
        {

        }
    }
}
