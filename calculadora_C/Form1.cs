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
    }
}
