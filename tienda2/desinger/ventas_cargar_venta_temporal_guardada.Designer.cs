
namespace tienda2.desinger
{
    partial class ventas_cargar_venta_temporal_guardada
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
            this.lstbx_ventas_guardadas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstbx_ventas_guardadas
            // 
            this.lstbx_ventas_guardadas.FormattingEnabled = true;
            this.lstbx_ventas_guardadas.Location = new System.Drawing.Point(12, 12);
            this.lstbx_ventas_guardadas.Name = "lstbx_ventas_guardadas";
            this.lstbx_ventas_guardadas.Size = new System.Drawing.Size(178, 173);
            this.lstbx_ventas_guardadas.TabIndex = 3;
            this.lstbx_ventas_guardadas.DoubleClick += new System.EventHandler(this.lstbx_ventas_guardadas_DoubleClick);
            // 
            // ventas_cargar_venta_temporal_guardada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 226);
            this.Controls.Add(this.lstbx_ventas_guardadas);
            this.Name = "ventas_cargar_venta_temporal_guardada";
            this.Text = "ventas_cargar_venta_temporal_guardada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx_ventas_guardadas;
    }
}