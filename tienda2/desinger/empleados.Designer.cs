﻿
namespace tienda2.desinger
{
    partial class Empleados
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
            this.btn_img_fondo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_conf_contr = new System.Windows.Forms.TextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cmb_cargo = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Lst_empleados = new System.Windows.Forms.ListBox();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.txt_fecha_ingreso = new System.Windows.Forms.TextBox();
            this.txt_apllido_materno = new System.Windows.Forms.TextBox();
            this.txt_apllido_pat = new System.Windows.Forms.TextBox();
            this.txt_imag = new System.Windows.Forms.TextBox();
            this.txt_comentarios = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Lbl_sueldo = new System.Windows.Forms.Label();
            this.Lbl_fecha_ingreso = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_am = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_ap = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_img_fondo
            // 
            this.btn_img_fondo.Location = new System.Drawing.Point(33, 190);
            this.btn_img_fondo.Name = "btn_img_fondo";
            this.btn_img_fondo.Size = new System.Drawing.Size(75, 37);
            this.btn_img_fondo.TabIndex = 97;
            this.btn_img_fondo.Text = "imagen fondo";
            this.btn_img_fondo.UseVisualStyleBackColor = true;
            this.btn_img_fondo.Click += new System.EventHandler(this.btn_img_fondo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "confirmar contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "contraseña";
            // 
            // txt_conf_contr
            // 
            this.txt_conf_contr.Location = new System.Drawing.Point(130, 287);
            this.txt_conf_contr.Name = "txt_conf_contr";
            this.txt_conf_contr.Size = new System.Drawing.Size(100, 20);
            this.txt_conf_contr.TabIndex = 94;
            this.txt_conf_contr.UseSystemPasswordChar = true;
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.Location = new System.Drawing.Point(130, 261);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(100, 20);
            this.txt_contrasenia.TabIndex = 93;
            this.txt_contrasenia.UseSystemPasswordChar = true;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(130, 17);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(14, 13);
            this.lbl_id.TabIndex = 92;
            this.lbl_id.Text = "#";
            // 
            // cmb_cargo
            // 
            this.cmb_cargo.FormattingEnabled = true;
            this.cmb_cargo.Items.AddRange(new object[] {
            "admin",
            "encargado",
            "usuario",
            "invitado"});
            this.cmb_cargo.Location = new System.Drawing.Point(112, 163);
            this.cmb_cargo.Name = "cmb_cargo";
            this.cmb_cargo.Size = new System.Drawing.Size(121, 21);
            this.cmb_cargo.TabIndex = 91;
            this.cmb_cargo.SelectedIndexChanged += new System.EventHandler(this.cmb_cargo_SelectedIndexChanged);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(72, 171);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(34, 13);
            this.lbl_tipo.TabIndex = 90;
            this.lbl_tipo.Text = "cargo";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(8, 377);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(85, 23);
            this.Btn_buscar.TabIndex = 89;
            this.Btn_buscar.Text = "buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(361, 377);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar.TabIndex = 88;
            this.Btn_eliminar.Text = "eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(280, 377);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_editar.TabIndex = 87;
            this.Btn_editar.Text = "editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(199, 377);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.Btn_agregar.TabIndex = 86;
            this.Btn_agregar.Text = "agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Lst_empleados
            // 
            this.Lst_empleados.FormattingEnabled = true;
            this.Lst_empleados.Location = new System.Drawing.Point(236, 12);
            this.Lst_empleados.Name = "Lst_empleados";
            this.Lst_empleados.ScrollAlwaysVisible = true;
            this.Lst_empleados.Size = new System.Drawing.Size(178, 212);
            this.Lst_empleados.TabIndex = 85;
            this.Lst_empleados.SelectedIndexChanged += new System.EventHandler(this.Lst_empleados_SelectedIndexChanged);
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.Location = new System.Drawing.Point(130, 133);
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.Size = new System.Drawing.Size(100, 20);
            this.txt_sueldo.TabIndex = 84;
            // 
            // txt_fecha_ingreso
            // 
            this.txt_fecha_ingreso.Location = new System.Drawing.Point(130, 111);
            this.txt_fecha_ingreso.Name = "txt_fecha_ingreso";
            this.txt_fecha_ingreso.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_ingreso.TabIndex = 83;
            // 
            // txt_apllido_materno
            // 
            this.txt_apllido_materno.Location = new System.Drawing.Point(130, 87);
            this.txt_apllido_materno.Name = "txt_apllido_materno";
            this.txt_apllido_materno.Size = new System.Drawing.Size(100, 20);
            this.txt_apllido_materno.TabIndex = 82;
            // 
            // txt_apllido_pat
            // 
            this.txt_apllido_pat.Location = new System.Drawing.Point(130, 65);
            this.txt_apllido_pat.Name = "txt_apllido_pat";
            this.txt_apllido_pat.Size = new System.Drawing.Size(100, 20);
            this.txt_apllido_pat.TabIndex = 81;
            // 
            // txt_imag
            // 
            this.txt_imag.Location = new System.Drawing.Point(114, 199);
            this.txt_imag.Name = "txt_imag";
            this.txt_imag.Size = new System.Drawing.Size(116, 20);
            this.txt_imag.TabIndex = 80;
            // 
            // txt_comentarios
            // 
            this.txt_comentarios.Location = new System.Drawing.Point(239, 261);
            this.txt_comentarios.Multiline = true;
            this.txt_comentarios.Name = "txt_comentarios";
            this.txt_comentarios.Size = new System.Drawing.Size(175, 90);
            this.txt_comentarios.TabIndex = 79;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(130, 235);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 78;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(130, 39);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 77;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(106, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(15, 13);
            this.Label1.TabIndex = 76;
            this.Label1.Text = "id";
            // 
            // Lbl_sueldo
            // 
            this.Lbl_sueldo.AutoSize = true;
            this.Lbl_sueldo.Location = new System.Drawing.Point(86, 140);
            this.Lbl_sueldo.Name = "Lbl_sueldo";
            this.Lbl_sueldo.Size = new System.Drawing.Size(38, 13);
            this.Lbl_sueldo.TabIndex = 75;
            this.Lbl_sueldo.Text = "sueldo";
            // 
            // Lbl_fecha_ingreso
            // 
            this.Lbl_fecha_ingreso.AutoSize = true;
            this.Lbl_fecha_ingreso.Location = new System.Drawing.Point(38, 118);
            this.Lbl_fecha_ingreso.Name = "Lbl_fecha_ingreso";
            this.Lbl_fecha_ingreso.Size = new System.Drawing.Size(86, 13);
            this.Lbl_fecha_ingreso.TabIndex = 74;
            this.Lbl_fecha_ingreso.Text = "fecha de ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "comentarios";
            // 
            // Lbl_am
            // 
            this.Lbl_am.AutoSize = true;
            this.Lbl_am.Location = new System.Drawing.Point(40, 94);
            this.Lbl_am.Name = "Lbl_am";
            this.Lbl_am.Size = new System.Drawing.Size(84, 13);
            this.Lbl_am.TabIndex = 73;
            this.Lbl_am.Text = "apellido materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "usuario";
            // 
            // Lbl_ap
            // 
            this.Lbl_ap.AutoSize = true;
            this.Lbl_ap.Location = new System.Drawing.Point(42, 72);
            this.Lbl_ap.Name = "Lbl_ap";
            this.Lbl_ap.Size = new System.Drawing.Size(82, 13);
            this.Lbl_ap.TabIndex = 72;
            this.Lbl_ap.Text = "apellido paterno";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Location = new System.Drawing.Point(82, 46);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(42, 13);
            this.Lbl_nombre.TabIndex = 69;
            this.Lbl_nombre.Text = "nombre";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 422);
            this.Controls.Add(this.btn_img_fondo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_conf_contr);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cmb_cargo);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Lst_empleados);
            this.Controls.Add(this.txt_sueldo);
            this.Controls.Add(this.txt_fecha_ingreso);
            this.Controls.Add(this.txt_apllido_materno);
            this.Controls.Add(this.txt_apllido_pat);
            this.Controls.Add(this.txt_imag);
            this.Controls.Add(this.txt_comentarios);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Lbl_sueldo);
            this.Controls.Add(this.Lbl_fecha_ingreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_am);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_ap);
            this.Controls.Add(this.Lbl_nombre);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_img_fondo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_conf_contr;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ComboBox cmb_cargo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.ListBox Lst_empleados;
        private System.Windows.Forms.TextBox txt_sueldo;
        private System.Windows.Forms.TextBox txt_fecha_ingreso;
        private System.Windows.Forms.TextBox txt_apllido_materno;
        private System.Windows.Forms.TextBox txt_apllido_pat;
        private System.Windows.Forms.TextBox txt_imag;
        private System.Windows.Forms.TextBox txt_comentarios;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Lbl_sueldo;
        private System.Windows.Forms.Label Lbl_fecha_ingreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_am;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_ap;
        private System.Windows.Forms.Label Lbl_nombre;
    }
}