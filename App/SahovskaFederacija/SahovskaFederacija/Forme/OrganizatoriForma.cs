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
    public partial class OrganizatoriForma : Form
    {
        Form pocetna;
        public OrganizatoriForma(Form p)
        {
            InitializeComponent();
            p.Hide();
            pocetna = p;
        }

        private void OrganizatoriForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            pocetna.Show();
        }

        private void OrganizatoriForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listViewOrganizatori.Items.Clear();
            List<OrganizatorPregled> data = DTOManager.vratiOrganizatore();

            foreach (OrganizatorPregled o in data)
            {
                ListViewItem item = new ListViewItem(new string[] { o.organizatorId.ToString(), o.Ime, o.Prezime, o.Grad, o.Ulica, o.Broj, o.JMBG });
                listViewOrganizatori.Items.Add(item);
            }
            listViewOrganizatori.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewOrganizatori.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite jednog organizatora kog zelite da obrisete!");
                return;
            }
            int id = Int32.Parse(listViewOrganizatori.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete organizatora: " + listViewOrganizatori.SelectedItems[0].SubItems[1].Text + " " + listViewOrganizatori.SelectedItems[0].SubItems[2].Text + "?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiOrganizatora(id);
                MessageBox.Show("Brisanje organizatora je uspesno obavljeno!");
                this.popuniPodacima();
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            DodajOrganizatoraForma form = new DodajOrganizatoraForma(this);
            form.Show();

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listViewOrganizatori.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite jednog organizatora cije podatke zelite da izmenite!");
                return;
            }
            OrganizatorPregled o = new OrganizatorPregled(Int32.Parse(listViewOrganizatori.SelectedItems[0].SubItems[0].Text),
                listViewOrganizatori.SelectedItems[0].SubItems[1].Text,
                listViewOrganizatori.SelectedItems[0].SubItems[2].Text,
                listViewOrganizatori.SelectedItems[0].SubItems[3].Text,
                listViewOrganizatori.SelectedItems[0].SubItems[4].Text,
                listViewOrganizatori.SelectedItems[0].SubItems[5].Text,
                listViewOrganizatori.SelectedItems[0].SubItems[6].Text);
            IzmeniOrganizatoraForma f = new IzmeniOrganizatoraForma(this, o);
            f.Show();
        }

        private void OrganizatoriForma_Activated(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
