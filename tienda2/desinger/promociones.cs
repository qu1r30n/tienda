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
        bool se_guardo = false;

        char[] G_parametros = { '|', '°', '¬', '^' };
        List<string> G_productos = new List<string>();

        public promociones()
        {
            InitializeComponent();
            bas.Crear_archivo_y_directorio(dir_promo, "nombre_promocion|codigo_barras_1¬cantidad_del_producto¬nombre_producto_1°codigo_barras_2¬cantidad_del_producto¬nombre_productp_2|precio|");
            string[] promociones_todas = bas.Leer(dir_promo);
            recargar_lista_izquierda();
            Recargar_texbox();
        }

        private void Btn_procesar_venta_Click(object sender, EventArgs e)
        {
            modificacion_promo();
            recargar_lista_izquierda();
            lstb_produc_promo.Items.Clear();
            txt_precio_promo.Text = "";
            lbl_nom_promo.Text="nombre promo";
            lbl_precio_promo.Text = "precio promo";
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
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string[] info = Txt_buscar_producto.Text.Split(G_parametros[0]);
                Procesar_codigo_del_textbox_para_promo(info[0], info[3], info[5], info[2]);
            }
            Txt_buscar_producto.Text = "";
            Txt_nom_producto.Text = "";
            Txt_buscar_producto.Focus();
        }

        private void Txt_nom_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Lst_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] lista_esplit=lst_promociones_puestas.SelectedItem.ToString().Split('|');
            lbl_nom_promo.Text = lista_esplit[0];
            recargar_lista_derecha();

        }

        private void btn_agregar_promo_Click(object sender, EventArgs e)
        {
            Ventana_emergente vent_emer = new Ventana_emergente();
            string[] enviar;
            enviar = new string[] { "1°nombre_de_la_promocion" };
            string nombre_de_la_promo = vent_emer.Proceso_ventana_emergente(enviar);
            nombre_de_la_promo = bas.Trimend_paresido(nombre_de_la_promo);
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



        private void lstb_produc_promo_DoubleClick(object sender, EventArgs e)
        {
            string[] produc_esplit = lstb_produc_promo.SelectedItem.ToString().Split('¬');

            Ventana_emergente vent_emer = new Ventana_emergente();
            string[] enviar;
            enviar = new string[] { "1°cantidad_producto°0°2" };
            string nueva_cantidad_producto = vent_emer.Proceso_ventana_emergente(enviar);
            nueva_cantidad_producto = bas.Trimend_paresido(nueva_cantidad_producto);
            produc_esplit[1] = nueva_cantidad_producto;

            lstb_produc_promo.Items[lstb_produc_promo.SelectedIndex] = string.Join("¬", produc_esplit);
            
        }

        private void promociones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (se_guardo==false)
            {
                DialogResult resultado_dialog = MessageBox.Show("no se guardaron las modificacion\nquieres guardar?", "deseas guardar cambios?", MessageBoxButtons.YesNo);
                if (resultado_dialog == DialogResult.Yes)
                {
                    
                }
            }
        }

        private void Recargar_texbox()
        {

            Tex_base bas = new Tex_base();

            string[] imprimir = bas.Leer("inf\\inventario\\invent.txt", "1|0|2|3|4|5|6|7|8", G_parametros[0]);
            Txt_nom_producto.AutoCompleteCustomSource.Clear();
            for (int k = 1; k < imprimir.Length; k++)
            {
                Txt_nom_producto.AutoCompleteCustomSource.Add("" + imprimir[k]);
            }

            string[] imprimir2 = bas.Leer("inf\\inventario\\invent.txt", "3|0|2|1|4|5|6|7|8", G_parametros[0]);

            for (int k = 1; k < imprimir2.Length; k++)
            {
                G_productos.Add(imprimir2[k]);
                Txt_buscar_producto.AutoCompleteCustomSource.Add("" + imprimir2[k]);
            }
        }


        public void Procesar_codigo_del_textbox_para_promo(string codigo,string nombre_producto,string precio_comp, string precio_vent, string cantidad_a_sumar_o_restar = "1")
        {
            bool bandera = false;
            for (int i = 0; i < lstb_produc_promo.Items.Count; i++)
            {
                string[] product_espliteado=lstb_produc_promo.Items[i].ToString().Split('¬');
                if (product_espliteado[0]==codigo)
                {
                    product_espliteado[1] = "" + (Convert.ToDouble(product_espliteado[1]) + Convert.ToDouble(cantidad_a_sumar_o_restar));
                    lstb_produc_promo.Items[i] = string.Join("¬", product_espliteado);
                    bandera = true;
                }
                
            }
            if (bandera==false)
            {
                lstb_produc_promo.Items.Add(codigo + "¬" + cantidad_a_sumar_o_restar + "¬" + nombre_producto + "¬" + precio_comp + "¬" + precio_vent);
                string resultado = "";
                for (int i = 0; i < lstb_produc_promo.Items.Count; i++)
                {
                    resultado = resultado + lstb_produc_promo.Items[i] + "°";
                }
                resultado = bas.Trimend_paresido(resultado, '°');

                bas.Editar_espesifico(dir_promo, 0, lbl_nom_promo.Text, "1|2", resultado + "|" + txt_precio_promo.Text);
                recargar_lista_izquierda();

                recargar_lista_derecha();
            }
        }


        private void recargar_lista_derecha()
        {
            string promo_a_recargar = "";
            for (int i = 0; i < lst_promociones_puestas.Items.Count; i++)
            {
                string[] prom_esplit = lst_promociones_puestas.Items[i].ToString().Split('|');
                if (prom_esplit[0] == lbl_nom_promo.Text)
                {
                    promo_a_recargar = lst_promociones_puestas.Items[i].ToString();
                }
            }

            string[] lista_esplit = promo_a_recargar.Split('|');
            lbl_nom_promo.Text = lista_esplit[0];
            char[] caracteres_arreglos = { '|', '°' };
            arreglos_compuestos_y_simples arr_comp_sim = new arreglos_compuestos_y_simples();
            string[] arreglo_introducir = { promo_a_recargar };
            //"nombre_promocion|codigo_barras_1¬cantidad_del_producto°codigo_barras_2¬cantidad_del_producto|precio|
            string[] result = arr_comp_sim.extraer_ultimo_arreglo_dentro_de_arreglo(arreglo_introducir, 0, lista_esplit[0], "1", caracteres_arreglos);
            lstb_produc_promo.Items.Clear();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i]!="")
                {
                    lstb_produc_promo.Items.Add(result[i]);
                }
                
            }
            txt_precio_promo.Text = lista_esplit[2];
            lbl_precio_promo.Text = lista_esplit[2];
        }

        private void modificacion_promo()
        {
            //---------------------------------------------------------------------
            string resultado = "";
            for (int i = 0; i < lstb_produc_promo.Items.Count; i++)
            {
                resultado = resultado + lstb_produc_promo.Items[i] + "°";
            }
            resultado = bas.Trimend_paresido(resultado, '°');

            bas.Editar_espesifico(dir_promo, 0, lbl_nom_promo.Text, "1|2", resultado + "|" + txt_precio_promo.Text);
            recargar_lista_izquierda();
            //--------------------------------------------------------
        }




    }
}
