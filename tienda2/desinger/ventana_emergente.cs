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
    public partial class ventana_emergente : Form
    {

        char[] G_parametros = { '|' };
        string G_datos_de_boton="";
        int G_celdas_totales = 0;


        public ventana_emergente()
        {
            InitializeComponent();


        }

        public string proceso_ventana_emergente(string[] nom_datos_recolectados, int modificara = 0, string[] infoextra = null, char caracter_spliteo = '°')
        {
            int x = 120;
            int y = 0;
            int ancho = 100;
            int alto = 50;
            int acumleft = 0;
            int separacion_y = 15;
            int contador_en_horisontal_txtbox = 0;

            string[] info= { "" };

            string hola = "";
            string union = "";

            string bandera1 = "0", bandera2 = "0", bandera3 = "0";

            for (int i = 0; i < nom_datos_recolectados.Length; i++)
            {
                string [] tipo_de_datos=nom_datos_recolectados[i].Split(caracter_spliteo);

                if (tipo_de_datos[0]=="1")
                {
                    bandera1 = "1";
                }
                else if (tipo_de_datos[0] == "2")
                {
                    bandera2 = "1";
                }
                else if (tipo_de_datos[0] == "3")
                {
                    bandera3 = "1";
                }
            }
            if (bandera3 == "1" && bandera1 == "0" && bandera2 == "0")
            {
                info [0]="solo_botones" ;
            }

            string[] arraytextbox = new string[nom_datos_recolectados.Length];
            G_celdas_totales = nom_datos_recolectados.Length;

            

            if (nom_datos_recolectados.Length != 0)
            {
                for (int i = 0; i < nom_datos_recolectados.Length; i++)
                {
                    string[] espliteado = nom_datos_recolectados[i].Split(caracter_spliteo);
                    
                    if (espliteado[0] == "1")//labels y textbox
                    {
                        Label lb = new Label();
                        TextBox txt = new TextBox();
                        if (contador_en_horisontal_txtbox <= 4)
                        {
                            lb.Top = y;
                            lb.Left = acumleft;

                            txt.Top = y + separacion_y;
                            txt.Left = acumleft;

                        }
                        else
                        {
                            contador_en_horisontal_txtbox = 0;
                            y = y + 40;
                            acumleft = 0;
                            lb.Top = y;
                            lb.Left = acumleft;

                            txt.Top = y + separacion_y;
                            txt.Left = acumleft;
                        }

                        contador_en_horisontal_txtbox = contador_en_horisontal_txtbox + 1;


                        if (espliteado.Length == 3)
                        {
                            txt.Text = espliteado[2];
                        }

                        nom_datos_recolectados[i] = espliteado[1];

                        lb.Text = nom_datos_recolectados[i];

                        txt.Width = ancho;
                        txt.Height = alto;

                        lb.AutoSize = true;
                        this.Controls.Add(lb);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        this.Controls.Add(txt);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        acumleft = acumleft + x;
                        


                    }

                    else if (espliteado[0] == "2")//labels y textbox
                    {
                        Label lb = new Label();
                        Label lbl2 = new Label();
                        arraytextbox[i] = espliteado[2];
                        if (contador_en_horisontal_txtbox <= 4)
                        {
                            lb.Top = y;
                            lb.Left = acumleft;

                            lbl2.Top = y + separacion_y;
                            lbl2.Left = acumleft;

                        }
                        else
                        {
                            contador_en_horisontal_txtbox = 0;
                            y = y + 40;
                            acumleft = 0;
                            lb.Top = y;
                            lb.Left = acumleft;

                            lbl2.Top = y + separacion_y;
                            lbl2.Left = acumleft;
                            
                        }

                        contador_en_horisontal_txtbox = contador_en_horisontal_txtbox + 1;


                        if (espliteado.Length == 3)
                        {
                            lbl2.Text = espliteado[2];
                        }

                        nom_datos_recolectados[i] = espliteado[1];

                        lb.Text = nom_datos_recolectados[i];

                        lbl2.Width = ancho;
                        //lbl2.Height = alto;

                        lb.AutoSize = true;
                        this.Controls.Add(lb);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        this.Controls.Add(lbl2);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        acumleft = acumleft + x;



                    }

                    else if (espliteado[0] == "3")//botones
                    {
                        Button btn_nuevoboton = new Button();
                        btn_nuevoboton.Name = espliteado[2];
                        btn_nuevoboton.Text = espliteado[1];


                        if (contador_en_horisontal_txtbox <= 4)
                        {
                            btn_nuevoboton.Top = y + separacion_y;
                            btn_nuevoboton.Left = acumleft;
                        }
                        else
                        {
                            contador_en_horisontal_txtbox = 0;
                            y = y + 40;
                            acumleft = 0;

                            btn_nuevoboton.Top = y + separacion_y;
                            btn_nuevoboton.Left = acumleft;
                        }

                        contador_en_horisontal_txtbox = contador_en_horisontal_txtbox + 1;

                        btn_nuevoboton.Width = ancho;
                        btn_nuevoboton.Height = alto;

                        this.Controls.Add(btn_nuevoboton);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        acumleft = acumleft + x;
                        
                        this.Controls.Add(btn_nuevoboton);

                        string parametros = i+"°"+ espliteado[2];
                        //btn_nuevoboton.Click += new EventHandler(nuevoBoton_Click); 
                        if (info[0]== "solo_botones")
                        {
                            
                            btn_nuevoboton.Click += new EventHandler((sender1, e1) => hola = nuevoBoton_Click(sender1, e1, parametros, info));
                        }
                        else
                        {
                            btn_nuevoboton.Click += new EventHandler((sender1, e1) => hola = nuevoBoton_Click(sender1, e1, parametros));
                        }
                        

                        

                    }

                }
                

                if (bandera1 == "1")
                {
                    Button btn_aceptar = new Button();

                    btn_aceptar.Width = ancho;
                    btn_aceptar.Height = alto;
                    btn_aceptar.Top = y + 60;
                    btn_aceptar.Left = x;
                    btn_aceptar.Name = "btn_aceptar_1";
                    btn_aceptar.Text = "aceptar";
                    this.Controls.Add(btn_aceptar);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string

                    btn_aceptar.DialogResult = DialogResult.OK;
                    this.ShowDialog();

                    //----------------------------------------------------------------------------------------------------------------------------
                    if (btn_aceptar.DialogResult == DialogResult)
                    {
                        arraytextbox = boton_aceptar(arraytextbox,modificara,infoextra,caracter_spliteo);
                        
                    }
                    else
                    {
                        arraytextbox = new[] { "" };
                    }
                    
                    //------------------------------------------------------------------------------------------------------------------

                }

                else if (bandera2=="1" || bandera3 == "1" && bandera1 != "1")
                {
                    this.ShowDialog();
                    union = hola;
                }

            }
            else { MessageBox.Show("no has puesto ningun dato"); }

            
            if (arraytextbox[0] != null)
            {
                for (int i = 0; i < arraytextbox.Length; i++)
                {
                    union = union + arraytextbox[i] + G_parametros[0];
                }
            }
            return union;
        }

        public string[] boton_aceptar(string[] arraytextbox, int modificara = 0, string[] infoextra = null, char caracter_spliteo = '°')
        {
            tex_base bas = new tex_base();
            operaciones_archivos op = new operaciones_archivos();
            string temp2 = "";

            string [] info_detro_celda = G_datos_de_boton.Split(G_parametros[0]);

            for (int i = 0; i < info_detro_celda.Length; i++)
            {
                string[] posicion_y_datos = info_detro_celda[i].Split(caracter_spliteo);
                if (posicion_y_datos.Length>=2)
                {
                    arraytextbox[Convert.ToInt32(posicion_y_datos[0])] = posicion_y_datos[1];
                }
            }

            int k = 0;
            for (int j = 0; j < this.Controls.Count; j++) //aqui agrega al arreglo global "arraytextbox" la informacion
            {
                object obj = this.Controls[j];
                
                for (int i = k; i < arraytextbox.Length; i++)
                {
                    
                    if (obj is TextBox && arraytextbox[i]==null)
                    {
                        TextBox temp = (TextBox)obj;
                        arraytextbox[i] = temp.Text;
                        k = i;
                        break;
                    }
                }
                
            }


            

            for (int i = 0; i < arraytextbox.Length ; i++)
            {
                temp2 = temp2 + arraytextbox[i] + G_parametros[0];
            }
            operaciones_textos op_tex = new operaciones_textos();
            op_tex.trimend_paresido(temp2, G_parametros[0]);


            bas.crear_archivo_y_directorio("inf\\inventario\\cosas_no_estaban.txt");
            
            switch (modificara)
            {
                case 0:
                    bas.agregar("inf\\inventario\\cosas_no_estaban.txt", "movimiento origen: " + modificara + G_parametros[0] + temp2);
                    break;
                case 1:
                    bas.agregar("inf\\inventario\\cosas_no_estaban.txt", "movimiento origen: " + modificara + G_parametros[0] + temp2);
                    bas.agregar("inf\\inventario\\invent.txt", temp2);
                    break;
                case 2:
                    bas.agregar("inf\\inventario\\cosas_no_estaban.txt", "movimiento origen: " + modificara + G_parametros[0] + temp2);

                    op.actualisar_costo_compra("inf\\inventario\\invent.txt", infoextra[0], Convert.ToDecimal(arraytextbox[0]));
                    break;
                case 3:
                    bas.agregar("inf\\inventario\\cosas_no_estaban.txt", "movimiento origen: " + modificara + G_parametros[0] + temp2);
                    break;
                default:
                    bas.agregar("inf\\inventario\\cosas_no_estaban.txt", "movimiento origen: " + modificara + G_parametros[0] + temp2);
                    break;
            }
            
            this.Close();
            return arraytextbox;

        }

        public string nuevoBoton_Click(object sender, EventArgs e, string seccion,string[] info_extra=null)
        {
            //comprobamos en que boton se a clicado
            Button btn = sender as Button;

            //G_datos_de_boton = G_datos_de_boton + seccion + G_parametros[0];

            if (info_extra!=null)
            {
                if (info_extra[0] == "solo_botones")
                {
                    string[] seccion_espliteado = seccion.Split('°');
                    seccion = seccion_espliteado[1];
                    G_datos_de_boton =seccion;
                    this.Close();
                }
                else
                {
                    G_datos_de_boton = G_datos_de_boton + seccion + G_parametros[0];
                    this.Close();
                }
            }
            else
            {
                G_datos_de_boton = G_datos_de_boton + seccion + G_parametros[0];
            }
            
            //y vemos el resutado
            //MessageBox.Show("pulsado el boton: " + btn.Text + "\nsu valor es: " + seccion);
            
            return G_datos_de_boton;
        }

        public static string InputBox(string title = "aqui tu titulo", string promptText = "aqui la pregunta", string value = "aqui el valor")
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return value;
        }

    }
}