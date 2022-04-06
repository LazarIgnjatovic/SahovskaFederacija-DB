using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SahovskaFederacija.Forme
{
    public partial class IzmeniPotezForma : Form
    {
        PoteziPartijeForma poteziPartijeForma;
        PotezPregled potez;
        public IzmeniPotezForma(PoteziPartijeForma ppf, PotezPregled pp)
        {
            InitializeComponent();
            ppf.Hide();
            poteziPartijeForma = ppf;
            potez = pp;
        }

        private void IzmeniPotezForma_Load(object sender, EventArgs e)
        {
            lblBrojPoteza.BackColor = Color.Transparent;
            lblPotez.BackColor = Color.Transparent;
            lblVreme.BackColor = Color.Transparent;
            numBroj.Value = potez.Broj;
            tbPotez.Text = potez.Odigrano;
            dtpVreme.Value = potez.Vreme;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (tbPotez.Text == "")
            {
                MessageBox.Show("Morate uneti potez!");
                return;
            }
            PotezPregled pp = potez;
            pp.Broj = (int)numBroj.Value;
            pp.Odigrano = tbPotez.Text;
            pp.Vreme = dtpVreme.Value;
            DTOManager.izmeniPotez(pp);
            MessageBox.Show("Uspesno ste izmenili potez!");
        }

        private void IzmeniPotezForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            poteziPartijeForma.Show();
            poteziPartijeForma.popuniPodacima();
        }
    }
}
