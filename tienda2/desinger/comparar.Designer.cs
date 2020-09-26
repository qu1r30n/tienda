namespace tienda2.desinger
{
    partial class comparar
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
            this.rdb_gastos = new System.Windows.Forms.RadioButton();
            this.rdb_productos = new System.Windows.Forms.RadioButton();
            this.rdb_ventas = new System.Windows.Forms.RadioButton();
            this.btn_comparar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_dia = new System.Windows.Forms.ComboBox();
            this.cmb_año = new System.Windows.Forms.ComboBox();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rdb_gastos
            // 
            this.rdb_gastos.AutoSize = true;
            this.rdb_gastos.Location = new System.Drawing.Point(298, 52);
            this.rdb_gastos.Name = "rdb_gastos";
            this.rdb_gastos.Size = new System.Drawing.Size(56, 17);
            this.rdb_gastos.TabIndex = 43;
            this.rdb_gastos.TabStop = true;
            this.rdb_gastos.Text = "gastos";
            this.rdb_gastos.UseVisualStyleBackColor = true;
            // 
            // rdb_productos
            // 
            this.rdb_productos.AutoSize = true;
            this.rdb_productos.Location = new System.Drawing.Point(155, 52);
            this.rdb_productos.Name = "rdb_productos";
            this.rdb_productos.Size = new System.Drawing.Size(72, 17);
            this.rdb_productos.TabIndex = 42;
            this.rdb_productos.TabStop = true;
            this.rdb_productos.Text = "productos";
            this.rdb_productos.UseVisualStyleBackColor = true;
            // 
            // rdb_ventas
            // 
            this.rdb_ventas.AutoSize = true;
            this.rdb_ventas.Location = new System.Drawing.Point(12, 52);
            this.rdb_ventas.Name = "rdb_ventas";
            this.rdb_ventas.Size = new System.Drawing.Size(57, 17);
            this.rdb_ventas.TabIndex = 41;
            this.rdb_ventas.TabStop = true;
            this.rdb_ventas.Text = "ventas";
            this.rdb_ventas.UseVisualStyleBackColor = true;
            // 
            // btn_comparar
            // 
            this.btn_comparar.Location = new System.Drawing.Point(12, 97);
            this.btn_comparar.Name = "btn_comparar";
            this.btn_comparar.Size = new System.Drawing.Size(75, 23);
            this.btn_comparar.TabIndex = 40;
            this.btn_comparar.Text = "comparar";
            this.btn_comparar.UseVisualStyleBackColor = true;
            this.btn_comparar.Click += new System.EventHandler(this.btn_comparar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "año";
            // 
            // cmb_dia
            // 
            this.cmb_dia.FormattingEnabled = true;
            this.cmb_dia.Location = new System.Drawing.Point(298, 25);
            this.cmb_dia.Name = "cmb_dia";
            this.cmb_dia.Size = new System.Drawing.Size(121, 21);
            this.cmb_dia.TabIndex = 36;
            // 
            // cmb_año
            // 
            this.cmb_año.FormattingEnabled = true;
            this.cmb_año.Location = new System.Drawing.Point(12, 25);
            this.cmb_año.Name = "cmb_año";
            this.cmb_año.Size = new System.Drawing.Size(121, 21);
            this.cmb_año.TabIndex = 35;
            // 
            // cmb_mes
            // 
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Location = new System.Drawing.Point(155, 25);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(121, 21);
            this.cmb_mes.TabIndex = 34;
            // 
            // comparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 134);
            this.Controls.Add(this.rdb_gastos);
            this.Controls.Add(this.rdb_productos);
            this.Controls.Add(this.rdb_ventas);
            this.Controls.Add(this.btn_comparar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_dia);
            this.Controls.Add(this.cmb_año);
            this.Controls.Add(this.cmb_mes);
            this.Name = "comparar";
            this.Text = "comparar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_gastos;
        private System.Windows.Forms.RadioButton rdb_productos;
        private System.Windows.Forms.RadioButton rdb_ventas;
        private System.Windows.Forms.Button btn_comparar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_dia;
        private System.Windows.Forms.ComboBox cmb_año;
        private System.Windows.Forms.ComboBox cmb_mes;
    }
}