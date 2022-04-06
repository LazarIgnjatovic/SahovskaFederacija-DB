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
    public partial class IzmeniSahistuForma : Form
    {
        SahistiForma sahistiForma;
        SahistaPregled sahista;
        public IzmeniSahistuForma(SahistiForma sf,SahistaPregled s)
        {
            InitializeComponent();
            sf.Hide();
            sahistiForma = sf;
            sahista = s;
        }

        private void IzmeniSahistuForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            sahistiForma.Show();
            sahistiForma.popuniPodacima();
        }

        private void IzmeniSahistuForma_Load(object sender, EventArgs e)
        {
            lblIme.BackColor = Color.Transparent;
            lblPrezime.BackColor = Color.Transparent;
            lblGrad.BackColor = Color.Transparent;
            lblUlica.BackColor = Color.Transparent;
            lblBroj.BackColor = Color.Transparent;
            lblRegBroj.BackColor = Color.Transparent;
            lblZemljaPorekla.BackColor = Color.Transparent;
            lblDatumRodjenja.BackColor = Color.Transparent;
            lblBrojPasosa.BackColor = Color.Transparent;
            lblDatumUclanjenja.BackColor = Color.Transparent;
            lblZvanje.BackColor = Color.Transparent;
            lblDatumSticanja.BackColor = Color.Transparent;
            lblNedostajuPartije.BackColor = Color.Transparent;

            tbIme.Text = sahista.Ime;
            tbPrezime.Text = sahista.Prezime;
            tbGrad.Text = sahista.Grad;
            tbUlica.Text = sahista.Ulica;
            tbBroj.Text = sahista.Broj;
            tbRegBroj.Text = sahista.RegBroj.ToString();
            tbRegBroj.Enabled = false;
            dtpDatumRodjenja.Text = sahista.DatumRodjenja.ToString();
            tbBrojPasosa.Text = sahista.BrojPasosa.ToString();
            dtpDatumUclanjenja.Text = sahista.DatumUclanjenja.ToString();
            if(sahista.GetType() == typeof(SahistaObicanPregled))
            {
                tbZvanje.Enabled = false;
                dtpDatumSticanja.Enabled = false;
                tbNedostajuPartije.Enabled = false;
            }
            if(sahista.GetType() == typeof(SahistaKandidatPregled))
            {
                tbZvanje.Enabled = false;
                dtpDatumSticanja.Enabled = false;
                SahistaKandidatPregled skp = (SahistaKandidatPregled)sahista;
                tbNedostajuPartije.Text = skp.BrojNedostalih.ToString();
            }
            if(sahista.GetType() == typeof(SahistaMajstorPregled))
            {
                tbNedostajuPartije.Enabled = false;
                SahistaMajstorPregled smp = (SahistaMajstorPregled)sahista;
                tbZvanje.Text = smp.Zvanje;
                dtpDatumSticanja.Text = smp.DatumSticanja.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (sahista.GetType() == typeof(SahistaObicanPregled))
            {
                sahista.Ime = tbIme.Text;
                sahista.Prezime = tbPrezime.Text;
                sahista.Grad = tbGrad.Text;
                sahista.Ulica = tbUlica.Text;
                sahista.Broj = tbBroj.Text;
                sahista.RegBroj = Int32.Parse(tbRegBroj.Text);
                sahista.DatumRodjenja =dtpDatumRodjenja.Value;
                if (tbBrojPasosa.Text != "")
                    sahista.BrojPasosa = Int32.Parse(tbBrojPasosa.Text);
                else
                    sahista.BrojPasosa = null;
                if (dtpDatumUclanjenja.Text != "")
                    sahista.DatumUclanjenja = dtpDatumUclanjenja.Value;
                else
                    sahista.DatumUclanjenja = null;
                DTOManager.azurirajSahistu(sahista);
                MessageBox.Show("Uspesno ste azurirali sahistu!");
            }
            if (sahista.GetType() == typeof(SahistaKandidatPregled))
            {  
                SahistaKandidatPregled skp = (SahistaKandidatPregled)sahista;
                skp.Ime = tbIme.Text;
                skp.Prezime = tbPrezime.Text;
                skp.Grad = tbGrad.Text;
                skp.Ulica = tbUlica.Text;
                skp.Broj = tbBroj.Text;
                skp.RegBroj = Int32.Parse(tbRegBroj.Text);
                skp.DatumRodjenja = dtpDatumRodjenja.Value;
                if (tbBrojPasosa.Text != "")
                    skp.BrojPasosa = Int32.Parse(tbBrojPasosa.Text);
                else
                    skp.BrojPasosa = null;
                if (dtpDatumUclanjenja.Text != "")
                    skp.DatumUclanjenja = dtpDatumUclanjenja.Value;
                else
                    skp.DatumUclanjenja = null;
                skp.BrojNedostalih = Int32.Parse(tbNedostajuPartije.Text);
                DTOManager.azurirajSahistu(skp);
                MessageBox.Show("Uspesno ste azurirali sahistu!");
            }
            if (sahista.GetType() == typeof(SahistaMajstorPregled))
            {   
                SahistaMajstorPregled smp = (SahistaMajstorPregled)sahista;
                smp.Ime = tbIme.Text;
                smp.Prezime = tbPrezime.Text;
                smp.Grad = tbGrad.Text;
                smp.Ulica = tbUlica.Text;
                smp.Broj = tbBroj.Text;
                smp.RegBroj = Int32.Parse(tbRegBroj.Text);
                smp.DatumRodjenja = dtpDatumRodjenja.Value;
                if (tbBrojPasosa.Text != "")
                    smp.BrojPasosa = Int32.Parse(tbBrojPasosa.Text);
                else
                    smp.BrojPasosa = null;
                if (dtpDatumUclanjenja.Text != "")
                    smp.DatumUclanjenja = dtpDatumUclanjenja.Value;
                else
                    smp.DatumUclanjenja = null;
                smp.Zvanje = tbZvanje.Text;
                smp.DatumSticanja = dtpDatumSticanja.Value;
                DTOManager.azurirajSahistu(smp);
                MessageBox.Show("Uspesno ste azurirali sahistu!");
            }
        }
    }
}
