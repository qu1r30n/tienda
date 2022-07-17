
namespace tienda2.desinger
{
    partial class Ventas_confirmar
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
            this.Btn_pagar = new System.Windows.Forms.Button();
            this.Txt_dinero = new System.Windows.Forms.TextBox();
            this.Lbl_dinero = new System.Windows.Forms.Label();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.Lbl_titulo_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_pagar
            // 
            this.Btn_pagar.Location = new System.Drawing.Point(258, 8);
            this.Btn_pagar.Name = "Btn_pagar";
            this.Btn_pagar.Size = new System.Drawing.Size(75, 50);
            this.Btn_pagar.TabIndex = 14;
            this.Btn_pagar.Text = "pagar";
            this.Btn_pagar.UseVisualStyleBackColor = true;
            this.Btn_pagar.Click += new System.EventHandler(this.Btn_pagar_Click);
            // 
            // Txt_dinero
            // 
            this.Txt_dinero.Location = new System.Drawing.Point(152, 24);
            this.Txt_dinero.Name = "Txt_dinero";
            this.Txt_dinero.Size = new System.Drawing.Size(100, 20);
            this.Txt_dinero.TabIndex = 13;
            this.Txt_dinero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_dinero_keypress);
            // 
            // Lbl_dinero
            // 
            this.Lbl_dinero.AutoSize = true;
            this.Lbl_dinero.Location = new System.Drawing.Point(149, 9);
            this.Lbl_dinero.Name = "Lbl_dinero";
            this.Lbl_dinero.Size = new System.Drawing.Size(74, 13);
            this.Lbl_dinero.TabIndex = 12;
            this.Lbl_dinero.Text = "dinero que dio";
            // 
            // Lbl_total
            // 
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.Location = new System.Drawing.Point(12, 27);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(13, 13);
            this.Lbl_total.TabIndex = 11;
            this.Lbl_total.Text = "$";
            // 
            // Lbl_titulo_total
            // 
            this.Lbl_titulo_total.AutoSize = true;
            this.Lbl_titulo_total.Location = new System.Drawing.Point(12, 9);
            this.Lbl_titulo_total.Name = "Lbl_titulo_total";
            this.Lbl_titulo_total.Size = new System.Drawing.Size(66, 13);
            this.Lbl_titulo_total.TabIndex = 10;
            this.Lbl_titulo_total.Text = "total a pagar";
            // 
            // Ventas_confirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 68);
            this.Controls.Add(this.Btn_pagar);
            this.Controls.Add(this.Txt_dinero);
            this.Controls.Add(this.Lbl_dinero);
            this.Controls.Add(this.Lbl_total);
            this.Controls.Add(this.Lbl_titulo_total);
            this.Name = "Ventas_confirmar";
            this.Text = "Ventas_confirmar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_pagar;
        public System.Windows.Forms.TextBox Txt_dinero;
        private System.Windows.Forms.Label Lbl_dinero;
        public System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.Label Lbl_titulo_total;
    }
}