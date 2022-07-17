
namespace tienda2.desinger
{
    partial class Compras
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
            this.btn_elim_ultimo_carga = new System.Windows.Forms.Button();
            this.btn_elim_todos_carga = new System.Windows.Forms.Button();
            this.btn_elim_selec_carga = new System.Windows.Forms.Button();
            this.btn_cargar_lst_comprar = new System.Windows.Forms.Button();
            this.lst_carga = new System.Windows.Forms.ListBox();
            this.btn_individual = new System.Windows.Forms.Button();
            this.btn_paquete = new System.Windows.Forms.Button();
            this.cmb_provedor = new System.Windows.Forms.ComboBox();
            this.Lbl_nom_product_list = new System.Windows.Forms.Label();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.Btn_cargar_pedido = new System.Windows.Forms.Button();
            this.Lbl_id = new System.Windows.Forms.Label();
            this.Lbl_id_titulo = new System.Windows.Forms.Label();
            this.Btn_elim_ultimo = new System.Windows.Forms.Button();
            this.Btn_procesar_venta = new System.Windows.Forms.Button();
            this.Btn_eliminar_todo = new System.Windows.Forms.Button();
            this.Btn_eliminar_seleccionado = new System.Windows.Forms.Button();
            this.Lst_compras = new System.Windows.Forms.ListBox();
            this.Rdb_producto = new System.Windows.Forms.RadioButton();
            this.Rdb_codigo_barras = new System.Windows.Forms.RadioButton();
            this.Txt_nom_producto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_buscar_producto = new System.Windows.Forms.TextBox();
            this.Lbl_nombre_producto = new System.Windows.Forms.Label();
            this.Lbl_producto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_cantidad_cant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_precio_compra_cant = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.Lbl_precio_venta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igualarProvedpresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarRapidoCodigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_elim_ultimo_carga
            // 
            this.btn_elim_ultimo_carga.Location = new System.Drawing.Point(67, 225);
            this.btn_elim_ultimo_carga.Name = "btn_elim_ultimo_carga";
            this.btn_elim_ultimo_carga.Size = new System.Drawing.Size(84, 23);
            this.btn_elim_ultimo_carga.TabIndex = 82;
            this.btn_elim_ultimo_carga.Text = "eliminar ultimo";
            this.btn_elim_ultimo_carga.UseVisualStyleBackColor = true;
            this.btn_elim_ultimo_carga.Click += new System.EventHandler(this.btn_elim_ultimo_carga_Click);
            // 
            // btn_elim_todos_carga
            // 
            this.btn_elim_todos_carga.Location = new System.Drawing.Point(67, 187);
            this.btn_elim_todos_carga.Name = "btn_elim_todos_carga";
            this.btn_elim_todos_carga.Size = new System.Drawing.Size(84, 23);
            this.btn_elim_todos_carga.TabIndex = 81;
            this.btn_elim_todos_carga.Text = "eliminar todos";
            this.btn_elim_todos_carga.UseVisualStyleBackColor = true;
            this.btn_elim_todos_carga.Click += new System.EventHandler(this.btn_elim_todos_carga_Click);
            // 
            // btn_elim_selec_carga
            // 
            this.btn_elim_selec_carga.Location = new System.Drawing.Point(67, 133);
            this.btn_elim_selec_carga.Name = "btn_elim_selec_carga";
            this.btn_elim_selec_carga.Size = new System.Drawing.Size(84, 48);
            this.btn_elim_selec_carga.TabIndex = 80;
            this.btn_elim_selec_carga.Text = "eliminar seleccionado";
            this.btn_elim_selec_carga.UseVisualStyleBackColor = true;
            this.btn_elim_selec_carga.Click += new System.EventHandler(this.btn_elim_selec_carga_Click);
            // 
            // btn_cargar_lst_comprar
            // 
            this.btn_cargar_lst_comprar.Location = new System.Drawing.Point(76, 267);
            this.btn_cargar_lst_comprar.Name = "btn_cargar_lst_comprar";
            this.btn_cargar_lst_comprar.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar_lst_comprar.TabIndex = 79;
            this.btn_cargar_lst_comprar.Text = "cargar compra";
            this.btn_cargar_lst_comprar.UseVisualStyleBackColor = true;
            this.btn_cargar_lst_comprar.Click += new System.EventHandler(this.btn_cargar_lst_comprar_Click);
            // 
            // lst_carga
            // 
            this.lst_carga.FormattingEnabled = true;
            this.lst_carga.Location = new System.Drawing.Point(163, 116);
            this.lst_carga.Name = "lst_carga";
            this.lst_carga.Size = new System.Drawing.Size(319, 173);
            this.lst_carga.TabIndex = 78;
            this.lst_carga.DoubleClick += new System.EventHandler(this.lst_carga_DoubleClick);
            // 
            // btn_individual
            // 
            this.btn_individual.Location = new System.Drawing.Point(767, 76);
            this.btn_individual.Name = "btn_individual";
            this.btn_individual.Size = new System.Drawing.Size(75, 39);
            this.btn_individual.TabIndex = 53;
            this.btn_individual.Text = "individual";
            this.btn_individual.UseVisualStyleBackColor = true;
            this.btn_individual.Click += new System.EventHandler(this.btn_individual_Click);
            // 
            // btn_paquete
            // 
            this.btn_paquete.Location = new System.Drawing.Point(767, 31);
            this.btn_paquete.Name = "btn_paquete";
            this.btn_paquete.Size = new System.Drawing.Size(75, 39);
            this.btn_paquete.TabIndex = 52;
            this.btn_paquete.Text = "paquete";
            this.btn_paquete.UseVisualStyleBackColor = true;
            this.btn_paquete.Click += new System.EventHandler(this.btn_paquete_Click);
            // 
            // cmb_provedor
            // 
            this.cmb_provedor.FormattingEnabled = true;
            this.cmb_provedor.ItemHeight = 13;
            this.cmb_provedor.Location = new System.Drawing.Point(644, 53);
            this.cmb_provedor.Name = "cmb_provedor";
            this.cmb_provedor.Size = new System.Drawing.Size(117, 21);
            this.cmb_provedor.TabIndex = 51;
            // 
            // Lbl_nom_product_list
            // 
            this.Lbl_nom_product_list.AutoSize = true;
            this.Lbl_nom_product_list.Location = new System.Drawing.Point(160, 303);
            this.Lbl_nom_product_list.Name = "Lbl_nom_product_list";
            this.Lbl_nom_product_list.Size = new System.Drawing.Size(185, 13);
            this.Lbl_nom_product_list.TabIndex = 77;
            this.Lbl_nom_product_list.Text = "nombre_precio_produc_seleccionado";
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuenta.Location = new System.Drawing.Point(671, 339);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(19, 20);
            this.Lbl_cuenta.TabIndex = 76;
            this.Lbl_cuenta.Text = "$";
            // 
            // Btn_cargar_pedido
            // 
            this.Btn_cargar_pedido.Location = new System.Drawing.Point(500, 339);
            this.Btn_cargar_pedido.Name = "Btn_cargar_pedido";
            this.Btn_cargar_pedido.Size = new System.Drawing.Size(98, 39);
            this.Btn_cargar_pedido.TabIndex = 58;
            this.Btn_cargar_pedido.Text = "cargar pedido";
            this.Btn_cargar_pedido.UseVisualStyleBackColor = true;
            this.Btn_cargar_pedido.Click += new System.EventHandler(this.Btn_cargar_pedido_Click);
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Location = new System.Drawing.Point(160, 60);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(13, 13);
            this.Lbl_id.TabIndex = 75;
            this.Lbl_id.Text = "0";
            // 
            // Lbl_id_titulo
            // 
            this.Lbl_id_titulo.AutoSize = true;
            this.Lbl_id_titulo.Location = new System.Drawing.Point(160, 37);
            this.Lbl_id_titulo.Name = "Lbl_id_titulo";
            this.Lbl_id_titulo.Size = new System.Drawing.Size(18, 13);
            this.Lbl_id_titulo.TabIndex = 74;
            this.Lbl_id_titulo.Text = "ID";
            // 
            // Btn_elim_ultimo
            // 
            this.Btn_elim_ultimo.Location = new System.Drawing.Point(789, 258);
            this.Btn_elim_ultimo.Name = "Btn_elim_ultimo";
            this.Btn_elim_ultimo.Size = new System.Drawing.Size(75, 40);
            this.Btn_elim_ultimo.TabIndex = 56;
            this.Btn_elim_ultimo.Text = "eliminar ultimo";
            this.Btn_elim_ultimo.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo.Click += new System.EventHandler(this.Btn_elim_ultimo_Click);
            // 
            // Btn_procesar_venta
            // 
            this.Btn_procesar_venta.Location = new System.Drawing.Point(789, 303);
            this.Btn_procesar_venta.Name = "Btn_procesar_venta";
            this.Btn_procesar_venta.Size = new System.Drawing.Size(75, 23);
            this.Btn_procesar_venta.TabIndex = 57;
            this.Btn_procesar_venta.Text = "procesar venta";
            this.Btn_procesar_venta.UseVisualStyleBackColor = true;
            this.Btn_procesar_venta.Click += new System.EventHandler(this.Btn_procesar_venta_Click);
            // 
            // Btn_eliminar_todo
            // 
            this.Btn_eliminar_todo.Location = new System.Drawing.Point(789, 225);
            this.Btn_eliminar_todo.Name = "Btn_eliminar_todo";
            this.Btn_eliminar_todo.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar_todo.TabIndex = 55;
            this.Btn_eliminar_todo.Text = "eliminar todo";
            this.Btn_eliminar_todo.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo.Click += new System.EventHandler(this.Btn_eliminar_todo_Click);
            // 
            // Btn_eliminar_seleccionado
            // 
            this.Btn_eliminar_seleccionado.Location = new System.Drawing.Point(789, 177);
            this.Btn_eliminar_seleccionado.Name = "Btn_eliminar_seleccionado";
            this.Btn_eliminar_seleccionado.Size = new System.Drawing.Size(86, 42);
            this.Btn_eliminar_seleccionado.TabIndex = 54;
            this.Btn_eliminar_seleccionado.Text = "eliminar seleccionado";
            this.Btn_eliminar_seleccionado.UseVisualStyleBackColor = true;
            this.Btn_eliminar_seleccionado.Click += new System.EventHandler(this.Btn_eliminar_seleccionado_Click);
            // 
            // Lst_compras
            // 
            this.Lst_compras.FormattingEnabled = true;
            this.Lst_compras.Location = new System.Drawing.Point(504, 116);
            this.Lst_compras.Name = "Lst_compras";
            this.Lst_compras.Size = new System.Drawing.Size(279, 173);
            this.Lst_compras.TabIndex = 68;
            this.Lst_compras.SelectedIndexChanged += new System.EventHandler(this.Lst_compras_SelectedIndexChanged);
            // 
            // Rdb_producto
            // 
            this.Rdb_producto.AutoSize = true;
            this.Rdb_producto.Location = new System.Drawing.Point(12, 107);
            this.Rdb_producto.Name = "Rdb_producto";
            this.Rdb_producto.Size = new System.Drawing.Size(14, 13);
            this.Rdb_producto.TabIndex = 63;
            this.Rdb_producto.TabStop = true;
            this.Rdb_producto.UseVisualStyleBackColor = true;
            // 
            // Rdb_codigo_barras
            // 
            this.Rdb_codigo_barras.AutoSize = true;
            this.Rdb_codigo_barras.Location = new System.Drawing.Point(12, 56);
            this.Rdb_codigo_barras.Name = "Rdb_codigo_barras";
            this.Rdb_codigo_barras.Size = new System.Drawing.Size(14, 13);
            this.Rdb_codigo_barras.TabIndex = 61;
            this.Rdb_codigo_barras.TabStop = true;
            this.Rdb_codigo_barras.UseVisualStyleBackColor = true;
            // 
            // Txt_nom_producto
            // 
            this.Txt_nom_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_nom_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_nom_producto.Location = new System.Drawing.Point(32, 107);
            this.Txt_nom_producto.Name = "Txt_nom_producto";
            this.Txt_nom_producto.Size = new System.Drawing.Size(119, 20);
            this.Txt_nom_producto.TabIndex = 59;
            this.Txt_nom_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_nom_producto_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "nombre producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "provedor";
            // 
            // Txt_buscar_producto
            // 
            this.Txt_buscar_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_buscar_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_buscar_producto.Location = new System.Drawing.Point(32, 53);
            this.Txt_buscar_producto.Name = "Txt_buscar_producto";
            this.Txt_buscar_producto.Size = new System.Drawing.Size(119, 20);
            this.Txt_buscar_producto.TabIndex = 50;
            this.Txt_buscar_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_buscar_producto_PreviewKeyDown);
            // 
            // Lbl_nombre_producto
            // 
            this.Lbl_nombre_producto.AutoSize = true;
            this.Lbl_nombre_producto.Location = new System.Drawing.Point(201, 57);
            this.Lbl_nombre_producto.Name = "Lbl_nombre_producto";
            this.Lbl_nombre_producto.Size = new System.Drawing.Size(87, 13);
            this.Lbl_nombre_producto.TabIndex = 64;
            this.Lbl_nombre_producto.Text = "nombre producto";
            // 
            // Lbl_producto
            // 
            this.Lbl_producto.AutoSize = true;
            this.Lbl_producto.Location = new System.Drawing.Point(201, 37);
            this.Lbl_producto.Name = "Lbl_producto";
            this.Lbl_producto.Size = new System.Drawing.Size(49, 13);
            this.Lbl_producto.TabIndex = 62;
            this.Lbl_producto.Text = "producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "cantidad inventario";
            // 
            // Lbl_cantidad_cant
            // 
            this.Lbl_cantidad_cant.AutoSize = true;
            this.Lbl_cantidad_cant.Location = new System.Drawing.Point(501, 60);
            this.Lbl_cantidad_cant.Name = "Lbl_cantidad_cant";
            this.Lbl_cantidad_cant.Size = new System.Drawing.Size(13, 13);
            this.Lbl_cantidad_cant.TabIndex = 71;
            this.Lbl_cantidad_cant.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "precio compra";
            // 
            // Lbl_precio_compra_cant
            // 
            this.Lbl_precio_compra_cant.AutoSize = true;
            this.Lbl_precio_compra_cant.Location = new System.Drawing.Point(332, 60);
            this.Lbl_precio_compra_cant.Name = "Lbl_precio_compra_cant";
            this.Lbl_precio_compra_cant.Size = new System.Drawing.Size(13, 13);
            this.Lbl_precio_compra_cant.TabIndex = 66;
            this.Lbl_precio_compra_cant.Text = "$";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(416, 37);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(66, 13);
            this.label0.TabIndex = 67;
            this.label0.Text = "precio venta";
            // 
            // Lbl_precio_venta
            // 
            this.Lbl_precio_venta.AutoSize = true;
            this.Lbl_precio_venta.Location = new System.Drawing.Point(416, 60);
            this.Lbl_precio_venta.Name = "Lbl_precio_venta";
            this.Lbl_precio_venta.Size = new System.Drawing.Size(13, 13);
            this.Lbl_precio_venta.TabIndex = 69;
            this.Lbl_precio_venta.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "codigo de barras";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustesToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 83;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ajustesToolStripMenuItem.Text = "ajustes";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igualarProvedpresToolStripMenuItem,
            this.cargarRapidoCodigosToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.opcionesToolStripMenuItem.Text = "opciones";
            // 
            // igualarProvedpresToolStripMenuItem
            // 
            this.igualarProvedpresToolStripMenuItem.Name = "igualarProvedpresToolStripMenuItem";
            this.igualarProvedpresToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.igualarProvedpresToolStripMenuItem.Text = "igualar provedpres";
            this.igualarProvedpresToolStripMenuItem.Click += new System.EventHandler(this.igualarProvedpresToolStripMenuItem_Click);
            // 
            // cargarRapidoCodigosToolStripMenuItem
            // 
            this.cargarRapidoCodigosToolStripMenuItem.Name = "cargarRapidoCodigosToolStripMenuItem";
            this.cargarRapidoCodigosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cargarRapidoCodigosToolStripMenuItem.Text = "cargar rapido codigos";
            this.cargarRapidoCodigosToolStripMenuItem.Click += new System.EventHandler(this.cargarRapidoCodigosToolStripMenuItem_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 385);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_elim_ultimo_carga);
            this.Controls.Add(this.btn_elim_todos_carga);
            this.Controls.Add(this.btn_elim_selec_carga);
            this.Controls.Add(this.btn_cargar_lst_comprar);
            this.Controls.Add(this.lst_carga);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_buscar_producto);
            this.Controls.Add(this.Lbl_nombre_producto);
            this.Controls.Add(this.Lbl_producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_cantidad_cant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_precio_compra_cant);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.Lbl_precio_venta);
            this.Controls.Add(this.label4);
            this.Name = "Compras";
            this.Text = "Compras";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_elim_ultimo_carga;
        private System.Windows.Forms.Button btn_elim_todos_carga;
        private System.Windows.Forms.Button btn_elim_selec_carga;
        private System.Windows.Forms.Button btn_cargar_lst_comprar;
        public System.Windows.Forms.ListBox lst_carga;
        private System.Windows.Forms.Button btn_individual;
        private System.Windows.Forms.Button btn_paquete;
        private System.Windows.Forms.ComboBox cmb_provedor;
        private System.Windows.Forms.Label Lbl_nom_product_list;
        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.Button Btn_cargar_pedido;
        private System.Windows.Forms.Label Lbl_id;
        private System.Windows.Forms.Label Lbl_id_titulo;
        private System.Windows.Forms.Button Btn_elim_ultimo;
        private System.Windows.Forms.Button Btn_procesar_venta;
        private System.Windows.Forms.Button Btn_eliminar_todo;
        private System.Windows.Forms.Button Btn_eliminar_seleccionado;
        private System.Windows.Forms.ListBox Lst_compras;
        private System.Windows.Forms.RadioButton Rdb_producto;
        private System.Windows.Forms.RadioButton Rdb_codigo_barras;
        private System.Windows.Forms.TextBox Txt_nom_producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_buscar_producto;
        private System.Windows.Forms.Label Lbl_nombre_producto;
        private System.Windows.Forms.Label Lbl_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_cantidad_cant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_precio_compra_cant;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label Lbl_precio_venta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igualarProvedpresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarRapidoCodigosToolStripMenuItem;
    }
}