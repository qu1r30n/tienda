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
    public partial class promociones : Form
    {
        
        Tex_base bas = new Tex_base();
        string dir_promo = "promosiones\\promos.txt";
        List<string> lista_promos_var = new List<string>();

        public promociones()
        {
            InitializeComponent();
            bas.Crear_archivo_y_directorio(dir_promo, "nombre_promocion|codigo_barras_1¬cantidad_del_producto°codigo_barras_2¬cantidad_del_producto|precio|");
            string[] promociones_todas = bas.Leer(dir_promo);
            recargar_lista_izquierda();
        }

        private void Btn_procesar_venta_Click(object sender, EventArgs e)
        {

        }

        private void Btn_elim_ultimo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_todo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_seleccionado_Click(object sender, EventArgs e)
        {

        }

        private void Txt_buscar_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Txt_nom_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Lst_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            arreglos_compuestos_y_simples arr_comp_sim = new arreglos_compuestos_y_simples();
            
        }

        private void btn_agregar_promo_Click(object sender, EventArgs e)
        {
            Ventana_emergente vent_emer = new Ventana_emergente();
            string[] enviar;
            enviar = new string[] { "1°nombre_de_la_promocion" };
            string nombre_de_la_promo = vent_emer.Proceso_ventana_emergente(enviar);
            //"nombre_promocion|codigo_barras_1¬cantidad_del_producto°codigo_barras_2¬cantidad_del_producto|precio|
            string dat_a_ingresar = nombre_de_la_promo + "|||";
            bas.Agregar(dir_promo, dat_a_ingresar);
            lista_promos_var.Add(dat_a_ingresar);
            lst_promociones_puestas.Items.Add(dat_a_ingresar);
        }

        private void btn_elim_promo_Click(object sender, EventArgs e)
        {
            DialogResult resultado_dialog = MessageBox.Show(lst_promociones_puestas.SelectedItem + "\nestas seguro que quieres eliminar este item", "estas seguro", MessageBoxButtons.YesNo);
            if(resultado_dialog == DialogResult.Yes)
            {
                string[] promo_spliteada = lst_promociones_puestas.SelectedItem.ToString().Split('|');
                bas.Eliminar(dir_promo, promo_spliteada[0],0);
                
                recargar_lista_izquierda();
                
            }
        }

        private void btn_editar_promo_Click(object sender, EventArgs e)
        {

        }

        private void recargar_lista_izquierda()
        {
            lst_promociones_puestas.Items.Clear();
            lista_promos_var.Clear();

            string[] promociones_todas = bas.Leer(dir_promo);
            for (int i = 1; i < promociones_todas.Length; i++)
            {

                lst_promociones_puestas.Items.Add(promociones_todas[i]);
                lista_promos_var.Add(promociones_todas[i]);
            }
        }
    }
}
