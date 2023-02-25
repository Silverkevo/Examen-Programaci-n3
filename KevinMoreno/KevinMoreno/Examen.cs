using System;
using System.Windows.Forms;

namespace KevinMoreno
{
    public partial class Examen : Form
    {
        public Examen()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ejercicio1 = new Frm1();
            Ejercicio1.MdiParent = this;
            Ejercicio1.Show();
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ejercicio2 = new Frm2();
            Ejercicio2.MdiParent = this;
            Ejercicio2.Show();
        }

        private void formulario3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ejercicio3 = new Frm3();
            Ejercicio3.MdiParent = this;
            Ejercicio3.Show();
        }
    }
}
