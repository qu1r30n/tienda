namespace tienda2.desinger
{
    partial class pedidos
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
            this.txt_buscar_producto = new System.Windows.Forms.TextBox();
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_cantidad_cant = new System.Windows.Forms.Label();
            this.lbl_precio_compra = new System.Windows.Forms.Label();
            this.lbl_precio_compra_cant = new System.Windows.Forms.Label();
            this.lbl_prcio_vnt = new System.Windows.Forms.Label();
            this.lbl_precio_venta = new System.Windows.Forms.Label();
            this.lbl_nuevo_cantidad = new System.Windows.Forms.Label();
            this.txt_costo_compra = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_provedor = new System.Windows.Forms.TextBox();
            this.lbl_provedor = new System.Windows.Forms.Label();
            this.lbl_nom_producto_buscar = new System.Windows.Forms.Label();
            this.txt_nom_producto = new System.Windows.Forms.TextBox();
            this.rdb_codigo_barras = new System.Windows.Forms.RadioButton();
            this.rdb_producto = new System.Windows.Forms.RadioButton();
            this.lst_compras = new System.Windows.Forms.ListBox();
            this.btn_elim_ultimo = new System.Windows.Forms.Button();
            this.btn_procesar_venta = new System.Windows.Forms.Button();
            this.btn_eliminar_todo = new System.Windows.Forms.Button();
            this.btn_eliminar_seleccionado = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label_cant = new System.Windows.Forms.Label();
            this.lbl_id_titulo = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_cargar_pedido = new System.Windows.Forms.Button();
            this.lbl_cuenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_buscar_producto
            // 
            this.txt_buscar_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_buscar_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_buscar_producto.Location = new System.Drawing.Point(26, 22);
            this.txt_buscar_producto.Name = "txt_buscar_producto";
            this.txt_buscar_producto.Size = new System.Drawing.Size(119, 20);
            this.txt_buscar_producto.TabIndex = 1;
            this.txt_buscar_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_buscar_producto_PreviewKeyDown);
            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Location = new System.Drawing.Point(195, 26);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(87, 13);
            this.lbl_nombre_producto.TabIndex = 12;
            this.lbl_nombre_producto.Text = "nombre producto";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(195, 6);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(49, 13);
            this.lbl_producto.TabIndex = 11;
            this.lbl_producto.Text = "producto";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(783, 62);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 46);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(495, 6);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(97, 13);
            this.lbl_cantidad.TabIndex = 17;
            this.lbl_cantidad.Text = "cantidad inventario";
            // 
            // lbl_cantidad_cant
            // 
            this.lbl_cantidad_cant.AutoSize = true;
            this.lbl_cantidad_cant.Location = new System.Drawing.Point(495, 29);
            this.lbl_cantidad_cant.Name = "lbl_cantidad_cant";
            this.lbl_cantidad_cant.Size = new System.Drawing.Size(13, 13);
            this.lbl_cantidad_cant.TabIndex = 18;
            this.lbl_cantidad_cant.Text = "$";
            // 
            // lbl_precio_compra
            // 
            this.lbl_precio_compra.AutoSize = true;
            this.lbl_precio_compra.Location = new System.Drawing.Point(326, 6);
            this.lbl_precio_compra.Name = "lbl_precio_compra";
            this.lbl_precio_compra.Size = new System.Drawing.Size(74, 13);
            this.lbl_precio_compra.TabIndex = 13;
            this.lbl_precio_compra.Text = "precio compra";
            // 
            // lbl_precio_compra_cant
            // 
            this.lbl_precio_compra_cant.AutoSize = true;
            this.lbl_precio_compra_cant.Location = new System.Drawing.Point(326, 29);
            this.lbl_precio_compra_cant.Name = "lbl_precio_compra_cant";
            this.lbl_precio_compra_cant.Size = new System.Drawing.Size(13, 13);
            this.lbl_precio_compra_cant.TabIndex = 14;
            this.lbl_precio_compra_cant.Text = "$";
            // 
            // lbl_prcio_vnt
            // 
            this.lbl_prcio_vnt.AutoSize = true;
            this.lbl_prcio_vnt.Location = new System.Drawing.Point(410, 6);
            this.lbl_prcio_vnt.Name = "lbl_prcio_vnt";
            this.lbl_prcio_vnt.Size = new System.Drawing.Size(66, 13);
            this.lbl_prcio_vnt.TabIndex = 15;
            this.lbl_prcio_vnt.Text = "precio venta";
            // 
            // lbl_precio_venta
            // 
            this.lbl_precio_venta.AutoSize = true;
            this.lbl_precio_venta.Location = new System.Drawing.Point(410, 29);
            this.lbl_precio_venta.Name = "lbl_precio_venta";
            this.lbl_precio_venta.Size = new System.Drawing.Size(13, 13);
            this.lbl_precio_venta.TabIndex = 16;
            this.lbl_precio_venta.Text = "$";
            // 
            // lbl_nuevo_cantidad
            // 
            this.lbl_nuevo_cantidad.AutoSize = true;
            this.lbl_nuevo_cantidad.Location = new System.Drawing.Point(701, 3);
            this.lbl_nuevo_cantidad.Name = "lbl_nuevo_cantidad";
            this.lbl_nuevo_cantidad.Size = new System.Drawing.Size(42, 13);
            this.lbl_nuevo_cantidad.TabIndex = 19;
            this.lbl_nuevo_cantidad.Text = "costo   ";
            // 
            // txt_costo_compra
            // 
            this.txt_costo_compra.Location = new System.Drawing.Point(704, 19);
            this.txt_costo_compra.Name = "txt_costo_compra";
            this.txt_costo_compra.Size = new System.Drawing.Size(100, 20);
            this.txt_costo_compra.TabIndex = 3;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(26, 6);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(86, 13);
            this.lbl_codigo.TabIndex = 10;
            this.lbl_codigo.Text = "codigo de barras";
            // 
            // txt_provedor
            // 
            this.txt_provedor.Location = new System.Drawing.Point(810, 18);
            this.txt_provedor.Name = "txt_provedor";
            this.txt_provedor.Size = new System.Drawing.Size(100, 20);
            this.txt_provedor.TabIndex = 4;
            // 
            // lbl_provedor
            // 
            this.lbl_provedor.AutoSize = true;
            this.lbl_provedor.Location = new System.Drawing.Point(807, 2);
            this.lbl_provedor.Name = "lbl_provedor";
            this.lbl_provedor.Size = new System.Drawing.Size(49, 13);
            this.lbl_provedor.TabIndex = 20;
            this.lbl_provedor.Text = "provedor";
            // 
            // lbl_nom_producto_buscar
            // 
            this.lbl_nom_producto_buscar.AutoSize = true;
            this.lbl_nom_producto_buscar.Location = new System.Drawing.Point(23, 60);
            this.lbl_nom_producto_buscar.Name = "lbl_nom_producto_buscar";
            this.lbl_nom_producto_buscar.Size = new System.Drawing.Size(87, 13);
            this.lbl_nom_producto_buscar.TabIndex = 35;
            this.lbl_nom_producto_buscar.Text = "nombre producto";
            // 
            // txt_nom_producto
            // 
            this.txt_nom_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_nom_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_nom_producto.Location = new System.Drawing.Point(26, 76);
            this.txt_nom_producto.Name = "txt_nom_producto";
            this.txt_nom_producto.Size = new System.Drawing.Size(119, 20);
            this.txt_nom_producto.TabIndex = 10;
            this.txt_nom_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_nom_producto_PreviewKeyDown);
            // 
            // rdb_codigo_barras
            // 
            this.rdb_codigo_barras.AutoSize = true;
            this.rdb_codigo_barras.Location = new System.Drawing.Point(6, 25);
            this.rdb_codigo_barras.Name = "rdb_codigo_barras";
            this.rdb_codigo_barras.Size = new System.Drawing.Size(14, 13);
            this.rdb_codigo_barras.TabIndex = 21;
            this.rdb_codigo_barras.TabStop = true;
            this.rdb_codigo_barras.UseVisualStyleBackColor = true;
            // 
            // rdb_producto
            // 
            this.rdb_producto.AutoSize = true;
            this.rdb_producto.Location = new System.Drawing.Point(6, 76);
            this.rdb_producto.Name = "rdb_producto";
            this.rdb_producto.Size = new System.Drawing.Size(14, 13);
            this.rdb_producto.TabIndex = 22;
            this.rdb_producto.TabStop = true;
            this.rdb_producto.UseVisualStyleBackColor = true;
            // 
            // lst_compras
            // 
            this.lst_compras.FormattingEnabled = true;
            this.lst_compras.Location = new System.Drawing.Point(198, 76);
            this.lst_compras.Name = "lst_compras";
            this.lst_compras.Size = new System.Drawing.Size(579, 186);
            this.lst_compras.TabIndex = 9;
            // 
            // btn_elim_ultimo
            // 
            this.btn_elim_ultimo.Location = new System.Drawing.Point(783, 227);
            this.btn_elim_ultimo.Name = "btn_elim_ultimo";
            this.btn_elim_ultimo.Size = new System.Drawing.Size(75, 40);
            this.btn_elim_ultimo.TabIndex = 7;
            this.btn_elim_ultimo.Text = "eliminar ultimo";
            this.btn_elim_ultimo.UseVisualStyleBackColor = true;
            this.btn_elim_ultimo.Click += new System.EventHandler(this.btn_elim_ultimo_Click);
            // 
            // btn_procesar_venta
            // 
            this.btn_procesar_venta.Location = new System.Drawing.Point(783, 273);
            this.btn_procesar_venta.Name = "btn_procesar_venta";
            this.btn_procesar_venta.Size = new System.Drawing.Size(75, 23);
            this.btn_procesar_venta.TabIndex = 6;
            this.btn_procesar_venta.Text = "procesar venta";
            this.btn_procesar_venta.UseVisualStyleBackColor = true;
            this.btn_procesar_venta.Click += new System.EventHandler(this.btn_procesar_venta_Click);
            // 
            // btn_eliminar_todo
            // 
            this.btn_eliminar_todo.Location = new System.Drawing.Point(783, 194);
            this.btn_eliminar_todo.Name = "btn_eliminar_todo";
            this.btn_eliminar_todo.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar_todo.TabIndex = 8;
            this.btn_eliminar_todo.Text = "eliminar todo";
            this.btn_eliminar_todo.UseVisualStyleBackColor = true;
            this.btn_eliminar_todo.Click += new System.EventHandler(this.btn_eliminar_todo_Click);
            // 
            // btn_eliminar_seleccionado
            // 
            this.btn_eliminar_seleccionado.Location = new System.Drawing.Point(783, 146);
            this.btn_eliminar_seleccionado.Name = "btn_eliminar_seleccionado";
            this.btn_eliminar_seleccionado.Size = new System.Drawing.Size(86, 42);
            this.btn_eliminar_seleccionado.TabIndex = 9;
            this.btn_eliminar_seleccionado.Text = "eliminar seleccionado";
            this.btn_eliminar_seleccionado.UseVisualStyleBackColor = true;
            this.btn_eliminar_seleccionado.Click += new System.EventHandler(this.btn_eliminar_seleccionado_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(598, 18);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 2;
            // 
            // label_cant
            // 
            this.label_cant.AutoSize = true;
            this.label_cant.Location = new System.Drawing.Point(595, 2);
            this.label_cant.Name = "label_cant";
            this.label_cant.Size = new System.Drawing.Size(89, 13);
            this.label_cant.TabIndex = 37;
            this.label_cant.Text = "cantidad comprar";
            // 
            // lbl_id_titulo
            // 
            this.lbl_id_titulo.AutoSize = true;
            this.lbl_id_titulo.Location = new System.Drawing.Point(154, 6);
            this.lbl_id_titulo.Name = "lbl_id_titulo";
            this.lbl_id_titulo.Size = new System.Drawing.Size(18, 13);
            this.lbl_id_titulo.TabIndex = 38;
            this.lbl_id_titulo.Text = "ID";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(154, 29);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(13, 13);
            this.lbl_id.TabIndex = 39;
            this.lbl_id.Text = "0";
            // 
            // btn_cargar_pedido
            // 
            this.btn_cargar_pedido.Location = new System.Drawing.Point(12, 254);
            this.btn_cargar_pedido.Name = "btn_cargar_pedido";
            this.btn_cargar_pedido.Size = new System.Drawing.Size(98, 39);
            this.btn_cargar_pedido.TabIndex = 40;
            this.btn_cargar_pedido.Text = "cargar pedido";
            this.btn_cargar_pedido.UseVisualStyleBackColor = true;
            this.btn_cargar_pedido.Click += new System.EventHandler(this.btn_cargar_pedido_Click);
            // 
            // lbl_cuenta
            // 
            this.lbl_cuenta.AutoSize = true;
            this.lbl_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuenta.Location = new System.Drawing.Point(665, 273);
            this.lbl_cuenta.Name = "lbl_cuenta";
            this.lbl_cuenta.Size = new System.Drawing.Size(19, 20);
            this.lbl_cuenta.TabIndex = 41;
            this.lbl_cuenta.Text = "$";
            // 
            // pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 305);
            this.Controls.Add(this.lbl_cuenta);
            this.Controls.Add(this.btn_cargar_pedido);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_id_titulo);
            this.Controls.Add(this.label_cant);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.btn_elim_ultimo);
            this.Controls.Add(this.btn_procesar_venta);
            this.Controls.Add(this.btn_eliminar_todo);
            this.Controls.Add(this.btn_eliminar_seleccionado);
            this.Controls.Add(this.lst_compras);
            this.Controls.Add(this.rdb_producto);
            this.Controls.Add(this.rdb_codigo_barras);
            this.Controls.Add(this.txt_nom_producto);
            this.Controls.Add(this.lbl_nom_producto_buscar);
            this.Controls.Add(this.lbl_provedor);
            this.Controls.Add(this.txt_provedor);
            this.Controls.Add(this.txt_buscar_producto);
            this.Controls.Add(this.lbl_nombre_producto);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_cantidad_cant);
            this.Controls.Add(this.lbl_precio_compra);
            this.Controls.Add(this.lbl_precio_compra_cant);
            this.Controls.Add(this.lbl_prcio_vnt);
            this.Controls.Add(this.lbl_precio_venta);
            this.Controls.Add(this.lbl_nuevo_cantidad);
            this.Controls.Add(this.txt_costo_compra);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "pedidos";
            this.Text = "pedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_buscar_producto;
        private System.Windows.Forms.Label lbl_nombre_producto;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_cantidad_cant;
        private System.Windows.Forms.Label lbl_precio_compra;
        private System.Windows.Forms.Label lbl_precio_compra_cant;
        private System.Windows.Forms.Label lbl_prcio_vnt;
        private System.Windows.Forms.Label lbl_precio_venta;
        private System.Windows.Forms.Label lbl_nuevo_cantidad;
        private System.Windows.Forms.TextBox txt_costo_compra;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_provedor;
        private System.Windows.Forms.Label lbl_provedor;
        private System.Windows.Forms.Label lbl_nom_producto_buscar;
        private System.Windows.Forms.TextBox txt_nom_producto;
        private System.Windows.Forms.RadioButton rdb_codigo_barras;
        private System.Windows.Forms.RadioButton rdb_producto;
        private System.Windows.Forms.ListBox lst_compras;
        private System.Windows.Forms.Button btn_elim_ultimo;
        private System.Windows.Forms.Button btn_procesar_venta;
        private System.Windows.Forms.Button btn_eliminar_todo;
        private System.Windows.Forms.Button btn_eliminar_seleccionado;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label_cant;
        private System.Windows.Forms.Label lbl_id_titulo;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_cargar_pedido;
        private System.Windows.Forms.Label lbl_cuenta;
    }
}