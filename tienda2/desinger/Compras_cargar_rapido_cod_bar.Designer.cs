
namespace tienda2.desinger
{
    partial class Compras_cargar_rapido_cod_bar
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
            this.txt_cod_bar = new System.Windows.Forms.TextBox();
            this.lst_cod_bar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_elim_ultimo = new System.Windows.Forms.Button();
            this.Btn_pasar_a_pedidos = new System.Windows.Forms.Button();
            this.Btn_eliminar_todo = new System.Windows.Forms.Button();
            this.Btn_eliminar_seleccionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cod_bar
            // 
            this.txt_cod_bar.Location = new System.Drawing.Point(12, 45);
            this.txt_cod_bar.Name = "txt_cod_bar";
            this.txt_cod_bar.Size = new System.Drawing.Size(155, 20);
            this.txt_cod_bar.TabIndex = 0;
            this.txt_cod_bar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_cod_bar_PreviewKeyDown);
            // 
            // lst_cod_bar
            // 
            this.lst_cod_bar.FormattingEnabled = true;
            this.lst_cod_bar.Location = new System.Drawing.Point(12, 71);
            this.lst_cod_bar.Name = "lst_cod_bar";
            this.lst_cod_bar.Size = new System.Drawing.Size(155, 251);
            this.lst_cod_bar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "codigo de barras";
            // 
            // Btn_elim_ultimo
            // 
            this.Btn_elim_ultimo.Location = new System.Drawing.Point(173, 252);
            this.Btn_elim_ultimo.Name = "Btn_elim_ultimo";
            this.Btn_elim_ultimo.Size = new System.Drawing.Size(86, 40);
            this.Btn_elim_ultimo.TabIndex = 16;
            this.Btn_elim_ultimo.Text = "eliminar ultimo";
            this.Btn_elim_ultimo.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo.Click += new System.EventHandler(this.Btn_elim_ultimo_Click);
            // 
            // Btn_pasar_a_pedidos
            // 
            this.Btn_pasar_a_pedidos.Location = new System.Drawing.Point(173, 298);
            this.Btn_pasar_a_pedidos.Name = "Btn_pasar_a_pedidos";
            this.Btn_pasar_a_pedidos.Size = new System.Drawing.Size(86, 36);
            this.Btn_pasar_a_pedidos.TabIndex = 15;
            this.Btn_pasar_a_pedidos.Text = "pasar a pedidos";
            this.Btn_pasar_a_pedidos.UseVisualStyleBackColor = true;
            this.Btn_pasar_a_pedidos.Click += new System.EventHandler(this.Btn_procesar_venta_Click);
            // 
            // Btn_eliminar_todo
            // 
            this.Btn_eliminar_todo.Location = new System.Drawing.Point(173, 219);
            this.Btn_eliminar_todo.Name = "Btn_eliminar_todo";
            this.Btn_eliminar_todo.Size = new System.Drawing.Size(86, 23);
            this.Btn_eliminar_todo.TabIndex = 17;
            this.Btn_eliminar_todo.Text = "eliminar todo";
            this.Btn_eliminar_todo.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo.Click += new System.EventHandler(this.Btn_eliminar_todo_Click);
            // 
            // Btn_eliminar_seleccionado
            // 
            this.Btn_eliminar_seleccionado.Location = new System.Drawing.Point(173, 171);
            this.Btn_eliminar_seleccionado.Name = "Btn_eliminar_seleccionado";
            this.Btn_eliminar_seleccionado.Size = new System.Drawing.Size(86, 42);
            this.Btn_eliminar_seleccionado.TabIndex = 18;
            this.Btn_eliminar_seleccionado.Text = "eliminar seleccionado";
            this.Btn_eliminar_seleccionado.UseVisualStyleBackColor = true;
            this.Btn_eliminar_seleccionado.Click += new System.EventHandler(this.Btn_eliminar_seleccionado_Click);
            // 
            // cargar_rapido_cod_bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 356);
            this.Controls.Add(this.Btn_elim_ultimo);
            this.Controls.Add(this.Btn_pasar_a_pedidos);
            this.Controls.Add(this.Btn_eliminar_todo);
            this.Controls.Add(this.Btn_eliminar_seleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_cod_bar);
            this.Controls.Add(this.txt_cod_bar);
            this.Name = "cargar_rapido_cod_bar";
            this.Text = "cargar_rapido_cod_bar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cod_bar;
        private System.Windows.Forms.ListBox lst_cod_bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_elim_ultimo;
        private System.Windows.Forms.Button Btn_pasar_a_pedidos;
        private System.Windows.Forms.Button Btn_eliminar_todo;
        private System.Windows.Forms.Button Btn_eliminar_seleccionado;
    }
}