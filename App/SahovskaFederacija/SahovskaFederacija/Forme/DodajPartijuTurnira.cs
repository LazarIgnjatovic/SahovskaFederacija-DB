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
    public partial class DodajPartijuTurnira : Form
    {
        public DodajPartijuTurnira()
        {
            InitializeComponent();
        }
        Form pocetna;
        int idTur;
        public DodajPartijuTurnira(Form p, int id)
        {
            pocetna = p;
            idTur = id;
            pocetna.Hide();
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DodajPartijuTurnira_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            azurirajOpcije();
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

        private void DodajPartijuTurnira_FormClosing(object sender, FormClosingEventArgs e)
        {
            pocetna.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PartijaPregled part = new PartijaPregled(0, dtDatum.Value, dtVreme.Value, (int)numTrajanje.Value, tbIshod.Text, "", "");
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
            DTOManager.dodajPartijuTurnira(idTur, part, idBeli, idCrni, isMajstor, Int32.Parse(cbSudija.Text.Split(' ')[1]));
        }
    }
}
