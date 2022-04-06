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
    public partial class PartijeTurniraForm : Form
    {
        public PartijeTurniraForm()
        {
            InitializeComponent();
        }
        Form pocetna;
        int idTur;
        public PartijeTurniraForm(Form p, int id)
        {
            pocetna = p;
            idTur = id;
            pocetna.Hide();
            InitializeComponent();
        }

        private void PartijeTurniraForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            List<PartijaPregled> data = DTOManager.vratiPartijeTurnira(idTur);
        }
        private void popuniPodacima()
        {
            listViewPartije.Items.Clear();
            List<PartijaPregled> data = DTOManager.vratiPartijeTurnira(idTur);
            foreach (PartijaPregled o in data)
            {
                ListViewItem item = new ListViewItem(new string[] { o.partijaId.ToString(), o.Datum.ToString("dddd, dd MMMM yyyy"), o.Vreme.ToString("hh:mm tt"), o.Trajanje.ToString(), o.Ishod, o.BeliSahista, o.CrniSahista });
                listViewPartije.Items.Add(item);
            }
            listViewPartije.Refresh();
        }

        private void PartijeTurniraForm_Activated(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void PartijeTurniraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pocetna.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajPartijuTurnira p = new DodajPartijuTurnira(this, idTur);
            p.Show();
        }

        private void btnPotezi_Click(object sender, EventArgs e)
        {
            if (listViewPartije.SelectedItems.Count == 1)
            {
                int idPartije = Int32.Parse(listViewPartije.SelectedItems[0].SubItems[0].Text);
                PoteziPartijeForma ppf = new PoteziPartijeForma(this, idPartije);
                ppf.Show();
            }
            else
                MessageBox.Show("Izaberite jednu partiju cije poteze zelite videti!");
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listViewPartije.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite jednu partiju za izmenu!");
                return;
            }
            IzmeniPartijeTurniraForma ip = new IzmeniPartijeTurniraForma(this, Int32.Parse(listViewPartije.SelectedItems[0].SubItems[0].Text), idTur);
            ip.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewPartije.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite jednu partiju koju zelite da obrisete!");
                return;
            }
            int id = Int32.Parse(listViewPartije.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete partiju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPartiju(id);
                this.popuniPodacima();
            }
        }
    }
}
