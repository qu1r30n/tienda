
namespace tienda2.desinger
{
    partial class investigacion_mercado
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
            this.lst_mejor_opciones = new System.Windows.Forms.ListBox();
            this.Btn_elim_ultimo = new System.Windows.Forms.Button();
            this.Btn_verificar_hist = new System.Windows.Forms.Button();
            this.Btn_eliminar_todo = new System.Windows.Forms.Button();
            this.Btn_eliminar_seleccionado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_carg_investigacion = new System.Windows.Forms.Button();
            this.lstb_carga_investigacion = new System.Windows.Forms.ListBox();
            this.txt_codigo_de_barras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_mejor_opciones
            // 
            this.lst_mejor_opciones.FormattingEnabled = true;
            this.lst_mejor_opciones.Location = new System.Drawing.Point(294, 51);
            this.lst_mejor_opciones.Name = "lst_mejor_opciones";
            this.lst_mejor_opciones.Size = new System.Drawing.Size(120, 173);
            this.lst_mejor_opciones.TabIndex = 39;
            // 
            // Btn_elim_ultimo
            // 
            this.Btn_elim_ultimo.Location = new System.Drawing.Point(202, 142);
            this.Btn_elim_ultimo.Name = "Btn_elim_ultimo";
            this.Btn_elim_ultimo.Size = new System.Drawing.Size(86, 40);
            this.Btn_elim_ultimo.TabIndex = 36;
            this.Btn_elim_ultimo.Text = "eliminar ultimo";
            this.Btn_elim_ultimo.UseVisualStyleBackColor = true;
            this.Btn_elim_ultimo.Click += new System.EventHandler(this.Btn_elim_ultimo_Click);
            // 
            // Btn_verificar_hist
            // 
            this.Btn_verificar_hist.Location = new System.Drawing.Point(202, 188);
            this.Btn_verificar_hist.Name = "Btn_verificar_hist";
            this.Btn_verificar_hist.Size = new System.Drawing.Size(86, 36);
            this.Btn_verificar_hist.TabIndex = 35;
            this.Btn_verificar_hist.Text = "verificar";
            this.Btn_verificar_hist.UseVisualStyleBackColor = true;
            this.Btn_verificar_hist.Click += new System.EventHandler(this.Btn_verificar_his_Click);
            // 
            // Btn_eliminar_todo
            // 
            this.Btn_eliminar_todo.Location = new System.Drawing.Point(202, 109);
            this.Btn_eliminar_todo.Name = "Btn_eliminar_todo";
            this.Btn_eliminar_todo.Size = new System.Drawing.Size(86, 23);
            this.Btn_eliminar_todo.TabIndex = 37;
            this.Btn_eliminar_todo.Text = "eliminar todo";
            this.Btn_eliminar_todo.UseVisualStyleBackColor = true;
            this.Btn_eliminar_todo.Click += new System.EventHandler(this.Btn_eliminar_todo_Click);
            // 
            // Btn_eliminar_seleccionado
            // 
            this.Btn_eliminar_seleccionado.Location = new System.Drawing.Point(202, 61);
            this.Btn_eliminar_seleccionado.Name = "Btn_eliminar_seleccionado";
            this.Btn_eliminar_seleccionado.Size = new System.Drawing.Size(86, 42);
            this.Btn_eliminar_seleccionado.TabIndex = 38;
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
            this.label1.TabIndex = 34;
            this.label1.Text = "codigo de barras";
            // 
            // btn_carg_investigacion
            // 
            this.btn_carg_investigacion.Location = new System.Drawing.Point(12, 230);
            this.btn_carg_investigacion.Name = "btn_carg_investigacion";
            this.btn_carg_investigacion.Size = new System.Drawing.Size(75, 37);
            this.btn_carg_investigacion.TabIndex = 33;
            this.btn_carg_investigacion.Text = "cargar investigacion";
            this.btn_carg_investigacion.UseVisualStyleBackColor = true;
            this.btn_carg_investigacion.Click += new System.EventHandler(this.btn_carg_investigacion_Click);
            // 
            // lstb_carga_investigacion
            // 
            this.lstb_carga_investigacion.FormattingEnabled = true;
            this.lstb_carga_investigacion.Location = new System.Drawing.Point(12, 51);
            this.lstb_carga_investigacion.Name = "lstb_carga_investigacion";
            this.lstb_carga_investigacion.Size = new System.Drawing.Size(184, 173);
            this.lstb_carga_investigacion.TabIndex = 32;
            this.lstb_carga_investigacion.SelectedIndexChanged += new System.EventHandler(this.lstb_carga_investigacion_SelectedIndexChanged);
            // 
            // txt_codigo_de_barras
            // 
            this.txt_codigo_de_barras.Location = new System.Drawing.Point(12, 25);
            this.txt_codigo_de_barras.Name = "txt_codigo_de_barras";
            this.txt_codigo_de_barras.Size = new System.Drawing.Size(184, 20);
            this.txt_codigo_de_barras.TabIndex = 31;
            this.txt_codigo_de_barras.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_codigo_de_barras_PreviewKeyDown);
            // 
            // investigacion_mercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_mejor_opciones);
            this.Controls.Add(this.Btn_elim_ultimo);
            this.Controls.Add(this.Btn_verificar_hist);
            this.Controls.Add(this.Btn_eliminar_todo);
            this.Controls.Add(this.Btn_eliminar_seleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_carg_investigacion);
            this.Controls.Add(this.lstb_carga_investigacion);
            this.Controls.Add(this.txt_codigo_de_barras);
            this.Name = "investigacion_mercado";
            this.Text = "investigacion_mercado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_mejor_opciones;
        private System.Windows.Forms.Button Btn_elim_ultimo;
        private System.Windows.Forms.Button Btn_verificar_hist;
        private System.Windows.Forms.Button Btn_eliminar_todo;
        private System.Windows.Forms.Button Btn_eliminar_seleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_carg_investigacion;
        private System.Windows.Forms.ListBox lstb_carga_investigacion;
        private System.Windows.Forms.TextBox txt_codigo_de_barras;
    }
}