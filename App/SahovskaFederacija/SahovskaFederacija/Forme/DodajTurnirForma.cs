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
    public partial class DodajTurnirForma : Form
    {
        public DodajTurnirForma()
        {
            InitializeComponent();
        }
        Form pocetna;
        public DodajTurnirForma(Form p)
        {
            pocetna = p;
            pocetna.Hide();
            InitializeComponent();
        }

        private void updateFields()
        {
            if(cbBrziopotezni.Checked)
            {
                tbVreme.Enabled = true;
            }
            else
            {
                tbVreme.Enabled = false;
                tbVreme.Text = "";
            }

            if(rbHumanitarni.Checked)
            {
                tbSuma.Enabled = true;
                tbPrimalac.Enabled = true;
            }
            else
            {
                tbSuma.Enabled = false;
                tbSuma.Text = "";
                tbPrimalac.Enabled = false;
                tbPrimalac.Text = "";
            }
            if (rbTakmicarski.Checked)
            {
                tbZnacaj.Enabled = true;
            }
            else
            {
                tbZnacaj.Enabled = false;
                tbZnacaj.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateFields();
        }

        private void DodajTurnirForma_Load(object sender, EventArgs e)
        {
            lblDKraj.BackColor = Color.Transparent;
            lblDPoc.BackColor = Color.Transparent;
            lblGodina.BackColor = Color.Transparent;
            lblGrad.BackColor = Color.Transparent;
            lblNaziv.BackColor = Color.Transparent;
            lblPrimalac.BackColor = Color.Transparent;
            lblSuma.BackColor = Color.Transparent;
            lblVreme.BackColor = Color.Transparent;
            lblZemlja.BackColor = Color.Transparent;
            lblZnacaj.BackColor = Color.Transparent;

        }

        private void DodajTurnirForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            pocetna.Show();
        }

        private void rbHumanitarni_CheckedChanged(object sender, EventArgs e)
        {
            updateFields();
        }

        private void rbPromotivni_CheckedChanged(object sender, EventArgs e)
        {
            updateFields();
        }

        private void rbTakmicarski_CheckedChanged(object sender, EventArgs e)
        {
            updateFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurnirPregled t=new TurnirHumanitarniBPPregled();
            if (cbBrziopotezni.Checked)
            {
                if (rbHumanitarni.Checked)
                    t = new TurnirHumanitarniBPPregled(0, tbNaziv.Text, tbZemlja.Text, tbGrad.Text, Int32.Parse(tbGodina.Text), dateTimePicker1.Value, dateTimePicker2.Value, Int32.Parse(tbSuma.Text), tbPrimalac.Text, Int32.Parse(tbVreme.Text));
                if (rbPromotivni.Checked)
                    t = new TurnirPromotivniBPPregled(0, tbNaziv.Text, tbZemlja.Text, tbGrad.Text, Int32.Parse(tbGodina.Text), dateTimePicker1.Value, dateTimePicker2.Value, Int32.Parse(tbVreme.Text));
                if (rbTakmicarski.Checked)
                    t = new TurnirTakmicarskiBPPregled(0, tbNaziv.Text, tbZemlja.Text, tbGrad.Text, Int32.Parse(tbGodina.Text), dateTimePicker1.Value, dateTimePicker2.Value, Int32.Parse(tbVreme.Text), tbZnacaj.Text);
                
            }
            else
            {

                if (rbHumanitarni.Checked)
                    t = new TurnirHumanitarniNPregled(0, tbNaziv.Text, tbZemlja.Text, tbGrad.Text, Int32.Parse(tbGodina.Text), dateTimePicker1.Value, dateTimePicker2.Value, Int32.Parse(tbSuma.Text), tbPrimalac.Text);
                if (rbPromotivni.Checked)
                    t = new TurnirPromotivniNPregled(0, tbNaziv.Text, tbZemlja.Text, tbGrad.Text, Int32.Parse(tbGodina.Text), dateTimePicker1.Value, dateTimePicker2.Value);
                if (rbTakmicarski.Checked)
                    t = new TurnirTakmicarskiNPregled(0, tbNaziv.Text, tbZemlja.Text, tbGrad.Text, Int32.Parse(tbGodina.Text), dateTimePicker1.Value, dateTimePicker2.Value, tbZnacaj.Text);
            }
            DTOManager.dodajTurnir(t);
            MessageBox.Show("Turnir uspesno dodat!");
        }
    }
}
