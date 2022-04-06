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
    public partial class PoteziPartijeForma : Form
    {
        PartijeTurniraForm partijeTurniraForma;
        int idPartije;
        public PoteziPartijeForma(PartijeTurniraForm ptf, int id)
        {
            InitializeComponent();
            ptf.Hide();
            partijeTurniraForma = ptf;
            idPartije = id;
        }
        private void PoteziPartijeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listViewPotezi.Items.Clear();
            List<PotezPregled> data = DTOManager.vratiPotezePartije(idPartije);
            ListViewItem item;
            foreach (PotezPregled pp in data)
            {
                item = new ListViewItem(new string[] { pp.potezId.ToString(), pp.Broj.ToString(), pp.Odigrano, pp.Vreme.ToString() });
                listViewPotezi.Items.Add(item);
            }
            listViewPotezi.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajPotezForma dpf = new DodajPotezForma(this, idPartije);
            dpf.Show();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listViewPotezi.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite potez koji zelite izmeniti!");
                return;
            }
            int idPoteza = Int32.Parse(listViewPotezi.SelectedItems[0].SubItems[0].Text);
            IzmeniPotezForma ipf = new IzmeniPotezForma(this, DTOManager.vratiPotez(idPoteza));
            ipf.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewPotezi.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite potez koji zelite izbrisati!");
                return;
            }
            int idPoteza = Int32.Parse(listViewPotezi.SelectedItems[0].SubItems[0].Text);
            DTOManager.obrisiPotez(idPoteza);
            MessageBox.Show("Uspesno izbrisan potez!");
            popuniPodacima();
        }

        private void PoteziPartijeForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            partijeTurniraForma.Show();
        }
    }
}
