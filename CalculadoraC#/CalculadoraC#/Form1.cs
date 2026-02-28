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
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        string operacion = "";
        bool hayOperacion = false;

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

        private void Operador_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            // Guardamos el primer número y la operación seleccionada
            valor1 = double.Parse(txtPantalla.Text);
            operacion = boton.Text;
            hayOperacion = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double valor2 = double.Parse(txtPantalla.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+": resultado = valor1 + valor2; break;
                case "-": resultado = valor1 - valor2; break;
                case "x": resultado = valor1 * valor2; break;
                case "/":
                    // Heurística: Prevención de errores (Nielsen)
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        MessageBox.Show("Error: No se puede dividir por cero");
                        return;
                    }
                    break;
            }
            txtPantalla.Text = resultado.ToString();
            hayOperacion = true;
        }
    }
}
