using System;
using System.Windows.Forms;

namespace KevinMoreno
{
    public partial class Frm3 : Form
    {
        public Frm3()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 == 0 && numero % 5 == 0)
                {
                    listBox1.Items.Add("Kevin Moreno" + numero);
                }
                else if (numero % 5 == 0)
                {
                    listBox1.Items.Add("Moreno" + numero);
                }
                else if (numero % 3 == 0)
                {
                    listBox1.Items.Add("Kevin" + numero);
                }
                else
                {
                    listBox1.Items.Add(numero);
                }

            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
