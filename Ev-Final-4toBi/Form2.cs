using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textVar1.Text);
            int num2 = int.Parse(textVar2.Text);
            int producto = num1 * num2;
            MessageBox.Show("el resultado del producto es:" + producto);

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textVar1.Text);
            int num2 = int.Parse(textVar2.Text);
            int suma = num1 + num2;
            MessageBox.Show("el resultado de la suma es:" + suma);

        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textVar1.Text);
            int num2 = int.Parse(textVar2.Text);
            int resultado = 1;
            for (int i = 0; i < num1; i++)
                resultado *= num1;
            MessageBox.Show("el resultado es:" + resultado);


        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textVar1.Text);
            float num2 = float.Parse(textVar2.Text);
            if (num2 < 0)
            {
                float division = num1 / num2;
                MessageBox.Show("el resultado es:" + division);
            }
            else
            {
                MessageBox.Show("la definicion es indefinida");
            }
        }
        
        
    }
}
