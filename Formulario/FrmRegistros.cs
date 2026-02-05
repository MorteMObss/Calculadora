using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calculadora.Clases;

namespace Calculadora.Formulario
{
    public partial class FrmRegistrosAlumnos : Form
    {
        List<Persona> persona = new List<Persona>();
        public FrmRegistrosAlumnos()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Fecha = dtpFecha.Value
            });

            MessageBox.Show("Registro exitoso");

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tcRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tcRegistro.SelectedIndex == 1)
            {
                dgvMostrar.DataSource = null;
                dgvMostrar.DataSource = persona;
            }

        }
    }
}
