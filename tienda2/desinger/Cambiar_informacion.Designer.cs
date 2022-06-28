namespace tienda2.desinger
{
    partial class Cambiar_informacion
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
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.Txt_remplazo = new System.Windows.Forms.TextBox();
            this.Lbl_nuevo_cantidad = new System.Windows.Forms.Label();
            this.Lbl_precio_venta_camb = new System.Windows.Forms.Label();
            this.Lbl_prcio_vnt = new System.Windows.Forms.Label();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Lbl_producto = new System.Windows.Forms.Label();
            this.Lbl_nombre_producto_camb = new System.Windows.Forms.Label();
            this.Txt_buscar_producto = new System.Windows.Forms.TextBox();
            this.Lbl_precio_compra_canb = new System.Windows.Forms.Label();
            this.Lbl_precio_compra = new System.Windows.Forms.Label();
            this.Lbl_cantidad_canb = new System.Windows.Forms.Label();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.Rdb_compra = new System.Windows.Forms.RadioButton();
            this.Rdb_venta = new System.Windows.Forms.RadioButton();
            this.Rdb_inventario = new System.Windows.Forms.RadioButton();
            this.Rdb_producto = new System.Windows.Forms.RadioButton();
            this.Lbl_provedor_camb = new System.Windows.Forms.Label();
            this.Lbl_provedor = new System.Windows.Forms.Label();
            this.Rdb_provedor = new System.Windows.Forms.RadioButton();
            this.chb_no_vacio = new System.Windows.Forms.CheckBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.chb_suma_si_ya_paso_producto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.Location = new System.Drawing.Point(12, 47);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(86, 13);
            this.Lbl_codigo.TabIndex = 1;
            this.Lbl_codigo.Text = "codigo de barras";
            // 
            // Txt_remplazo
            // 
            this.Txt_remplazo.Location = new System.Drawing.Point(668, 60);
            this.Txt_remplazo.Name = "Txt_remplazo";
            this.Txt_remplazo.Size = new System.Drawing.Size(100, 20);
            this.Txt_remplazo.TabIndex = 3;
            this.Txt_remplazo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_remplazo_PreviewKeyDown);
            // 
            // Lbl_nuevo_cantidad
            // 
            this.Lbl_nuevo_cantidad.AutoSize = true;
            this.Lbl_nuevo_cantidad.Location = new System.Drawing.Point(665, 44);
            this.Lbl_nuevo_cantidad.Name = "Lbl_nuevo_cantidad";
            this.Lbl_nuevo_cantidad.Size = new System.Drawing.Size(94, 13);
            this.Lbl_nuevo_cantidad.TabIndex = 14;
            this.Lbl_nuevo_cantidad.Text = "nueva informacion";
            // 
            // Lbl_precio_venta_camb
            // 
            this.Lbl_precio_venta_camb.AutoSize = true;
            this.Lbl_precio_venta_camb.Location = new System.Drawing.Point(360, 70);
            this.Lbl_precio_venta_camb.Name = "Lbl_precio_venta_camb";
            this.Lbl_precio_venta_camb.Size = new System.Drawing.Size(13, 13);
            this.Lbl_precio_venta_camb.TabIndex = 8;
            this.Lbl_precio_venta_camb.Text = "$";
            // 
            // Lbl_prcio_vnt
            // 
            this.Lbl_prcio_vnt.AutoSize = true;
            this.Lbl_prcio_vnt.Location = new System.Drawing.Point(360, 47);
            this.Lbl_prcio_vnt.Name = "Lbl_prcio_vnt";
            this.Lbl_prcio_vnt.Size = new System.Drawing.Size(66, 13);
            this.Lbl_prcio_vnt.TabIndex = 7;
            this.Lbl_prcio_vnt.Text = "precio venta";
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(789, 31);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 50);
            this.Btn_editar.TabIndex = 4;
            this.Btn_editar.Text = "cambiar precio";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Lbl_producto
            // 
            this.Lbl_producto.AutoSize = true;
            this.Lbl_producto.Location = new System.Drawing.Point(137, 47);
            this.Lbl_producto.Name = "Lbl_producto";
            this.Lbl_producto.Size = new System.Drawing.Size(49, 13);
            this.Lbl_producto.TabIndex = 3;
            this.Lbl_producto.Text = "producto";
            // 
            // Lbl_nombre_producto_camb
            // 
            this.Lbl_nombre_producto_camb.AutoSize = true;
            this.Lbl_nombre_producto_camb.Location = new System.Drawing.Point(137, 67);
            this.Lbl_nombre_producto_camb.Name = "Lbl_nombre_producto_camb";
            this.Lbl_nombre_producto_camb.Size = new System.Drawing.Size(87, 13);
            this.Lbl_nombre_producto_camb.TabIndex = 4;
            this.Lbl_nombre_producto_camb.Text = "nombre producto";
            // 
            // Txt_buscar_producto
            // 
            this.Txt_buscar_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_buscar_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_buscar_producto.Location = new System.Drawing.Point(12, 63);
            this.Txt_buscar_producto.Name = "Txt_buscar_producto";
            this.Txt_buscar_producto.Size = new System.Drawing.Size(119, 20);
            this.Txt_buscar_producto.TabIndex = 1;
            this.Txt_buscar_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_buscar_producto_PreviewKeyDown);
            // 
            // Lbl_precio_compra_canb
            // 
            this.Lbl_precio_compra_canb.AutoSize = true;
            this.Lbl_precio_compra_canb.Location = new System.Drawing.Point(276, 70);
            this.Lbl_precio_compra_canb.Name = "Lbl_precio_compra_canb";
            this.Lbl_precio_compra_canb.Size = new System.Drawing.Size(13, 13);
            this.Lbl_precio_compra_canb.TabIndex = 6;
            this.Lbl_precio_compra_canb.Text = "$";
            // 
            // Lbl_precio_compra
            // 
            this.Lbl_precio_compra.AutoSize = true;
            this.Lbl_precio_compra.Location = new System.Drawing.Point(276, 47);
            this.Lbl_precio_compra.Name = "Lbl_precio_compra";
            this.Lbl_precio_compra.Size = new System.Drawing.Size(74, 13);
            this.Lbl_precio_compra.TabIndex = 5;
            this.Lbl_precio_compra.Text = "precio compra";
            // 
            // Lbl_cantidad_canb
            // 
            this.Lbl_cantidad_canb.AutoSize = true;
            this.Lbl_cantidad_canb.Location = new System.Drawing.Point(445, 70);
            this.Lbl_cantidad_canb.Name = "Lbl_cantidad_canb";
            this.Lbl_cantidad_canb.Size = new System.Drawing.Size(13, 13);
            this.Lbl_cantidad_canb.TabIndex = 10;
            this.Lbl_cantidad_canb.Text = "$";
            // 
            // Lbl_cantidad
            // 
            this.Lbl_cantidad.AutoSize = true;
            this.Lbl_cantidad.Location = new System.Drawing.Point(445, 47);
            this.Lbl_cantidad.Name = "Lbl_cantidad";
            this.Lbl_cantidad.Size = new System.Drawing.Size(97, 13);
            this.Lbl_cantidad.TabIndex = 9;
            this.Lbl_cantidad.Text = "cantidad inventario";
            // 
            // Rdb_compra
            // 
            this.Rdb_compra.AutoSize = true;
            this.Rdb_compra.Location = new System.Drawing.Point(279, 110);
            this.Rdb_compra.Name = "Rdb_compra";
            this.Rdb_compra.Size = new System.Drawing.Size(60, 17);
            this.Rdb_compra.TabIndex = 11;
            this.Rdb_compra.TabStop = true;
            this.Rdb_compra.Text = "compra";
            this.Rdb_compra.UseVisualStyleBackColor = true;
            this.Rdb_compra.CheckedChanged += new System.EventHandler(this.Rdb_compra_CheckedChanged);
            // 
            // Rdb_venta
            // 
            this.Rdb_venta.AutoSize = true;
            this.Rdb_venta.Location = new System.Drawing.Point(363, 110);
            this.Rdb_venta.Name = "Rdb_venta";
            this.Rdb_venta.Size = new System.Drawing.Size(52, 17);
            this.Rdb_venta.TabIndex = 12;
            this.Rdb_venta.TabStop = true;
            this.Rdb_venta.Text = "venta";
            this.Rdb_venta.UseVisualStyleBackColor = true;
            this.Rdb_venta.CheckedChanged += new System.EventHandler(this.Rdb_venta_CheckedChanged);
            // 
            // Rdb_inventario
            // 
            this.Rdb_inventario.AutoSize = true;
            this.Rdb_inventario.Location = new System.Drawing.Point(448, 110);
            this.Rdb_inventario.Name = "Rdb_inventario";
            this.Rdb_inventario.Size = new System.Drawing.Size(71, 17);
            this.Rdb_inventario.TabIndex = 13;
            this.Rdb_inventario.TabStop = true;
            this.Rdb_inventario.Text = "inventario";
            this.Rdb_inventario.UseVisualStyleBackColor = true;
            this.Rdb_inventario.CheckedChanged += new System.EventHandler(this.Rdb_inventario_CheckedChanged);
            // 
            // Rdb_producto
            // 
            this.Rdb_producto.AutoSize = true;
            this.Rdb_producto.Location = new System.Drawing.Point(140, 110);
            this.Rdb_producto.Name = "Rdb_producto";
            this.Rdb_producto.Size = new System.Drawing.Size(67, 17);
            this.Rdb_producto.TabIndex = 15;
            this.Rdb_producto.TabStop = true;
            this.Rdb_producto.Text = "producto";
            this.Rdb_producto.UseVisualStyleBackColor = true;
            this.Rdb_producto.CheckedChanged += new System.EventHandler(this.Rdb_producto_CheckedChanged);
            // 
            // Lbl_provedor_camb
            // 
            this.Lbl_provedor_camb.AutoSize = true;
            this.Lbl_provedor_camb.Location = new System.Drawing.Point(548, 70);
            this.Lbl_provedor_camb.Name = "Lbl_provedor_camb";
            this.Lbl_provedor_camb.Size = new System.Drawing.Size(104, 13);
            this.Lbl_provedor_camb.TabIndex = 10;
            this.Lbl_provedor_camb.Text = "nombre del provedor";
            // 
            // Lbl_provedor
            // 
            this.Lbl_provedor.AutoSize = true;
            this.Lbl_provedor.Location = new System.Drawing.Point(548, 47);
            this.Lbl_provedor.Name = "Lbl_provedor";
            this.Lbl_provedor.Size = new System.Drawing.Size(49, 13);
            this.Lbl_provedor.TabIndex = 9;
            this.Lbl_provedor.Text = "provedor";
            // 
            // Rdb_provedor
            // 
            this.Rdb_provedor.AutoSize = true;
            this.Rdb_provedor.Location = new System.Drawing.Point(551, 110);
            this.Rdb_provedor.Name = "Rdb_provedor";
            this.Rdb_provedor.Size = new System.Drawing.Size(67, 17);
            this.Rdb_provedor.TabIndex = 13;
            this.Rdb_provedor.TabStop = true;
            this.Rdb_provedor.Text = "provedor";
            this.Rdb_provedor.UseVisualStyleBackColor = true;
            this.Rdb_provedor.CheckedChanged += new System.EventHandler(this.Rdb_provedor_CheckedChanged);
            // 
            // chb_no_vacio
            // 
            this.chb_no_vacio.AutoSize = true;
            this.chb_no_vacio.Location = new System.Drawing.Point(668, 87);
            this.chb_no_vacio.Name = "chb_no_vacio";
            this.chb_no_vacio.Size = new System.Drawing.Size(90, 17);
            this.chb_no_vacio.TabIndex = 16;
            this.chb_no_vacio.Text = "no este vacio";
            this.chb_no_vacio.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(789, 88);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // chb_suma_si_ya_paso_producto
            // 
            this.chb_suma_si_ya_paso_producto.AutoSize = true;
            this.chb_suma_si_ya_paso_producto.Location = new System.Drawing.Point(668, 110);
            this.chb_suma_si_ya_paso_producto.Name = "chb_suma_si_ya_paso_producto";
            this.chb_suma_si_ya_paso_producto.Size = new System.Drawing.Size(158, 17);
            this.chb_suma_si_ya_paso_producto.TabIndex = 17;
            this.chb_suma_si_ya_paso_producto.Text = "suma_si_ya_paso_producto";
            this.chb_suma_si_ya_paso_producto.UseVisualStyleBackColor = true;
            this.chb_suma_si_ya_paso_producto.Visible = false;
            // 
            // Cambiar_precio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 139);
            this.Controls.Add(this.chb_suma_si_ya_paso_producto);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.chb_no_vacio);
            this.Controls.Add(this.Rdb_producto);
            this.Controls.Add(this.Rdb_provedor);
            this.Controls.Add(this.Rdb_inventario);
            this.Controls.Add(this.Rdb_venta);
            this.Controls.Add(this.Rdb_compra);
            this.Controls.Add(this.Txt_buscar_producto);
            this.Controls.Add(this.Lbl_nombre_producto_camb);
            this.Controls.Add(this.Lbl_producto);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Lbl_provedor);
            this.Controls.Add(this.Lbl_provedor_camb);
            this.Controls.Add(this.Lbl_cantidad);
            this.Controls.Add(this.Lbl_cantidad_canb);
            this.Controls.Add(this.Lbl_precio_compra);
            this.Controls.Add(this.Lbl_precio_compra_canb);
            this.Controls.Add(this.Lbl_prcio_vnt);
            this.Controls.Add(this.Lbl_precio_venta_camb);
            this.Controls.Add(this.Lbl_nuevo_cantidad);
            this.Controls.Add(this.Txt_remplazo);
            this.Controls.Add(this.Lbl_codigo);
            this.Name = "Cambiar_precio";
            this.Text = "cambiar_precio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.TextBox Txt_remplazo;
        private System.Windows.Forms.Label Lbl_nuevo_cantidad;
        private System.Windows.Forms.Label Lbl_precio_venta_camb;
        private System.Windows.Forms.Label Lbl_prcio_vnt;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Label Lbl_producto;
        private System.Windows.Forms.Label Lbl_nombre_producto_camb;
        private System.Windows.Forms.TextBox Txt_buscar_producto;
        private System.Windows.Forms.Label Lbl_precio_compra_canb;
        private System.Windows.Forms.Label Lbl_precio_compra;
        private System.Windows.Forms.Label Lbl_cantidad_canb;
        private System.Windows.Forms.Label Lbl_cantidad;
        private System.Windows.Forms.RadioButton Rdb_compra;
        private System.Windows.Forms.RadioButton Rdb_venta;
        private System.Windows.Forms.RadioButton Rdb_inventario;
        private System.Windows.Forms.RadioButton Rdb_producto;
        private System.Windows.Forms.Label Lbl_provedor_camb;
        private System.Windows.Forms.Label Lbl_provedor;
        private System.Windows.Forms.RadioButton Rdb_provedor;
        private System.Windows.Forms.CheckBox chb_no_vacio;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.CheckBox chb_suma_si_ya_paso_producto;
    }
}