﻿namespace tienda2.desinger
{
    partial class Cambiar_precio
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
            this.Lbl_precio_venta = new System.Windows.Forms.Label();
            this.Lbl_prcio_vnt = new System.Windows.Forms.Label();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Lbl_producto = new System.Windows.Forms.Label();
            this.Lbl_nombre_producto = new System.Windows.Forms.Label();
            this.Txt_buscar_producto = new System.Windows.Forms.TextBox();
            this.Lbl_precio_compra_cant = new System.Windows.Forms.Label();
            this.Lbl_precio_compra = new System.Windows.Forms.Label();
            this.Lbl_cantidad_cant = new System.Windows.Forms.Label();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.Rdb_compra = new System.Windows.Forms.RadioButton();
            this.Rdb_venta = new System.Windows.Forms.RadioButton();
            this.Rdb_inventario = new System.Windows.Forms.RadioButton();
            this.Rdb_producto = new System.Windows.Forms.RadioButton();
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
            this.Txt_remplazo.Location = new System.Drawing.Point(557, 60);
            this.Txt_remplazo.Name = "Txt_remplazo";
            this.Txt_remplazo.Size = new System.Drawing.Size(100, 20);
            this.Txt_remplazo.TabIndex = 3;
            this.Txt_remplazo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_remplazo_PreviewKeyDown);
            // 
            // Lbl_nuevo_cantidad
            // 
            this.Lbl_nuevo_cantidad.AutoSize = true;
            this.Lbl_nuevo_cantidad.Location = new System.Drawing.Point(554, 44);
            this.Lbl_nuevo_cantidad.Name = "Lbl_nuevo_cantidad";
            this.Lbl_nuevo_cantidad.Size = new System.Drawing.Size(94, 13);
            this.Lbl_nuevo_cantidad.TabIndex = 14;
            this.Lbl_nuevo_cantidad.Text = "nueva informacion";
            // 
            // Lbl_precio_venta
            // 
            this.Lbl_precio_venta.AutoSize = true;
            this.Lbl_precio_venta.Location = new System.Drawing.Point(360, 70);
            this.Lbl_precio_venta.Name = "Lbl_precio_venta";
            this.Lbl_precio_venta.Size = new System.Drawing.Size(13, 13);
            this.Lbl_precio_venta.TabIndex = 8;
            this.Lbl_precio_venta.Text = "$";
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
            this.Btn_editar.Location = new System.Drawing.Point(678, 58);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 23);
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
            // Lbl_nombre_producto
            // 
            this.Lbl_nombre_producto.AutoSize = true;
            this.Lbl_nombre_producto.Location = new System.Drawing.Point(137, 67);
            this.Lbl_nombre_producto.Name = "Lbl_nombre_producto";
            this.Lbl_nombre_producto.Size = new System.Drawing.Size(87, 13);
            this.Lbl_nombre_producto.TabIndex = 4;
            this.Lbl_nombre_producto.Text = "nombre producto";
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
            // Lbl_precio_compra_cant
            // 
            this.Lbl_precio_compra_cant.AutoSize = true;
            this.Lbl_precio_compra_cant.Location = new System.Drawing.Point(276, 70);
            this.Lbl_precio_compra_cant.Name = "Lbl_precio_compra_cant";
            this.Lbl_precio_compra_cant.Size = new System.Drawing.Size(13, 13);
            this.Lbl_precio_compra_cant.TabIndex = 6;
            this.Lbl_precio_compra_cant.Text = "$";
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
            // Lbl_cantidad_cant
            // 
            this.Lbl_cantidad_cant.AutoSize = true;
            this.Lbl_cantidad_cant.Location = new System.Drawing.Point(445, 70);
            this.Lbl_cantidad_cant.Name = "Lbl_cantidad_cant";
            this.Lbl_cantidad_cant.Size = new System.Drawing.Size(13, 13);
            this.Lbl_cantidad_cant.TabIndex = 10;
            this.Lbl_cantidad_cant.Text = "$";
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
            // 
            // cambiar_precio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 139);
            this.Controls.Add(this.Rdb_producto);
            this.Controls.Add(this.Rdb_inventario);
            this.Controls.Add(this.Rdb_venta);
            this.Controls.Add(this.Rdb_compra);
            this.Controls.Add(this.Txt_buscar_producto);
            this.Controls.Add(this.Lbl_nombre_producto);
            this.Controls.Add(this.Lbl_producto);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Lbl_cantidad);
            this.Controls.Add(this.Lbl_cantidad_cant);
            this.Controls.Add(this.Lbl_precio_compra);
            this.Controls.Add(this.Lbl_precio_compra_cant);
            this.Controls.Add(this.Lbl_prcio_vnt);
            this.Controls.Add(this.Lbl_precio_venta);
            this.Controls.Add(this.Lbl_nuevo_cantidad);
            this.Controls.Add(this.Txt_remplazo);
            this.Controls.Add(this.Lbl_codigo);
            this.Name = "cambiar_precio";
            this.Text = "cambiar_precio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.TextBox Txt_remplazo;
        private System.Windows.Forms.Label Lbl_nuevo_cantidad;
        private System.Windows.Forms.Label Lbl_precio_venta;
        private System.Windows.Forms.Label Lbl_prcio_vnt;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Label Lbl_producto;
        private System.Windows.Forms.Label Lbl_nombre_producto;
        private System.Windows.Forms.TextBox Txt_buscar_producto;
        private System.Windows.Forms.Label Lbl_precio_compra_cant;
        private System.Windows.Forms.Label Lbl_precio_compra;
        private System.Windows.Forms.Label Lbl_cantidad_cant;
        private System.Windows.Forms.Label Lbl_cantidad;
        private System.Windows.Forms.RadioButton Rdb_compra;
        private System.Windows.Forms.RadioButton Rdb_venta;
        private System.Windows.Forms.RadioButton Rdb_inventario;
        private System.Windows.Forms.RadioButton Rdb_producto;
    }
}