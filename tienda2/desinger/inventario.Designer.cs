﻿
namespace tienda2.desinger
{
    partial class inventario
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
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirYBorrarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cargar_archivo_inv = new System.Windows.Forms.Button();
            this.chb_cambiar_invent = new System.Windows.Forms.CheckBox();
            this.Btn_elim_ultimo2 = new System.Windows.Forms.Button();
            this.Btn_eliminar_todo2 = new System.Windows.Forms.Button();
            this.Btn_eliminar_seleccionado2 = new System.Windows.Forms.Button();
            this.btn_terminar = new System.Windows.Forms.Button();
            this.Btn_elim_ultimo = new System.Windows.Forms.Button();
            this.Btn_verificar_inv = new System.Windows.Forms.Button();
            this.Btn_eliminar_todo = new System.Windows.Forms.Button();
            this.Btn_eliminar_seleccionado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_todos_los_agregados = new System.Windows.Forms.ListBox();
            this.lst_cod_bar = new System.Windows.Forms.ListBox();
            this.txt_cod_bar = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirYBorrarInventarioToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.opcionesToolStripMenuItem.Text = "opciones";
            // 
            // salirYBorrarInventarioToolStripMenuItem
            // 
            this.salirYBorrarInventarioToolStripMenuItem.Name = "salirYBorrarInventarioToolStripMenuItem";
            this.salirYBorrarInventarioToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.salirYBorrarInventarioToolStripMenuItem.Text = "salir y borrar inventario";
            this.salirYBorrarInventarioToolStripMenuItem.Click += new System.EventHandler(this.salirYBorrarInventarioToolStripMenuItem_Click);
            // 
            // btn_cargar_archivo_inv
            // 
            this.btn_cargar_archivo_inv.Location = new System.Drawing.Point(176, 31);
            this.btn_cargar_archivo_inv.Name = "btn_cargar_archivo_inv";
            this.btn_cargar_archivo_inv.Size = new System.Drawing.Size(75, 36);
            this.btn_cargar_archivo_inv.TabIndex = 47;
            this.btn_cargar_archivo_inv.Text = "cargar inventario";
            this.btn_cargar_archivo_inv.UseVisualStyleBackColor = true;
            this.btn_cargar_archivo_inv.Click += new System.EventHandler(this.btn_cargar_archivo_inv_Click);
            // 
            // chb_cambiar_invent
            // 
            this.chb_cambiar_invent.AutoSize = true;
            this.chb_cambiar_invent.Location = new System.Drawing.Point(668, 332);
            this.chb_cambiar_invent.Name = "chb_cambiar_invent";
            this.chb_cambiar_invent.Size = new System.Drawing.Size(112, 17);
            this.chb_cambiar_invent.TabIndex = 46;
            this.chb_cambiar_invent.Text = "cambiar inventario";
            this.chb_cambiar_invent.UseVisualStyleBackColor = true;
            // 
            // Btn_elim_ultimo2
            // 
            this.Btn_elim_ultimo2.Location = new System.Drawing.Point(668, 232);
            this.Btn_elim_ultimo2.Name = "Btn_elim_ultimo2";
            this.Btn_elim_ultimo2.Size = new System.Drawing.Size(75, 40);
            this.Btn_elim_ultimo2.TabIndex = 45;
            this.Btn_elim_ultimo2.Text = "eliminar ultimo";
            this.Btn_elim_ultimo2.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo2.Click += new System.EventHandler(this.Btn_elim_ultimo2_Click);
            // 
            // Btn_eliminar_todo2
            // 
            this.Btn_eliminar_todo2.Location = new System.Drawing.Point(668, 199);
            this.Btn_eliminar_todo2.Name = "Btn_eliminar_todo2";
            this.Btn_eliminar_todo2.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar_todo2.TabIndex = 44;
            this.Btn_eliminar_todo2.Text = "eliminar todo";
            this.Btn_eliminar_todo2.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo2.Click += new System.EventHandler(this.Btn_eliminar_todo2_Click);
            // 
            // Btn_eliminar_seleccionado2
            // 
            this.Btn_eliminar_seleccionado2.Location = new System.Drawing.Point(665, 151);
            this.Btn_eliminar_seleccionado2.Name = "Btn_eliminar_seleccionado2";
            this.Btn_eliminar_seleccionado2.Size = new System.Drawing.Size(78, 42);
            this.Btn_eliminar_seleccionado2.TabIndex = 43;
            this.Btn_eliminar_seleccionado2.Text = "eliminar seleccionado";
            this.Btn_eliminar_seleccionado2.UseVisualStyleBackColor = true;
            this.Btn_eliminar_seleccionado2.Click += new System.EventHandler(this.Btn_eliminar_seleccionado2_Click);
            // 
            // btn_terminar
            // 
            this.btn_terminar.Location = new System.Drawing.Point(668, 291);
            this.btn_terminar.Name = "btn_terminar";
            this.btn_terminar.Size = new System.Drawing.Size(75, 35);
            this.btn_terminar.TabIndex = 42;
            this.btn_terminar.Text = "se termino inventario";
            this.btn_terminar.UseVisualStyleBackColor = true;
            this.btn_terminar.Click += new System.EventHandler(this.btn_terminar_Click);
            // 
            // Btn_elim_ultimo
            // 
            this.Btn_elim_ultimo.Location = new System.Drawing.Point(176, 247);
            this.Btn_elim_ultimo.Name = "Btn_elim_ultimo";
            this.Btn_elim_ultimo.Size = new System.Drawing.Size(86, 40);
            this.Btn_elim_ultimo.TabIndex = 39;
            this.Btn_elim_ultimo.Text = "eliminar ultimo";
            this.Btn_elim_ultimo.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo.Click += new System.EventHandler(this.Btn_elim_ultimo_Click);
            // 
            // Btn_verificar_inv
            // 
            this.Btn_verificar_inv.Location = new System.Drawing.Point(176, 293);
            this.Btn_verificar_inv.Name = "Btn_verificar_inv";
            this.Btn_verificar_inv.Size = new System.Drawing.Size(86, 36);
            this.Btn_verificar_inv.TabIndex = 38;
            this.Btn_verificar_inv.Text = "verificar";
            this.Btn_verificar_inv.UseVisualStyleBackColor = true;
            this.Btn_verificar_inv.Click += new System.EventHandler(this.Btn_verificar_inv_Click);
            // 
            // Btn_eliminar_todo
            // 
            this.Btn_eliminar_todo.Location = new System.Drawing.Point(176, 214);
            this.Btn_eliminar_todo.Name = "Btn_eliminar_todo";
            this.Btn_eliminar_todo.Size = new System.Drawing.Size(86, 23);
            this.Btn_eliminar_todo.TabIndex = 40;
            this.Btn_eliminar_todo.Text = "eliminar todo";
            this.Btn_eliminar_todo.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo.Click += new System.EventHandler(this.Btn_eliminar_todo_Click);
            // 
            // Btn_eliminar_seleccionado
            // 
            this.Btn_eliminar_seleccionado.Location = new System.Drawing.Point(176, 166);
            this.Btn_eliminar_seleccionado.Name = "Btn_eliminar_seleccionado";
            this.Btn_eliminar_seleccionado.Size = new System.Drawing.Size(86, 42);
            this.Btn_eliminar_seleccionado.TabIndex = 41;
            this.Btn_eliminar_seleccionado.Text = "eliminar seleccionado";
            this.Btn_eliminar_seleccionado.UseVisualStyleBackColor = true;
            this.Btn_eliminar_seleccionado.Click += new System.EventHandler(this.Btn_eliminar_seleccionado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "codigo de barras";
            // 
            // lst_todos_los_agregados
            // 
            this.lst_todos_los_agregados.FormattingEnabled = true;
            this.lst_todos_los_agregados.Location = new System.Drawing.Point(285, 66);
            this.lst_todos_los_agregados.Name = "lst_todos_los_agregados";
            this.lst_todos_los_agregados.Size = new System.Drawing.Size(374, 251);
            this.lst_todos_los_agregados.TabIndex = 35;
            // 
            // lst_cod_bar
            // 
            this.lst_cod_bar.FormattingEnabled = true;
            this.lst_cod_bar.Location = new System.Drawing.Point(15, 66);
            this.lst_cod_bar.Name = "lst_cod_bar";
            this.lst_cod_bar.Size = new System.Drawing.Size(155, 251);
            this.lst_cod_bar.TabIndex = 36;
            // 
            // txt_cod_bar
            // 
            this.txt_cod_bar.Location = new System.Drawing.Point(15, 40);
            this.txt_cod_bar.Name = "txt_cod_bar";
            this.txt_cod_bar.Size = new System.Drawing.Size(155, 20);
            this.txt_cod_bar.TabIndex = 34;
            this.txt_cod_bar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_cod_bar_PreviewKeyDown);
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.btn_cargar_archivo_inv);
            this.Controls.Add(this.chb_cambiar_invent);
            this.Controls.Add(this.Btn_elim_ultimo2);
            this.Controls.Add(this.Btn_eliminar_todo2);
            this.Controls.Add(this.Btn_eliminar_seleccionado2);
            this.Controls.Add(this.btn_terminar);
            this.Controls.Add(this.Btn_elim_ultimo);
            this.Controls.Add(this.Btn_verificar_inv);
            this.Controls.Add(this.Btn_eliminar_todo);
            this.Controls.Add(this.Btn_eliminar_seleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_todos_los_agregados);
            this.Controls.Add(this.lst_cod_bar);
            this.Controls.Add(this.txt_cod_bar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "inventario";
            this.Text = "inventario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirYBorrarInventarioToolStripMenuItem;
        private System.Windows.Forms.Button btn_cargar_archivo_inv;
        private System.Windows.Forms.CheckBox chb_cambiar_invent;
        private System.Windows.Forms.Button Btn_elim_ultimo2;
        private System.Windows.Forms.Button Btn_eliminar_todo2;
        private System.Windows.Forms.Button Btn_eliminar_seleccionado2;
        private System.Windows.Forms.Button btn_terminar;
        private System.Windows.Forms.Button Btn_elim_ultimo;
        private System.Windows.Forms.Button Btn_verificar_inv;
        private System.Windows.Forms.Button Btn_eliminar_todo;
        private System.Windows.Forms.Button Btn_eliminar_seleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_todos_los_agregados;
        private System.Windows.Forms.ListBox lst_cod_bar;
        private System.Windows.Forms.TextBox txt_cod_bar;
    }
}