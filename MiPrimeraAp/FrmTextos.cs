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

        private void btnMostrarPassW_Click(object sender, EventArgs e)
        {
            if (!txtContraseña.UseSystemPasswordChar)
            {
                txtContraseña.Text = "Ocultar";
                txtContraseña.UseSystemPasswordChar = true;
            }else {
                txtContraseña.Text = "Mostrar";
                txtContraseña.UseSystemPasswordChar=false; }
        }

        private void btnActivarApellido_Click(object sender, EventArgs e)
        {
            if (btnActivarApellido.Text == "Desactivar")
            {
                txtApellido.Enabled = true;
            }
            else
            {
                btnActivarApellido.Text= "Activar";
                txtApellido.Enabled=false;
            }
        }

        private void btnFoco_Click(object sender, EventArgs e)
        {
            txtMusica.Focus();
        }

        private void btnEscritura_click(object sender, EventArgs e)
        {
            if (btnEscritura.Text == "Escritura")
            {
                btnEscritura.Text = "Solo lectura";
                txtNombre.ReadOnly = false;

            }
            else
            {
                btnEscritura.Text = "Escritura";
                txtNombre.ReadOnly = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
