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
    public partial class DodajOrganizatoraTurniraForma : Form
    {
        public DodajOrganizatoraTurniraForma()
        {
            InitializeComponent();
        }
        Form pocetna;
        int idTur;
        public DodajOrganizatoraTurniraForma(Form p, int id)
        {
            pocetna = p;
            idTur = id;
            pocetna.Hide();
            InitializeComponent();
        }
        private void DodajOrganizatoraTurniraForma_Load(object sender, EventArgs e)
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

        private void DodajOrganizatoraTurniraForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            pocetna.Show();
        }

        private void DodajOrganizatoraTurniraForma_Activated(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (listViewOrganizatori.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite jednog organizatora kog zelite da dodate!");
                return;
            }
            int idOrg = Int32.Parse(listViewOrganizatori.SelectedItems[0].SubItems[0].Text);
            DTOManager.dodajOrganizatoraTurnira(idTur, idOrg);
        }
    }
}
