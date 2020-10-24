namespace tienda2.desinger
{
    partial class Ventas
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
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.pb_product = new System.Windows.Forms.PictureBox();
            this.Btn_elim_ultimo = new System.Windows.Forms.Button();
            this.Btn_procesar_venta = new System.Windows.Forms.Button();
            this.Btn_eliminar_todo = new System.Windows.Forms.Button();
            this.Btn_eliminar_seleccionado = new System.Windows.Forms.Button();
            this.Lst_ventas = new System.Windows.Forms.ListBox();
            this.Txt_buscar_producto = new System.Windows.Forms.TextBox();
            this.Txt_nom_producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_nom_product_list = new System.Windows.Forms.Label();
            this.Lbl_costo_product_list = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_product)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuenta.Location = new System.Drawing.Point(207, 328);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_cuenta.Size = new System.Drawing.Size(24, 25);
            this.Lbl_cuenta.TabIndex = 11;
            this.Lbl_cuenta.Text = "$";
            // 
            // pb_product
            // 
            this.pb_product.Location = new System.Drawing.Point(254, 15);
            this.pb_product.Name = "pb_product";
            this.pb_product.Size = new System.Drawing.Size(103, 95);
            this.pb_product.TabIndex = 15;
            this.pb_product.TabStop = false;
            // 
            // Btn_elim_ultimo
            // 
            this.Btn_elim_ultimo.Location = new System.Drawing.Point(257, 197);
            this.Btn_elim_ultimo.Name = "Btn_elim_ultimo";
            this.Btn_elim_ultimo.Size = new System.Drawing.Size(75, 40);
            this.Btn_elim_ultimo.TabIndex = 12;
            this.Btn_elim_ultimo.Text = "eliminar ultimo";
            this.Btn_elim_ultimo.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo.Click += new System.EventHandler(this.Btn_elim_ultimo_Click);
            // 
            // Btn_procesar_venta
            // 
            this.Btn_procesar_venta.Location = new System.Drawing.Point(257, 243);
            this.Btn_procesar_venta.Name = "Btn_procesar_venta";
            this.Btn_procesar_venta.Size = new System.Drawing.Size(75, 23);
            this.Btn_procesar_venta.TabIndex = 9;
            this.Btn_procesar_venta.Text = "procesar venta";
            this.Btn_procesar_venta.UseVisualStyleBackColor = true;
            this.Btn_procesar_venta.Click += new System.EventHandler(this.Btn_procesar_venta_Click);
            // 
            // Btn_eliminar_todo
            // 
            this.Btn_eliminar_todo.Location = new System.Drawing.Point(257, 164);
            this.Btn_eliminar_todo.Name = "Btn_eliminar_todo";
            this.Btn_eliminar_todo.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar_todo.TabIndex = 13;
            this.Btn_eliminar_todo.Text = "eliminar todo";
            this.Btn_eliminar_todo.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo.Click += new System.EventHandler(this.Btn_eliminar_todo_Click);
            // 
            // Btn_eliminar_seleccionado
            // 
            this.Btn_eliminar_seleccionado.Location = new System.Drawing.Point(257, 116);
            this.Btn_eliminar_seleccionado.Name = "Btn_eliminar_seleccionado";
            this.Btn_eliminar_seleccionado.Size = new System.Drawing.Size(86, 42);
            this.Btn_eliminar_seleccionado.TabIndex = 14;
            this.Btn_eliminar_seleccionado.Text = "eliminar seleccionado";
            this.Btn_eliminar_seleccionado.UseVisualStyleBackColor = true;
            this.Btn_eliminar_seleccionado.Click += new System.EventHandler(this.Btn_eliminar_seleccionado_Click);
            // 
            // Lst_ventas
            // 
            this.Lst_ventas.FormattingEnabled = true;
            this.Lst_ventas.Location = new System.Drawing.Point(12, 12);
            this.Lst_ventas.Name = "Lst_ventas";
            this.Lst_ventas.Size = new System.Drawing.Size(239, 251);
            this.Lst_ventas.TabIndex = 16;
            this.Lst_ventas.SelectedIndexChanged += new System.EventHandler(this.Lst_ventas_SelectedIndexChanged);
            // 
            // Txt_buscar_producto
            // 
            this.Txt_buscar_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_buscar_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_buscar_producto.Location = new System.Drawing.Point(54, 307);
            this.Txt_buscar_producto.Name = "Txt_buscar_producto";
            this.Txt_buscar_producto.Size = new System.Drawing.Size(150, 20);
            this.Txt_buscar_producto.TabIndex = 8;
            this.Txt_buscar_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_buscar_producto_PreviewKeyDown);
            // 
            // Txt_nom_producto
            // 
            this.Txt_nom_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_nom_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_nom_producto.Location = new System.Drawing.Point(54, 333);
            this.Txt_nom_producto.Name = "Txt_nom_producto";
            this.Txt_nom_producto.Size = new System.Drawing.Size(150, 20);
            this.Txt_nom_producto.TabIndex = 15;
            this.Txt_nom_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_nom_producto_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "TOTAL";
            // 
            // Lbl_nom_product_list
            // 
            this.Lbl_nom_product_list.AutoSize = true;
            this.Lbl_nom_product_list.Location = new System.Drawing.Point(9, 266);
            this.Lbl_nom_product_list.Name = "Lbl_nom_product_list";
            this.Lbl_nom_product_list.Size = new System.Drawing.Size(104, 13);
            this.Lbl_nom_product_list.TabIndex = 19;
            this.Lbl_nom_product_list.Text = "nombre del producto";
            // 
            // Lbl_costo_product_list
            // 
            this.Lbl_costo_product_list.AutoSize = true;
            this.Lbl_costo_product_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_costo_product_list.Location = new System.Drawing.Point(12, 279);
            this.Lbl_costo_product_list.Name = "Lbl_costo_product_list";
            this.Lbl_costo_product_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_costo_product_list.Size = new System.Drawing.Size(24, 25);
            this.Lbl_costo_product_list.TabIndex = 11;
            this.Lbl_costo_product_list.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-254, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "nombre del producto";
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 359);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_nom_product_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_costo_product_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_cuenta);
            this.Controls.Add(this.pb_product);
            this.Controls.Add(this.Btn_elim_ultimo);
            this.Controls.Add(this.Btn_procesar_venta);
            this.Controls.Add(this.Btn_eliminar_todo);
            this.Controls.Add(this.Btn_eliminar_seleccionado);
            this.Controls.Add(this.Lst_ventas);
            this.Controls.Add(this.Txt_nom_producto);
            this.Controls.Add(this.Txt_buscar_producto);
            this.Name = "ventas";
            this.Text = "ventas";
            ((System.ComponentModel.ISupportInitialize)(this.pb_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.PictureBox pb_product;
        private System.Windows.Forms.Button Btn_elim_ultimo;
        private System.Windows.Forms.Button Btn_procesar_venta;
        private System.Windows.Forms.Button Btn_eliminar_todo;
        private System.Windows.Forms.Button Btn_eliminar_seleccionado;
        private System.Windows.Forms.ListBox Lst_ventas;
        private System.Windows.Forms.TextBox Txt_buscar_producto;
        private System.Windows.Forms.TextBox Txt_nom_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_nom_product_list;
        private System.Windows.Forms.Label Lbl_costo_product_list;
        private System.Windows.Forms.Label label5;
    }
}