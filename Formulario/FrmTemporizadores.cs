using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;
using CSCore.SoundOut;

namespace Calculadora.Formulario
{
    public partial class FrmTemporizadores : Form
    {
        String alarma1 = "";
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
            if (lblHora.Text == alarma1) {
                SoundPlayer player = new SoundPlayer();
                player.Play();
            }

        }

        private void alarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("Ingrese la hora para la alarma (formato hh:mm:ss tt)", "Sistema" , "(00:00:00 x.x)");
        }
    }
}
