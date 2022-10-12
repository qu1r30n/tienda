
namespace tienda2.desinger
{
    partial class poner_a_cero
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
            this.btn_reiniciar_a_cero = new System.Windows.Forms.Button();
            this.rdb_todo_junto = new System.Windows.Forms.RadioButton();
            this.rdb_ventas = new System.Windows.Forms.RadioButton();
            this.rdb_ranking = new System.Windows.Forms.RadioButton();
            this.rdb_inventario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_reiniciar_a_cero
            // 
            this.btn_reiniciar_a_cero.Location = new System.Drawing.Point(12, 35);
            this.btn_reiniciar_a_cero.Name = "btn_reiniciar_a_cero";
            this.btn_reiniciar_a_cero.Size = new System.Drawing.Size(75, 23);
            this.btn_reiniciar_a_cero.TabIndex = 6;
            this.btn_reiniciar_a_cero.Text = "poner a cero";
            this.btn_reiniciar_a_cero.UseVisualStyleBackColor = true;
            this.btn_reiniciar_a_cero.Click += new System.EventHandler(this.btn_reiniciar_a_cero_Click);
            // 
            // rdb_todo_junto
            // 
            this.rdb_todo_junto.AutoSize = true;
            this.rdb_todo_junto.Location = new System.Drawing.Point(285, 12);
            this.rdb_todo_junto.Name = "rdb_todo_junto";
            this.rdb_todo_junto.Size = new System.Drawing.Size(72, 17);
            this.rdb_todo_junto.TabIndex = 2;
            this.rdb_todo_junto.TabStop = true;
            this.rdb_todo_junto.Text = "todo junto";
            this.rdb_todo_junto.UseVisualStyleBackColor = true;
            // 
            // rdb_ventas
            // 
            this.rdb_ventas.AutoSize = true;
            this.rdb_ventas.Location = new System.Drawing.Point(194, 12);
            this.rdb_ventas.Name = "rdb_ventas";
            this.rdb_ventas.Size = new System.Drawing.Size(57, 17);
            this.rdb_ventas.TabIndex = 3;
            this.rdb_ventas.TabStop = true;
            this.rdb_ventas.Text = "ventas";
            this.rdb_ventas.UseVisualStyleBackColor = true;
            // 
            // rdb_ranking
            // 
            this.rdb_ranking.AutoSize = true;
            this.rdb_ranking.Location = new System.Drawing.Point(103, 12);
            this.rdb_ranking.Name = "rdb_ranking";
            this.rdb_ranking.Size = new System.Drawing.Size(60, 17);
            this.rdb_ranking.TabIndex = 4;
            this.rdb_ranking.TabStop = true;
            this.rdb_ranking.Text = "ranking";
            this.rdb_ranking.UseVisualStyleBackColor = true;
            // 
            // rdb_inventario
            // 
            this.rdb_inventario.AutoSize = true;
            this.rdb_inventario.Location = new System.Drawing.Point(12, 12);
            this.rdb_inventario.Name = "rdb_inventario";
            this.rdb_inventario.Size = new System.Drawing.Size(71, 17);
            this.rdb_inventario.TabIndex = 5;
            this.rdb_inventario.TabStop = true;
            this.rdb_inventario.Text = "inventario";
            this.rdb_inventario.UseVisualStyleBackColor = true;
            // 
            // poner_a_cero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 77);
            this.Controls.Add(this.btn_reiniciar_a_cero);
            this.Controls.Add(this.rdb_todo_junto);
            this.Controls.Add(this.rdb_ventas);
            this.Controls.Add(this.rdb_ranking);
            this.Controls.Add(this.rdb_inventario);
            this.Name = "poner_a_cero";
            this.Text = "poner_a_cero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reiniciar_a_cero;
        private System.Windows.Forms.RadioButton rdb_todo_junto;
        private System.Windows.Forms.RadioButton rdb_ventas;
        private System.Windows.Forms.RadioButton rdb_ranking;
        private System.Windows.Forms.RadioButton rdb_inventario;
    }
}