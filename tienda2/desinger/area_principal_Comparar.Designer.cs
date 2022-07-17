
namespace tienda2.desinger
{
    partial class area_principal_Comparar
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
            this.Rdb_gastos = new System.Windows.Forms.RadioButton();
            this.Rdb_productos = new System.Windows.Forms.RadioButton();
            this.Rdb_ventas = new System.Windows.Forms.RadioButton();
            this.Btn_comparar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_dia = new System.Windows.Forms.ComboBox();
            this.cmb_año = new System.Windows.Forms.ComboBox();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Rdb_gastos
            // 
            this.Rdb_gastos.AutoSize = true;
            this.Rdb_gastos.Location = new System.Drawing.Point(298, 52);
            this.Rdb_gastos.Name = "Rdb_gastos";
            this.Rdb_gastos.Size = new System.Drawing.Size(56, 17);
            this.Rdb_gastos.TabIndex = 53;
            this.Rdb_gastos.TabStop = true;
            this.Rdb_gastos.Text = "gastos";
            this.Rdb_gastos.UseVisualStyleBackColor = true;
            this.Rdb_gastos.CheckedChanged += new System.EventHandler(this.Rdb_gastos_CheckedChanged);
            // 
            // Rdb_productos
            // 
            this.Rdb_productos.AutoSize = true;
            this.Rdb_productos.Location = new System.Drawing.Point(155, 52);
            this.Rdb_productos.Name = "Rdb_productos";
            this.Rdb_productos.Size = new System.Drawing.Size(72, 17);
            this.Rdb_productos.TabIndex = 52;
            this.Rdb_productos.TabStop = true;
            this.Rdb_productos.Text = "productos";
            this.Rdb_productos.UseVisualStyleBackColor = true;
            this.Rdb_productos.CheckedChanged += new System.EventHandler(this.Rdb_productos_CheckedChanged);
            // 
            // Rdb_ventas
            // 
            this.Rdb_ventas.AutoSize = true;
            this.Rdb_ventas.Location = new System.Drawing.Point(12, 52);
            this.Rdb_ventas.Name = "Rdb_ventas";
            this.Rdb_ventas.Size = new System.Drawing.Size(57, 17);
            this.Rdb_ventas.TabIndex = 51;
            this.Rdb_ventas.TabStop = true;
            this.Rdb_ventas.Text = "ventas";
            this.Rdb_ventas.UseVisualStyleBackColor = true;
            this.Rdb_ventas.CheckedChanged += new System.EventHandler(this.Rdb_ventas_CheckedChanged);
            // 
            // Btn_comparar
            // 
            this.Btn_comparar.Location = new System.Drawing.Point(12, 97);
            this.Btn_comparar.Name = "Btn_comparar";
            this.Btn_comparar.Size = new System.Drawing.Size(75, 23);
            this.Btn_comparar.TabIndex = 50;
            this.Btn_comparar.Text = "comparar";
            this.Btn_comparar.UseVisualStyleBackColor = true;
            this.Btn_comparar.Click += new System.EventHandler(this.Btn_comparar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "año";
            // 
            // cmb_dia
            // 
            this.cmb_dia.FormattingEnabled = true;
            this.cmb_dia.Location = new System.Drawing.Point(298, 25);
            this.cmb_dia.Name = "cmb_dia";
            this.cmb_dia.Size = new System.Drawing.Size(121, 21);
            this.cmb_dia.TabIndex = 46;
            this.cmb_dia.SelectedIndexChanged += new System.EventHandler(this.cmb_dia_SelectedIndexChanged);
            // 
            // cmb_año
            // 
            this.cmb_año.FormattingEnabled = true;
            this.cmb_año.Location = new System.Drawing.Point(12, 25);
            this.cmb_año.Name = "cmb_año";
            this.cmb_año.Size = new System.Drawing.Size(121, 21);
            this.cmb_año.TabIndex = 45;
            this.cmb_año.SelectedIndexChanged += new System.EventHandler(this.cmb_año_SelectedIndexChanged);
            // 
            // cmb_mes
            // 
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Location = new System.Drawing.Point(155, 25);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(121, 21);
            this.cmb_mes.TabIndex = 44;
            this.cmb_mes.SelectedIndexChanged += new System.EventHandler(this.cmb_mes_SelectedIndexChanged);
            // 
            // area_principal_Comparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 129);
            this.Controls.Add(this.Rdb_gastos);
            this.Controls.Add(this.Rdb_productos);
            this.Controls.Add(this.Rdb_ventas);
            this.Controls.Add(this.Btn_comparar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_dia);
            this.Controls.Add(this.cmb_año);
            this.Controls.Add(this.cmb_mes);
            this.Name = "area_principal_Comparar";
            this.Text = "area_principal_Comparar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rdb_gastos;
        private System.Windows.Forms.RadioButton Rdb_productos;
        private System.Windows.Forms.RadioButton Rdb_ventas;
        private System.Windows.Forms.Button Btn_comparar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_dia;
        private System.Windows.Forms.ComboBox cmb_año;
        private System.Windows.Forms.ComboBox cmb_mes;
    }
}