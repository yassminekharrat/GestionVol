using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVolYassmineKharrat
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void avionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDesAvions gs = new GestionDesAvions();
            gs.MdiParent = this;
            gs.Show();
        }

        private void volToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionVols gv = new GestionVols();
            gv.MdiParent = this;
            gv.Show();
        }

        private void MenuPrincopal_Load(object sender, EventArgs e)
        {

        }
    }
}
