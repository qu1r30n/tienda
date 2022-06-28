namespace tienda2.desinger
{
    partial class Area_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Lbl_ganancia = new System.Windows.Forms.Label();
            this.Txt_ganancia = new System.Windows.Forms.TextBox();
            this.Btn_ganancias = new System.Windows.Forms.Button();
            this.Rdb_gastos = new System.Windows.Forms.RadioButton();
            this.Rdb_productos = new System.Windows.Forms.RadioButton();
            this.Rdb_ventas = new System.Windows.Forms.RadioButton();
            this.Btn_comparar = new System.Windows.Forms.Button();
            this.Btn_compras = new System.Windows.Forms.Button();
            this.Btn_respaldo = new System.Windows.Forms.Button();
            this.Btn_gastos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_dia = new System.Windows.Forms.ComboBox();
            this.cmb_año = new System.Windows.Forms.ComboBox();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.Lst_ventas = new System.Windows.Forms.ListBox();
            this.Btn_empleados = new System.Windows.Forms.Button();
            this.Btn_nueva_venta = new System.Windows.Forms.Button();
            this.Btn_crear_cod_bar = new System.Windows.Forms.Button();
            this.Btn_canbio_precios = new System.Windows.Forms.Button();
            this.chrt_ventas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_igualar_provedores = new System.Windows.Forms.Button();
            this.btn_inv_merc = new System.Windows.Forms.Button();
            this.btn_pedidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ganancia
            // 
            this.Lbl_ganancia.AutoSize = true;
            this.Lbl_ganancia.Location = new System.Drawing.Point(473, 314);
            this.Lbl_ganancia.Name = "Lbl_ganancia";
            this.Lbl_ganancia.Size = new System.Drawing.Size(56, 13);
            this.Lbl_ganancia.TabIndex = 53;
            this.Lbl_ganancia.Text = "dinero hay";
            this.Lbl_ganancia.Visible = false;
            // 
            // Txt_ganancia
            // 
            this.Txt_ganancia.Location = new System.Drawing.Point(476, 330);
            this.Txt_ganancia.Name = "Txt_ganancia";
            this.Txt_ganancia.Size = new System.Drawing.Size(183, 20);
            this.Txt_ganancia.TabIndex = 17;
            this.Txt_ganancia.Visible = false;
            // 
            // Btn_ganancias
            // 
            this.Btn_ganancias.Location = new System.Drawing.Point(584, 240);
            this.Btn_ganancias.Name = "Btn_ganancias";
            this.Btn_ganancias.Size = new System.Drawing.Size(75, 23);
            this.Btn_ganancias.TabIndex = 15;
            this.Btn_ganancias.Text = "ganancias";
            this.Btn_ganancias.UseVisualStyleBackColor = true;
            this.Btn_ganancias.Click += new System.EventHandler(this.Btn_ganancias_Click);
            // 
            // Rdb_gastos
            // 
            this.Rdb_gastos.AutoSize = true;
            this.Rdb_gastos.Location = new System.Drawing.Point(584, 188);
            this.Rdb_gastos.Name = "Rdb_gastos";
            this.Rdb_gastos.Size = new System.Drawing.Size(56, 17);
            this.Rdb_gastos.TabIndex = 13;
            this.Rdb_gastos.TabStop = true;
            this.Rdb_gastos.Text = "gastos";
            this.Rdb_gastos.UseVisualStyleBackColor = true;
            this.Rdb_gastos.CheckedChanged += new System.EventHandler(this.Rdb_gastos_CheckedChanged);
            // 
            // Rdb_productos
            // 
            this.Rdb_productos.AutoSize = true;
            this.Rdb_productos.Location = new System.Drawing.Point(584, 165);
            this.Rdb_productos.Name = "Rdb_productos";
            this.Rdb_productos.Size = new System.Drawing.Size(72, 17);
            this.Rdb_productos.TabIndex = 12;
            this.Rdb_productos.TabStop = true;
            this.Rdb_productos.Text = "productos";
            this.Rdb_productos.UseVisualStyleBackColor = true;
            this.Rdb_productos.CheckedChanged += new System.EventHandler(this.Rdb_productos_CheckedChanged);
            // 
            // Rdb_ventas
            // 
            this.Rdb_ventas.AutoSize = true;
            this.Rdb_ventas.Location = new System.Drawing.Point(584, 142);
            this.Rdb_ventas.Name = "Rdb_ventas";
            this.Rdb_ventas.Size = new System.Drawing.Size(57, 17);
            this.Rdb_ventas.TabIndex = 11;
            this.Rdb_ventas.TabStop = true;
            this.Rdb_ventas.Text = "ventas";
            this.Rdb_ventas.UseVisualStyleBackColor = true;
            this.Rdb_ventas.CheckedChanged += new System.EventHandler(this.Rdb_ventas_CheckedChanged);
            // 
            // Btn_comparar
            // 
            this.Btn_comparar.Location = new System.Drawing.Point(580, 211);
            this.Btn_comparar.Name = "Btn_comparar";
            this.Btn_comparar.Size = new System.Drawing.Size(75, 23);
            this.Btn_comparar.TabIndex = 14;
            this.Btn_comparar.Text = "comparar";
            this.Btn_comparar.UseVisualStyleBackColor = true;
            this.Btn_comparar.Click += new System.EventHandler(this.Btn_comparar_Click);
            // 
            // Btn_compras
            // 
            this.Btn_compras.Location = new System.Drawing.Point(3, 123);
            this.Btn_compras.Name = "Btn_compras";
            this.Btn_compras.Size = new System.Drawing.Size(143, 23);
            this.Btn_compras.TabIndex = 5;
            this.Btn_compras.Text = "Compras";
            this.Btn_compras.UseVisualStyleBackColor = true;
            this.Btn_compras.Click += new System.EventHandler(this.Btn_pedidos_Click);
            // 
            // Btn_respaldo
            // 
            this.Btn_respaldo.Location = new System.Drawing.Point(3, 182);
            this.Btn_respaldo.Name = "Btn_respaldo";
            this.Btn_respaldo.Size = new System.Drawing.Size(143, 23);
            this.Btn_respaldo.TabIndex = 7;
            this.Btn_respaldo.Text = "Respaldo";
            this.Btn_respaldo.UseVisualStyleBackColor = true;
            this.Btn_respaldo.Click += new System.EventHandler(this.Btn_respaldo_Click);
            // 
            // Btn_gastos
            // 
            this.Btn_gastos.Location = new System.Drawing.Point(3, 65);
            this.Btn_gastos.Name = "Btn_gastos";
            this.Btn_gastos.Size = new System.Drawing.Size(143, 23);
            this.Btn_gastos.TabIndex = 3;
            this.Btn_gastos.Text = "Gastos";
            this.Btn_gastos.UseVisualStyleBackColor = true;
            this.Btn_gastos.Click += new System.EventHandler(this.Btn_compras_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "total";
            // 
            // Txt_total
            // 
            this.Txt_total.Location = new System.Drawing.Point(175, 330);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(283, 20);
            this.Txt_total.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "año";
            // 
            // cmb_dia
            // 
            this.cmb_dia.FormattingEnabled = true;
            this.cmb_dia.Location = new System.Drawing.Point(580, 115);
            this.cmb_dia.Name = "cmb_dia";
            this.cmb_dia.Size = new System.Drawing.Size(121, 21);
            this.cmb_dia.TabIndex = 10;
            // 
            // cmb_año
            // 
            this.cmb_año.FormattingEnabled = true;
            this.cmb_año.Location = new System.Drawing.Point(581, 28);
            this.cmb_año.Name = "cmb_año";
            this.cmb_año.Size = new System.Drawing.Size(121, 21);
            this.cmb_año.TabIndex = 8;
            this.cmb_año.SelectedIndexChanged += new System.EventHandler(this.Cmb_año_SelectedIndexChanged);
            // 
            // cmb_mes
            // 
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Location = new System.Drawing.Point(580, 75);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(121, 21);
            this.cmb_mes.TabIndex = 9;
            this.cmb_mes.SelectedIndexChanged += new System.EventHandler(this.Cmb_mes_SelectedIndexChanged);
            // 
            // Lst_ventas
            // 
            this.Lst_ventas.FormattingEnabled = true;
            this.Lst_ventas.Location = new System.Drawing.Point(708, 12);
            this.Lst_ventas.Name = "Lst_ventas";
            this.Lst_ventas.Size = new System.Drawing.Size(420, 303);
            this.Lst_ventas.TabIndex = 35;
            this.Lst_ventas.SelectedIndexChanged += new System.EventHandler(this.Lst_ventas_SelectedIndexChanged);
            // 
            // Btn_empleados
            // 
            this.Btn_empleados.Location = new System.Drawing.Point(3, 94);
            this.Btn_empleados.Name = "Btn_empleados";
            this.Btn_empleados.Size = new System.Drawing.Size(143, 23);
            this.Btn_empleados.TabIndex = 4;
            this.Btn_empleados.Text = "empleados";
            this.Btn_empleados.UseVisualStyleBackColor = true;
            this.Btn_empleados.Click += new System.EventHandler(this.Btn_empleados_Click);
            // 
            // Btn_nueva_venta
            // 
            this.Btn_nueva_venta.Location = new System.Drawing.Point(3, 40);
            this.Btn_nueva_venta.Name = "Btn_nueva_venta";
            this.Btn_nueva_venta.Size = new System.Drawing.Size(143, 19);
            this.Btn_nueva_venta.TabIndex = 2;
            this.Btn_nueva_venta.Text = "NUEVA VENTA";
            this.Btn_nueva_venta.UseVisualStyleBackColor = true;
            this.Btn_nueva_venta.Click += new System.EventHandler(this.Btn_nueva_venta_Click);
            // 
            // Btn_crear_cod_bar
            // 
            this.Btn_crear_cod_bar.Location = new System.Drawing.Point(3, 11);
            this.Btn_crear_cod_bar.Name = "Btn_crear_cod_bar";
            this.Btn_crear_cod_bar.Size = new System.Drawing.Size(143, 23);
            this.Btn_crear_cod_bar.TabIndex = 1;
            this.Btn_crear_cod_bar.Text = "crear codigo barras";
            this.Btn_crear_cod_bar.UseVisualStyleBackColor = true;
            this.Btn_crear_cod_bar.Click += new System.EventHandler(this.Btn_crear_cod_bar_Click);
            // 
            // Btn_canbio_precios
            // 
            this.Btn_canbio_precios.Location = new System.Drawing.Point(3, 152);
            this.Btn_canbio_precios.Name = "Btn_canbio_precios";
            this.Btn_canbio_precios.Size = new System.Drawing.Size(143, 21);
            this.Btn_canbio_precios.TabIndex = 6;
            this.Btn_canbio_precios.Text = " cambio de informacion";
            this.Btn_canbio_precios.UseVisualStyleBackColor = true;
            this.Btn_canbio_precios.Click += new System.EventHandler(this.Btn_canbio_precios_Click);
            // 
            // chrt_ventas
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_ventas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_ventas.Legends.Add(legend1);
            this.chrt_ventas.Location = new System.Drawing.Point(156, 11);
            this.chrt_ventas.Name = "chrt_ventas";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrt_ventas.Series.Add(series1);
            this.chrt_ventas.Size = new System.Drawing.Size(403, 300);
            this.chrt_ventas.TabIndex = 19;
            this.chrt_ventas.Text = "ventas";
            // 
            // btn_inventario
            // 
            this.btn_inventario.Location = new System.Drawing.Point(3, 211);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(143, 23);
            this.btn_inventario.TabIndex = 54;
            this.btn_inventario.Text = "inventario";
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_igualar_provedores
            // 
            this.btn_igualar_provedores.Location = new System.Drawing.Point(3, 343);
            this.btn_igualar_provedores.Name = "btn_igualar_provedores";
            this.btn_igualar_provedores.Size = new System.Drawing.Size(75, 35);
            this.btn_igualar_provedores.TabIndex = 55;
            this.btn_igualar_provedores.Text = "igualar provedores";
            this.btn_igualar_provedores.UseVisualStyleBackColor = true;
            this.btn_igualar_provedores.Click += new System.EventHandler(this.btn_igualar_provedores_Click);
            // 
            // btn_inv_merc
            // 
            this.btn_inv_merc.Location = new System.Drawing.Point(3, 239);
            this.btn_inv_merc.Name = "btn_inv_merc";
            this.btn_inv_merc.Size = new System.Drawing.Size(143, 23);
            this.btn_inv_merc.TabIndex = 56;
            this.btn_inv_merc.Text = "investigacion de mercado";
            this.btn_inv_merc.UseVisualStyleBackColor = true;
            this.btn_inv_merc.Click += new System.EventHandler(this.btn_inv_merc_Click);
            // 
            // btn_pedidos
            // 
            this.btn_pedidos.Location = new System.Drawing.Point(3, 268);
            this.btn_pedidos.Name = "btn_pedidos";
            this.btn_pedidos.Size = new System.Drawing.Size(143, 23);
            this.btn_pedidos.TabIndex = 57;
            this.btn_pedidos.Text = "pedidos";
            this.btn_pedidos.UseVisualStyleBackColor = true;
            this.btn_pedidos.Click += new System.EventHandler(this.btn_pedidos_Click_1);
            // 
            // Area_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 378);
            this.Controls.Add(this.btn_pedidos);
            this.Controls.Add(this.btn_inv_merc);
            this.Controls.Add(this.btn_igualar_provedores);
            this.Controls.Add(this.btn_inventario);
            this.Controls.Add(this.Btn_canbio_precios);
            this.Controls.Add(this.chrt_ventas);
            this.Controls.Add(this.Lbl_ganancia);
            this.Controls.Add(this.Txt_ganancia);
            this.Controls.Add(this.Btn_ganancias);
            this.Controls.Add(this.Rdb_gastos);
            this.Controls.Add(this.Rdb_productos);
            this.Controls.Add(this.Rdb_ventas);
            this.Controls.Add(this.Btn_comparar);
            this.Controls.Add(this.Btn_compras);
            this.Controls.Add(this.Btn_respaldo);
            this.Controls.Add(this.Btn_gastos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_dia);
            this.Controls.Add(this.cmb_año);
            this.Controls.Add(this.cmb_mes);
            this.Controls.Add(this.Lst_ventas);
            this.Controls.Add(this.Btn_empleados);
            this.Controls.Add(this.Btn_nueva_venta);
            this.Controls.Add(this.Btn_crear_cod_bar);
            this.Name = "Area_principal";
            this.Text = "Area_principal";
            ((System.ComponentModel.ISupportInitialize)(this.chrt_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ganancia;
        private System.Windows.Forms.TextBox Txt_ganancia;
        private System.Windows.Forms.Button Btn_ganancias;
        private System.Windows.Forms.RadioButton Rdb_gastos;
        private System.Windows.Forms.RadioButton Rdb_productos;
        private System.Windows.Forms.RadioButton Rdb_ventas;
        private System.Windows.Forms.Button Btn_comparar;
        private System.Windows.Forms.Button Btn_compras;
        private System.Windows.Forms.Button Btn_respaldo;
        private System.Windows.Forms.Button Btn_gastos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_dia;
        private System.Windows.Forms.ComboBox cmb_año;
        private System.Windows.Forms.ComboBox cmb_mes;
        public System.Windows.Forms.ListBox Lst_ventas;
        private System.Windows.Forms.Button Btn_empleados;
        private System.Windows.Forms.Button Btn_nueva_venta;
        private System.Windows.Forms.Button Btn_crear_cod_bar;
        private System.Windows.Forms.Button Btn_canbio_precios;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_ventas;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_igualar_provedores;
        private System.Windows.Forms.Button btn_inv_merc;
        private System.Windows.Forms.Button btn_pedidos;
    }
}