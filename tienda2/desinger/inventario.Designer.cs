
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
            this.Btn_elim_ultimo = new System.Windows.Forms.Button();
            this.Btn_verificar_inv = new System.Windows.Forms.Button();
            this.Btn_eliminar_todo = new System.Windows.Forms.Button();
            this.Btn_eliminar_seleccionado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_cod_bar = new System.Windows.Forms.ListBox();
            this.txt_cod_bar = new System.Windows.Forms.TextBox();
            this.lst_todos_los_agregados = new System.Windows.Forms.ListBox();
            this.btn_terminar = new System.Windows.Forms.Button();
            this.Btn_eliminar_seleccionado2 = new System.Windows.Forms.Button();
            this.Btn_eliminar_todo2 = new System.Windows.Forms.Button();
            this.Btn_elim_ultimo2 = new System.Windows.Forms.Button();
            this.chb_cambiar_invent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_elim_ultimo
            // 
            this.Btn_elim_ultimo.Location = new System.Drawing.Point(176, 232);
            this.Btn_elim_ultimo.Name = "Btn_elim_ultimo";
            this.Btn_elim_ultimo.Size = new System.Drawing.Size(86, 40);
            this.Btn_elim_ultimo.TabIndex = 23;
            this.Btn_elim_ultimo.Text = "eliminar ultimo";
            this.Btn_elim_ultimo.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo.Click += new System.EventHandler(this.Btn_elim_ultimo_Click);
            // 
            // Btn_verificar_inv
            // 
            this.Btn_verificar_inv.Location = new System.Drawing.Point(176, 278);
            this.Btn_verificar_inv.Name = "Btn_verificar_inv";
            this.Btn_verificar_inv.Size = new System.Drawing.Size(86, 36);
            this.Btn_verificar_inv.TabIndex = 22;
            this.Btn_verificar_inv.Text = "verificar";
            this.Btn_verificar_inv.UseVisualStyleBackColor = true;
            this.Btn_verificar_inv.Click += new System.EventHandler(this.Btn_verificar_inv_Click);
            // 
            // Btn_eliminar_todo
            // 
            this.Btn_eliminar_todo.Location = new System.Drawing.Point(176, 199);
            this.Btn_eliminar_todo.Name = "Btn_eliminar_todo";
            this.Btn_eliminar_todo.Size = new System.Drawing.Size(86, 23);
            this.Btn_eliminar_todo.TabIndex = 24;
            this.Btn_eliminar_todo.Text = "eliminar todo";
            this.Btn_eliminar_todo.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo.Click += new System.EventHandler(this.Btn_eliminar_todo_Click);
            // 
            // Btn_eliminar_seleccionado
            // 
            this.Btn_eliminar_seleccionado.Location = new System.Drawing.Point(176, 151);
            this.Btn_eliminar_seleccionado.Name = "Btn_eliminar_seleccionado";
            this.Btn_eliminar_seleccionado.Size = new System.Drawing.Size(86, 42);
            this.Btn_eliminar_seleccionado.TabIndex = 25;
            this.Btn_eliminar_seleccionado.Text = "eliminar seleccionado";
            this.Btn_eliminar_seleccionado.UseVisualStyleBackColor = true;
            this.Btn_eliminar_seleccionado.Click += new System.EventHandler(this.Btn_eliminar_seleccionado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "codigo de barras";
            // 
            // lst_cod_bar
            // 
            this.lst_cod_bar.FormattingEnabled = true;
            this.lst_cod_bar.Location = new System.Drawing.Point(15, 51);
            this.lst_cod_bar.Name = "lst_cod_bar";
            this.lst_cod_bar.Size = new System.Drawing.Size(155, 251);
            this.lst_cod_bar.TabIndex = 20;
            // 
            // txt_cod_bar
            // 
            this.txt_cod_bar.Location = new System.Drawing.Point(15, 25);
            this.txt_cod_bar.Name = "txt_cod_bar";
            this.txt_cod_bar.Size = new System.Drawing.Size(155, 20);
            this.txt_cod_bar.TabIndex = 19;
            this.txt_cod_bar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_cod_bar_PreviewKeyDown);
            // 
            // lst_todos_los_agregados
            // 
            this.lst_todos_los_agregados.FormattingEnabled = true;
            this.lst_todos_los_agregados.Location = new System.Drawing.Point(285, 51);
            this.lst_todos_los_agregados.Name = "lst_todos_los_agregados";
            this.lst_todos_los_agregados.Size = new System.Drawing.Size(374, 251);
            this.lst_todos_los_agregados.TabIndex = 20;
            // 
            // btn_terminar
            // 
            this.btn_terminar.Location = new System.Drawing.Point(668, 291);
            this.btn_terminar.Name = "btn_terminar";
            this.btn_terminar.Size = new System.Drawing.Size(75, 35);
            this.btn_terminar.TabIndex = 26;
            this.btn_terminar.Text = "se termino inventario";
            this.btn_terminar.UseVisualStyleBackColor = true;
            this.btn_terminar.Click += new System.EventHandler(this.btn_terminar_Click);
            // 
            // Btn_eliminar_seleccionado2
            // 
            this.Btn_eliminar_seleccionado2.Location = new System.Drawing.Point(665, 151);
            this.Btn_eliminar_seleccionado2.Name = "Btn_eliminar_seleccionado2";
            this.Btn_eliminar_seleccionado2.Size = new System.Drawing.Size(78, 42);
            this.Btn_eliminar_seleccionado2.TabIndex = 27;
            this.Btn_eliminar_seleccionado2.Text = "eliminar seleccionado";
            this.Btn_eliminar_seleccionado2.UseVisualStyleBackColor = true;
            this.Btn_eliminar_seleccionado2.Click += new System.EventHandler(this.Btn_eliminar_seleccionado2_Click);
            // 
            // Btn_eliminar_todo2
            // 
            this.Btn_eliminar_todo2.Location = new System.Drawing.Point(668, 199);
            this.Btn_eliminar_todo2.Name = "Btn_eliminar_todo2";
            this.Btn_eliminar_todo2.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar_todo2.TabIndex = 28;
            this.Btn_eliminar_todo2.Text = "eliminar todo";
            this.Btn_eliminar_todo2.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo2.Click += new System.EventHandler(this.Btn_eliminar_todo2_Click);
            // 
            // Btn_elim_ultimo2
            // 
            this.Btn_elim_ultimo2.Location = new System.Drawing.Point(668, 232);
            this.Btn_elim_ultimo2.Name = "Btn_elim_ultimo2";
            this.Btn_elim_ultimo2.Size = new System.Drawing.Size(75, 40);
            this.Btn_elim_ultimo2.TabIndex = 29;
            this.Btn_elim_ultimo2.Text = "eliminar ultimo";
            this.Btn_elim_ultimo2.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo2.Click += new System.EventHandler(this.Btn_elim_ultimo2_Click);
            // 
            // chb_cambiar_invent
            // 
            this.chb_cambiar_invent.AutoSize = true;
            this.chb_cambiar_invent.Location = new System.Drawing.Point(668, 332);
            this.chb_cambiar_invent.Name = "chb_cambiar_invent";
            this.chb_cambiar_invent.Size = new System.Drawing.Size(112, 17);
            this.chb_cambiar_invent.TabIndex = 30;
            this.chb_cambiar_invent.Text = "cambiar inventario";
            this.chb_cambiar_invent.UseVisualStyleBackColor = true;
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
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
            this.Name = "inventario";
            this.Text = "inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_elim_ultimo;
        private System.Windows.Forms.Button Btn_verificar_inv;
        private System.Windows.Forms.Button Btn_eliminar_todo;
        private System.Windows.Forms.Button Btn_eliminar_seleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_cod_bar;
        private System.Windows.Forms.TextBox txt_cod_bar;
        private System.Windows.Forms.ListBox lst_todos_los_agregados;
        private System.Windows.Forms.Button btn_terminar;
        private System.Windows.Forms.Button Btn_eliminar_seleccionado2;
        private System.Windows.Forms.Button Btn_eliminar_todo2;
        private System.Windows.Forms.Button Btn_elim_ultimo2;
        private System.Windows.Forms.CheckBox chb_cambiar_invent;
    }
}