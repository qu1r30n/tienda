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
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_invitado = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(9, 61);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(29, 13);
            this.lbl_pass.TabIndex = 7;
            this.lbl_pass.Text = "pass";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(12, 11);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(41, 13);
            this.lbl_usuario.TabIndex = 6;
            this.lbl_usuario.Text = "usuario";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(12, 77);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 2;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(12, 27);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 1;
            // 
            // btn_invitado
            // 
            this.btn_invitado.Location = new System.Drawing.Point(188, 113);
            this.btn_invitado.Name = "btn_invitado";
            this.btn_invitado.Size = new System.Drawing.Size(75, 23);
            this.btn_invitado.TabIndex = 5;
            this.btn_invitado.Text = "invitado";
            this.btn_invitado.UseVisualStyleBackColor = true;
            this.btn_invitado.Click += new System.EventHandler(this.btn_invitado_Click);
            // 
            // btn_usuario
            // 
            this.btn_usuario.Location = new System.Drawing.Point(107, 113);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(75, 23);
            this.btn_usuario.TabIndex = 4;
            this.btn_usuario.Text = "usuario";
            this.btn_usuario.UseVisualStyleBackColor = true;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(12, 113);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(89, 23);
            this.btn_admin.TabIndex = 3;
            this.btn_admin.Text = "administrador";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 155);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_invitado);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.btn_admin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_invitado;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.Button btn_admin;
    }
}

