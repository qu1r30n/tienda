namespace tienda2.desinger
{
    partial class Pedidos
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
            this.Txt_buscar_producto = new System.Windows.Forms.TextBox();
            this.Lbl_nombre_producto = new System.Windows.Forms.Label();
            this.Lbl_producto = new System.Windows.Forms.Label();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.Lbl_cantidad_cant = new System.Windows.Forms.Label();
            this.Lbl_precio_compra = new System.Windows.Forms.Label();
            this.Lbl_precio_compra_cant = new System.Windows.Forms.Label();
            this.Lbl_prcio_vnt = new System.Windows.Forms.Label();
            this.Lbl_precio_venta = new System.Windows.Forms.Label();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.Lbl_provedor = new System.Windows.Forms.Label();
            this.Lbl_nom_producto_buscar = new System.Windows.Forms.Label();
            this.Txt_nom_producto = new System.Windows.Forms.TextBox();
            this.Rdb_codigo_barras = new System.Windows.Forms.RadioButton();
            this.Rdb_producto = new System.Windows.Forms.RadioButton();
            this.Lst_compras = new System.Windows.Forms.ListBox();
            this.Btn_elim_ultimo = new System.Windows.Forms.Button();
            this.Btn_procesar_venta = new System.Windows.Forms.Button();
            this.Btn_eliminar_todo = new System.Windows.Forms.Button();
            this.Btn_eliminar_seleccionado = new System.Windows.Forms.Button();
            this.Lbl_id_titulo = new System.Windows.Forms.Label();
            this.Lbl_id = new System.Windows.Forms.Label();
            this.Btn_cargar_pedido = new System.Windows.Forms.Button();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.Lbl_nom_product_list = new System.Windows.Forms.Label();
            this.cmb_provedor = new System.Windows.Forms.ComboBox();
            this.btn_paquete = new System.Windows.Forms.Button();
            this.btn_individual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_buscar_producto
            // 
            this.Txt_buscar_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_buscar_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_buscar_producto.Location = new System.Drawing.Point(26, 22);
            this.Txt_buscar_producto.Name = "Txt_buscar_producto";
            this.Txt_buscar_producto.Size = new System.Drawing.Size(119, 20);
            this.Txt_buscar_producto.TabIndex = 1;
            this.Txt_buscar_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_buscar_producto_PreviewKeyDown);
            // 
            // Lbl_nombre_producto
            // 
            this.Lbl_nombre_producto.AutoSize = true;
            this.Lbl_nombre_producto.Location = new System.Drawing.Point(195, 26);
            this.Lbl_nombre_producto.Name = "Lbl_nombre_producto";
            this.Lbl_nombre_producto.Size = new System.Drawing.Size(87, 13);
            this.Lbl_nombre_producto.TabIndex = 12;
            this.Lbl_nombre_producto.Text = "nombre producto";
            // 
            // Lbl_producto
            // 
            this.Lbl_producto.AutoSize = true;
            this.Lbl_producto.Location = new System.Drawing.Point(195, 6);
            this.Lbl_producto.Name = "Lbl_producto";
            this.Lbl_producto.Size = new System.Drawing.Size(49, 13);
            this.Lbl_producto.TabIndex = 11;
            this.Lbl_producto.Text = "producto";
            // 
            // Lbl_cantidad
            // 
            this.Lbl_cantidad.AutoSize = true;
            this.Lbl_cantidad.Location = new System.Drawing.Point(495, 6);
            this.Lbl_cantidad.Name = "Lbl_cantidad";
            this.Lbl_cantidad.Size = new System.Drawing.Size(97, 13);
            this.Lbl_cantidad.TabIndex = 17;
            this.Lbl_cantidad.Text = "cantidad inventario";
            // 
            // Lbl_cantidad_cant
            // 
            this.Lbl_cantidad_cant.AutoSize = true;
            this.Lbl_cantidad_cant.Location = new System.Drawing.Point(495, 29);
            this.Lbl_cantidad_cant.Name = "Lbl_cantidad_cant";
            this.Lbl_cantidad_cant.Size = new System.Drawing.Size(13, 13);
            this.Lbl_cantidad_cant.TabIndex = 18;
            this.Lbl_cantidad_cant.Text = "$";
            // 
            // Lbl_precio_compra
            // 
            this.Lbl_precio_compra.AutoSize = true;
            this.Lbl_precio_compra.Location = new System.Drawing.Point(326, 6);
            this.Lbl_precio_compra.Name = "Lbl_precio_compra";
            this.Lbl_precio_compra.Size = new System.Drawing.Size(74, 13);
            this.Lbl_precio_compra.TabIndex = 13;
            this.Lbl_precio_compra.Text = "precio compra";
            // 
            // Lbl_precio_compra_cant
            // 
            this.Lbl_precio_compra_cant.AutoSize = true;
            this.Lbl_precio_compra_cant.Location = new System.Drawing.Point(326, 29);
            this.Lbl_precio_compra_cant.Name = "Lbl_precio_compra_cant";
            this.Lbl_precio_compra_cant.Size = new System.Drawing.Size(13, 13);
            this.Lbl_precio_compra_cant.TabIndex = 14;
            this.Lbl_precio_compra_cant.Text = "$";
            // 
            // Lbl_prcio_vnt
            // 
            this.Lbl_prcio_vnt.AutoSize = true;
            this.Lbl_prcio_vnt.Location = new System.Drawing.Point(410, 6);
            this.Lbl_prcio_vnt.Name = "Lbl_prcio_vnt";
            this.Lbl_prcio_vnt.Size = new System.Drawing.Size(66, 13);
            this.Lbl_prcio_vnt.TabIndex = 15;
            this.Lbl_prcio_vnt.Text = "precio venta";
            // 
            // Lbl_precio_venta
            // 
            this.Lbl_precio_venta.AutoSize = true;
            this.Lbl_precio_venta.Location = new System.Drawing.Point(410, 29);
            this.Lbl_precio_venta.Name = "Lbl_precio_venta";
            this.Lbl_precio_venta.Size = new System.Drawing.Size(13, 13);
            this.Lbl_precio_venta.TabIndex = 16;
            this.Lbl_precio_venta.Text = "$";
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.Location = new System.Drawing.Point(26, 6);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(86, 13);
            this.Lbl_codigo.TabIndex = 10;
            this.Lbl_codigo.Text = "codigo de barras";
            // 
            // Lbl_provedor
            // 
            this.Lbl_provedor.AutoSize = true;
            this.Lbl_provedor.Location = new System.Drawing.Point(635, 6);
            this.Lbl_provedor.Name = "Lbl_provedor";
            this.Lbl_provedor.Size = new System.Drawing.Size(49, 13);
            this.Lbl_provedor.TabIndex = 20;
            this.Lbl_provedor.Text = "provedor";
            // 
            // Lbl_nom_producto_buscar
            // 
            this.Lbl_nom_producto_buscar.AutoSize = true;
            this.Lbl_nom_producto_buscar.Location = new System.Drawing.Point(23, 60);
            this.Lbl_nom_producto_buscar.Name = "Lbl_nom_producto_buscar";
            this.Lbl_nom_producto_buscar.Size = new System.Drawing.Size(87, 13);
            this.Lbl_nom_producto_buscar.TabIndex = 35;
            this.Lbl_nom_producto_buscar.Text = "nombre producto";
            // 
            // Txt_nom_producto
            // 
            this.Txt_nom_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_nom_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_nom_producto.Location = new System.Drawing.Point(26, 76);
            this.Txt_nom_producto.Name = "Txt_nom_producto";
            this.Txt_nom_producto.Size = new System.Drawing.Size(119, 20);
            this.Txt_nom_producto.TabIndex = 12;
            this.Txt_nom_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_nom_producto_PreviewKeyDown);
            // 
            // Rdb_codigo_barras
            // 
            this.Rdb_codigo_barras.AutoSize = true;
            this.Rdb_codigo_barras.Location = new System.Drawing.Point(6, 25);
            this.Rdb_codigo_barras.Name = "Rdb_codigo_barras";
            this.Rdb_codigo_barras.Size = new System.Drawing.Size(14, 13);
            this.Rdb_codigo_barras.TabIndex = 13;
            this.Rdb_codigo_barras.TabStop = true;
            this.Rdb_codigo_barras.UseVisualStyleBackColor = true;
            // 
            // Rdb_producto
            // 
            this.Rdb_producto.AutoSize = true;
            this.Rdb_producto.Location = new System.Drawing.Point(6, 76);
            this.Rdb_producto.Name = "Rdb_producto";
            this.Rdb_producto.Size = new System.Drawing.Size(14, 13);
            this.Rdb_producto.TabIndex = 14;
            this.Rdb_producto.TabStop = true;
            this.Rdb_producto.UseVisualStyleBackColor = true;
            // 
            // Lst_compras
            // 
            this.Lst_compras.FormattingEnabled = true;
            this.Lst_compras.Location = new System.Drawing.Point(198, 85);
            this.Lst_compras.Name = "Lst_compras";
            this.Lst_compras.Size = new System.Drawing.Size(579, 173);
            this.Lst_compras.TabIndex = 15;
            this.Lst_compras.SelectedIndexChanged += new System.EventHandler(this.Lst_compras_SelectedIndexChanged);
            // 
            // Btn_elim_ultimo
            // 
            this.Btn_elim_ultimo.Location = new System.Drawing.Point(783, 227);
            this.Btn_elim_ultimo.Name = "Btn_elim_ultimo";
            this.Btn_elim_ultimo.Size = new System.Drawing.Size(75, 40);
            this.Btn_elim_ultimo.TabIndex = 9;
            this.Btn_elim_ultimo.Text = "eliminar ultimo";
            this.Btn_elim_ultimo.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo.Click += new System.EventHandler(this.Btn_elim_ultimo_Click);
            // 
            // Btn_procesar_venta
            // 
            this.Btn_procesar_venta.Location = new System.Drawing.Point(783, 272);
            this.Btn_procesar_venta.Name = "Btn_procesar_venta";
            this.Btn_procesar_venta.Size = new System.Drawing.Size(75, 23);
            this.Btn_procesar_venta.TabIndex = 10;
            this.Btn_procesar_venta.Text = "procesar venta";
            this.Btn_procesar_venta.UseVisualStyleBackColor = true;
            this.Btn_procesar_venta.Click += new System.EventHandler(this.Btn_procesar_venta_Click);
            // 
            // Btn_eliminar_todo
            // 
            this.Btn_eliminar_todo.Location = new System.Drawing.Point(783, 194);
            this.Btn_eliminar_todo.Name = "Btn_eliminar_todo";
            this.Btn_eliminar_todo.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar_todo.TabIndex = 8;
            this.Btn_eliminar_todo.Text = "eliminar todo";
            this.Btn_eliminar_todo.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo.Click += new System.EventHandler(this.Btn_eliminar_todo_Click);
            // 
            // Btn_eliminar_seleccionado
            // 
            this.Btn_eliminar_seleccionado.Location = new System.Drawing.Point(783, 146);
            this.Btn_eliminar_seleccionado.Name = "Btn_eliminar_seleccionado";
            this.Btn_eliminar_seleccionado.Size = new System.Drawing.Size(86, 42);
            this.Btn_eliminar_seleccionado.TabIndex = 7;
            this.Btn_eliminar_seleccionado.Text = "eliminar seleccionado";
            this.Btn_eliminar_seleccionado.UseVisualStyleBackColor = true;
            this.Btn_eliminar_seleccionado.Click += new System.EventHandler(this.Btn_eliminar_seleccionado_Click);
            // 
            // Lbl_id_titulo
            // 
            this.Lbl_id_titulo.AutoSize = true;
            this.Lbl_id_titulo.Location = new System.Drawing.Point(154, 6);
            this.Lbl_id_titulo.Name = "Lbl_id_titulo";
            this.Lbl_id_titulo.Size = new System.Drawing.Size(18, 13);
            this.Lbl_id_titulo.TabIndex = 38;
            this.Lbl_id_titulo.Text = "ID";
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Location = new System.Drawing.Point(154, 29);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(13, 13);
            this.Lbl_id.TabIndex = 39;
            this.Lbl_id.Text = "0";
            // 
            // Btn_cargar_pedido
            // 
            this.Btn_cargar_pedido.Location = new System.Drawing.Point(12, 254);
            this.Btn_cargar_pedido.Name = "Btn_cargar_pedido";
            this.Btn_cargar_pedido.Size = new System.Drawing.Size(98, 39);
            this.Btn_cargar_pedido.TabIndex = 11;
            this.Btn_cargar_pedido.Text = "cargar pedido";
            this.Btn_cargar_pedido.UseVisualStyleBackColor = true;
            this.Btn_cargar_pedido.Click += new System.EventHandler(this.Btn_cargar_pedido_Click);
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuenta.Location = new System.Drawing.Point(665, 285);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(19, 20);
            this.Lbl_cuenta.TabIndex = 41;
            this.Lbl_cuenta.Text = "$";
            // 
            // Lbl_nom_product_list
            // 
            this.Lbl_nom_product_list.AutoSize = true;
            this.Lbl_nom_product_list.Location = new System.Drawing.Point(195, 267);
            this.Lbl_nom_product_list.Name = "Lbl_nom_product_list";
            this.Lbl_nom_product_list.Size = new System.Drawing.Size(185, 13);
            this.Lbl_nom_product_list.TabIndex = 42;
            this.Lbl_nom_product_list.Text = "nombre_precio_produc_seleccionado";
            // 
            // cmb_provedor
            // 
            this.cmb_provedor.FormattingEnabled = true;
            this.cmb_provedor.ItemHeight = 13;
            this.cmb_provedor.Location = new System.Drawing.Point(638, 22);
            this.cmb_provedor.Name = "cmb_provedor";
            this.cmb_provedor.Size = new System.Drawing.Size(117, 21);
            this.cmb_provedor.TabIndex = 4;
            // 
            // btn_paquete
            // 
            this.btn_paquete.Location = new System.Drawing.Point(761, 0);
            this.btn_paquete.Name = "btn_paquete";
            this.btn_paquete.Size = new System.Drawing.Size(75, 39);
            this.btn_paquete.TabIndex = 43;
            this.btn_paquete.Text = "paquete";
            this.btn_paquete.UseVisualStyleBackColor = true;
            this.btn_paquete.Click += new System.EventHandler(this.btn_paquete_Click);
            // 
            // btn_individual
            // 
            this.btn_individual.Location = new System.Drawing.Point(761, 45);
            this.btn_individual.Name = "btn_individual";
            this.btn_individual.Size = new System.Drawing.Size(75, 39);
            this.btn_individual.TabIndex = 43;
            this.btn_individual.Text = "individual";
            this.btn_individual.UseVisualStyleBackColor = true;
            this.btn_individual.Click += new System.EventHandler(this.btn_individual_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 305);
            this.Controls.Add(this.btn_individual);
            this.Controls.Add(this.btn_paquete);
            this.Controls.Add(this.cmb_provedor);
            this.Controls.Add(this.Lbl_nom_product_list);
            this.Controls.Add(this.Lbl_cuenta);
            this.Controls.Add(this.Btn_cargar_pedido);
            this.Controls.Add(this.Lbl_id);
            this.Controls.Add(this.Lbl_id_titulo);
            this.Controls.Add(this.Btn_elim_ultimo);
            this.Controls.Add(this.Btn_procesar_venta);
            this.Controls.Add(this.Btn_eliminar_todo);
            this.Controls.Add(this.Btn_eliminar_seleccionado);
            this.Controls.Add(this.Lst_compras);
            this.Controls.Add(this.Rdb_producto);
            this.Controls.Add(this.Rdb_codigo_barras);
            this.Controls.Add(this.Txt_nom_producto);
            this.Controls.Add(this.Lbl_nom_producto_buscar);
            this.Controls.Add(this.Lbl_provedor);
            this.Controls.Add(this.Txt_buscar_producto);
            this.Controls.Add(this.Lbl_nombre_producto);
            this.Controls.Add(this.Lbl_producto);
            this.Controls.Add(this.Lbl_cantidad);
            this.Controls.Add(this.Lbl_cantidad_cant);
            this.Controls.Add(this.Lbl_precio_compra);
            this.Controls.Add(this.Lbl_precio_compra_cant);
            this.Controls.Add(this.Lbl_prcio_vnt);
            this.Controls.Add(this.Lbl_precio_venta);
            this.Controls.Add(this.Lbl_codigo);
            this.Name = "Pedidos";
            this.Text = "pedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_buscar_producto;
        private System.Windows.Forms.Label Lbl_nombre_producto;
        private System.Windows.Forms.Label Lbl_producto;
        private System.Windows.Forms.Label Lbl_cantidad;
        private System.Windows.Forms.Label Lbl_cantidad_cant;
        private System.Windows.Forms.Label Lbl_precio_compra;
        private System.Windows.Forms.Label Lbl_precio_compra_cant;
        private System.Windows.Forms.Label Lbl_prcio_vnt;
        private System.Windows.Forms.Label Lbl_precio_venta;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.Label Lbl_provedor;
        private System.Windows.Forms.Label Lbl_nom_producto_buscar;
        private System.Windows.Forms.TextBox Txt_nom_producto;
        private System.Windows.Forms.RadioButton Rdb_codigo_barras;
        private System.Windows.Forms.RadioButton Rdb_producto;
        private System.Windows.Forms.ListBox Lst_compras;
        private System.Windows.Forms.Button Btn_elim_ultimo;
        private System.Windows.Forms.Button Btn_procesar_venta;
        private System.Windows.Forms.Button Btn_eliminar_todo;
        private System.Windows.Forms.Button Btn_eliminar_seleccionado;
        private System.Windows.Forms.Label Lbl_id_titulo;
        private System.Windows.Forms.Label Lbl_id;
        private System.Windows.Forms.Button Btn_cargar_pedido;
        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.Label Lbl_nom_product_list;
        private System.Windows.Forms.ComboBox cmb_provedor;
        private System.Windows.Forms.Button btn_paquete;
        private System.Windows.Forms.Button btn_individual;
    }
}