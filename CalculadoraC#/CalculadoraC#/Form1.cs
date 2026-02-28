using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraC_
{
    double valor1 = 0;
    double valor2 = 0;
    string operacion = "";
    bool hayOperacion = false;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if ((txtPantalla.Text == "0") || (hayOperacion))
                txtPantalla.Clear();

            hayOperacion = false;
            txtPantalla.Text += boton.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
