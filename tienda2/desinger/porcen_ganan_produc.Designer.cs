
namespace tienda2.desinger
{
    partial class porcen_ganan_produc
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
            this.lstb_productos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstb_productos
            // 
            this.lstb_productos.FormattingEnabled = true;
            this.lstb_productos.Location = new System.Drawing.Point(12, 12);
            this.lstb_productos.Name = "lstb_productos";
            this.lstb_productos.Size = new System.Drawing.Size(283, 420);
            this.lstb_productos.TabIndex = 0;
            this.lstb_productos.SelectedIndexChanged += new System.EventHandler(this.lstb_productos_SelectedIndexChanged);
            // 
            // porcen_ganan_produc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstb_productos);
            this.Name = "porcen_ganan_produc";
            this.Text = "porcen_ganan_produc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstb_productos;
    }
}