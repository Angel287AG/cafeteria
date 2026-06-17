using Cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeteria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void cafeteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cafeteria = Application.OpenForms["frmcafeteria"];

            if (cafeteria != null)
            {
                if (cafeteria.WindowState == FormWindowState.Minimized)
                    cafeteria.WindowState = FormWindowState.Normal;

                cafeteria.Activate();
            }
            else
            {
                cafeteria = new frmcafeteria();
                cafeteria.MdiParent = this;
                cafeteria.Show();
            }
        }

        private void cafeteriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form cafeteria = Application.OpenForms["frmcafeteria"];

            if (cafeteria != null)
            {
                if (cafeteria.WindowState == FormWindowState.Minimized)
                    cafeteria.WindowState = FormWindowState.Normal;

                cafeteria.Activate();
            }
            else
            {
                cafeteria = new frmcafeteria();
                cafeteria.MdiParent = this;
                cafeteria.Show();
            }
        }

        private void maquinaExpendedoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cafeteria = Application.OpenForms["maquina expendedora"];

            if (cafeteria != null)
            {
                if (cafeteria.WindowState == FormWindowState.Minimized)
                    cafeteria.WindowState = FormWindowState.Normal;

                cafeteria.Activate();
            }
            else
            {
                cafeteria = new frmmaquinaexpendedora();
                cafeteria.MdiParent = this;
                cafeteria.Show();
            }
        }
    }
}
