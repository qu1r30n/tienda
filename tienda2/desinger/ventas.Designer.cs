
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarGuardadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_modo_inventario = new System.Windows.Forms.Label();
            this.btn_guardar_venta = new System.Windows.Forms.Button();
            this.lbl_ventas_compras_resultado = new System.Windows.Forms.Label();
            this.chb_ventas_compras = new System.Windows.Forms.CheckBox();
            this.Lbl_nom_product_list = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_costo_product_list = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.pb_product = new System.Windows.Forms.PictureBox();
            this.Btn_elim_ultimo = new System.Windows.Forms.Button();
            this.Btn_procesar_venta = new System.Windows.Forms.Button();
            this.Btn_eliminar_todo = new System.Windows.Forms.Button();
            this.Btn_eliminar_seleccionado = new System.Windows.Forms.Button();
            this.Lst_ventas = new System.Windows.Forms.ListBox();
            this.Txt_nom_producto = new System.Windows.Forms.TextBox();
            this.Txt_buscar_producto = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_product)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustesToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configuracionToolStripMenuItem.Text = "configuracion";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ajustesToolStripMenuItem.Text = "ajustes";
            this.ajustesToolStripMenuItem.Click += new System.EventHandler(this.ajustesToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provedorToolStripMenuItem,
            this.restaurarGuardadoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.opcionesToolStripMenuItem.Text = "opciones";
            // 
            // provedorToolStripMenuItem
            // 
            this.provedorToolStripMenuItem.Name = "provedorToolStripMenuItem";
            this.provedorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.provedorToolStripMenuItem.Text = "provedor";
            this.provedorToolStripMenuItem.Click += new System.EventHandler(this.provedorToolStripMenuItem_Click);
            // 
            // restaurarGuardadoToolStripMenuItem
            // 
            this.restaurarGuardadoToolStripMenuItem.Name = "restaurarGuardadoToolStripMenuItem";
            this.restaurarGuardadoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.restaurarGuardadoToolStripMenuItem.Text = "restaurar guardado";
            this.restaurarGuardadoToolStripMenuItem.Click += new System.EventHandler(this.restaurarGuardadoToolStripMenuItem_Click);
            // 
            // lbl_modo_inventario
            // 
            this.lbl_modo_inventario.AutoSize = true;
            this.lbl_modo_inventario.Location = new System.Drawing.Point(14, 47);
            this.lbl_modo_inventario.Name = "lbl_modo_inventario";
            this.lbl_modo_inventario.Size = new System.Drawing.Size(10, 13);
            this.lbl_modo_inventario.TabIndex = 42;
            this.lbl_modo_inventario.Text = ".";
            // 
            // btn_guardar_venta
            // 
            this.btn_guardar_venta.Location = new System.Drawing.Point(257, 125);
            this.btn_guardar_venta.Name = "btn_guardar_venta";
            this.btn_guardar_venta.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar_venta.TabIndex = 41;
            this.btn_guardar_venta.Text = "guardar";
            this.btn_guardar_venta.UseVisualStyleBackColor = true;
            this.btn_guardar_venta.Click += new System.EventHandler(this.btn_guardar_venta_Click);
            // 
            // lbl_ventas_compras_resultado
            // 
            this.lbl_ventas_compras_resultado.AutoSize = true;
            this.lbl_ventas_compras_resultado.Location = new System.Drawing.Point(154, 28);
            this.lbl_ventas_compras_resultado.Name = "lbl_ventas_compras_resultado";
            this.lbl_ventas_compras_resultado.Size = new System.Drawing.Size(81, 13);
            this.lbl_ventas_compras_resultado.TabIndex = 40;
            this.lbl_ventas_compras_resultado.Text = "ventas|compras";
            // 
            // chb_ventas_compras
            // 
            this.chb_ventas_compras.AutoSize = true;
            this.chb_ventas_compras.Location = new System.Drawing.Point(12, 27);
            this.chb_ventas_compras.Name = "chb_ventas_compras";
            this.chb_ventas_compras.Size = new System.Drawing.Size(136, 17);
            this.chb_ventas_compras.TabIndex = 39;
            this.chb_ventas_compras.Text = "ocultar ventas compras";
            this.chb_ventas_compras.UseVisualStyleBackColor = true;
            // 
            // Lbl_nom_product_list
            // 
            this.Lbl_nom_product_list.AutoSize = true;
            this.Lbl_nom_product_list.Location = new System.Drawing.Point(9, 304);
            this.Lbl_nom_product_list.Name = "Lbl_nom_product_list";
            this.Lbl_nom_product_list.Size = new System.Drawing.Size(104, 13);
            this.Lbl_nom_product_list.TabIndex = 38;
            this.Lbl_nom_product_list.Text = "nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "codigo";
            // 
            // Lbl_costo_product_list
            // 
            this.Lbl_costo_product_list.AutoSize = true;
            this.Lbl_costo_product_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_costo_product_list.Location = new System.Drawing.Point(12, 317);
            this.Lbl_costo_product_list.Name = "Lbl_costo_product_list";
            this.Lbl_costo_product_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_costo_product_list.Size = new System.Drawing.Size(24, 25);
            this.Lbl_costo_product_list.TabIndex = 27;
            this.Lbl_costo_product_list.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "nombre";
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuenta.Location = new System.Drawing.Point(207, 366);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_cuenta.Size = new System.Drawing.Size(24, 25);
            this.Lbl_cuenta.TabIndex = 28;
            this.Lbl_cuenta.Text = "$";
            // 
            // pb_product
            // 
            this.pb_product.Location = new System.Drawing.Point(257, 31);
            this.pb_product.Name = "pb_product";
            this.pb_product.Size = new System.Drawing.Size(103, 94);
            this.pb_product.TabIndex = 32;
            this.pb_product.TabStop = false;
            // 
            // Btn_elim_ultimo
            // 
            this.Btn_elim_ultimo.Location = new System.Drawing.Point(257, 235);
            this.Btn_elim_ultimo.Name = "Btn_elim_ultimo";
            this.Btn_elim_ultimo.Size = new System.Drawing.Size(75, 40);
            this.Btn_elim_ultimo.TabIndex = 29;
            this.Btn_elim_ultimo.Text = "eliminar ultimo";
            this.Btn_elim_ultimo.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo.Click += new System.EventHandler(this.Btn_elim_ultimo_Click);
            // 
            // Btn_procesar_venta
            // 
            this.Btn_procesar_venta.Location = new System.Drawing.Point(257, 281);
            this.Btn_procesar_venta.Name = "Btn_procesar_venta";
            this.Btn_procesar_venta.Size = new System.Drawing.Size(75, 23);
            this.Btn_procesar_venta.TabIndex = 26;
            this.Btn_procesar_venta.Text = "procesar venta";
            this.Btn_procesar_venta.UseVisualStyleBackColor = true;
            this.Btn_procesar_venta.Click += new System.EventHandler(this.Btn_procesar_venta_Click);
            // 
            // Btn_eliminar_todo
            // 
            this.Btn_eliminar_todo.Location = new System.Drawing.Point(257, 202);
            this.Btn_eliminar_todo.Name = "Btn_eliminar_todo";
            this.Btn_eliminar_todo.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar_todo.TabIndex = 30;
            this.Btn_eliminar_todo.Text = "eliminar todo";
            this.Btn_eliminar_todo.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo.Click += new System.EventHandler(this.Btn_eliminar_todo_Click);
            // 
            // Btn_eliminar_seleccionado
            // 
            this.Btn_eliminar_seleccionado.Location = new System.Drawing.Point(257, 154);
            this.Btn_eliminar_seleccionado.Name = "Btn_eliminar_seleccionado";
            this.Btn_eliminar_seleccionado.Size = new System.Drawing.Size(86, 42);
            this.Btn_eliminar_seleccionado.TabIndex = 31;
            this.Btn_eliminar_seleccionado.Text = "eliminar seleccionado";
            this.Btn_eliminar_seleccionado.UseVisualStyleBackColor = true;
            this.Btn_eliminar_seleccionado.Click += new System.EventHandler(this.Btn_eliminar_seleccionado_Click);
            // 
            // Lst_ventas
            // 
            this.Lst_ventas.FormattingEnabled = true;
            this.Lst_ventas.Location = new System.Drawing.Point(12, 63);
            this.Lst_ventas.Name = "Lst_ventas";
            this.Lst_ventas.Size = new System.Drawing.Size(239, 238);
            this.Lst_ventas.TabIndex = 34;
            this.Lst_ventas.SelectedIndexChanged += new System.EventHandler(this.Lst_ventas_SelectedIndexChanged);
            // 
            // Txt_nom_producto
            // 
            this.Txt_nom_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_nom_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_nom_producto.Location = new System.Drawing.Point(54, 371);
            this.Txt_nom_producto.Name = "Txt_nom_producto";
            this.Txt_nom_producto.Size = new System.Drawing.Size(150, 20);
            this.Txt_nom_producto.TabIndex = 33;
            this.Txt_nom_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_nom_producto_PreviewKeyDown);
            // 
            // Txt_buscar_producto
            // 
            this.Txt_buscar_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_buscar_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_buscar_producto.Location = new System.Drawing.Point(54, 345);
            this.Txt_buscar_producto.Name = "Txt_buscar_producto";
            this.Txt_buscar_producto.Size = new System.Drawing.Size(150, 20);
            this.Txt_buscar_producto.TabIndex = 25;
            this.Txt_buscar_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_buscar_producto_KeyPress);
            this.Txt_buscar_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_buscar_producto_PreviewKeyDown);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 411);
            this.Controls.Add(this.lbl_modo_inventario);
            this.Controls.Add(this.btn_guardar_venta);
            this.Controls.Add(this.lbl_ventas_compras_resultado);
            this.Controls.Add(this.chb_ventas_compras);
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
            this.Controls.Add(this.menuStrip1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarGuardadoToolStripMenuItem;
        private System.Windows.Forms.Label lbl_modo_inventario;
        private System.Windows.Forms.Button btn_guardar_venta;
        private System.Windows.Forms.Label lbl_ventas_compras_resultado;
        private System.Windows.Forms.CheckBox chb_ventas_compras;
        private System.Windows.Forms.Label Lbl_nom_product_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_costo_product_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.PictureBox pb_product;
        private System.Windows.Forms.Button Btn_elim_ultimo;
        private System.Windows.Forms.Button Btn_procesar_venta;
        private System.Windows.Forms.Button Btn_eliminar_todo;
        private System.Windows.Forms.Button Btn_eliminar_seleccionado;
        private System.Windows.Forms.ListBox Lst_ventas;
        private System.Windows.Forms.TextBox Txt_nom_producto;
        private System.Windows.Forms.TextBox Txt_buscar_producto;
    }
}