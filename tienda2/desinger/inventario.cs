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
    public partial class inventario : Form
    {
        char[] G_parametros = { '|', '°', '¬', '^' };
        List<string> G_productos = new List<string>();
        string G_prov_anterior = null;//si el provedor trajera varios productos nuevos para no estar escribe y escribe el provedor solo se guarda temporalmente         


        Tex_base bas = new Tex_base();

        string[] productos;


        public inventario()
        {
            InitializeComponent();
            variables_estaticas.GG_modo_inventario = true;
            productos = bas.Leer("inf\\inventario\\invent.txt");
            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            string direccion_result_inventario = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\tienda_inventarios\\" + año_mes_dia + "_todo_tienda.txt";
            bas.Crear_archivo_y_directorio(direccion_result_inventario);
            string[] temp_para_listbox = bas.Leer(direccion_result_inventario);
            for (int i = 0; i < temp_para_listbox.Length; i++)
            {
                lst_todos_los_agregados.Items.Add(temp_para_listbox[i]);
            }

        }

        private void Btn_verificar_inv_Click(object sender, EventArgs e)
        {
            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            //id_0|producto_1|precio_de_venta_2|0_3|cantidad_4|costo_compra_5|provedor_6|grupo_7|multiusos_8|cantidad_productos_por_
            for (int i = 0; i < lst_cod_bar.Items.Count; i++)
            {
                bool bandera = false;
                for (int j = 0; j < productos.Length; j++)
                {
                    string[] productos_espliteado = productos[j].Split('|');
                    if ("" + lst_cod_bar.Items[i] == productos_espliteado[3])
                    {
                        bandera = true;

                        agregar_a_list_todos_agreg(productos_espliteado[3], productos_espliteado[1]);

                    }

                }
                if (bandera==false)
                {
                    mod_ventana_si_no_existe_en_el_inventario(""+lst_cod_bar.Items[i]);
                }

            }
        }

        private void Btn_elim_ultimo_Click(object sender, EventArgs e)
        {
            lst_cod_bar.Items.Remove(lst_cod_bar.Items[lst_cod_bar.Items.Count - 1]);
        }

        private void Btn_eliminar_todo_Click(object sender, EventArgs e)
        {
            lst_cod_bar.Items.Clear();
        }

        private void Btn_eliminar_seleccionado_Click(object sender, EventArgs e)
        {
            lst_cod_bar.Items.RemoveAt(lst_cod_bar.SelectedIndex);
        }

        private string mod_ventana_si_no_existe_en_el_inventario(string codigo_barras)
        {
            Operaciones_textos op_text = new Operaciones_textos();
            string[] provedores = bas.Leer("inf\\inventario\\provedores.txt", "0", G_parametros[0]);//este regresa los provedores
            string provedores_txt = op_text.join_paresido('°', provedores);

            //------------------------------------------------------------
            Ventana_emergente vent_emergent = new Ventana_emergente();
            //-------------------------------------------------------------
            string[] enviar;

            if (G_prov_anterior == null)
            {
                if (provedores.Length < 0)
                {
                    G_prov_anterior = provedores[0];
                }



                enviar = new string[] { "2°id°" + productos.Length, "1°producto", "1°precio venta°0°2", "2°codigo de barras°" + codigo_barras, "1°cantidad°1°2", "1°costo de compra°0°2", "4°provedor°marinela°°" + G_prov_anterior + '°' + provedores_txt, "4°grupo°2°4°1°1°2°3°4", "2°no poner nada°", "1°cantidad_productos_por_paquete°1°2", "1°productos_elaborados°°3" };
            }
            else
            {

                enviar = new string[] { "2°id°" + productos.Length, "1°producto", "1°precio venta°0°2", "2°codigo de barras°" + codigo_barras, "1°cantidad°1°2", "1°costo de compra°0°2", "4°provedor°" + G_prov_anterior + "°°" + G_prov_anterior + '°' + provedores_txt, "4°grupo°2°4°1°1°2°3°4", "2°no poner nada°", "1°cantidad_productos_por_paquete°1°2", "1°productos_elaborados°°3" };
            }

            string mensage = vent_emergent.Proceso_ventana_emergente(enviar);//el uno significa que modificara el inventario

            return mensage;
        }

        private void si_encuetra_producto_en_la_lista_lo_suma_tod_agreg(string codigo, string nom_producto,int posicion_de_la_lista_a_editar)
        {
            Ventana_emergente vent_emer = new Ventana_emergente();
            string[] enviar = { "1°" + nom_producto + "°0°2" };
            double cantidad_a_sumar = Convert.ToDouble(vent_emer.Proceso_ventana_emergente(enviar));
            string temp_a_esplitear=""+lst_todos_los_agregados.Items[posicion_de_la_lista_a_editar];
            String[] registro_de_lista_a_edita = temp_a_esplitear.Split('|');
            double cantidad_de_la_lista=Convert.ToDouble(registro_de_lista_a_edita[2]);
            double nueva_cantidad = cantidad_de_la_lista + cantidad_a_sumar;
            registro_de_lista_a_edita[2] = ""+nueva_cantidad;

            
        }

        private void agregar_a_list_todos_agreg(string codigo,string nom_producto)
        {
            
            DateTime fecha_hora = DateTime.Now;
            string hora_min_seg = fecha_hora.ToString("HHmmss");
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            string direccion_inventario_hacer = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\tienda_inventarios\\" + año_mes_dia + "_todo_tienda.txt";

            Ventana_emergente vent_emer = new Ventana_emergente();
            string[] enviar = { "1°" + nom_producto + "°0°2" };
            string resultado = vent_emer.Proceso_ventana_emergente(enviar);
            resultado=bas.Trimend_paresido(resultado);
            string texto_a_agregar = codigo + "|" + nom_producto + "|" + resultado + "|" + hora_min_seg;
            lst_todos_los_agregados.Items.Add(texto_a_agregar);
            bas.Agregar(direccion_inventario_hacer, texto_a_agregar);

        }

        private void btn_terminar_Click(object sender, EventArgs e)
        {
            string[] produc_del_inventario = bas.Leer("inf\\inventario\\invent.txt", "3|4|1");
            
            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
            string dir_venta_rest_invent = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\tienda_inventarios\\" + año_mes_dia + "_compras_durante_invet.txt";
            bas.Crear_archivo_y_directorio(dir_venta_rest_invent);
            string[] compras_echas_durante_invent=bas.Leer(dir_venta_rest_invent);

            List<string> lst_codigos = new List<string>();
            List<string> lst_cantidades = new List<string>();
            List<string> lst_hora = new List<string>();

            //al inventario le restara las compras falta hacer la copia del inventario para comparar
            for (int i = 0; i < lst_todos_los_agregados.Items.Count; i++)
            {
                bool bandera = false;
                string[] item_espliteado = lst_todos_los_agregados.Items[i].ToString().Split('|');
                for (int j = 0; j < lst_codigos.Count; j++)
                {
                    
                    if (item_espliteado[0]==""+lst_codigos[j])
                    {
                        bandera = true;
                        lst_cantidades[j] = ""+(Convert.ToDouble(lst_cantidades[j]) + Convert.ToDouble(item_espliteado[2]));

                    }
                }
                if (bandera == false)
                {
                    lst_codigos.Add(item_espliteado[0]);

                    lst_cantidades.Add(item_espliteado[2]);
                    lst_hora.Add(item_espliteado[3]);
                }
            }
            //-------------------------------------------------------

            
            for (int i = 0; i < compras_echas_durante_invent.Length; i++)
            {
                string [] comp_dur_inv_split=compras_echas_durante_invent[i].Split('|');
                for (int j = 0; j < lst_codigos.Count; j++)
                {
                    if (comp_dur_inv_split[0]==lst_codigos[j])
                    {
                        lst_cantidades[j] = "" + (Convert.ToDouble(lst_cantidades[j]) - Convert.ToDouble(comp_dur_inv_split[2]));
                    }
                }
            }

            //string[] produc_del_inventario = bas.Leer("inf\\inventario\\invent.txt", "3|4");
            if (chb_cambiar_invent.Checked==true)
            {
                for (int i = 0; i < lst_codigos.Count; i++)
                {
                    bas.Editar_espesifico("inf\\inventario\\invent.txt",3,lst_codigos[i],"4",lst_cantidades[i]);
                }
            }

            else
            {
                string dir_result_inventarios_sobrantes= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\tienda_inventarios\\result_invent\\" + año_mes_dia + "_sobrantes_tienda.txt";
                string dir_result_inventarios_faltantes = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\tienda_inventarios\\result_invent\\" + año_mes_dia + "_faltantes_tienda.txt";
                string dir_result_inventarios_no_estan = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\tienda_inventarios\\result_invent\\" + año_mes_dia + "_no_estan_tienda.txt";

                for (int i = 0; i < produc_del_inventario.Length; i++)
                {
                    bool bandera = false;
                    for (int j = 0; j < lst_codigos.Count; j++)
                    {
                        string[] procuc_del_inv_esplit = produc_del_inventario[i].Split('|');

                        string lst_codigos_en_estring = lst_codigos[j];
                        string procuc_del_inv_esplit_en_estring = procuc_del_inv_esplit[0];
                        

                        if (lst_codigos_en_estring == procuc_del_inv_esplit_en_estring)
                        {
                            bandera = true;
                            double lst_cantidades_double = Convert.ToDouble("" + lst_cantidades[j]);
                            double procuc_del_inv_esplits_double = Convert.ToDouble(procuc_del_inv_esplit[1]);

                            if (lst_cantidades_double < procuc_del_inv_esplits_double)
                            {

                                bas.Crear_archivo_y_directorio(dir_result_inventarios_faltantes);

                                double cantidad_faltante = procuc_del_inv_esplits_double - lst_cantidades_double;
                                bas.Agregar(dir_result_inventarios_faltantes, lst_codigos_en_estring + "|" + cantidad_faltante + "|" + procuc_del_inv_esplit[2]);
                                //faltantes
                            }
                            else if (lst_cantidades_double > procuc_del_inv_esplits_double)
                            {
                                bas.Crear_archivo_y_directorio(dir_result_inventarios_sobrantes);
                                if (procuc_del_inv_esplits_double < 0)
                                {
                                    procuc_del_inv_esplits_double = 0;
                                }
                                double cantidad_sobrante = lst_cantidades_double - procuc_del_inv_esplits_double;
                                bas.Agregar(dir_result_inventarios_sobrantes, lst_codigos_en_estring + "|" + cantidad_sobrante + "|" + procuc_del_inv_esplit[2]);

                                //sobrantes
                            }

                        }
                    }
                    if(bandera==false){
                        bas.Crear_archivo_y_directorio(dir_result_inventarios_no_estan);
                        bas.Agregar(dir_result_inventarios_no_estan,produc_del_inventario[i]);
                        //no esta en la tienda deberia de estar en 0
                    }

                }
            }
            

            
            
        }

        private void txt_cod_bar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txt_cod_bar.Text != "")
                {
                    lst_cod_bar.Items.Add(txt_cod_bar.Text);
                    txt_cod_bar.Text = "";
                }
            }

        }

        private void Btn_eliminar_seleccionado2_Click(object sender, EventArgs e)
        {
            lst_todos_los_agregados.Items.RemoveAt(lst_todos_los_agregados.SelectedIndex);
        }

        private void Btn_eliminar_todo2_Click(object sender, EventArgs e)
        {
            lst_todos_los_agregados.Items.Clear();
        }

        private void Btn_elim_ultimo2_Click(object sender, EventArgs e)
        {
            lst_todos_los_agregados.Items.Remove(lst_todos_los_agregados.Items[lst_todos_los_agregados.Items.Count - 1]);
            //bas.Eliminar();
        }
    }
}

