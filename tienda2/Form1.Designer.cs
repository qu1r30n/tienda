namespace tienda2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_pass = new System.Windows.Forms.Label();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Txt_pass = new System.Windows.Forms.TextBox();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Btn_invitado = new System.Windows.Forms.Button();
            this.Btn_usuario = new System.Windows.Forms.Button();
            this.Btn_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_pass
            // 
            this.Lbl_pass.AutoSize = true;
            this.Lbl_pass.Location = new System.Drawing.Point(9, 61);
            this.Lbl_pass.Name = "Lbl_pass";
            this.Lbl_pass.Size = new System.Drawing.Size(29, 13);
            this.Lbl_pass.TabIndex = 7;
            this.Lbl_pass.Text = "pass";
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Location = new System.Drawing.Point(12, 11);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(41, 13);
            this.Lbl_usuario.TabIndex = 6;
            this.Lbl_usuario.Text = "usuario";
            // 
            // Txt_pass
            // 
            this.Txt_pass.Location = new System.Drawing.Point(12, 77);
            this.Txt_pass.Name = "Txt_pass";
            this.Txt_pass.PasswordChar = '*';
            this.Txt_pass.Size = new System.Drawing.Size(100, 20);
            this.Txt_pass.TabIndex = 2;
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(12, 27);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.Txt_usuario.TabIndex = 1;
            // 
            // Btn_invitado
            // 
            this.Btn_invitado.Location = new System.Drawing.Point(188, 113);
            this.Btn_invitado.Name = "Btn_invitado";
            this.Btn_invitado.Size = new System.Drawing.Size(75, 23);
            this.Btn_invitado.TabIndex = 5;
            this.Btn_invitado.Text = "invitado";
            this.Btn_invitado.UseVisualStyleBackColor = true;
            this.Btn_invitado.Click += new System.EventHandler(this.Btn_invitado_Click);
            // 
            // Btn_usuario
            // 
            this.Btn_usuario.Location = new System.Drawing.Point(107, 113);
            this.Btn_usuario.Name = "Btn_usuario";
            this.Btn_usuario.Size = new System.Drawing.Size(75, 23);
            this.Btn_usuario.TabIndex = 4;
            this.Btn_usuario.Text = "usuario";
            this.Btn_usuario.UseVisualStyleBackColor = true;
            this.Btn_usuario.Click += new System.EventHandler(this.Btn_usuario_Click);
            // 
            // Btn_admin
            // 
            this.Btn_admin.Location = new System.Drawing.Point(12, 113);
            this.Btn_admin.Name = "Btn_admin";
            this.Btn_admin.Size = new System.Drawing.Size(89, 23);
            this.Btn_admin.TabIndex = 3;
            this.Btn_admin.Text = "administrador";
            this.Btn_admin.UseVisualStyleBackColor = true;
            this.Btn_admin.Click += new System.EventHandler(this.Btn_admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 155);
            this.Controls.Add(this.Lbl_pass);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Txt_pass);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Btn_invitado);
            this.Controls.Add(this.Btn_usuario);
            this.Controls.Add(this.Btn_admin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_pass;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.TextBox Txt_pass;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.Button Btn_invitado;
        private System.Windows.Forms.Button Btn_usuario;
        private System.Windows.Forms.Button Btn_admin;
    }
}

