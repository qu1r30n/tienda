namespace tienda2.desinger
{
    partial class cambiar_precio
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_remplazo = new System.Windows.Forms.TextBox();
            this.lbl_nuevo_cantidad = new System.Windows.Forms.Label();
            this.lbl_precio_venta = new System.Windows.Forms.Label();
            this.lbl_prcio_vnt = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.txt_buscar_producto = new System.Windows.Forms.TextBox();
            this.lbl_precio_compra_cant = new System.Windows.Forms.Label();
            this.lbl_precio_compra = new System.Windows.Forms.Label();
            this.lbl_cantidad_cant = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.rdb_compra = new System.Windows.Forms.RadioButton();
            this.rdb_venta = new System.Windows.Forms.RadioButton();
            this.rdb_inventario = new System.Windows.Forms.RadioButton();
            this.rdb_producto = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(12, 47);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(86, 13);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "codigo de barras";
            // 
            // txt_remplazo
            // 
            this.txt_remplazo.Location = new System.Drawing.Point(557, 60);
            this.txt_remplazo.Name = "txt_remplazo";
            this.txt_remplazo.Size = new System.Drawing.Size(100, 20);
            this.txt_remplazo.TabIndex = 3;
            this.txt_remplazo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_remplazo_PreviewKeyDown);
            // 
            // lbl_nuevo_cantidad
            // 
            this.lbl_nuevo_cantidad.AutoSize = true;
            this.lbl_nuevo_cantidad.Location = new System.Drawing.Point(554, 44);
            this.lbl_nuevo_cantidad.Name = "lbl_nuevo_cantidad";
            this.lbl_nuevo_cantidad.Size = new System.Drawing.Size(94, 13);
            this.lbl_nuevo_cantidad.TabIndex = 14;
            this.lbl_nuevo_cantidad.Text = "nueva informacion";
            // 
            // lbl_precio_venta
            // 
            this.lbl_precio_venta.AutoSize = true;
            this.lbl_precio_venta.Location = new System.Drawing.Point(360, 70);
            this.lbl_precio_venta.Name = "lbl_precio_venta";
            this.lbl_precio_venta.Size = new System.Drawing.Size(13, 13);
            this.lbl_precio_venta.TabIndex = 8;
            this.lbl_precio_venta.Text = "$";
            // 
            // lbl_prcio_vnt
            // 
            this.lbl_prcio_vnt.AutoSize = true;
            this.lbl_prcio_vnt.Location = new System.Drawing.Point(360, 47);
            this.lbl_prcio_vnt.Name = "lbl_prcio_vnt";
            this.lbl_prcio_vnt.Size = new System.Drawing.Size(66, 13);
            this.lbl_prcio_vnt.TabIndex = 7;
            this.lbl_prcio_vnt.Text = "precio venta";
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(678, 58);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "cambiar precio";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(137, 47);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(49, 13);
            this.lbl_producto.TabIndex = 3;
            this.lbl_producto.Text = "producto";
            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Location = new System.Drawing.Point(137, 67);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(87, 13);
            this.lbl_nombre_producto.TabIndex = 4;
            this.lbl_nombre_producto.Text = "nombre producto";
            // 
            // txt_buscar_producto
            // 
            this.txt_buscar_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_buscar_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_buscar_producto.Location = new System.Drawing.Point(12, 63);
            this.txt_buscar_producto.Name = "txt_buscar_producto";
            this.txt_buscar_producto.Size = new System.Drawing.Size(119, 20);
            this.txt_buscar_producto.TabIndex = 1;
            this.txt_buscar_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_buscar_producto_PreviewKeyDown);
            // 
            // lbl_precio_compra_cant
            // 
            this.lbl_precio_compra_cant.AutoSize = true;
            this.lbl_precio_compra_cant.Location = new System.Drawing.Point(276, 70);
            this.lbl_precio_compra_cant.Name = "lbl_precio_compra_cant";
            this.lbl_precio_compra_cant.Size = new System.Drawing.Size(13, 13);
            this.lbl_precio_compra_cant.TabIndex = 6;
            this.lbl_precio_compra_cant.Text = "$";
            // 
            // lbl_precio_compra
            // 
            this.lbl_precio_compra.AutoSize = true;
            this.lbl_precio_compra.Location = new System.Drawing.Point(276, 47);
            this.lbl_precio_compra.Name = "lbl_precio_compra";
            this.lbl_precio_compra.Size = new System.Drawing.Size(74, 13);
            this.lbl_precio_compra.TabIndex = 5;
            this.lbl_precio_compra.Text = "precio compra";
            // 
            // lbl_cantidad_cant
            // 
            this.lbl_cantidad_cant.AutoSize = true;
            this.lbl_cantidad_cant.Location = new System.Drawing.Point(445, 70);
            this.lbl_cantidad_cant.Name = "lbl_cantidad_cant";
            this.lbl_cantidad_cant.Size = new System.Drawing.Size(13, 13);
            this.lbl_cantidad_cant.TabIndex = 10;
            this.lbl_cantidad_cant.Text = "$";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(445, 47);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(97, 13);
            this.lbl_cantidad.TabIndex = 9;
            this.lbl_cantidad.Text = "cantidad inventario";
            // 
            // rdb_compra
            // 
            this.rdb_compra.AutoSize = true;
            this.rdb_compra.Location = new System.Drawing.Point(279, 110);
            this.rdb_compra.Name = "rdb_compra";
            this.rdb_compra.Size = new System.Drawing.Size(60, 17);
            this.rdb_compra.TabIndex = 11;
            this.rdb_compra.TabStop = true;
            this.rdb_compra.Text = "compra";
            this.rdb_compra.UseVisualStyleBackColor = true;
            // 
            // rdb_venta
            // 
            this.rdb_venta.AutoSize = true;
            this.rdb_venta.Location = new System.Drawing.Point(363, 110);
            this.rdb_venta.Name = "rdb_venta";
            this.rdb_venta.Size = new System.Drawing.Size(52, 17);
            this.rdb_venta.TabIndex = 12;
            this.rdb_venta.TabStop = true;
            this.rdb_venta.Text = "venta";
            this.rdb_venta.UseVisualStyleBackColor = true;
            // 
            // rdb_inventario
            // 
            this.rdb_inventario.AutoSize = true;
            this.rdb_inventario.Location = new System.Drawing.Point(448, 110);
            this.rdb_inventario.Name = "rdb_inventario";
            this.rdb_inventario.Size = new System.Drawing.Size(71, 17);
            this.rdb_inventario.TabIndex = 13;
            this.rdb_inventario.TabStop = true;
            this.rdb_inventario.Text = "inventario";
            this.rdb_inventario.UseVisualStyleBackColor = true;
            // 
            // rdb_producto
            // 
            this.rdb_producto.AutoSize = true;
            this.rdb_producto.Location = new System.Drawing.Point(140, 110);
            this.rdb_producto.Name = "rdb_producto";
            this.rdb_producto.Size = new System.Drawing.Size(67, 17);
            this.rdb_producto.TabIndex = 15;
            this.rdb_producto.TabStop = true;
            this.rdb_producto.Text = "producto";
            this.rdb_producto.UseVisualStyleBackColor = true;
            // 
            // cambiar_precio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 139);
            this.Controls.Add(this.rdb_producto);
            this.Controls.Add(this.rdb_inventario);
            this.Controls.Add(this.rdb_venta);
            this.Controls.Add(this.rdb_compra);
            this.Controls.Add(this.txt_buscar_producto);
            this.Controls.Add(this.lbl_nombre_producto);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_cantidad_cant);
            this.Controls.Add(this.lbl_precio_compra);
            this.Controls.Add(this.lbl_precio_compra_cant);
            this.Controls.Add(this.lbl_prcio_vnt);
            this.Controls.Add(this.lbl_precio_venta);
            this.Controls.Add(this.lbl_nuevo_cantidad);
            this.Controls.Add(this.txt_remplazo);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "cambiar_precio";
            this.Text = "cambiar_precio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_remplazo;
        private System.Windows.Forms.Label lbl_nuevo_cantidad;
        private System.Windows.Forms.Label lbl_precio_venta;
        private System.Windows.Forms.Label lbl_prcio_vnt;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label lbl_nombre_producto;
        private System.Windows.Forms.TextBox txt_buscar_producto;
        private System.Windows.Forms.Label lbl_precio_compra_cant;
        private System.Windows.Forms.Label lbl_precio_compra;
        private System.Windows.Forms.Label lbl_cantidad_cant;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.RadioButton rdb_compra;
        private System.Windows.Forms.RadioButton rdb_venta;
        private System.Windows.Forms.RadioButton rdb_inventario;
        private System.Windows.Forms.RadioButton rdb_producto;
    }
}