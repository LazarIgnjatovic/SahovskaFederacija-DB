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
    public partial class SponzoriForma : Form
    {
        int turnirId;
        TurniriForma turnirForma;
        public SponzoriForma(TurniriForma tf,int tid)
        {
            InitializeComponent();
            tf.Hide();
            turnirForma = tf;
            turnirId = tid;
        }

        private void SponzoriForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listViewSponzori.Items.Clear();
            List<SponzorPregled> data = DTOManager.vratiSponzoreTurnira(turnirId);
            ListViewItem item;
            foreach (SponzorPregled sp in data)
            {
                item = new ListViewItem(new string[] { sp.sponozrId.ToString(), sp.Naziv });
                listViewSponzori.Items.Add(item);
            }
            listViewSponzori.Refresh();
        }

        private void btnDodajSponzora_Click(object sender, EventArgs e)
        {
            DodajSponzoraForma dsf = new DodajSponzoraForma(this,turnirId);
            dsf.Show();
        }

        private void btnIzmeniSponzora_Click(object sender, EventArgs e)
        {
            if (listViewSponzori.SelectedItems.Count == 1)
            {
                int idSponzora = Int32.Parse(listViewSponzori.SelectedItems[0].SubItems[0].Text);
                IzmeniSponzoraForma isf = new IzmeniSponzoraForma(this, DTOManager.vratiSponzora(idSponzora));
                isf.Show();
            }
            else
                MessageBox.Show("Izaberite sponzora kojeg zelite izmeniti!");
        }

        private void btnObrisiSponzora_Click(object sender, EventArgs e)
        {
            if (listViewSponzori.SelectedItems.Count == 1)
            {
                int idSponzora = Int32.Parse(listViewSponzori.SelectedItems[0].SubItems[0].Text);
                DTOManager.obrisiSponzora(DTOManager.vratiSponzora(idSponzora));
                MessageBox.Show("Uspesno ste obrisali sponzora!");
                popuniPodacima();
            }
            else
                MessageBox.Show("Izaberite sponzora kojeg zelite obrisati!");
        }

        private void SponzoriForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            turnirForma.Show();
        }
    }
}
