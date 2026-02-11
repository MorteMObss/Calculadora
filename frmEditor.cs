using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculadora
{
    public partial class frmEditor : Form
    {
        Boolean saved = false;
        String path = "";
        public frmEditor()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdEditor.ShowDialog() == DialogResult.OK) {
                if (File.Exists(ofdEditor.FileName)) {

                    using (StreamReader archivo = new StreamReader(ofdEditor.FileName))
                    {
                        rtbEditor.Text = File.ReadAllText(ofdEditor.FileName);
                    }
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                guardar();
                saved = true;
            }
            else {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter archivo = new StreamWriter(sfdEditor.FileName))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = "";
            saved = false;
        }


        private void guardar() {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }


    }
}
