using System;
using System.Windows.Forms;

namespace KevinMoreno
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {

            float[] interes = new float[12];
            string[] nombresMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            float interesMes = 0;
            float capital = 200000;
            float tasa = 0.015f;
            for (int i = 0; i < 1; i++)
            {



                for (int j = 0; j < 12; j++)
                {

                    interesMes = capital * tasa;
                    capital = capital + interesMes;
                    interes[i] = interesMes;

                    listBox1.Items.Add("El  interes del mes de " + nombresMeses[j] + " es de L." + interes[i]);
                }

            }



        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }









        //private double Calcular(double intereses)
        //{
        //    double deposito = 200000.00;
        //    double interesMes = 0;
        //    double tasa = 0.0115;
        //    interesMes = deposito * tasa;
        //    intereses = interesMes + deposito;


        //    return intereses;
        //}
    }
}

