namespace MiPrimeraAp
{
    partial class FrmTextos
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMusica = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnFoco = new System.Windows.Forms.Button();
            this.btnEscritura = new System.Windows.Forms.Button();
            this.btnActivarApellido = new System.Windows.Forms.Button();
            this.btnHacerVisible = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 184);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtMusica
            // 
            this.txtMusica.Location = new System.Drawing.Point(79, 34);
            this.txtMusica.Multiline = true;
            this.txtMusica.Name = "txtMusica";
            this.txtMusica.Size = new System.Drawing.Size(252, 144);
            this.txtMusica.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(79, 210);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(252, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(79, 236);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(252, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // btnFoco
            // 
            this.btnFoco.Location = new System.Drawing.Point(369, 104);
            this.btnFoco.Name = "btnFoco";
            this.btnFoco.Size = new System.Drawing.Size(136, 35);
            this.btnFoco.TabIndex = 4;
            this.btnFoco.Text = "Pasar foco";
            this.btnFoco.UseVisualStyleBackColor = true;
            this.btnFoco.Click += new System.EventHandler(this.btnFoco_Click);
            // 
            // btnEscritura
            // 
            this.btnEscritura.Location = new System.Drawing.Point(369, 177);
            this.btnEscritura.Name = "btnEscritura";
            this.btnEscritura.Size = new System.Drawing.Size(118, 27);
            this.btnEscritura.TabIndex = 5;
            this.btnEscritura.Text = "Escritura";
            this.btnEscritura.UseVisualStyleBackColor = true;
            this.btnEscritura.Click += new System.EventHandler(this.btnEscritura_click);
            // 
            // button3
            // 
            this.btnActivarApellido.Location = new System.Drawing.Point(369, 210);
            this.btnActivarApellido.Name = "button3";
            this.btnActivarApellido.Size = new System.Drawing.Size(118, 24);
            this.btnActivarApellido.TabIndex = 6;
            this.btnActivarApellido.Text = "Activar";
            this.btnActivarApellido.UseVisualStyleBackColor = true;
            this.btnActivarApellido.Click += new System.EventHandler(this.btnActivarApellido_Click);
            // 
            // btnHacerVisible
            // 
            this.btnHacerVisible.Location = new System.Drawing.Point(369, 240);
            this.btnHacerVisible.Name = "btnHacerVisible";
            this.btnHacerVisible.Size = new System.Drawing.Size(109, 28);
            this.btnHacerVisible.TabIndex = 7;
            this.btnHacerVisible.Text = "Hacer visible";
            this.btnHacerVisible.UseVisualStyleBackColor = true;
            this.btnHacerVisible.Click += new System.EventHandler(this.btnMostrarPassW_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(9, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(21, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Musica";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmTextos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(564, 288);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHacerVisible);
            this.Controls.Add(this.btnActivarApellido);
            this.Controls.Add(this.btnEscritura);
            this.Controls.Add(this.btnFoco);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtMusica);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmTextos";
            this.Text = "Frm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMusica;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnFoco;
        private System.Windows.Forms.Button btnEscritura;
        private System.Windows.Forms.Button btnActivarApellido;
        private System.Windows.Forms.Button btnHacerVisible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}