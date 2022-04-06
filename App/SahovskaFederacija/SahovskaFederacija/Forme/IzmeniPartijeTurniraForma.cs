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
    public partial class IzmeniPartijeTurniraForma : Form
    {
        public IzmeniPartijeTurniraForma()
        {
            InitializeComponent();
        }
        Form pocetna;
        int idPartije;
        int idTur;
        public IzmeniPartijeTurniraForma(Form p, int idPar, int idt)
        {
            idTur = idt;
            pocetna = p;
            idPartije = idPar;
            p.Hide();
            InitializeComponent();
        }

        private void IzmeniPartijeTurniraForma_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            azurirajOpcije();
            azurirajPodatke(); 
        }
        private void azurirajPodatke()
        {
            PartijaPregled partija = DTOManager.vratiPartiju(idPartije);
            string sudija = DTOManager.vratiSudijuPartije(idPartije);
            dtDatum.Value = partija.Datum;
            dtVreme.Value = partija.Vreme;
            numTrajanje.Value = (decimal)partija.Trajanje;
            tbIshod.Text = partija.Ishod;
            for(int i =0;i<cbBeli.Items.Count;i++)
            {
                if ((cbBeli.Items[i].ToString().Split(' '))[0] == partija.BeliSahista)
                    cbBeli.SelectedItem = cbBeli.Items[i];
            }
            for (int i = 0; i < cbCrni.Items.Count; i++)
            {
                if ((cbCrni.Items[i].ToString().Split(' '))[0] == partija.CrniSahista)
                    cbCrni.SelectedItem = cbCrni.Items[i];
            }
            for (int i = 0; i < cbSudija.Items.Count; i++)
            {
                string su= cbSudija.Items[i].ToString().Split(' ')[2] + cbSudija.Items[i].ToString().Split(' ')[3];
                if ( su == sudija)
                    cbSudija.SelectedItem = cbSudija.Items[i];
            }
        }
        private void azurirajOpcije()
        {
            List<SahistaPregled> sahisti = DTOManager.vratiSveSahiste();
            foreach (SahistaPregled s in sahisti)
            {
                cbBeli.Items.Add(s.sahistaId + " " + s.Ime + " " + s.Prezime);
                cbCrni.Items.Add(s.sahistaId + " " + s.Ime + " " + s.Prezime);
            }
            List<SahistaMajstorPregled> majstori = DTOManager.vratiMajstore();
            List<OrganizatorPregled> organizatori = DTOManager.vratiOrganizatoreTurnira(idTur);
            foreach (SahistaMajstorPregled s in majstori)
            {
                cbSudija.Items.Add("Majstor " + s.sahistaId + " " + s.Ime + " " + s.Prezime);
            }
            foreach (OrganizatorPregled s in organizatori)
            {
                cbSudija.Items.Add("Organizator " + s.organizatorId + " " + s.Ime + " " + s.Prezime);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PartijaPregled part = new PartijaPregled(idPartije, dtDatum.Value, dtVreme.Value, (int)numTrajanje.Value, tbIshod.Text, "", "");
            int idBeli = Int32.Parse(cbBeli.Text.Split(' ')[0]);
            int idCrni = Int32.Parse(cbCrni.Text.Split(' ')[0]);
            if (idBeli == idCrni)
            {
                MessageBox.Show("Crni i beli sahista moraju biti razliciti!");
                return;
            }
            bool isMajstor = false;
            if (cbSudija.Text.Split(' ')[0] == "Majstor")
                isMajstor = true;
            DTOManager.izmeniPartijuTurnira(idTur, part, idBeli, idCrni, isMajstor, Int32.Parse(cbSudija.Text.Split(' ')[1]));
        }

        private void IzmeniPartijeTurniraForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            pocetna.Show();
        }
    }
}
