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
    public partial class DodajOrganizatoraForma : Form
    {
        public DodajOrganizatoraForma()
        {
            InitializeComponent();
        }
        Form pocetna;
        public DodajOrganizatoraForma(Form p)
        {
            InitializeComponent();
            p.Hide();
            pocetna = p;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbIme.Text.Length == 0 || tbPrezime.Text.Length == 0 || tbJMBG.Text.Length == 0)
            {
                MessageBox.Show("Morate uneti ime, prezime i JMBG!");
                return;
            }
            else
            if (tbJMBG.Text.Length != 13)
            {
                MessageBox.Show("JMBG mora imati 13 cifara!");
                return;
            }
            OrganizatorPregled noviOrg = new OrganizatorPregled(0, tbIme.Text, tbPrezime.Text, tbGrad.Text, tbUlica.Text, tbBroj.Text, tbJMBG.Text);
            DTOManager.dodajOrganizatora(noviOrg);
            MessageBox.Show("Uspesno ste dodali organizatora");
        }

        private void DodajOrganizatoraForma_Load(object sender, EventArgs e)
        {
            lblIme.BackColor = Color.Transparent;
            lblPrezime.BackColor = Color.Transparent;
            lblGrad.BackColor = Color.Transparent;
            lblUlica.BackColor = Color.Transparent;
            lblBroj.BackColor = Color.Transparent;
            lblRegBroj.BackColor = Color.Transparent;
        }

        private void DodajOrganizatoraForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            pocetna.Show();
        }

        private void tbJMBG_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUlica_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGrad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRegBroj_Click(object sender, EventArgs e)
        {

        }

        private void lblBroj_Click(object sender, EventArgs e)
        {

        }

        private void lblUlica_Click(object sender, EventArgs e)
        {

        }

        private void lblGrad_Click(object sender, EventArgs e)
        {

        }

        private void lblPrezime_Click(object sender, EventArgs e)
        {

        }

        private void lblIme_Click(object sender, EventArgs e)
        {

        }
    }
}
