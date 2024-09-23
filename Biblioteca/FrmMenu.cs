namespace Biblioteca
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void MnuGenero_Click(object sender, EventArgs e)
        {
            FrmGenero oFrm = new FrmGenero();
            oFrm.MdiParent = this;
            MnuGenero.Enabled = false;
            MnSGenero.Enabled = false;
            oFrm.Show();
        }

        private void MnSGenero_Click(object sender, EventArgs e)
        {
            MnuGenero_Click(sender, e);
        }

        private void MnuAula01_Click(object sender, EventArgs e)
        {
            FrmAula01 oFrm = new FrmAula01();
            oFrm.MdiParent = this;
            oFrm.Show();

        }

        private void MnuAutor_Click_1(object sender, EventArgs e)
        {
            FrmAutor oFrm = new FrmAutor();
            oFrm.MdiParent = this;
            MnuAutor.Enabled = false;
            MnSAutor.Enabled = false;
            oFrm.Show();
        }

        private void MnSAutor_Click(object sender, EventArgs e)
        {
            MnuAutor_Click_1(sender, e);
        }


        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MnuSuspenso_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void MnuIdioma_Click(object sender, EventArgs e)
        {
            FrmIdioma oFrm = new FrmIdioma();
            oFrm.MdiParent = this;
            MnuIdioma.Enabled = false;
            MnSIdioma.Enabled = false;
            oFrm.Show();
        }
        private void MnSIdioma_Click(object sender, EventArgs e)
        {
            MnuIdioma_Click(sender, e);
        }
    }
}
