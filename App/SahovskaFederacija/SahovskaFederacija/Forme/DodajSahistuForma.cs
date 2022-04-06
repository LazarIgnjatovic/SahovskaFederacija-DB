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
    public partial class DodajSahistuForma : Form
    {
        SahistiForma sahistiForma;
        public DodajSahistuForma(SahistiForma sf)
        {
            InitializeComponent();
            sf.Hide();
            sahistiForma = sf;
        }

        private void DodajSahistuForma_Load(object sender, EventArgs e)
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
        }

        private void DodajSahistuForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            sahistiForma.Show();
            sahistiForma.popuniPodacima();
        }

        private void lblIme_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbNedostajuPartije.Text != "" && tbZvanje.Text != "")
                MessageBox.Show("Ne mozete uneti partije koje nedostaju i zvanje!");
            if (tbNedostajuPartije.Text != "" && dtpDatumSticanja.Text != "")
                MessageBox.Show("Ne mozete uneti partije koje nedostaju i datum sticanja zvanja!");
            if (tbZvanje.Text != "" && dtpDatumSticanja.Text == "")
                MessageBox.Show("Ne mozete da unesete zvanje bez datuma sticanja zvanja!");
            if (tbZvanje.Text == "" && dtpDatumSticanja.Text != "")
                MessageBox.Show("Ne mozete da unesete datum sticanja zvanja kad zvanje nije uneseno!");
            else
            {
                if (tbNedostajuPartije.Text != "")
                {
                    SahistaKandidatPregled skp = new SahistaKandidatPregled();
                    if (tbIme.Text.Length == 0 || tbPrezime.Text.Length == 0 || tbNedostajuPartije.Text.Length == 0)
                    {
                        MessageBox.Show("Morate uneti ime, prezime i broj partija koje sahisti nedostaju za zvanje!");
                        return;
                    }
                    else
                    {
                        skp.Ime = tbIme.Text;
                        skp.Prezime = tbPrezime.Text;
                        skp.Grad = tbGrad.Text;
                        skp.Ulica = tbUlica.Text;
                        skp.Broj = tbBroj.Text;
                        if (tbRegBroj.Text != "")
                            skp.RegBroj = Int32.Parse(tbRegBroj.Text);
                        else
                            MessageBox.Show("Morate uneti registracioni broj!");
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
                        DTOManager.dodajSahistu(skp);
                        MessageBox.Show("Sahista uspesno dodat!");
                    }
                }
                else if (tbZvanje.Text != "" && dtpDatumSticanja.Text != "")
                {
                    SahistaMajstorPregled smp = new SahistaMajstorPregled();
                    if (tbIme.Text.Length == 0 || tbPrezime.Text.Length == 0 || tbZvanje.Text.Length == 0 || dtpDatumSticanja.Text.Length == 0)
                    {
                        MessageBox.Show("Morate uneti ime, prezime, zvanje i datum sticanja zvanja!");
                        return;
                    }
                    else
                    {
                        smp.Ime = tbIme.Text;
                        smp.Prezime = tbPrezime.Text;
                        smp.Grad = tbGrad.Text;
                        smp.Ulica = tbUlica.Text;
                        smp.Broj = tbBroj.Text;
                        if (tbRegBroj.Text != "")
                            smp.RegBroj = Int32.Parse(tbRegBroj.Text);
                        else
                            MessageBox.Show("Morate uneti registracioni broj!");
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
                        DTOManager.dodajSahistu(smp);
                        MessageBox.Show("Sahista uspesno dodat!");
                    }
                }
                else
                {
                    SahistaObicanPregled sahista = new SahistaObicanPregled();
                    if (tbIme.Text.Length == 0 || tbPrezime.Text.Length == 0)
                    {
                        MessageBox.Show("Morate uneti ime i prezime!");
                        return;
                    }

                    else
                    {
                        sahista.Ime = tbIme.Text;
                        sahista.Prezime = tbPrezime.Text;
                        sahista.Grad = tbGrad.Text;
                        sahista.Ulica = tbUlica.Text;
                        sahista.Broj = tbBroj.Text;
                        if (tbRegBroj.Text != "")
                            sahista.RegBroj = Int32.Parse(tbRegBroj.Text);
                        else
                            MessageBox.Show("Morate uneti registracioni broj!");
                        sahista.DatumRodjenja = dtpDatumRodjenja.Value;
                        if (tbBrojPasosa.Text != "")
                            sahista.BrojPasosa = Int32.Parse(tbBrojPasosa.Text);
                        else
                            sahista.BrojPasosa = null;
                        if (dtpDatumUclanjenja.Text != "")
                            sahista.DatumUclanjenja = dtpDatumUclanjenja.Value;
                        else
                            sahista.DatumUclanjenja = null;
                        DTOManager.dodajSahistu(sahista);
                        MessageBox.Show("Sahista uspesno dodat!");
                    }
                }
            }
        }
    }
}
