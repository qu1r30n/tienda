
namespace tienda2.desinger
{
    partial class Respaldo
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
            this.Btn_usar_respaldo = new System.Windows.Forms.Button();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.Btn_respaldar = new System.Windows.Forms.Button();
            this.Btn_donde_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_usar_respaldo
            // 
            this.Btn_usar_respaldo.Location = new System.Drawing.Point(181, 122);
            this.Btn_usar_respaldo.Name = "Btn_usar_respaldo";
            this.Btn_usar_respaldo.Size = new System.Drawing.Size(75, 45);
            this.Btn_usar_respaldo.TabIndex = 11;
            this.Btn_usar_respaldo.Text = "usar respaldo";
            this.Btn_usar_respaldo.UseVisualStyleBackColor = true;
            this.Btn_usar_respaldo.Click += new System.EventHandler(this.Btn_usar_respaldo_Click);
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Location = new System.Drawing.Point(9, 70);
            this.Lbl_direccion.MaximumSize = new System.Drawing.Size(300, 0);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(283, 26);
            this.Lbl_direccion.TabIndex = 10;
            this.Lbl_direccion.Text = "oprime boton donde guararlos para buscar donde poner el respaldo";
            // 
            // Btn_respaldar
            // 
            this.Btn_respaldar.Location = new System.Drawing.Point(12, 122);
            this.Btn_respaldar.Name = "Btn_respaldar";
            this.Btn_respaldar.Size = new System.Drawing.Size(75, 45);
            this.Btn_respaldar.TabIndex = 9;
            this.Btn_respaldar.Text = "respaldar";
            this.Btn_respaldar.UseVisualStyleBackColor = true;
            this.Btn_respaldar.Click += new System.EventHandler(this.Btn_respaldar_Click);
            // 
            // Btn_donde_guardar
            // 
            this.Btn_donde_guardar.Location = new System.Drawing.Point(12, 12);
            this.Btn_donde_guardar.Name = "Btn_donde_guardar";
            this.Btn_donde_guardar.Size = new System.Drawing.Size(75, 36);
            this.Btn_donde_guardar.TabIndex = 8;
            this.Btn_donde_guardar.Text = "dond guardarlos";
            this.Btn_donde_guardar.UseVisualStyleBackColor = true;
            this.Btn_donde_guardar.Click += new System.EventHandler(this.Btn_donde_guardar_Click);
            // 
            // Respaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 184);
            this.Controls.Add(this.Btn_usar_respaldo);
            this.Controls.Add(this.Lbl_direccion);
            this.Controls.Add(this.Btn_respaldar);
            this.Controls.Add(this.Btn_donde_guardar);
            this.Name = "Respaldo";
            this.Text = "Respaldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_usar_respaldo;
        private System.Windows.Forms.Label Lbl_direccion;
        private System.Windows.Forms.Button Btn_respaldar;
        private System.Windows.Forms.Button Btn_donde_guardar;
    }
}