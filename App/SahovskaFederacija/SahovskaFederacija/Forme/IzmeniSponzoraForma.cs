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
    public partial class IzmeniSponzoraForma : Form
    {
        SponzoriForma sponzoriForma;
        SponzorPregled sponzor;
        public IzmeniSponzoraForma(SponzoriForma sp, SponzorPregled s)
        {
            InitializeComponent();
            sp.Hide();
            sponzoriForma = sp;
            sponzor = s;
        }

        private void IzmeniSponzoraForma_Load(object sender, EventArgs e)
        {
            lblNaziv.BackColor = Color.Transparent;
            tbNaziv.Text = sponzor.Naziv;
        }

        private void IzmeniSponzoraForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            sponzoriForma.Show();
            sponzoriForma.popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (tbNaziv.Text != null)
            {
                sponzor.Naziv = tbNaziv.Text;
                DTOManager.izmeniSponzora(sponzor);
                MessageBox.Show("Uspesno ste izmenili sponozra!");
            }
            else
                MessageBox.Show("Unesite novi naziv za sponzora!");
        }
    }
}
