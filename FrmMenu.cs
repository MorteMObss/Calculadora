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
    }
}
