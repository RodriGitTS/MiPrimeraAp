using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAp
{
    public partial class FrmTextos : Form
    {
        public FrmTextos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!txtContraseña.UseSystemPasswordChar)
            {
                txtContraseña.UseSystemPasswordChar = true;
            }else { txtContraseña.UseSystemPasswordChar=false; }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMusica.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Escritura")
            {
                button2.Text = "Solo lectura";
                txtNombre.ReadOnly = false;

            }
            else
            {
                button2.Text = "Escritura";
                txtNombre.ReadOnly = true;
            }
        }
    }
}
