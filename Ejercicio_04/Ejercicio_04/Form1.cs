using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            listbArreglo.Items.Add(txbNumero.Text);
            txbNumero.Clear();
            txbNumero.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int mayorneg = int.MinValue;
            bool hayNumerosNegativosPares = false;

            double cantidadnumeros = listbArreglo.Items.Count;
            double cantidadceros = 0;
            double porcentaje = 0;

            double cantidadImpares = 0;
            double sumaImpares = 0;

            bool encontrado = false;

            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString();

                if (int.TryParse(valor, out int numero))
                {
                    // Manejar números negativos pares
                    if (numero < 0 && numero % 2 == 0)
                    {
                        if (numero > mayorneg)
                        {
                            mayorneg = numero;
                            hayNumerosNegativosPares = true;
                        }
                    }

                    // Contar cantidad de ceros
                    if (numero == 0)
                    {
                        cantidadceros++;
                    }

                    // Calcular suma de números impares positivos
                    if (numero > 0 && numero % 2 != 0)
                    {
                        sumaImpares += numero;
                        cantidadImpares++;
                    }

                    // Verificar si hay al menos un número negativo par
                    if (numero < 0 && numero % 2 == 0)
                    {
                        if (numero > mayorneg)
                        {
                            mayorneg = numero;
                            encontrado = true;
                        }
                    }
                }
                else
                {
                    // Manejar la conversión fallida, por ejemplo, mostrar un mensaje de error.
                    MessageBox.Show($"No se pudo convertir el valor '{valor}' a un número válido.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Mostrar resultado de números negativos pares
            if (hayNumerosNegativosPares)
            {
                txbCalculo1.Text = mayorneg.ToString();
            }
            else
            {
                txbCalculo1.Text = "No hay números negativos pares";
            }

            // Calcular y mostrar porcentaje de ceros
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            txbCalculo2.Text = porcentaje.ToString() + "%";

            // Mostrar resultado de suma de números impares positivos
            if (cantidadImpares > 0)
            {
                double promedioImpares = sumaImpares / cantidadImpares;
                txbCalculo3.Text = promedioImpares.ToString();
            }
            else
            {
                txbCalculo3.Text = "No hay números impares positivos";
            }

            // Mostrar resultado de búsqueda de números negativos pares
           int mayor = int.MinValue; // Inicializar con el valor mínimo de Int32

            foreach (object item in listbArreglo.Items)
            {
                if (int.TryParse(item.ToString(), out int numero))
                {
                    if (numero > 0 && numero % 2 == 0)
                    {
                        if (numero > mayor)
                        {
                            mayor = numero;
                        }
                    }
                }
                else
                {
                    // Manejar la conversión fallida, por ejemplo, mostrar un mensaje de error.
                    MessageBox.Show($"No se pudo convertir el valor '{item}' a un número válido.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (mayor != int.MinValue)
            {
                txbCalculo4.Text = mayor.ToString();
            }
            else
            {
                // Manejar el caso cuando no hay números pares positivos.
                txbCalculo4.Text = "No hay números pares positivos.";
            }
        }
    }
}