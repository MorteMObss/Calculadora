using Calculadora.Formulario;

namespace Calculadora
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadoraSimpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculadora calculadoraSimple = new FrmCalculadora();
            calculadoraSimple.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBurbuja burbuja = new FrmBurbuja();
            burbuja.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrosAlumnos registrosAlumnos = new FrmRegistrosAlumnos();
            registrosAlumnos.Show();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTemporizadores temporizadores = new FrmTemporizadores();
            temporizadores.Show();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor editor = new frmEditor();
            editor.Show();
        }
    }
}
