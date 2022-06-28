namespace tienda2.desinger
{
    partial class gastos
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
            this.Btn_guardar_compra = new System.Windows.Forms.Button();
            this.Txt_cantidad_gastada = new System.Windows.Forms.TextBox();
            this.Txt_quien_facturo = new System.Windows.Forms.TextBox();
            this.Txt_razon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_guardar_compra
            // 
            this.Btn_guardar_compra.Location = new System.Drawing.Point(15, 147);
            this.Btn_guardar_compra.Name = "Btn_guardar_compra";
            this.Btn_guardar_compra.Size = new System.Drawing.Size(111, 34);
            this.Btn_guardar_compra.TabIndex = 13;
            this.Btn_guardar_compra.Text = "guarda compra";
            this.Btn_guardar_compra.UseVisualStyleBackColor = true;
            this.Btn_guardar_compra.Click += new System.EventHandler(this.Btn_guardar_compra_Click);
            // 
            // Txt_cantidad_gastada
            // 
            this.Txt_cantidad_gastada.Location = new System.Drawing.Point(15, 120);
            this.Txt_cantidad_gastada.Name = "Txt_cantidad_gastada";
            this.Txt_cantidad_gastada.Size = new System.Drawing.Size(100, 20);
            this.Txt_cantidad_gastada.TabIndex = 12;
            // 
            // Txt_quien_facturo
            // 
            this.Txt_quien_facturo.Location = new System.Drawing.Point(15, 77);
            this.Txt_quien_facturo.Name = "Txt_quien_facturo";
            this.Txt_quien_facturo.Size = new System.Drawing.Size(229, 20);
            this.Txt_quien_facturo.TabIndex = 11;
            // 
            // Txt_razon
            // 
            this.Txt_razon.Location = new System.Drawing.Point(12, 25);
            this.Txt_razon.Name = "Txt_razon";
            this.Txt_razon.Size = new System.Drawing.Size(386, 20);
            this.Txt_razon.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "quien facturo(si no hubo factura no poner nada)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "cantidad gastada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "razon de compra";
            // 
            // compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 188);
            this.Controls.Add(this.Btn_guardar_compra);
            this.Controls.Add(this.Txt_cantidad_gastada);
            this.Controls.Add(this.Txt_quien_facturo);
            this.Controls.Add(this.Txt_razon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "compras";
            this.Text = "compras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_guardar_compra;
        private System.Windows.Forms.TextBox Txt_cantidad_gastada;
        private System.Windows.Forms.TextBox Txt_quien_facturo;
        private System.Windows.Forms.TextBox Txt_razon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}