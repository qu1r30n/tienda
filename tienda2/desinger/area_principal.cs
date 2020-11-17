using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienda2.desinger
{
    public partial class Area_principal : Form
    {
        public Area_principal()
        {
            InitializeComponent();
            try
            {

                DateTime fecha_hora = DateTime.Now;//guarda la fecha y hora de ahurita
                Tex_base bas = new Tex_base();//bas es la clase tex_base
                string direc_tem = "ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\" + fecha_hora.ToString("MM") + ".txt";//direccion del archivo de hoy
                cmb_año.Text = fecha_hora.ToString("yyyy");//el combo box del año contendra el año de hoy
                cmb_mes.Text = fecha_hora.ToString("MM");//el combo box del mes contendra el mes de hoy

                Combo_a("ventas\\total_años.txt");//extrae de total_años.Txt  todos los años  que se a generedado archivos
                Combo_m("ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("yyyy") + ".txt");// extrae de el año actual todos los meses que se a generedado archivos
                Combo_d("ventas\\" + fecha_hora.ToString("yyyy") + "\\" + fecha_hora.ToString("MM") + "\\" + fecha_hora.ToString("MM") + ".txt");// extrae del mes actual todos los dias  que se a generedado archivos

                Grafica(direc_tem, fecha_hora.ToString("yyyy-MM"), false);//hace una graficacion de año-mes

                if (cmb_año.Items.Count == 0)//si el archivo no tiene lineas  quiere decir que no tendra el combobox  items  y si  los items son igual a 0 entra y manda un mensaje
                {
                    MessageBox.Show("no estan los archivos has una venta y reinicia el programa para ver los graficos");//hace el mensaje
                }
                Rdb_ventas.Checked = true; //pone por defecto el radio buton en ventas
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region botones y combobox
        private void Btn_inventario_Click(object sender, EventArgs e)
        {
            Lbl_ganancia.Visible = false;//pone invisible el label de ganancia
            Txt_ganancia.Visible = false;//pone invisible el textbox de ganancia

            crear_codigo_barras crear_barras = new crear_codigo_barras();//invent sera el form inventario
            crear_barras.Show();//muestra el form inventario
        }

        private void Btn_nueva_venta_Click(object sender, EventArgs e)
        {
            Lbl_ganancia.Visible = false;//pone invisible el label de ganancia
            Txt_ganancia.Visible = false;//pone invisible el textbox de ganancia

            Ventas nuev_vent = new Ventas();//nuev_vent sera el form ventas
            nuev_vent.Show();//muestra el form ventas

        }

        private void Btn_empleados_Click(object sender, EventArgs e)
        {
            Lbl_ganancia.Visible = false;//pone invisible el label de ganancia
            Txt_ganancia.Visible = false;//pone invisible el textbox de ganancia

            Empleados empl = new Empleados();//nuev_vent sera el form empleados
            empl.Show();// muestra el form empleados
        }

        private void Btn_compras_Click(object sender, EventArgs e)
        {
            Lbl_ganancia.Visible = false;
            Txt_ganancia.Visible = false;

            Compras comp = new Compras();
            comp.Show();
        }

        private void Btn_respaldo_Click(object sender, EventArgs e)
        {
            Lbl_ganancia.Visible = false;
            Txt_ganancia.Visible = false;

            Respaldo respaldo = new Respaldo();
            respaldo.Show();

        }

        private void Btn_pedidos_Click(object sender, EventArgs e)
        {
            Lbl_ganancia.Visible = false;
            Txt_ganancia.Visible = false;

            Pedidos pedi = new Pedidos();
            pedi.Show();
        }

        private void Btn_comparar_Click(object sender, EventArgs e)
        {


            Lbl_ganancia.Visible = false;
            Txt_ganancia.Visible = false;

            if (Rdb_ventas.Checked)
            {
                Comparar.Checkbox_en_uso = "0";
                Modelo_grafica(cmb_año.Text, cmb_mes.Text, cmb_dia.Text, true);
            }
            else if (Rdb_productos.Checked)
            {
                Comparar.Checkbox_en_uso = "1";
                Modelo_grafica_productos(cmb_año.Text, cmb_mes.Text, cmb_dia.Text, true);
            }

            else if (Rdb_gastos.Checked)
            {
                Comparar.Checkbox_en_uso = "2";
                Modelo_grafica_gastos(cmb_año.Text, cmb_mes.Text, cmb_dia.Text, true);
            }
        }

        private void Cmb_año_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combo_m("ventas\\" + cmb_año.Text + "\\" + cmb_año.Text + ".txt");
        }

        private void Cmb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combo_d("ventas\\" + cmb_año.Text + "\\" + cmb_mes.Text + "\\" + cmb_mes.Text + ".txt");
        }

        private void Rdb_ventas_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_ganancia.Visible = false;
            Txt_ganancia.Visible = false;

            if (Rdb_ventas.Checked)
            {
                Modelo_grafica(cmb_año.Text, cmb_mes.Text, cmb_dia.Text, false);
            }
        }

        private void Rdb_productos_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_ganancia.Visible = false;
            Txt_ganancia.Visible = false;

            if (Rdb_productos.Checked)
            {
                Modelo_grafica_productos(cmb_año.Text, cmb_mes.Text, cmb_dia.Text, false);
            }
        }

        private void Rdb_gastos_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_ganancia.Visible = false;
            Txt_ganancia.Visible = false;

            if (Rdb_gastos.Checked)
            {
                Modelo_grafica_gastos(cmb_año.Text, cmb_mes.Text, cmb_dia.Text, false);
            }
        }

        private void Btn_ganancias_Click(object sender, EventArgs e)
        {
            Modelo_grafica_ganancias(cmb_año.Text, cmb_mes.Text, cmb_dia.Text, true);
            Lbl_ganancia.Visible = true;
            Txt_ganancia.Visible = true;

        }

        #endregion

        #region modelos y graficas

        //--------------------------------------------------------------------------------------------------------------
        public void Modelo_grafica(string c_año = "", string c_mes = "", string c_dia = "", bool comparacion = false)
        {

            Comparar comp = new Comparar(this);
            Lst_ventas.Items.Clear();


            if (c_año == "" && c_mes == "" && c_dia == "")
            {
                comp.Direccion_grafica = "ventas\\total_años.txt";
                comp.Palabra_reconocimiento = "total_años";

                if (comparacion == false)
                {
                    Grafica(comp.Direccion_grafica, "total_años", comparacion);
                }
                else
                {
                    comp.Show();
                }

            }

            else if (c_año != "" && c_mes == "" && c_dia == "")
            {
                comp.Direccion_grafica = "ventas\\" + c_año + "\\" + c_año + ".txt";
                comp.Palabra_reconocimiento = c_año;

                if (comparacion == false)
                {
                    Grafica(comp.Direccion_grafica, c_año, comparacion);
                }
                else
                {
                    comp.Show();
                }
            }

            else if (c_año != "" && c_mes != "" && c_dia == "")
            {
                comp.Direccion_grafica = "ventas\\" + c_año + "\\" + c_mes + "\\" + c_mes + ".txt";
                comp.Palabra_reconocimiento = c_año + "-" + c_mes;

                if (comparacion == false)
                {
                    Grafica(comp.Direccion_grafica, c_año + "-" + c_mes, comparacion);
                }
                else
                {
                    comp.Show();
                }
            }

            else if (c_año != "" && c_mes != "" && c_dia != "")
            {
                comp.Direccion_grafica = "ventas\\" + c_año + "\\" + c_mes + "\\" + "dias\\" + c_año + "-" + c_mes + "-" + c_dia + ".txt";
                comp.Palabra_reconocimiento = c_año + "-" + c_mes + "-" + c_dia;

                if (comparacion == false)
                {
                    Grafica_horas(comp.Direccion_grafica, c_año + "-" + c_mes + "-" + c_dia, comparacion);
                }
                else
                {
                    comp.Show();
                }
            }

            else
            {
                MessageBox.Show("error verifica que los combobox");
            }
        }

        public void Modelo_grafica_productos(string c_año = "", string c_mes = "", string c_dia = "", bool comparacion = false)
        {
            Comparar comp = new Comparar(this);
            Lst_ventas.Items.Clear();

            if (c_año == "" && c_mes == "" && c_dia == "")
            {
                comp.Direccion_grafica = "ventas\\p_total_años.txt";
                comp.Palabra_reconocimiento = "p_total_años";
                if (comparacion == false)
                {
                    Grafica_productos(comp.Direccion_grafica, "p_total_años", comparacion);
                }
                else
                {
                    comp.Show();
                }

            }

            else if (c_año != "" && c_mes == "" && c_dia == "")
            {
                comp.Direccion_grafica = "ventas\\" + c_año + "\\p_" + c_año + ".txt";
                comp.Palabra_reconocimiento = "p_" + c_año;
                if (comparacion == false)
                {
                    Grafica_productos(comp.Direccion_grafica, "p_" + c_año, comparacion);
                }
                else
                {
                    comp.Show();
                }
            }

            else if (c_año != "" && c_mes != "" && c_dia == "")
            {

                comp.Direccion_grafica = "ventas\\" + c_año + "\\" + c_mes + "\\p_" + c_mes + ".txt";
                comp.Palabra_reconocimiento = "p_" + c_año + "-" + c_mes;

                if (comparacion == false)
                {
                    Grafica_productos(comp.Direccion_grafica, "p_" + c_año + "-" + c_mes, comparacion);
                }
                else
                {
                    comp.Show();
                }
            }

            else if (c_año != "" && c_mes != "" && c_dia != "")
            {
                comp.Direccion_grafica = "ventas\\" + c_año + "\\" + c_mes + "\\" + "dias\\p_" + c_año + "-" + c_mes + "-" + c_dia + ".txt";
                comp.Palabra_reconocimiento = "p_" + c_año + "-" + c_mes + "-" + c_dia;

                if (comparacion == false)
                {
                    Grafica_productos(comp.Direccion_grafica, "p_" + c_año + "-" + c_mes + "-" + c_dia, comparacion);
                }
                else
                {
                    comp.Show();
                }
            }

            else
            {
                MessageBox.Show("error verifica que los combobox");
            }
        }

        public void Modelo_grafica_gastos(string c_año = "", string c_mes = "", string c_dia = "", bool comparacion = false)
        {
            Comparar comp = new Comparar(this);
            Lst_ventas.Items.Clear();

            if (c_año == "" && c_mes == "" && c_dia == "")
            {

                comp.Direccion_grafica = "ventas\\g_total_años.txt";
                comp.Palabra_reconocimiento = "g_total_años";

                if (comparacion == false)
                {
                    Grafica_compras(comp.Direccion_grafica, "g_total_años", comparacion);
                }
                else
                {
                    comp.Show();
                }


            }

            else if (c_año != "" && c_mes == "" && c_dia == "")
            {
                comp.Direccion_grafica = "ventas\\" + c_año + "\\g_" + c_año + ".txt";
                comp.Palabra_reconocimiento = "g_" + c_año;
                if (comparacion == false)
                {
                    Grafica_compras(comp.Direccion_grafica, "g_" + c_año, comparacion);
                }
                else
                {
                    comp.Show();
                }


            }

            else if (c_año != "" && c_mes != "" && c_dia == "")
            {

                comp.Direccion_grafica = "ventas\\" + c_año + "\\" + c_mes + "\\g_" + c_mes + ".txt";
                comp.Palabra_reconocimiento = "g_" + c_año + "-" + c_mes;
                if (comparacion == false)
                {
                    Grafica_compras(comp.Direccion_grafica, "g_" + c_año + "-" + c_mes, comparacion);
                }
                else
                {
                    comp.Show();
                }
            }

            else if (c_año != "" && c_mes != "" && c_dia != "")
            {


                comp.Direccion_grafica = "ventas\\" + c_año + "\\" + c_mes + "\\" + "dias\\g_" + c_año + "-" + c_mes + "-" + c_dia + ".txt";
                comp.Palabra_reconocimiento = "g_" + c_año + "-" + c_mes + "-" + c_dia;
                if (comparacion == false)
                {
                    Grafica_compras_horas(comp.Direccion_grafica, "g_" + c_año + "-" + c_mes + "-" + c_dia, comparacion);
                }
                else
                {
                    comp.Show();
                }
            }

            else
            {
                MessageBox.Show("error verifica que los combobox");
            }
        }

        public void Grafica_para_comparacion(string direccion_archivo, string direccion_archivo2, string nombre_serie, string nombre_serie2, bool comparacion = false, char caracter_de_separacion = '|')
        {


            chrt_ventas.Series.Clear();
            try
            {
                chrt_ventas.Series.Add(nombre_serie);
                chrt_ventas.Series.Add(nombre_serie2);
            }
            catch (Exception)
            {

                MessageBox.Show("tienen que ser diferentes las fechas de comparacion");
                return;
            }

            chrt_ventas.Series[nombre_serie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrt_ventas.Series[nombre_serie2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            string[] esplitedo = { "", "" }, esplitedo2 = { "", "" }, historial, historial2;
            int cual_es_mayor;

            //elim2_graficas_para_comparacion = 0;
            Tex_base bas = new Tex_base();
            historial = bas.Leer(direccion_archivo);
            historial2 = bas.Leer(direccion_archivo2);



            if (historial.Length >= historial2.Length)
            {
                cual_es_mayor = historial.Length;
            }
            else
            {
                cual_es_mayor = historial2.Length;
            }
            int cual_anotar = 0;
            for (int i = 0; i < cual_es_mayor - 1; i++)
            {
                if (i < historial.Length)
                {
                    esplitedo = historial[i].Split(caracter_de_separacion);
                    chrt_ventas.Series[0].Points.AddXY(esplitedo[0], esplitedo[1]);
                    cual_anotar = cual_anotar + 1;
                }
                if (i < historial2.Length)
                {
                    esplitedo2 = historial2[i].Split(caracter_de_separacion);
                    chrt_ventas.Series[1].Points.AddXY(esplitedo2[0], esplitedo2[1]);
                    cual_anotar = cual_anotar + 2;
                }

                switch (cual_anotar)
                {
                    case 1:
                        Lst_ventas.Items.Add(esplitedo[0] + caracter_de_separacion + esplitedo[1] + "          ");
                        break;
                    case 2:
                        Lst_ventas.Items.Add("          " + esplitedo2[0] + caracter_de_separacion + esplitedo2[1]);
                        break;
                    case 3:
                        Lst_ventas.Items.Add(esplitedo[0] + caracter_de_separacion + esplitedo[1] + "          " + esplitedo2[0] + caracter_de_separacion + esplitedo2[1]);
                        break;
                    default:
                        MessageBox.Show("error switch");
                        break;
                }

                cual_anotar = 0;
            }
            Txt_total.Text = "" + historial[historial.Length];
            Txt_total.Text = Txt_total.Text + ";  " + historial2[historial2.Length];
        }

        public void Modelo_grafica_ganancias(string c_año = "", string c_mes = "", string c_dia = "", bool comparacion = true)
        {

            string direc, direc2, nom_serie, nom_serie2;
            Lst_ventas.Items.Clear();

            if (c_año == "" && c_mes == "" && c_dia == "")
            {
                Grafica_ganancias("ventas\\total_años.txt", "ventas\\g_total_años.txt", "total_venta", "total_gasto", comparacion);
            }

            else if (c_año != "" && c_mes == "" && c_dia == "")
            {
                direc = "ventas\\" + c_año + "\\" + c_año + ".txt";
                direc2 = "ventas\\" + c_año + "\\g_" + c_año + ".txt";
                nom_serie = c_año;
                nom_serie2 = "g_" + c_año;
                Grafica_ganancias(direc, direc2, nom_serie, nom_serie2, comparacion);
            }

            else if (c_año != "" && c_mes != "" && c_dia == "")
            {
                direc = "ventas\\" + c_año + "\\" + c_mes + "\\" + c_mes + ".txt";
                direc2 = "ventas\\" + c_año + "\\" + c_mes + "\\g_" + c_mes + ".txt";
                nom_serie = c_año + "-" + c_mes;
                nom_serie2 = "g_" + c_año + "-" + c_mes;
                Grafica_ganancias(direc, direc2, nom_serie, nom_serie2, comparacion);
            }

            else if (c_año != "" && c_mes != "" && c_dia != "")
            {
                direc = "ventas\\" + c_año + "\\" + c_mes + "\\" + "dias\\" + c_año + "-" + c_mes + "-" + c_dia + ".txt";
                direc2 = "ventas\\" + c_año + "\\" + c_mes + "\\" + "dias\\g_" + c_año + "-" + c_mes + "-" + c_dia + ".txt";
                nom_serie = c_año + "-" + c_mes + "-" + c_dia;
                nom_serie2 = "g_" + c_año + "-" + c_mes + "-" + c_dia;
                Grafica_horas_ganancias(direc, direc2, nom_serie, nom_serie2, 0, comparacion);
            }

            else
            {
                MessageBox.Show("error verifica que los combobox");
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------

        public void Grafica(string direccion_archivo, string nombre_serie = "Serie1", bool comparacion = false, char caracter_de_separacion = '|')
        {


            if (comparacion == false)
            {
                chrt_ventas.Series.Clear();
            }
            try
            {
                chrt_ventas.Series.Add(nombre_serie);
            }
            catch (Exception)
            {

                throw;
            }

            chrt_ventas.Series[nombre_serie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            //elim0_graficas = 0;
            Tex_base bas = new Tex_base();
            
            string[] esplitedo, historial;
            historial = bas.Leer(direccion_archivo);

            decimal acum_venta=0,acum_compra = 0;
            for (int i = 0; i < historial.Length; i++)
            {
                esplitedo = historial[i].Split(caracter_de_separacion);
                chrt_ventas.Series[0].Points.AddXY(esplitedo[0], esplitedo[1]);
                Lst_ventas.Items.Add(esplitedo[0] + caracter_de_separacion + esplitedo[1] + caracter_de_separacion + esplitedo[2]);
                acum_venta = acum_venta + Convert.ToDecimal(esplitedo[1]);
                acum_compra = acum_compra + Convert.ToDecimal(esplitedo[2]);
            }
            Txt_total.Text = "total_venta: " + acum_venta + " total_costo_de_compra: " + acum_compra + " ganancia: "+(acum_venta-acum_compra);
        }

        public void Grafica_compras(string direccion_archivo, string nombre_serie = "Serie1", bool comparacion = false, char caracter_de_separacion = '|')
        {


            if (comparacion == false)
            {
                chrt_ventas.Series.Clear();
            }
            try
            {
                chrt_ventas.Series.Add(nombre_serie);
            }
            catch (Exception)
            {

                throw;
            }

            chrt_ventas.Series[nombre_serie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            //elim0_graficas = 0;
            Tex_base bas = new Tex_base();

            string[] esplitedo, historial;
            historial = bas.Leer(direccion_archivo);

            decimal acum_compra = 0;
            for (int i = 0; i < historial.Length; i++)
            {
                esplitedo = historial[i].Split(caracter_de_separacion);
                chrt_ventas.Series[0].Points.AddXY(esplitedo[0], esplitedo[1]);
                Lst_ventas.Items.Add(esplitedo[0] + caracter_de_separacion + esplitedo[1]);
                acum_compra = acum_compra + Convert.ToDecimal(esplitedo[1]);
            }
            Txt_total.Text = " total_compra: " + acum_compra;
        }


        public void Grafica_productos(string direccion_archivo, string nombre_serie = "Serie1", bool comparacion = false, char caracter_de_separacion = '|')
        {


            if (comparacion == false)
            {
                chrt_ventas.Series.Clear();
            }
            try
            {
                chrt_ventas.Series.Add(nombre_serie);
            }
            catch (Exception)
            {

                throw;
            }

            chrt_ventas.Series[nombre_serie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            //elim0_graficas = 0;
            Tex_base bas = new Tex_base();

            string[] esplitedo, historial;
            historial = bas.Leer(direccion_archivo);

            for (int i = 0; i < historial.Length; i++)
            {
                esplitedo = historial[i].Split(caracter_de_separacion);
                chrt_ventas.Series[0].Points.AddXY(esplitedo[2], esplitedo[1]);
                Lst_ventas.Items.Add(esplitedo[0] + caracter_de_separacion + esplitedo[1] + caracter_de_separacion + esplitedo[2]);
            }
            Txt_total.Text = "";
        }




        public void Grafica_horas(string direccion_archivo, string nombre_serie = "Serie1", bool comparacion = false, char caracter_de_separacion = '|')
        {

            if (comparacion == false)
            {
                chrt_ventas.Series.Clear();
            }

            try
            {
                chrt_ventas.Series.Add(nombre_serie);
            }
            catch (Exception)
            {

                throw;
            }



            chrt_ventas.Series[nombre_serie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            
            string[] esplitedo, historial;

            //elim1_graficas_hora = 0;
            Tex_base bas = new Tex_base();
            historial = bas.Leer(direccion_archivo);

            for (int i = 0; i < historial.Length; i++)
            {
                esplitedo = historial[i].Split(caracter_de_separacion);
                chrt_ventas.Series[0].Points.AddXY(esplitedo[0], esplitedo[2]);

                Lst_ventas.Items.Add(esplitedo[0] + caracter_de_separacion + esplitedo[2]);


            }

            //Txt_total.Text = "" + historial[historial.Length];
        }

        public void Grafica_compras_horas(string direccion_archivo, string nombre_serie = "Serie1", bool comparacion = false, char caracter_de_separacion = '|')
        {

            if (comparacion == false)
            {
                chrt_ventas.Series.Clear();
            }

            try
            {
                chrt_ventas.Series.Add(nombre_serie);
            }
            catch (Exception)
            {

                throw;
            }



            chrt_ventas.Series[nombre_serie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Operaciones_archivos op = new Operaciones_archivos();

            string[] esplitedo, historial;

            //elim1_graficas_compras_hora = 0;
            Tex_base bas = new Tex_base();
            historial = bas.Leer(direccion_archivo);
            decimal acum_compra = 0;
            for (int i = 0; i < historial.Length; i++)
            {
                esplitedo = historial[i].Split(caracter_de_separacion);
                chrt_ventas.Series[0].Points.AddXY(esplitedo[0], esplitedo[6]);

                Lst_ventas.Items.Add(esplitedo[0] + caracter_de_separacion + esplitedo[6]);
                acum_compra = acum_compra + Convert.ToDecimal(esplitedo[6]);

            }
            Txt_total.Text = "total comprado: " + acum_compra;
        }


        public void Grafica_horas_para_comparar(string direccion_archivo, string direccion_archivo2, string nombre_serie, string nombre_serie2, int decicion = 0, bool comparacion = false, char caracter_de_separacion = '|')
        {


            if (comparacion == false)
            {
                chrt_ventas.Series.Clear();
            }

            try
            {
                chrt_ventas.Series.Add(nombre_serie);
            }
            catch (Exception)
            {


            }
            chrt_ventas.Series[nombre_serie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            string[] esplitedo, historial;
            //elim3_graficas_hora_para_comprar = 1;
            Tex_base bas = new Tex_base();
            historial = bas.Leer(direccion_archivo);


            for (int i = 0; i < historial.Length; i++)
            {
                esplitedo = historial[i].Split(caracter_de_separacion);
                chrt_ventas.Series[0].Points.AddXY(esplitedo[0], esplitedo[1]);
                if (decicion == 0)
                {
                    Lst_ventas.Items.Add(esplitedo[0] + caracter_de_separacion + esplitedo[1]);
                }
                else
                {
                    Lst_ventas.Items.Add(esplitedo[1] + ": " + esplitedo[2]);
                }
            }
            //Txt_total.Text = "" + historial[historial.Length];
        }

        public void Grafica_ganancias(string direccion_archivo, string direccion_archivo2, string nombre_serie, string nombre_serie2, bool comparacion = false, char caracter_de_separacion = '|')
        {


            chrt_ventas.Series.Clear();
            try
            {
                chrt_ventas.Series.Add(nombre_serie);
                chrt_ventas.Series.Add(nombre_serie2);
            }
            catch (Exception)
            {

                MessageBox.Show("tienen que ser diferentes las fechas de comparacion");
                return;
            }

            chrt_ventas.Series[nombre_serie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrt_ventas.Series[nombre_serie2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            
            string[] esplitedo = { "", "" }, esplitedo2 = { "", "" }, historial, historial2;
            int cual_es_mayor;

            //elim4_grafica_ganancias = 1;
            Tex_base bas = new Tex_base();

            historial = bas.Leer(direccion_archivo);
            historial2 = bas.Leer(direccion_archivo2);
            
            

            if (historial.Length >= historial2.Length)//esta la puse para el listbox saber cuantos items  va  a contener
            {
                cual_es_mayor = historial.Length;
            }
            else
            {
                cual_es_mayor = historial2.Length;
            }

            int cual_anotar = 0;
            for (int i = 0; i < cual_es_mayor; i++)
            {
                if (i < historial.Length)
                {
                    esplitedo = historial[i].Split(caracter_de_separacion);
                    chrt_ventas.Series[0].Points.AddXY(esplitedo[0], esplitedo[1]);
                    cual_anotar = cual_anotar + 1;
                }
                if (i < historial2.Length)
                {
                    esplitedo2 = historial2[i].Split(caracter_de_separacion);
                    chrt_ventas.Series[1].Points.AddXY(esplitedo2[0], esplitedo2[1]);
                    cual_anotar = cual_anotar + 2;
                }

                switch (cual_anotar)
                {
                    case 1:
                        Lst_ventas.Items.Add(esplitedo[0] + caracter_de_separacion + esplitedo[1] + "          ");
                        break;
                    case 2:
                        Lst_ventas.Items.Add("          " + esplitedo2[0] + caracter_de_separacion + esplitedo2[1]);
                        break;
                    case 3:
                        Lst_ventas.Items.Add(esplitedo[0] + caracter_de_separacion + esplitedo[1] + "          " + esplitedo2[0] + caracter_de_separacion + esplitedo2[1]);
                        break;
                    default:
                        MessageBox.Show("error switch");
                        break;
                }

                cual_anotar = 0;
            }
            //elim_grafica_ganancias = 0;
            esplitedo = historial[historial.Length].Split(caracter_de_separacion);
            esplitedo2 = historial2[historial2.Length].Split(caracter_de_separacion);

            Txt_total.Text = "ventas: " + esplitedo[1];
            Txt_total.Text = Txt_total.Text + ";  " + "gastos: " + esplitedo2[1];
            Txt_ganancia.Text = "" + (Convert.ToDouble(esplitedo[1]) - Convert.ToDouble(esplitedo2[1]));
        }

        public void Grafica_horas_ganancias(string direccion_archivo, string direccion_archivo2, string nombre_serie, string nombre_serie2, int decicion = 0, bool comparacion = false, char caracter_de_separacion = '|')
        {

            if (comparacion == false)
            {
                chrt_ventas.Series.Clear();
            }
            try
            {
                chrt_ventas.Series.Clear();
                chrt_ventas.Series.Add(nombre_serie);
            }
            catch (Exception) { }

            chrt_ventas.Series[nombre_serie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Operaciones_archivos op = new Operaciones_archivos();

            string[] esplitedo, historial;

            //elim5_grafica_hora_ganancias = 0;
            Tex_base bas = new Tex_base();
            historial = bas.Leer(direccion_archivo);

        
            for (int i = 0; i < historial.Length; i++)
            {
                esplitedo = historial[i].Split(caracter_de_separacion);
                chrt_ventas.Series[0].Points.AddXY(esplitedo[0], esplitedo[1]);
                if (decicion == 0)
                {
                    Lst_ventas.Items.Add(esplitedo[0] + caracter_de_separacion + esplitedo[1]);
                }
                else
                {
                    Lst_ventas.Items.Add(esplitedo[1] + ": " + esplitedo[2]);
                }
            }
            //Txt_total.Text = "" + historial[historial.Length - 1];
        }

        #endregion
        //-------------------------------------------------------------------------------------------------------------------------------------------------------

        public void Combo_a(string direccion_archivo, char caracter_de_separacion = '|')
        {
            Lbl_ganancia.Visible = false;
            Txt_ganancia.Visible = false;

            string temp;
            cmb_año.Items.Clear();//limpia contenido del combo
            Operaciones_archivos op = new Operaciones_archivos();//op es la clase operaciones de archivos

            //elim6_combo_a = 1;
            Tex_base bas = new Tex_base();
            string[] archivos = bas.Leer(direccion_archivo);//revisa todo el contenido del archivo
            string[] espliteado;//es una arreglo
            for (int i = 0; i < archivos.Length; i++)
            {
                temp = archivos[i];
                espliteado = temp.Split(caracter_de_separacion);
                cmb_año.Items.Add(espliteado[0]);
            }
        }

        public void Combo_m(string direccion_archivo, char caracter_de_separacion = '|')
        {
            Lbl_ganancia.Visible = false;
            Txt_ganancia.Visible = false;

            string temp;
            cmb_mes.Items.Clear();
            Operaciones_archivos op = new Operaciones_archivos();

            //elim7_combo_m = 1;
            Tex_base bas = new Tex_base();
            string[] archivos = bas.Leer(direccion_archivo);
            string[] espliteado;
            for (int i = 0; i < archivos.Length; i++)
            {
                temp = archivos[i];
                espliteado = temp.Split(caracter_de_separacion);
                cmb_mes.Items.Add(espliteado[0]);
            }

        }

        public void Combo_d(string direccion_archivo, char caracter_de_separacion = '|')
        {
            
            Lbl_ganancia.Visible = false;
            Txt_ganancia.Visible = false;

            string temp;
            cmb_dia.Items.Clear();
            Operaciones_archivos op = new Operaciones_archivos();

            //elim8_combo_d = 1;
            Tex_base bas = new Tex_base();
            string[] archivos = bas.Leer(direccion_archivo);
            string[] espliteado;
            for (int i = 0; i < archivos.Length; i++)
            {
                temp = archivos[i];
                espliteado = temp.Split(caracter_de_separacion);
                cmb_dia.Items.Add(espliteado[0]);
            }
        }

        private void Btn_canbio_precios_Click(object sender, EventArgs e)
        {
            Cambiar_precio cam_precio = new Cambiar_precio();
            cam_precio.Show();
        }

        private void Lst_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lst_ventas.SelectedItem != null)
            {

                Txt_total.Text = Lst_ventas.SelectedItem.ToString(); 
            }
        }
    }
}
