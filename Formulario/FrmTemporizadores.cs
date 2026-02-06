using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formulario
{
    public partial class FrmTemporizadores : Form
    {
        public FrmTemporizadores()
        {
            InitializeComponent();
        }

        private void FrmTemporizadores_Load(object sender, EventArgs e)
        {

        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
