using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SahovskaFederacija;

namespace SahovskaFederacija.Forme
{
    public partial class SahistiForma : Form
    {
        Pocetna pocetna;
        public SahistiForma(Pocetna p)
        {
            InitializeComponent();
            p.Hide();
            pocetna = p;
        }

        private void SahistiForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            pocetna.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajSahistuForma dhf = new DodajSahistuForma(this);
            dhf.Show();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {;
            SahistaPregled sahista = new SahistaPregled();
            if (listViewSahisti.SelectedItems.Count == 1)
            {
                int idSahiste = Int32.Parse(listViewSahisti.SelectedItems[0].SubItems[0].Text);
                IzmeniSahistuForma isf = new IzmeniSahistuForma(this,DTOManager.vratiSahistu(idSahiste));
                isf.Show();
            }
            else if (listViewSahisti.SelectedItems.Count > 1)
                MessageBox.Show("Izaberite samo jednog sahistu cije podatke zelite promeniti!");
            else
                MessageBox.Show("Odaberite sahistu cije podatke zelite da izmenite!");
          
        }

        private void SahistiForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listViewSahisti.Items.Clear();
            List<SahistaPregled> data = DTOManager.vratiSveSahiste();

            foreach(SahistaPregled s in data)
            {
                if (s.GetType()==typeof(SahistaObicanPregled))
                {
                    ListViewItem item = new ListViewItem(new string[] { s.sahistaId.ToString(), s.Ime, s.Prezime, s.Grad, s.Ulica, s.Broj, s.RegBroj.ToString(), s.ZemljaPorekla, s.DatumRodjenja.ToString(), s.BrojPasosa.ToString(), s.DatumUclanjenja.ToString() });
                    listViewSahisti.Items.Add(item);
                }
                if (s.GetType() == typeof(SahistaKandidatPregled))
                {
                    SahistaKandidatPregled sk = (SahistaKandidatPregled)s;
                    ListViewItem item = new ListViewItem(new string[] { s.sahistaId.ToString(), s.Ime, s.Prezime, s.Grad, s.Ulica, s.Broj, s.RegBroj.ToString(), s.ZemljaPorekla, s.DatumRodjenja.ToString(), s.BrojPasosa.ToString(), s.DatumUclanjenja.ToString(),sk.BrojNedostalih.ToString() });
                    listViewSahisti.Items.Add(item);
                }
                if (s.GetType() == typeof(SahistaMajstorPregled))
                {
                    SahistaMajstorPregled sm = (SahistaMajstorPregled)s;
                    ListViewItem item = new ListViewItem(new string[] { s.sahistaId.ToString(), s.Ime, s.Prezime, s.Grad, s.Ulica, s.Broj, s.RegBroj.ToString(), s.ZemljaPorekla, s.DatumRodjenja.ToString(), s.BrojPasosa.ToString(), s.DatumUclanjenja.ToString(),"/", sm.Zvanje,sm.DatumSticanja.ToString() });
                    listViewSahisti.Items.Add(item);
                }

            }
            listViewSahisti.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewSahisti.SelectedItems.Count >= 1)
            {
                List<int> ids = new List<int>();
                for(int i = 0; i<listViewSahisti.SelectedItems.Count;i++)
                    ids.Add(Int32.Parse(listViewSahisti.SelectedItems[i].SubItems[0].Text));
                DTOManager.obrisiSahiste(ids);
                MessageBox.Show("Uspesno brisanje!");
                popuniPodacima();
            }
            else
            {

            }
        }
    }
}
