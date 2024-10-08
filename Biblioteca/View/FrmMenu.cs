using Biblioteca.View;

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

        private void MnuUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrm = new FrmUsuario();
            oFrm.MdiParent = this;
            MnuUsuario.Enabled = false;
            MnSUsuario.Enabled = false;
            oFrm.Show();
        }

        private void MnSUsuario_Click(object sender, EventArgs e)
        {
            MnuUsuario_Click(sender, e);
        }

        private void MnuLivro_Click(object sender, EventArgs e)
        {
            FrmLivro oFrm = new FrmLivro();
            oFrm.MdiParent = this;
            MnuLivro.Enabled = false;
            MnSLivro.Enabled = false;
            oFrm.Show();
        }

        private void MnSLivro_Click(object sender, EventArgs e)
        {
            MnuLivro_Click(sender, e);
        }
    }
}
