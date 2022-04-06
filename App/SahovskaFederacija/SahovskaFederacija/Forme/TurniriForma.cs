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
    public partial class TurniriForma : Form
    {
        Pocetna pocetna;
        public TurniriForma(Pocetna p)
        {
            InitializeComponent();
            p.Hide();
            pocetna = p;
        }

        private void TurniriForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            pocetna.Show();
        }

        private void listViewSahisti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewTurniri.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite jedan turnir kog zelite da obrisete!");
                return;
            }
            int id = Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete turnir: " + listViewTurniri.SelectedItems[0].SubItems[1].Text + "?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiTurnir(id);
                MessageBox.Show("Brisanje turnira je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

            if (listViewTurniri.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite jedan turnir koji zelite da izmenite!");
                return;
            }
            string tip = listViewTurniri.SelectedItems[0].SubItems[7].Text;
            if (tip == "Humanitaran Brzopotezni")
            {
                TurnirPregled o = new TurnirHumanitarniBPPregled(Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[0].Text),
                listViewTurniri.SelectedItems[0].SubItems[1].Text,
                listViewTurniri.SelectedItems[0].SubItems[2].Text,
                listViewTurniri.SelectedItems[0].SubItems[3].Text,
                Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[4].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[5].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[6].Text),
                Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[10].Text),
                listViewTurniri.SelectedItems[0].SubItems[11].Text,
                Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[8].Text));

                IzmeniTurnirForma iz = new IzmeniTurnirForma(this, o);
                iz.Show();

            }
            if (tip == "Humanitaran Normalni")
            {
                TurnirPregled o = new TurnirHumanitarniNPregled(Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[0].Text),
                listViewTurniri.SelectedItems[0].SubItems[1].Text,
                listViewTurniri.SelectedItems[0].SubItems[2].Text,
                listViewTurniri.SelectedItems[0].SubItems[3].Text,
                Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[4].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[5].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[6].Text),
                Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[10].Text),
                listViewTurniri.SelectedItems[0].SubItems[11].Text);
                IzmeniTurnirForma iz = new IzmeniTurnirForma(this, o);
                iz.Show();
            }
            if (tip == "Promotivan Brzopotezni")
            {
                TurnirPregled o = new TurnirPromotivniBPPregled(Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[0].Text),
                listViewTurniri.SelectedItems[0].SubItems[1].Text,
                listViewTurniri.SelectedItems[0].SubItems[2].Text,
                listViewTurniri.SelectedItems[0].SubItems[3].Text,
                Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[4].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[5].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[6].Text),
                Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[8].Text));
                IzmeniTurnirForma iz = new IzmeniTurnirForma(this, o);
                iz.Show();
            }
            if (tip == "Promotivan Normalni")
            {
                TurnirPregled o = new TurnirPromotivniNPregled(Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[0].Text),
                listViewTurniri.SelectedItems[0].SubItems[1].Text,
                listViewTurniri.SelectedItems[0].SubItems[2].Text,
                listViewTurniri.SelectedItems[0].SubItems[3].Text,
                Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[4].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[5].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[6].Text));
                IzmeniTurnirForma iz = new IzmeniTurnirForma(this, o);
                iz.Show();
            }
            if (tip == "Takmicarski Brzopotezni")
            {
                TurnirPregled o = new TurnirTakmicarskiBPPregled(Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[0].Text),
                listViewTurniri.SelectedItems[0].SubItems[1].Text,
                listViewTurniri.SelectedItems[0].SubItems[2].Text,
                listViewTurniri.SelectedItems[0].SubItems[3].Text,
                Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[4].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[5].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[6].Text),
                Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[8].Text),
                listViewTurniri.SelectedItems[0].SubItems[9].Text);
                IzmeniTurnirForma iz = new IzmeniTurnirForma(this, o);
                iz.Show();
            }
            if (tip == "Takmicarski Normalni")
            {
                TurnirPregled o = new TurnirTakmicarskiNPregled(Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[0].Text),
                listViewTurniri.SelectedItems[0].SubItems[1].Text,
                listViewTurniri.SelectedItems[0].SubItems[2].Text,
                listViewTurniri.SelectedItems[0].SubItems[3].Text,
                Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[4].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[5].Text),
                DateTime.Parse(listViewTurniri.SelectedItems[0].SubItems[6].Text),
                listViewTurniri.SelectedItems[0].SubItems[9].Text);
                IzmeniTurnirForma iz = new IzmeniTurnirForma(this, o);
                iz.Show();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajTurnirForma f = new DodajTurnirForma(this);
            f.Show();
        }

        private void TurniriForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listViewTurniri.Items.Clear();
            List<TurnirPregled> data = DTOManager.vratiSveTurnire();

            foreach (TurnirPregled s in data)
            {
                if (s.GetType() == typeof(TurnirHumanitarniBPPregled))
                {
                    TurnirHumanitarniBPPregled thbp = (TurnirHumanitarniBPPregled)s;
                    ListViewItem item = new ListViewItem(new string[] { s.turnirId.ToString(), s.Naziv, s.Zemlja, s.Grad, s.Godina.ToString(), s.Pocetak.ToString(), s.Kraj.ToString(), "Humanitaran Brzopotezni", thbp.Vreme.ToString(), "/", thbp.Suma.ToString(),thbp.Primalac });
                    listViewTurniri.Items.Add(item);
                }
                if (s.GetType() == typeof(TurnirHumanitarniNPregled))
                {
                    TurnirHumanitarniNPregled t = (TurnirHumanitarniNPregled)s;
                    ListViewItem item = new ListViewItem(new string[] { s.turnirId.ToString(), s.Naziv, s.Zemlja, s.Grad, s.Godina.ToString(), s.Pocetak.ToString(), s.Kraj.ToString(), "Humanitaran Normalni", "/", "/", t.Suma.ToString(), t.Primalac });
                    listViewTurniri.Items.Add(item);
                }
                if (s.GetType() == typeof(TurnirPromotivniBPPregled))
                {
                    TurnirPromotivniBPPregled t = (TurnirPromotivniBPPregled)s;
                    ListViewItem item = new ListViewItem(new string[] { s.turnirId.ToString(), s.Naziv, s.Zemlja, s.Grad, s.Godina.ToString(), s.Pocetak.ToString(), s.Kraj.ToString(), "Promotivan Brzopotezni", t.Vreme.ToString(), "/", "/", "/" });
                    listViewTurniri.Items.Add(item);
                }
                if (s.GetType() == typeof(TurnirPromotivniNPregled))
                {
                    TurnirPromotivniNPregled t = (TurnirPromotivniNPregled)s;
                    ListViewItem item = new ListViewItem(new string[] { s.turnirId.ToString(), s.Naziv, s.Zemlja, s.Grad, s.Godina.ToString(), s.Pocetak.ToString(), s.Kraj.ToString(), "Promotivan Normalni", "/", "/", "/", "/" });
                    listViewTurniri.Items.Add(item);
                }
                if (s.GetType() == typeof(TurnirTakmicarskiBPPregled))
                {
                    TurnirTakmicarskiBPPregled t = (TurnirTakmicarskiBPPregled)s;
                    ListViewItem item = new ListViewItem(new string[] { s.turnirId.ToString(), s.Naziv, s.Zemlja, s.Grad, s.Godina.ToString(), s.Pocetak.ToString(), s.Kraj.ToString(), "Takmicarski Brzopotezni", t.Vreme.ToString(), t.Znacaj, "/", "/" });
                    listViewTurniri.Items.Add(item);
                }
                if (s.GetType() == typeof(TurnirTakmicarskiNPregled))
                {
                    TurnirTakmicarskiNPregled t = (TurnirTakmicarskiNPregled)s;
                    ListViewItem item = new ListViewItem(new string[] { s.turnirId.ToString(), s.Naziv, s.Zemlja, s.Grad, s.Godina.ToString(), s.Pocetak.ToString(), s.Kraj.ToString(), "Takmicarski Normalni", "/", t.Znacaj, "/", "/" });
                    listViewTurniri.Items.Add(item);
                }

            }
            listViewTurniri.Refresh();
        }

        private void btnSponzori_Click(object sender, EventArgs e)
        {
            if (listViewTurniri.SelectedItems.Count == 1)
            {
                SponzoriForma sf = new SponzoriForma(this, Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[0].Text));
                sf.Show();
            }
            else
                MessageBox.Show("Izaberite turnir cije sponzore zelite videti!");
        }

        private void TurniriForma_Activated(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnPartije_Click(object sender, EventArgs e)
        {
            if (listViewTurniri.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite jedan turnir!");
                return;
            }
            int id = Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[0].Text);
            PartijeTurniraForm p = new PartijeTurniraForm(this, id);
            p.Show();
        }

        private void btnOrganizatori_Click(object sender, EventArgs e)
        {
            if (listViewTurniri.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite jedan turnir!");
                return;
            }
            int id = Int32.Parse(listViewTurniri.SelectedItems[0].SubItems[0].Text);
            OrganizatoriTurniraForma f = new OrganizatoriTurniraForma(this, id);
            f.Show();
        }
    }
}
