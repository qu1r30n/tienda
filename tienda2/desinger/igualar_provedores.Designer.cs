
namespace tienda2.desinger
{
    partial class igualar_provedores
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
            this.cmb_provedor = new System.Windows.Forms.ComboBox();
            this.cmb_provedor_editar = new System.Windows.Forms.ComboBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_provedor
            // 
            this.cmb_provedor.FormattingEnabled = true;
            this.cmb_provedor.ItemHeight = 13;
            this.cmb_provedor.Location = new System.Drawing.Point(12, 27);
            this.cmb_provedor.Name = "cmb_provedor";
            this.cmb_provedor.Size = new System.Drawing.Size(117, 21);
            this.cmb_provedor.TabIndex = 5;
            // 
            // cmb_provedor_editar
            // 
            this.cmb_provedor_editar.FormattingEnabled = true;
            this.cmb_provedor_editar.ItemHeight = 13;
            this.cmb_provedor_editar.Location = new System.Drawing.Point(149, 27);
            this.cmb_provedor_editar.Name = "cmb_provedor_editar";
            this.cmb_provedor_editar.Size = new System.Drawing.Size(117, 21);
            this.cmb_provedor_editar.TabIndex = 6;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(285, 27);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "a editar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "con el que lo vas a editar";
            // 
            // igualar_provedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 81);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.cmb_provedor_editar);
            this.Controls.Add(this.cmb_provedor);
            this.Name = "igualar_provedores";
            this.Text = "igualar_provedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_provedor;
        private System.Windows.Forms.ComboBox cmb_provedor_editar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}