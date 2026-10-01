using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "Brisly" && textContraseña.Text == "71")
            {
                this.Hide();
                Form2 App = new Form2();
                App.Show();

            }
            else
            {
                MessageBox.Show("datos incorrectos");
            }
        }
    }
}
