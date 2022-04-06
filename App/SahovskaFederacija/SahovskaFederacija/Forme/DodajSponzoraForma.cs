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
    public partial class DodajSponzoraForma : Form
    {
        SponzoriForma sponzoriForma;
        int idTurnira;
        public DodajSponzoraForma(SponzoriForma sf, int id)
        {
            InitializeComponent();
            sf.Hide();
            sponzoriForma = sf;
            idTurnira = id;
        }

        private void DodajSponzoraForma_Load(object sender, EventArgs e)
        {
            lblNaziv.BackColor = Color.Transparent;
        }

        private void DodajSponzoraForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            sponzoriForma.Show();
            sponzoriForma.popuniPodacima();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            SponzorPregled sponzor = new SponzorPregled();
            sponzor.Naziv = tbNaziv.Text;
            DTOManager.dodajSponzora(sponzor,idTurnira);
            MessageBox.Show("Uspesno ste dodali sponzora!");
        }
    }
}
