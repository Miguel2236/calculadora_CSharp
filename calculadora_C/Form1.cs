using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_C
{
    public partial class frmCalc : Form
    {
        private double memoria01 = 0.0;
        private double memoria02 = 0.0;
        private string signo = "";

        public frmCalc()
        {
            InitializeComponent();
        }

        // botones de números //
        private void btn0_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "9";
        }

        // botones de funciones //
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textPantalla.Text = "";
            memoria01 = 0.0;
            memoria02 = 0.0;
            signo = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPantalla.Text != "")
                {
                    memoria01 = Convert.ToDouble(textPantalla.Text);
                    signo = "+";
                    textPantalla.Clear();
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPantalla.Text != "")
                {
                    memoria01 = Convert.ToDouble(textPantalla.Text);
                    signo = "-";
                    textPantalla.Clear();
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPantalla.Text != "")
                {
                    memoria01 = Convert.ToDouble(textPantalla.Text);
                    signo = "*";
                    textPantalla.Clear();
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPantalla.Text != "")
                {
                    memoria01 = Convert.ToDouble(textPantalla.Text);
                    signo = "/";
                    textPantalla.Clear();
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPantalla.Text != "")
                {
                    memoria01 = Convert.ToDouble(textPantalla.Text);
                    signo = "exp";
                    textPantalla.Clear();
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPantalla.Text != "")
                {
                    memoria01 = Convert.ToDouble(textPantalla.Text);
                    signo = "raiz";
                    textPantalla.Clear();
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPantalla.Text != "")
                {
                    double ress = Convert.ToDouble(textPantalla.Text) * (-1);
                    textPantalla.Text = Convert.ToString(ress);
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }

        private void btnInversa_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPantalla.Text != "")
                {
                    double ress = 1 / Convert.ToDouble(textPantalla.Text);
                    textPantalla.Text = Convert.ToString(ress);
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPantalla.Text != "")
                {
                    memoria01 = Convert.ToDouble(textPantalla.Text);
                    signo = "%";
                    textPantalla.Clear();
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPantalla.Text == "")
                {
                    textPantalla.Text = "0.";
                }
                else if(validar_punto(textPantalla.Text) == false)
                {
                    textPantalla.Text = textPantalla.Text + ".";
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }
        private bool validar_punto(string cadena)
        {
            /* validar si hay punto */

            int largo;
            bool respuesta = false;

            largo = cadena.Length;

            for (int i = 1; i < largo; i++)
            {
                if (cadena.Substring(i,1) == ".")
                {
                    respuesta = true;
                }
            }

            return respuesta;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // borrar un solo digito
            try
            {
                int largo;

                if (textPantalla.Text != "")
                {
                    largo = textPantalla.Text.Length;

                    textPantalla.Text = textPantalla.Text.Substring(1, largo - 1);
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPantalla.Text != "")
                {
                    memoria02 = Convert.ToDouble(textPantalla.Text);
                    this.calculadora();
                }
            }
            catch (Exception)
            {
                textPantalla.Text = "Error";
                throw;
            }
        }
        
        private void calculadora()
        {
            // Calculos
            switch (signo)
            {
                case "+":
                    textPantalla.Text = Convert.ToString(memoria01 + memoria02);
                    break;

                case "-":
                    textPantalla.Text = Convert.ToString(memoria01 - memoria02);
                    break;

                case "*":
                    textPantalla.Text = Convert.ToString(memoria01 * memoria02);
                    break;

                case "/":
                    textPantalla.Text = Convert.ToString(memoria01 / memoria02);
                    break;

                case "raiz":
                    textPantalla.Text = Convert.ToString(Math.Pow(memoria01, (1/ memoria02)));
                    break;

                case "exp":
                    textPantalla.Text = Convert.ToString(Math.Pow(memoria01, memoria02));
                    break;

                case "%":
                    textPantalla.Text = Convert.ToString(memoria01 * memoria02/100);
                    break;

                default:
                    break;
            }
        }

        
    }
}
