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
    public partial class IzmeniOrganizatoraForma : Form
    {
        public IzmeniOrganizatoraForma()
        {
            InitializeComponent();
        }
        OrganizatorPregled organizator;
        Form pocetna;
        public IzmeniOrganizatoraForma(Form p,OrganizatorPregled org)
        {
            pocetna = p;
            organizator = org;
            InitializeComponent();
            p.Hide();
        }

        private void IzmeniOrganizatoraForma_Load(object sender, EventArgs e)
        {
            lblIme.BackColor = Color.Transparent;
            lblPrezime.BackColor = Color.Transparent;
            lblGrad.BackColor = Color.Transparent;
            lblUlica.BackColor = Color.Transparent;
            lblBroj.BackColor = Color.Transparent;
            lblRegBroj.BackColor = Color.Transparent;
            tbIme.Text = organizator.Ime;
            tbPrezime.Text = organizator.Prezime;
            tbGrad.Text = organizator.Grad;
            tbUlica.Text = organizator.Ulica;
            tbBroj.Text = organizator.Broj;
            tbJMBG.Text = organizator.JMBG;
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
            organizator.Ime = tbIme.Text;
            organizator.Prezime = tbPrezime.Text;
            organizator.Ulica = tbUlica.Text;
            organizator.Grad = tbGrad.Text;
            organizator.Broj = tbBroj.Text;
            organizator.JMBG = tbJMBG.Text;

            DTOManager.izmeniOrganizatora(organizator);
            MessageBox.Show("Uspesno ste izmenili organizatora!");

        }

        private void IzmeniOrganizatoraForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            pocetna.Show();
        }
    }
}
