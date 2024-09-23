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

        private void MnuEditora_Click(object sender, EventArgs e)
        {
            FrmEditora oFrm = new FrmEditora();
            oFrm.MdiParent = this;
            MnuEditora.Enabled = false;
            MnSEditora.Enabled = false;
            oFrm.Show();
        }

        private void MnSEditora_Click(object sender, EventArgs e)
        {
            MnuEditora_Click(sender, e); 
        }
    }
}
