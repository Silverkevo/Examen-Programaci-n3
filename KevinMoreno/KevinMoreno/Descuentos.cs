using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinMoreno
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }



        private async Task<float> DescuentoAsync(float n1, float n2, float n3)
        {

            float subtotal = await Task.Run(() =>
            {
                return n1 + n2 + n3;
            });
            return subtotal * 0.15f;
        }



        private async void CalcularaSyncButton_Click(object sender, System.EventArgs e)
        {
            if (CompraTextBox1.Text == "")
            {
                errorProvider1.SetError(CompraTextBox1, "Ingrese una compra o escriba 0 ");
                return;
            }
            errorProvider1.Clear();
            if (CompraTextBox2.Text == "")
            {
                errorProvider1.SetError(CompraTextBox2, "Ingrese una compra o escriba 0 ");
                return;
            }
            errorProvider1.Clear();
            if (CompraTextBox3.Text == "")
            {
                errorProvider1.SetError(CompraTextBox3, "Ingrese una compra o escriba 0 ");
                return;
            }
            errorProvider1.Clear();
            float zapatos = 800;
            float calcetines = 50;
            float camisas = 300;
            int cantidad = 0;
            cantidad = Convert.ToInt16(CompraTextBox1.Text) + Convert.ToInt16(CompraTextBox2.Text) + Convert.ToInt16(CompraTextBox3.Text);

            float num1 = Convert.ToInt16(CompraTextBox1.Text) * zapatos;
            float num2 = Convert.ToInt16(CompraTextBox2.Text) * calcetines;
            float num3 = Convert.ToInt16(CompraTextBox3.Text) * camisas;




            float resultado = await DescuentoAsync(num1, num2, num3);


            MessageBox.Show($" Compró {cantidad} prendas de  Vestir \n Su descuento fue de L. {resultado}\n Su total a pagar es de L. {num1 + num2 + num3 - resultado}", "Factura");






            CompraTextBox1.Focus();
            CompraTextBox1.Clear();
            CompraTextBox2.Clear();
            CompraTextBox3.Clear();





        }

        private void Frm2_Activated(object sender, EventArgs e)
        {
            CompraTextBox1.Focus();
        }

        private void CalcelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm2_Load(object sender, EventArgs e)
        {

        }
    }
}
