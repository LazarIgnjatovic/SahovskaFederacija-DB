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
    public partial class OrganizatoriTurniraForma : Form
    {
        public OrganizatoriTurniraForma()
        {
            InitializeComponent();
        }
        Form pocetna;
        int id;

        public OrganizatoriTurniraForma(Form f, int i)
        {
            pocetna = f;
            id = i;
            pocetna.Hide();
            InitializeComponent();
        }

        private void OrganizatoriTurniraForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {
            listViewOrganizatori.Items.Clear();
            List<OrganizatorPregled> data = DTOManager.vratiOrganizatoreTurnira(id);

            foreach (OrganizatorPregled o in data)
            {
                ListViewItem item = new ListViewItem(new string[] { o.organizatorId.ToString(), o.Ime, o.Prezime, o.Grad, o.Ulica, o.Broj, o.JMBG });
                listViewOrganizatori.Items.Add(item);
            }
            listViewOrganizatori.Refresh();
        }

        private void OrganizatoriTurniraForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            pocetna.Show();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            OrganizatoriForma f = new OrganizatoriForma(this);
            f.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewOrganizatori.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite jednog organizatora kog zelite da obrisete!");
                return;
            }
            int idOrg = Int32.Parse(listViewOrganizatori.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete organizatora: " + listViewOrganizatori.SelectedItems[0].SubItems[1].Text + " " + listViewOrganizatori.SelectedItems[0].SubItems[2].Text + "?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiOrganizatoraTurnira(id, idOrg);
                MessageBox.Show("Brisanje organizatora je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajOrganizatoraTurniraForma f = new DodajOrganizatoraTurniraForma(this, id);
            f.Show();
        }

        private void OrganizatoriTurniraForma_Activated(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void listViewOrganizatori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
