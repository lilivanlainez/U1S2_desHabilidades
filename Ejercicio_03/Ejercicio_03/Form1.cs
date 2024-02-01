using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            // Obtener el valor ingresado en la caja de texto
            if (double.TryParse(txbvalor.Text, out double valor))
            {
                // Verificar el tipo de conversión seleccionado
                if (rbtemperatura.Checked)
                {
                    // Convertir de Celsius a Fahrenheit
                    double resultado = CelsiusToFahrenheit(valor);
                    txbresultado.Text = resultado.ToString("0.00") + " °F";
                }
                else if (rblongitud.Checked)
                {
                    // Convertir de Metros a Pies
                    double resultado = MetrosToPies(valor);
                    txbresultado.Text = resultado.ToString("0.00") + " ft";
                }
                else if (rbpeso.Checked)
                {
                    // Convertir de Kilogramos a Libras
                    double resultado = KilogramosToLibras(valor);
                    txbresultado.Text = resultado.ToString("0.00") + " lbs";
                }
                else
                {
                    MessageBox.Show("Selecciona un tipo de conversión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private double MetrosToPies(double metros)
        {
            return metros * 3.28084;
        }

        private double KilogramosToLibras(double kilogramos)
        {
            return kilogramos * 2.20462;
        }
    }
}