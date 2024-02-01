using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            // Obtener valores de los TextBox
            if (!double.TryParse(txba.Text, out double a) ||
                !double.TryParse(txbb.Text, out double b) ||
                !double.TryParse(txbc.Text, out double c))
            {
                MessageBox.Show("Ingrese valores numéricos válidos para a, b y c.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular discriminante
            double discriminante = Math.Pow(b, 2) - 4 * a * c;

            // Calcular x1 y x2
            if (discriminante >= 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                // Mostrar resultados en los TextBox
                txbx1.Text = x1.ToString("0.00");
                txbx2.Text = x2.ToString("0.00");
            }
            else
            {
                MessageBox.Show("La ecuación cuadrática no tiene soluciones reales.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
