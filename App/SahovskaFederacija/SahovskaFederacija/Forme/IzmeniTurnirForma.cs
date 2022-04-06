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
    public partial class IzmeniTurnirForma : Form
    {
        public IzmeniTurnirForma()
        {
            InitializeComponent();
        }
        Form pocetna;
        int id;
        public IzmeniTurnirForma(Form p,TurnirPregled tp)
        {
            pocetna = p;
            pocetna.Hide();
            InitializeComponent();

            id = tp.turnirId;
            tbNaziv.Text = tp.Naziv;
            tbZemlja.Text = tp.Zemlja;
            tbGrad.Text = tp.Grad;
            tbGodina.Value = (decimal)tp.Godina;
            dateTimePicker1.Value = (DateTime)tp.Pocetak;
            dateTimePicker2.Value = (DateTime)tp.Kraj;

            if(tp.GetType()==typeof(TurnirHumanitarniBPPregled))
            {
                cbBrziopotezni.Checked = true;
                rbHumanitarni.Checked = true;
                rbPromotivni.Checked = false;
                rbTakmicarski.Checked = false;
                tbVreme.Value = ((TurnirHumanitarniBPPregled)tp).Vreme;
                tbSuma.Value = ((TurnirHumanitarniBPPregled)tp).Suma;
                tbPrimalac.Text = ((TurnirHumanitarniBPPregled)tp).Primalac;
            }
            if (tp.GetType() == typeof(TurnirPromotivniBPPregled))
            {
                cbBrziopotezni.Checked = true;
                rbHumanitarni.Checked = true;
                rbPromotivni.Checked = false;
                rbTakmicarski.Checked = false;
                tbVreme.Value = ((TurnirPromotivniBPPregled)tp).Vreme;
            }
            if (tp.GetType() == typeof(TurnirTakmicarskiBPPregled))
            {
                cbBrziopotezni.Checked = true;
                rbHumanitarni.Checked = true;
                rbPromotivni.Checked = false;
                rbTakmicarski.Checked = false;
                tbVreme.Value = ((TurnirTakmicarskiBPPregled)tp).Vreme;
                tbZnacaj.Text = ((TurnirTakmicarskiBPPregled)tp).Znacaj;
            }

            if (tp.GetType() == typeof(TurnirHumanitarniNPregled))
            {
                cbBrziopotezni.Checked = true;
                rbHumanitarni.Checked = true;
                rbPromotivni.Checked = false;
                rbTakmicarski.Checked = false;
                tbSuma.Value = ((TurnirHumanitarniNPregled)tp).Suma;
                tbPrimalac.Text = ((TurnirHumanitarniNPregled)tp).Primalac;
            }
            if (tp.GetType() == typeof(TurnirPromotivniNPregled))
            {
                cbBrziopotezni.Checked = true;
                rbHumanitarni.Checked = true;
                rbPromotivni.Checked = false;
                rbTakmicarski.Checked = false;

            }
            if (tp.GetType() == typeof(TurnirTakmicarskiNPregled))
            {
                cbBrziopotezni.Checked = true;
                rbHumanitarni.Checked = true;
                rbPromotivni.Checked = false;
                rbTakmicarski.Checked = false;
                tbZnacaj.Text = ((TurnirTakmicarskiNPregled)tp).Znacaj;
            }
            
        }
        private void updateFields()
        {
            if (cbBrziopotezni.Checked)
            {
                tbVreme.Enabled = true;
            }
            else
            {
                tbVreme.Enabled = false;
            }

            if (rbHumanitarni.Checked)
            {
                tbSuma.Enabled = true;
                tbPrimalac.Enabled = true;
            }
            else
            {
                tbSuma.Enabled = false;
                tbPrimalac.Enabled = false;
            }
            if (rbTakmicarski.Checked)
            {
                tbZnacaj.Enabled = true;
            }
            else
            {
                tbZnacaj.Enabled = false;
            }
        }

        private void IzmeniTurnirForma_Load(object sender, EventArgs e)
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
            updateFields();
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

        private void cbBrziopotezni_CheckedChanged(object sender, EventArgs e)
        {
            updateFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurnirPregled t = new TurnirHumanitarniBPPregled();
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
            t.turnirId = id;
            DTOManager.izmeniTurnir(t);
            MessageBox.Show("Turnir uspesno izmenjen");
        }

        private void IzmeniTurnirForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            pocetna.Show();
        }
    }
}
