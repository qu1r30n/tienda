﻿
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
            this.lstb_produc_promo = new System.Windows.Forms.ListBox();
            this.btn_agregar_promo = new System.Windows.Forms.Button();
            this.btn_elim_promo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "nombre";
            // 
            // Txt_nom_producto
            // 
            this.Txt_nom_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_nom_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_nom_producto.Location = new System.Drawing.Point(299, 302);
            this.Txt_nom_producto.Name = "Txt_nom_producto";
            this.Txt_nom_producto.Size = new System.Drawing.Size(150, 20);
            this.Txt_nom_producto.TabIndex = 38;
            this.Txt_nom_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_nom_producto_PreviewKeyDown);
            // 
            // Txt_buscar_producto
            // 
            this.Txt_buscar_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_buscar_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_buscar_producto.Location = new System.Drawing.Point(299, 276);
            this.Txt_buscar_producto.Name = "Txt_buscar_producto";
            this.Txt_buscar_producto.Size = new System.Drawing.Size(150, 20);
            this.Txt_buscar_producto.TabIndex = 37;
            this.Txt_buscar_producto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_buscar_producto_PreviewKeyDown);
            // 
            // Btn_elim_ultimo
            // 
            this.Btn_elim_ultimo.Location = new System.Drawing.Point(502, 113);
            this.Btn_elim_ultimo.Name = "Btn_elim_ultimo";
            this.Btn_elim_ultimo.Size = new System.Drawing.Size(75, 40);
            this.Btn_elim_ultimo.TabIndex = 42;
            this.Btn_elim_ultimo.Text = "eliminar ultimo";
            this.Btn_elim_ultimo.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo.Click += new System.EventHandler(this.Btn_elim_ultimo_Click);
            // 
            // Btn_procesar_venta
            // 
            this.Btn_procesar_venta.Location = new System.Drawing.Point(502, 159);
            this.Btn_procesar_venta.Name = "Btn_procesar_venta";
            this.Btn_procesar_venta.Size = new System.Drawing.Size(75, 23);
            this.Btn_procesar_venta.TabIndex = 41;
            this.Btn_procesar_venta.Text = "procesar venta";
            this.Btn_procesar_venta.UseVisualStyleBackColor = true;
            this.Btn_procesar_venta.Click += new System.EventHandler(this.Btn_procesar_venta_Click);
            // 
            // Btn_eliminar_todo
            // 
            this.Btn_eliminar_todo.Location = new System.Drawing.Point(502, 80);
            this.Btn_eliminar_todo.Name = "Btn_eliminar_todo";
            this.Btn_eliminar_todo.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar_todo.TabIndex = 43;
            this.Btn_eliminar_todo.Text = "eliminar todo";
            this.Btn_eliminar_todo.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo.Click += new System.EventHandler(this.Btn_eliminar_todo_Click);
            // 
            // Btn_eliminar_seleccionado
            // 
            this.Btn_eliminar_seleccionado.Location = new System.Drawing.Point(502, 32);
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
            this.lst_promociones_puestas.Location = new System.Drawing.Point(12, 19);
            this.lst_promociones_puestas.Name = "lst_promociones_puestas";
            this.lst_promociones_puestas.Size = new System.Drawing.Size(239, 251);
            this.lst_promociones_puestas.TabIndex = 45;
            this.lst_promociones_puestas.SelectedIndexChanged += new System.EventHandler(this.Lst_ventas_SelectedIndexChanged);
            // 
            // lstb_produc_promo
            // 
            this.lstb_produc_promo.FormattingEnabled = true;
            this.lstb_produc_promo.Location = new System.Drawing.Point(257, 19);
            this.lstb_produc_promo.Name = "lstb_produc_promo";
            this.lstb_produc_promo.Size = new System.Drawing.Size(239, 251);
            this.lstb_produc_promo.TabIndex = 45;
            this.lstb_produc_promo.SelectedIndexChanged += new System.EventHandler(this.Lst_ventas_SelectedIndexChanged);
            // 
            // btn_agregar_promo
            // 
            this.btn_agregar_promo.Location = new System.Drawing.Point(12, 276);
            this.btn_agregar_promo.Name = "btn_agregar_promo";
            this.btn_agregar_promo.Size = new System.Drawing.Size(95, 28);
            this.btn_agregar_promo.TabIndex = 46;
            this.btn_agregar_promo.Text = "agregar promo";
            this.btn_agregar_promo.UseVisualStyleBackColor = true;
            this.btn_agregar_promo.Click += new System.EventHandler(this.btn_agregar_promo_Click);
            // 
            // btn_elim_promo
            // 
            this.btn_elim_promo.Location = new System.Drawing.Point(113, 276);
            this.btn_elim_promo.Name = "btn_elim_promo";
            this.btn_elim_promo.Size = new System.Drawing.Size(95, 28);
            this.btn_elim_promo.TabIndex = 46;
            this.btn_elim_promo.Text = "eliminar promo";
            this.btn_elim_promo.UseVisualStyleBackColor = true;
            this.btn_elim_promo.Click += new System.EventHandler(this.btn_elim_promo_Click);
            // 
            // promociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 343);
            this.Controls.Add(this.btn_elim_promo);
            this.Controls.Add(this.btn_agregar_promo);
            this.Controls.Add(this.lstb_produc_promo);
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
        private System.Windows.Forms.ListBox lstb_produc_promo;
        private System.Windows.Forms.Button btn_agregar_promo;
        private System.Windows.Forms.Button btn_elim_promo;
    }
}