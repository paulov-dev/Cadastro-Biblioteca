using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmAula01 : Form
    {
        public FrmAula01()
        {
            InitializeComponent();
        }

        private void FrmAula01_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Primeira maravilhosa aula";
        }

        private void FrmAula01_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }
    }
}
