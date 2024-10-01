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
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {

            int ladoA, ladoB, ladoC;

            bool booLadoA = int.TryParse(lblLado1.Text, out ladoA);
            bool booLadoB = int.TryParse(lblLado2.Text, out ladoB);
            bool booLadoC = int.TryParse(lblLado1.Text, out ladoC);

            if( !booLadoA|| !booLadoB|| !booLadoC)
            {
                MessageBox.Show("Hay datos no numericos");
                return;
            }

            if (ladoA == ladoB && ladoB==ladoC && ladoA== ladoC)
            {
                lblResultado.Text = "Es un triangulo equilatero";
            }   
         

        }

        private void Frm2_Load(object sender, EventArgs e)
        {

        }
    }
}
