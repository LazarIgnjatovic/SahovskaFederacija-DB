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
    public partial class DodajPotezForma : Form
    {
        PoteziPartijeForma poteziPartijeForma;
        int idPartije;
        public DodajPotezForma(PoteziPartijeForma ppf, int id)
        {
            InitializeComponent();
            ppf.Hide();
            poteziPartijeForma = ppf;
            idPartije = id;
        }

        private void DodajPotezForma_Load(object sender, EventArgs e)
        {
            lblBrojPoteza.BackColor = Color.Transparent;
            lblPotez.BackColor = Color.Transparent;
            lblVreme.BackColor = Color.Transparent;
        }

        private void DodajPotezForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            poteziPartijeForma.Show();
            poteziPartijeForma.popuniPodacima();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbPotez.Text == "")
            {
                MessageBox.Show("Morate uneti potez!");
                return;
            }
            PotezPregled potez = new PotezPregled();
            potez.Broj = (int)numBroj.Value;
            potez.Odigrano = tbPotez.Text;
            potez.Vreme = dtpVreme.Value;
            DTOManager.dodajPotez(potez, idPartije);
            MessageBox.Show("Potez uspesno dodat!");
        }
    }
}
