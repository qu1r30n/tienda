
namespace tienda2.desinger
{
    partial class promociones
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_nom_producto = new System.Windows.Forms.TextBox();
            this.Txt_buscar_producto = new System.Windows.Forms.TextBox();
            this.Btn_elim_ultimo = new System.Windows.Forms.Button();
            this.Btn_procesar_venta = new System.Windows.Forms.Button();
            this.Btn_eliminar_todo = new System.Windows.Forms.Button();
            this.Btn_eliminar_seleccionado = new System.Windows.Forms.Button();
            this.lst_promociones_puestas = new System.Windows.Forms.ListBox();
            this.btn_agregar_promo = new System.Windows.Forms.Button();
            this.btn_elim_promo = new System.Windows.Forms.Button();
            this.lbl_precio_promo = new System.Windows.Forms.Label();
            this.txt_precio_promo = new System.Windows.Forms.TextBox();
            this.lstb_produc_promo = new System.Windows.Forms.ListBox();
            this.lbl_nom_promo = new System.Windows.Forms.Label();
            this.txt_seleccionado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_cost_comp = new System.Windows.Forms.Label();
            this.lbl_cost_vent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "nombre";
            // 
            // Txt_nom_producto
            // 
            this.Txt_nom_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_nom_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_nom_producto.Location = new System.Drawing.Point(299, 295);
            this.Txt_nom_producto.Name = "Txt_nom_producto";
            this.Txt_nom_producto.Size = new System.Drawing.Size(150, 20);
            this.Txt_nom_producto.TabIndex = 38;
            this.Txt_nom_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_nom_producto_PreviewKeyDown);
            // 
            // Txt_buscar_producto
            // 
            this.Txt_buscar_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_buscar_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_buscar_producto.Location = new System.Drawing.Point(299, 269);
            this.Txt_buscar_producto.Name = "Txt_buscar_producto";
            this.Txt_buscar_producto.Size = new System.Drawing.Size(150, 20);
            this.Txt_buscar_producto.TabIndex = 37;
            this.Txt_buscar_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_buscar_producto_KeyPress);
            this.Txt_buscar_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_buscar_producto_PreviewKeyDown);
            // 
            // Btn_elim_ultimo
            // 
            this.Btn_elim_ultimo.Location = new System.Drawing.Point(503, 194);
            this.Btn_elim_ultimo.Name = "Btn_elim_ultimo";
            this.Btn_elim_ultimo.Size = new System.Drawing.Size(75, 40);
            this.Btn_elim_ultimo.TabIndex = 42;
            this.Btn_elim_ultimo.Text = "eliminar ultimo";
            this.Btn_elim_ultimo.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo.Click += new System.EventHandler(this.Btn_elim_ultimo_Click);
            // 
            // Btn_procesar_venta
            // 
            this.Btn_procesar_venta.Location = new System.Drawing.Point(506, 240);
            this.Btn_procesar_venta.Name = "Btn_procesar_venta";
            this.Btn_procesar_venta.Size = new System.Drawing.Size(75, 23);
            this.Btn_procesar_venta.TabIndex = 41;
            this.Btn_procesar_venta.Text = "procesar venta";
            this.Btn_procesar_venta.UseVisualStyleBackColor = true;
            this.Btn_procesar_venta.Click += new System.EventHandler(this.Btn_procesar_venta_Click);
            // 
            // Btn_eliminar_todo
            // 
            this.Btn_eliminar_todo.Location = new System.Drawing.Point(503, 161);
            this.Btn_eliminar_todo.Name = "Btn_eliminar_todo";
            this.Btn_eliminar_todo.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar_todo.TabIndex = 43;
            this.Btn_eliminar_todo.Text = "eliminar todo";
            this.Btn_eliminar_todo.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo.Click += new System.EventHandler(this.Btn_eliminar_todo_Click);
            // 
            // Btn_eliminar_seleccionado
            // 
            this.Btn_eliminar_seleccionado.Location = new System.Drawing.Point(503, 113);
            this.Btn_eliminar_seleccionado.Name = "Btn_eliminar_seleccionado";
            this.Btn_eliminar_seleccionado.Size = new System.Drawing.Size(86, 42);
            this.Btn_eliminar_seleccionado.TabIndex = 44;
            this.Btn_eliminar_seleccionado.Text = "eliminar seleccionado";
            this.Btn_eliminar_seleccionado.UseVisualStyleBackColor = true;
            this.Btn_eliminar_seleccionado.Click += new System.EventHandler(this.Btn_eliminar_seleccionado_Click);
            // 
            // lst_promociones_puestas
            // 
            this.lst_promociones_puestas.FormattingEnabled = true;
            this.lst_promociones_puestas.Location = new System.Drawing.Point(12, 12);
            this.lst_promociones_puestas.Name = "lst_promociones_puestas";
            this.lst_promociones_puestas.Size = new System.Drawing.Size(239, 251);
            this.lst_promociones_puestas.TabIndex = 45;
            this.lst_promociones_puestas.SelectedIndexChanged += new System.EventHandler(this.Lst_ventas_SelectedIndexChanged);
            // 
            // btn_agregar_promo
            // 
            this.btn_agregar_promo.Location = new System.Drawing.Point(12, 269);
            this.btn_agregar_promo.Name = "btn_agregar_promo";
            this.btn_agregar_promo.Size = new System.Drawing.Size(95, 28);
            this.btn_agregar_promo.TabIndex = 46;
            this.btn_agregar_promo.Text = "agregar promo";
            this.btn_agregar_promo.UseVisualStyleBackColor = true;
            this.btn_agregar_promo.Click += new System.EventHandler(this.btn_agregar_promo_Click);
            // 
            // btn_elim_promo
            // 
            this.btn_elim_promo.Location = new System.Drawing.Point(113, 269);
            this.btn_elim_promo.Name = "btn_elim_promo";
            this.btn_elim_promo.Size = new System.Drawing.Size(95, 28);
            this.btn_elim_promo.TabIndex = 46;
            this.btn_elim_promo.Text = "eliminar promo";
            this.btn_elim_promo.UseVisualStyleBackColor = true;
            this.btn_elim_promo.Click += new System.EventHandler(this.btn_elim_promo_Click);
            // 
            // lbl_precio_promo
            // 
            this.lbl_precio_promo.AutoSize = true;
            this.lbl_precio_promo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_promo.Location = new System.Drawing.Point(502, 28);
            this.lbl_precio_promo.Name = "lbl_precio_promo";
            this.lbl_precio_promo.Size = new System.Drawing.Size(113, 20);
            this.lbl_precio_promo.TabIndex = 47;
            this.lbl_precio_promo.Text = "precio promo";
            // 
            // txt_precio_promo
            // 
            this.txt_precio_promo.Location = new System.Drawing.Point(506, 51);
            this.txt_precio_promo.Name = "txt_precio_promo";
            this.txt_precio_promo.Size = new System.Drawing.Size(100, 20);
            this.txt_precio_promo.TabIndex = 48;
            // 
            // lstb_produc_promo
            // 
            this.lstb_produc_promo.FormattingEnabled = true;
            this.lstb_produc_promo.Location = new System.Drawing.Point(257, 12);
            this.lstb_produc_promo.Name = "lstb_produc_promo";
            this.lstb_produc_promo.Size = new System.Drawing.Size(239, 251);
            this.lstb_produc_promo.TabIndex = 49;
            this.lstb_produc_promo.SelectedIndexChanged += new System.EventHandler(this.lstb_produc_promo_SelectedIndexChanged);
            this.lstb_produc_promo.DoubleClick += new System.EventHandler(this.lstb_produc_promo_DoubleClick);
            this.lstb_produc_promo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lstb_produc_promo_PreviewKeyDown);
            // 
            // lbl_nom_promo
            // 
            this.lbl_nom_promo.AutoSize = true;
            this.lbl_nom_promo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_promo.Location = new System.Drawing.Point(503, 12);
            this.lbl_nom_promo.Name = "lbl_nom_promo";
            this.lbl_nom_promo.Size = new System.Drawing.Size(147, 16);
            this.lbl_nom_promo.TabIndex = 50;
            this.lbl_nom_promo.Text = "nombre de la promo";
            // 
            // txt_seleccionado
            // 
            this.txt_seleccionado.Location = new System.Drawing.Point(7, 321);
            this.txt_seleccionado.Name = "txt_seleccionado";
            this.txt_seleccionado.Size = new System.Drawing.Size(643, 20);
            this.txt_seleccionado.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "costo compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "costo venta";
            // 
            // lbl_cost_comp
            // 
            this.lbl_cost_comp.AutoSize = true;
            this.lbl_cost_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost_comp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cost_comp.Location = new System.Drawing.Point(577, 272);
            this.lbl_cost_comp.Name = "lbl_cost_comp";
            this.lbl_cost_comp.Size = new System.Drawing.Size(16, 16);
            this.lbl_cost_comp.TabIndex = 54;
            this.lbl_cost_comp.Text = "0";
            // 
            // lbl_cost_vent
            // 
            this.lbl_cost_vent.AutoSize = true;
            this.lbl_cost_vent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost_vent.Location = new System.Drawing.Point(577, 295);
            this.lbl_cost_vent.Name = "lbl_cost_vent";
            this.lbl_cost_vent.Size = new System.Drawing.Size(16, 16);
            this.lbl_cost_vent.TabIndex = 55;
            this.lbl_cost_vent.Text = "0";
            // 
            // promociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 346);
            this.Controls.Add(this.lbl_cost_vent);
            this.Controls.Add(this.lbl_cost_comp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_seleccionado);
            this.Controls.Add(this.lbl_nom_promo);
            this.Controls.Add(this.lstb_produc_promo);
            this.Controls.Add(this.txt_precio_promo);
            this.Controls.Add(this.lbl_precio_promo);
            this.Controls.Add(this.btn_elim_promo);
            this.Controls.Add(this.btn_agregar_promo);
            this.Controls.Add(this.lst_promociones_puestas);
            this.Controls.Add(this.Btn_elim_ultimo);
            this.Controls.Add(this.Btn_procesar_venta);
            this.Controls.Add(this.Btn_eliminar_todo);
            this.Controls.Add(this.Btn_eliminar_seleccionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_nom_producto);
            this.Controls.Add(this.Txt_buscar_producto);
            this.Name = "promociones";
            this.Text = "promociones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.promociones_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_nom_producto;
        private System.Windows.Forms.TextBox Txt_buscar_producto;
        private System.Windows.Forms.Button Btn_elim_ultimo;
        private System.Windows.Forms.Button Btn_procesar_venta;
        private System.Windows.Forms.Button Btn_eliminar_todo;
        private System.Windows.Forms.Button Btn_eliminar_seleccionado;
        private System.Windows.Forms.ListBox lst_promociones_puestas;
        private System.Windows.Forms.Button btn_agregar_promo;
        private System.Windows.Forms.Button btn_elim_promo;
        private System.Windows.Forms.Label lbl_precio_promo;
        private System.Windows.Forms.TextBox txt_precio_promo;
        private System.Windows.Forms.ListBox lstb_produc_promo;
        private System.Windows.Forms.Label lbl_nom_promo;
        private System.Windows.Forms.TextBox txt_seleccionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_cost_comp;
        private System.Windows.Forms.Label lbl_cost_vent;
    }
}