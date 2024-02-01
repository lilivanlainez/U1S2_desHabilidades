using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string nombre = txbnombre.Text;
            double salario = double.Parse(txbsalario.Text);


            // Determinar el tipo de empleado seleccionado
            string tipoEmpleado = "";

            if (rbtgerente.Checked)
            {
                tipoEmpleado = "Gerente";
            }
            else if (rbtsubgerente.Checked)
            {
                tipoEmpleado = "Subgerente";
            }
            else if (rbtsecretaria.Checked)
            {
                tipoEmpleado = "Secretaria";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular descuento y salario neto
            double descuento = 0;

            switch (tipoEmpleado)
            {
                case "Gerente":
                    descuento = salario * 0.20;
                    break;

                case "Subgerente":
                    descuento = salario * 0.15;
                    break;

                case "Secretaria":
                    descuento = salario * 0.05;
                    break;
            }

            double salarioNeto = salario - descuento;

            // Mostrar resultados
            MessageBox.Show($"Nombre: {nombre}\nTipo de empleado: {tipoEmpleado}\nSalario antes de descuento: ${salario.ToString("0.00")}\nDescuento: ${descuento.ToString("0.00")}\nSalario neto: ${salarioNeto.ToString("0.00")}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

