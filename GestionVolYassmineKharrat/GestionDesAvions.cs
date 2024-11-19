using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace GestionVolYassmineKharrat
{
    public partial class GestionDesAvions : Form
    {
        public GestionDesAvions()
        {
            InitializeComponent();
        }
        private void GestionDesAvions_Load(object sender, EventArgs e)
        {

            foreach (Avion a in Avion.LesAvions)
            {
                dgvAvions.Rows.Add(a.Reference, a.Marque, a.Nbpassagers);

            }
            cmbmarques.Items.AddRange(Avion.LesAvions.ToArray());


        }

        private void dgvAvions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            if (pos != -1)
            {
                Avion a = Avion.LesAvions[pos];
                txtref.Text = a.Reference;
                cmbmarques.SelectedItem = a.Marque;
                Convert.ToInt32(txtnb.Text);
                btnsupp.Enabled = true;
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            if (txtref.Text == "" || cmbmarques.SelectedIndex == -1 || txtnb.Text == "")
            {
                MessageBox.Show("les champs ne doit etre vide");
            }
            else
            {
                Avion av = new Avion(txtref.Text,
                   (string)cmbmarques.SelectedItem, Convert.ToInt32(txtnb.Text), ckDispo.Checked);

                if (Avion.LesAvions.Contains(av))
                {
                    MessageBox.Show("Avion existe !!");
                }
                else
                {
                    Avion.LesAvions.Add(av);

                    MessageBox.Show("Avion ajoutée avec succès");
                    viderchamp();
                    GestionDesAvions_Load(sender, e);
                }
            }
        }

        private void viderchamp()
        {
            txtref.Text = cmbmarques.Text = txtnb.Text;

        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            if (dgvAvions.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Etes vous  sure de supprimer", "attention", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvAvions.SelectedRows)
                    {
                        string reference = row.Cells[0].Value.ToString();
                        Avion a = Avion.LesAvions
                            .Where(x => x.Reference == reference)
                            .FirstOrDefault();
                        Avion.LesAvions.Remove(a);
                    }
                    viderchamp();
                    GestionDesAvions_Load(sender, e);
                }
            }
        }
    }
}
            
     