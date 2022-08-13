
namespace tienda2.desinger
{
    partial class simul
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
            this.lbl_curso = new System.Windows.Forms.Label();
            this.cmb_curso = new System.Windows.Forms.ComboBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.lbl_dinero = new System.Windows.Forms.Label();
            this.txt_dinero = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(115, 25);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(30, 13);
            this.lbl_curso.TabIndex = 14;
            this.lbl_curso.Text = "cuso";
            // 
            // cmb_curso
            // 
            this.cmb_curso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_curso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_curso.FormattingEnabled = true;
            this.cmb_curso.Location = new System.Drawing.Point(118, 49);
            this.cmb_curso.Name = "cmb_curso";
            this.cmb_curso.Size = new System.Drawing.Size(121, 21);
            this.cmb_curso.TabIndex = 9;
            this.cmb_curso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_curso_KeyDown);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(12, 76);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 12;
            this.btn_registrar.Text = "registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_pagar
            // 
            this.btn_pagar.Location = new System.Drawing.Point(351, 47);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(75, 23);
            this.btn_pagar.TabIndex = 11;
            this.btn_pagar.Text = "pagar";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // lbl_dinero
            // 
            this.lbl_dinero.AutoSize = true;
            this.lbl_dinero.Location = new System.Drawing.Point(245, 24);
            this.lbl_dinero.Name = "lbl_dinero";
            this.lbl_dinero.Size = new System.Drawing.Size(36, 13);
            this.lbl_dinero.TabIndex = 15;
            this.lbl_dinero.Text = "dinero";
            // 
            // txt_dinero
            // 
            this.txt_dinero.Location = new System.Drawing.Point(245, 50);
            this.txt_dinero.Name = "txt_dinero";
            this.txt_dinero.Size = new System.Drawing.Size(100, 20);
            this.txt_dinero.TabIndex = 10;
            this.txt_dinero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_dinero_KeyDown);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 25);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(15, 13);
            this.lbl_id.TabIndex = 13;
            this.lbl_id.Text = "id";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(12, 50);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 8;
            this.txt_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroVendedoresToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.opcionesToolStripMenuItem.Text = "opciones";
            // 
            // registroVendedoresToolStripMenuItem
            // 
            this.registroVendedoresToolStripMenuItem.Name = "registroVendedoresToolStripMenuItem";
            this.registroVendedoresToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registroVendedoresToolStripMenuItem.Text = "registro vendedores";
            this.registroVendedoresToolStripMenuItem.Click += new System.EventHandler(this.registroVendedoresToolStripMenuItem_Click);
            // 
            // simul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 116);
            this.Controls.Add(this.lbl_curso);
            this.Controls.Add(this.cmb_curso);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.lbl_dinero);
            this.Controls.Add(this.txt_dinero);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "simul";
            this.Text = "simul";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.ComboBox cmb_curso;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label lbl_dinero;
        private System.Windows.Forms.TextBox txt_dinero;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroVendedoresToolStripMenuItem;
    }
}