namespace tienda2.desinger
{
    partial class crear_codigo_barras
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
            this.pctb_codigo_barras = new System.Windows.Forms.PictureBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_codigo_barras = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_codigo_barras)).BeginInit();
            this.SuspendLayout();
            // 
            // pctb_codigo_barras
            // 
            this.pctb_codigo_barras.Location = new System.Drawing.Point(12, 67);
            this.pctb_codigo_barras.Name = "pctb_codigo_barras";
            this.pctb_codigo_barras.Size = new System.Drawing.Size(567, 150);
            this.pctb_codigo_barras.TabIndex = 0;
            this.pctb_codigo_barras.TabStop = false;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(586, 9);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 2;
            this.btn_generar.Text = "generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // txt_codigo_barras
            // 
            this.txt_codigo_barras.Location = new System.Drawing.Point(12, 29);
            this.txt_codigo_barras.Name = "txt_codigo_barras";
            this.txt_codigo_barras.Size = new System.Drawing.Size(568, 20);
            this.txt_codigo_barras.TabIndex = 1;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(586, 38);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Texto";
            // 
            // crear_codigo_barras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_codigo_barras);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.pctb_codigo_barras);
            this.Name = "crear_codigo_barras";
            this.Text = "crear_codigo_barras";
            ((System.ComponentModel.ISupportInitialize)(this.pctb_codigo_barras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctb_codigo_barras;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox txt_codigo_barras;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label1;
    }
}