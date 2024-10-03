namespace MiPrimeraAp
{
    partial class Frm3
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtExplicacion = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnTipoLetra = new System.Windows.Forms.Button();
            this.lblProbando = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtExplicacion
            // 
            this.txtExplicacion.AutoSize = true;
            this.txtExplicacion.Location = new System.Drawing.Point(153, 164);
            this.txtExplicacion.Name = "txtExplicacion";
            this.txtExplicacion.Size = new System.Drawing.Size(801, 25);
            this.txtExplicacion.TabIndex = 0;
            this.txtExplicacion.Text = "Elige el color de fondo de este formulario y el tipo de letra de este cuadro de t" +
    "exto ";
            this.txtExplicacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(253, 255);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(147, 65);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnTipoLetra
            // 
            this.btnTipoLetra.Location = new System.Drawing.Point(634, 255);
            this.btnTipoLetra.Name = "btnTipoLetra";
            this.btnTipoLetra.Size = new System.Drawing.Size(137, 65);
            this.btnTipoLetra.TabIndex = 2;
            this.btnTipoLetra.Text = "letra";
            this.btnTipoLetra.UseVisualStyleBackColor = true;
            this.btnTipoLetra.Click += new System.EventHandler(this.btnTipoLetra_Click);
            // 
            // lblProbando
            // 
            this.lblProbando.Enabled = false;
            this.lblProbando.Location = new System.Drawing.Point(407, 409);
            this.lblProbando.Multiline = true;
            this.lblProbando.Name = "lblProbando";
            this.lblProbando.Size = new System.Drawing.Size(260, 91);
            this.lblProbando.TabIndex = 5;
            this.lblProbando.Text = "Probando...";
            this.lblProbando.TextChanged += new System.EventHandler(this.lblProbando_TextChanged);
            // 
            // Frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 570);
            this.Controls.Add(this.lblProbando);
            this.Controls.Add(this.btnTipoLetra);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtExplicacion);
            this.Name = "Frm3";
            this.Text = "Frm3";
            this.Load += new System.EventHandler(this.Frm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label txtExplicacion;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnTipoLetra;
        private System.Windows.Forms.TextBox lblProbando;
    }
}