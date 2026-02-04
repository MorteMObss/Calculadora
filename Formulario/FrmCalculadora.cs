using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                int a = 0;
                int b = 0;
                int resultado = 0;

                a = int.Parse(textBoxA.Text);
                b = int.Parse(textBoxB.Text);

                if (rdbSuma.Checked)
                {
                    resultado = a + b;
                }

                if (rdbResta.Checked)
                {
                    resultado = a - b;
                }

                if (rdbMult.Checked)
                {
                    resultado = a * b;
                }

                if (rdbDiv.Checked)
                {
                    resultado = a / b;
                }

                MessageBox.Show("El resultado es: " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Ingresa numeros enteros para calcular la suma.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void ButReset_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDiv_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
