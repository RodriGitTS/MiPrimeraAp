namespace MiPrimeraAp
{
    partial class Frm2
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
            this.lblLado1 = new System.Windows.Forms.TextBox();
            this.lblLado2 = new System.Windows.Forms.TextBox();
            this.lblLado3 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.Label();
            this.txtLado2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLado1
            // 
            this.lblLado1.Location = new System.Drawing.Point(84, 34);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(249, 20);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblLado2
            // 
            this.lblLado2.Location = new System.Drawing.Point(84, 64);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(249, 20);
            this.lblLado2.TabIndex = 1;
            // 
            // lblLado3
            // 
            this.lblLado3.Location = new System.Drawing.Point(84, 90);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(249, 20);
            this.lblLado3.TabIndex = 2;
            this.lblLado3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtLado1
            // 
            this.txtLado1.AutoSize = true;
            this.txtLado1.Location = new System.Drawing.Point(27, 41);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(41, 13);
            this.txtLado1.TabIndex = 3;
            this.txtLado1.Text = "Lado A";
            // 
            // txtLado2
            // 
            this.txtLado2.AutoSize = true;
            this.txtLado2.Location = new System.Drawing.Point(27, 67);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(41, 13);
            this.txtLado2.TabIndex = 4;
            this.txtLado2.Text = "Lado B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lado C";
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(108, 116);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(160, 29);
            this.btnComprobar.TabIndex = 6;
            this.btnComprobar.Text = "¿Sera un triangulo?";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(84, 151);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(249, 20);
            this.lblResultado.TabIndex = 7;
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(401, 198);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm2";
            this.Text = "Frm2";
            this.Load += new System.EventHandler(this.Frm2_Load);
            this.Resize += new System.EventHandler(this.formTriangulo_resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblLado1;
        private System.Windows.Forms.TextBox lblLado2;
        private System.Windows.Forms.TextBox lblLado3;
        private System.Windows.Forms.Label txtLado1;
        private System.Windows.Forms.Label txtLado2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.TextBox lblResultado;
    }
}