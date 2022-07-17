
namespace tienda2.desinger
{
    partial class pedidos
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
            this.btn_procesar = new System.Windows.Forms.Button();
            this.lstb_a_pedir = new System.Windows.Forms.ListBox();
            this.lstb_sugerencia = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_procesar
            // 
            this.btn_procesar.Location = new System.Drawing.Point(623, 158);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(75, 23);
            this.btn_procesar.TabIndex = 5;
            this.btn_procesar.Text = "procesar";
            this.btn_procesar.UseVisualStyleBackColor = true;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // lstb_a_pedir
            // 
            this.lstb_a_pedir.FormattingEnabled = true;
            this.lstb_a_pedir.Location = new System.Drawing.Point(321, 12);
            this.lstb_a_pedir.Name = "lstb_a_pedir";
            this.lstb_a_pedir.Size = new System.Drawing.Size(296, 290);
            this.lstb_a_pedir.TabIndex = 4;
            this.lstb_a_pedir.DoubleClick += new System.EventHandler(this.lstb_a_pedir_DoubleClick);
            // 
            // lstb_sugerencia
            // 
            this.lstb_sugerencia.FormattingEnabled = true;
            this.lstb_sugerencia.Location = new System.Drawing.Point(12, 12);
            this.lstb_sugerencia.Name = "lstb_sugerencia";
            this.lstb_sugerencia.Size = new System.Drawing.Size(275, 290);
            this.lstb_sugerencia.TabIndex = 3;
            this.lstb_sugerencia.DoubleClick += new System.EventHandler(this.lstb_sugerencia_DoubleClick);
            // 
            // pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 324);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.lstb_a_pedir);
            this.Controls.Add(this.lstb_sugerencia);
            this.Name = "pedidos";
            this.Text = "pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_procesar;
        private System.Windows.Forms.ListBox lstb_a_pedir;
        private System.Windows.Forms.ListBox lstb_sugerencia;
    }
}