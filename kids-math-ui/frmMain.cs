using Graficador;

namespace kids_math_ui
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmGraficador();

            frm.Show();
        }
    }
}
