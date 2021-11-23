
namespace tienda2.desinger
{
    partial class control_provedores
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
            this.lst_venta_provedor = new System.Windows.Forms.ListBox();
            this.txt_sugerencia_compra = new System.Windows.Forms.TextBox();
            this.txt_buscar_provedor = new System.Windows.Forms.TextBox();
            this.btn_buscar_provedor = new System.Windows.Forms.Button();
            this.btn_procesar_provedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_provedor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_venta_provedor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_venta_provedor
            // 
            this.lst_venta_provedor.FormattingEnabled = true;
            this.lst_venta_provedor.Location = new System.Drawing.Point(12, 95);
            this.lst_venta_provedor.Name = "lst_venta_provedor";
            this.lst_venta_provedor.Size = new System.Drawing.Size(543, 186);
            this.lst_venta_provedor.TabIndex = 0;
            this.lst_venta_provedor.SelectedIndexChanged += new System.EventHandler(this.lst_venta_provedor_SelectedIndexChanged);
            // 
            // txt_sugerencia_compra
            // 
            this.txt_sugerencia_compra.Location = new System.Drawing.Point(561, 232);
            this.txt_sugerencia_compra.Name = "txt_sugerencia_compra";
            this.txt_sugerencia_compra.Size = new System.Drawing.Size(100, 20);
            this.txt_sugerencia_compra.TabIndex = 3;
            // 
            // txt_buscar_provedor
            // 
            this.txt_buscar_provedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_buscar_provedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_buscar_provedor.Location = new System.Drawing.Point(12, 69);
            this.txt_buscar_provedor.Name = "txt_buscar_provedor";
            this.txt_buscar_provedor.Size = new System.Drawing.Size(543, 20);
            this.txt_buscar_provedor.TabIndex = 4;
            this.txt_buscar_provedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_provedor_KeyDown);
            // 
            // btn_buscar_provedor
            // 
            this.btn_buscar_provedor.Location = new System.Drawing.Point(561, 66);
            this.btn_buscar_provedor.Name = "btn_buscar_provedor";
            this.btn_buscar_provedor.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_provedor.TabIndex = 5;
            this.btn_buscar_provedor.Text = "buscar";
            this.btn_buscar_provedor.UseVisualStyleBackColor = true;
            this.btn_buscar_provedor.Click += new System.EventHandler(this.btn_buscar_provedor_Click);
            // 
            // btn_procesar_provedor
            // 
            this.btn_procesar_provedor.Location = new System.Drawing.Point(561, 258);
            this.btn_procesar_provedor.Name = "btn_procesar_provedor";
            this.btn_procesar_provedor.Size = new System.Drawing.Size(100, 23);
            this.btn_procesar_provedor.TabIndex = 6;
            this.btn_procesar_provedor.Text = "iniciar compra";
            this.btn_procesar_provedor.UseVisualStyleBackColor = true;
            this.btn_procesar_provedor.Click += new System.EventHandler(this.btn_procesar_provedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "buscar provedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "provedor";
            // 
            // lbl_provedor
            // 
            this.lbl_provedor.AutoSize = true;
            this.lbl_provedor.Location = new System.Drawing.Point(561, 132);
            this.lbl_provedor.Name = "lbl_provedor";
            this.lbl_provedor.Size = new System.Drawing.Size(49, 13);
            this.lbl_provedor.TabIndex = 9;
            this.lbl_provedor.Text = "provedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "cantidad comprar provedor";
            // 
            // lbl_venta_provedor
            // 
            this.lbl_venta_provedor.AutoSize = true;
            this.lbl_venta_provedor.Location = new System.Drawing.Point(561, 188);
            this.lbl_venta_provedor.Name = "lbl_venta_provedor";
            this.lbl_venta_provedor.Size = new System.Drawing.Size(13, 13);
            this.lbl_venta_provedor.TabIndex = 11;
            this.lbl_venta_provedor.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "cantidad comprar";
            // 
            // control_provedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_venta_provedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_provedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_procesar_provedor);
            this.Controls.Add(this.btn_buscar_provedor);
            this.Controls.Add(this.txt_buscar_provedor);
            this.Controls.Add(this.txt_sugerencia_compra);
            this.Controls.Add(this.lst_venta_provedor);
            this.Name = "control_provedores";
            this.Text = "control_provedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_venta_provedor;
        private System.Windows.Forms.TextBox txt_sugerencia_compra;
        private System.Windows.Forms.TextBox txt_buscar_provedor;
        private System.Windows.Forms.Button btn_buscar_provedor;
        private System.Windows.Forms.Button btn_procesar_provedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_provedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_venta_provedor;
        private System.Windows.Forms.Label label4;
    }
}