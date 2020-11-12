using System;
using System.Drawing;
using System.Windows.Forms;
using tienda2.clases;

namespace tienda2.desinger
{
    public partial class Ventana_emergente : Form
    {

        char[] G_parametros = { '|' };
        string G_datos_de_boton="";
        


        public Ventana_emergente()
        {
            InitializeComponent();


        }

        public string Proceso_ventana_emergente(string[] nom_datos_recolectados, int modificara = 0, string[] infoextra = null, char caracter_spliteo = '°')
        {
            int x = 120;
            int y = 0;
            int ancho = 100;
            int alto = 50;
            int acumleft = 0;
            int separacion_y = 15;
            int contador_en_horisontal_Txtbox = 0;

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
            

            

            if (nom_datos_recolectados.Length != 0)
            {
                for (int i = 0; i < nom_datos_recolectados.Length; i++)
                {
                    string[] espliteado = nom_datos_recolectados[i].Split(caracter_spliteo);

                    if (espliteado[0] == "1")//labels y textbox
                    {
                        Label lb = new Label();
                        TextBox Txt = new TextBox();
                        if (contador_en_horisontal_Txtbox <= 4)
                        {
                            lb.Top = y;
                            lb.Left = acumleft;

                            Txt.Top = y + separacion_y;
                            Txt.Left = acumleft;

                        }
                        else
                        {
                            contador_en_horisontal_Txtbox = 0;
                            y = y + 40;
                            acumleft = 0;
                            lb.Top = y;
                            lb.Left = acumleft;

                            Txt.Top = y + separacion_y;
                            Txt.Left = acumleft;
                        }

                        contador_en_horisontal_Txtbox = contador_en_horisontal_Txtbox + 1;


                        if (espliteado.Length == 3)
                        {
                            Txt.Text = espliteado[2];
                        }

                        nom_datos_recolectados[i] = espliteado[1];

                        lb.Text = nom_datos_recolectados[i];

                        Txt.Width = ancho;
                        Txt.Height = alto;

                        lb.AutoSize = true;
                        this.Controls.Add(lb);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        this.Controls.Add(Txt);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        acumleft = acumleft + x;



                    }

                    else if (espliteado[0] == "2")//labels
                    {
                        Label lb = new Label();
                        Label Lbl2 = new Label();
                        arraytextbox[i] = espliteado[2];
                        if (contador_en_horisontal_Txtbox <= 4)
                        {
                            lb.Top = y;
                            lb.Left = acumleft;

                            Lbl2.Top = y + separacion_y;
                            Lbl2.Left = acumleft;

                        }
                        else
                        {
                            contador_en_horisontal_Txtbox = 0;
                            y = y + 40;
                            acumleft = 0;
                            lb.Top = y;
                            lb.Left = acumleft;

                            Lbl2.Top = y + separacion_y;
                            Lbl2.Left = acumleft;

                        }

                        contador_en_horisontal_Txtbox = contador_en_horisontal_Txtbox + 1;


                        if (espliteado.Length == 3)
                        {
                            Lbl2.Text = espliteado[2];
                        }

                        nom_datos_recolectados[i] = espliteado[1];

                        lb.Text = nom_datos_recolectados[i];

                        Lbl2.Width = ancho;
                        //Lbl2.Height = alto;

                        lb.AutoSize = true;
                        this.Controls.Add(lb);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        this.Controls.Add(Lbl2);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        acumleft = acumleft + x;



                    }

                    else if (espliteado[0] == "3")//botones
                    {
                        Button Btn_nuevoboton = new Button();
                        Btn_nuevoboton.Name = espliteado[2];
                        Btn_nuevoboton.Text = espliteado[1];


                        if (contador_en_horisontal_Txtbox <= 4)
                        {
                            Btn_nuevoboton.Top = y + separacion_y;
                            Btn_nuevoboton.Left = acumleft;
                        }
                        else
                        {
                            contador_en_horisontal_Txtbox = 0;
                            y = y + 40;
                            acumleft = 0;

                            Btn_nuevoboton.Top = y + separacion_y;
                            Btn_nuevoboton.Left = acumleft;
                        }

                        contador_en_horisontal_Txtbox = contador_en_horisontal_Txtbox + 1;

                        Btn_nuevoboton.Width = ancho;
                        Btn_nuevoboton.Height = alto;

                        this.Controls.Add(Btn_nuevoboton);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        acumleft = acumleft + x;

                        this.Controls.Add(Btn_nuevoboton);

                        string parametros = i + "°" + espliteado[2];
                        //Btn_nuevoboton.Click += new EventHandler(nuevoBoton_Click); 
                        if (info[0] == "solo_botones")
                        {
                            Btn_nuevoboton.Click += new EventHandler((sender1, e1) => hola = NuevoBoton_Click(sender1, e1, parametros, info));

                        }
                        else
                        {
                            Btn_nuevoboton.Click += new EventHandler((sender1, e1) => hola = NuevoBoton_Click(sender1, e1, parametros));
                        }
                    }

                    else if (espliteado[0] == "4")
                    {

                        Label lb = new Label();
                        ComboBox cmb = new ComboBox();
                        if (contador_en_horisontal_Txtbox <= 4)
                        {
                            lb.Top = y;
                            lb.Left = acumleft;

                            cmb.Top = y + separacion_y;
                            cmb.Left = acumleft;

                        }
                        else
                        {
                            contador_en_horisontal_Txtbox = 0;
                            y = y + 40;
                            acumleft = 0;
                            lb.Top = y;
                            lb.Left = acumleft;

                            cmb.Top = y + separacion_y;
                            cmb.Left = acumleft;
                        }

                        contador_en_horisontal_Txtbox = contador_en_horisontal_Txtbox + 1;

                        if (espliteado.Length >= 3)
                        {
                            cmb.Text = espliteado[2];
                            for (int j = 2; j < espliteado.Length; j++)
                            {
                                if (espliteado[2]!= espliteado[j])
                                {
                                    cmb.Items.Add(espliteado[j]);
                                    
                                }
                                else
                                {
                                    espliteado[2] = "";//este sirve para que solo elimine una repeticion por que son 2 las que crea
                                }
                                
                            }

                        }

                        nom_datos_recolectados[i] = espliteado[1];

                        lb.Text = nom_datos_recolectados[i];

                        cmb.Width = ancho;
                        cmb.Height = alto;

                        lb.AutoSize = true;
                        this.Controls.Add(lb);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        this.Controls.Add(cmb);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string
                        acumleft = acumleft + x;

                    }

                }
                

                if (bandera1 == "1")
                {
                    Button Btn_aceptar = new Button();

                    Btn_aceptar.Width = ancho;
                    Btn_aceptar.Height = alto;
                    Btn_aceptar.Top = y + 60;
                    Btn_aceptar.Left = x;
                    Btn_aceptar.Name = "Btn_aceptar_1";
                    Btn_aceptar.Text = "aceptar";
                    this.Controls.Add(Btn_aceptar);//le agrega un indice al control para luego utilisarlo por su indise en  la funcion devolver string

                    Btn_aceptar.DialogResult = DialogResult.OK;
                    this.ShowDialog();

                    //----------------------------------------------------------------------------------------------------------------------------
                    if (Btn_aceptar.DialogResult == DialogResult)
                    {
                        arraytextbox = Boton_aceptar(arraytextbox,modificara,infoextra,caracter_spliteo);
                        
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

        public string[] Boton_aceptar(string[] arraytextbox, int modificara = 0, string[] infoextra = null, char caracter_spliteo = '°')
        {
            Tex_base bas = new Tex_base();
            Operaciones_archivos op = new Operaciones_archivos();
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
                    else if (obj is ComboBox && arraytextbox[i] == null)
                    
                    {
                        ComboBox temp = (ComboBox)obj;
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
            Operaciones_textos op_tex = new Operaciones_textos();
            op_tex.Trimend_paresido(temp2, G_parametros[0]);


            bas.Crear_archivo_y_directorio("inf\\inventario\\cosas_no_estaban.txt");
            
            switch (modificara)
            {
                case 0:
                    bas.Agregar("inf\\inventario\\cosas_no_estaban.txt", "movimiento origen: " + modificara + G_parametros[0] + temp2);
                    break;
                case 1:
                    bas.Agregar("inf\\inventario\\cosas_no_estaban.txt", "movimiento origen: " + modificara + G_parametros[0] + temp2);
                    bas.Agregar("inf\\inventario\\invent.txt", temp2);
                    break;
                case 2:
                    bas.Agregar("inf\\inventario\\cosas_no_estaban.txt", "movimiento origen: " + modificara + G_parametros[0] + temp2);

                    op.Actualisar_costo_compra("inf\\inventario\\invent.txt", infoextra[0], Convert.ToDecimal(arraytextbox[0]));
                    break;
                case 3:
                    bas.Agregar("inf\\inventario\\cosas_no_estaban.txt", "movimiento origen: " + modificara + G_parametros[0] + temp2);
                    break;
                default:
                    bas.Agregar("inf\\inventario\\cosas_no_estaban.txt", "movimiento origen: " + modificara + G_parametros[0] + temp2);
                    break;
            }
            
            this.Close();
            return arraytextbox;

        }

        public string NuevoBoton_Click(object sender, EventArgs e, string seccion,string[] info_extra=null)
        {
            //comprobamos en que boton se a clicado
            Button Btn = sender as Button;

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
            //MessageBox.Show("pulsado el boton: " + Btn.Text + "\nsu valor es: " + seccion);
            
            return G_datos_de_boton;
        }

        public static string txt_entrada(string title = "aqui tu titulo", string promptText = "aqui la pregunta", string value = "aqui el valor")
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