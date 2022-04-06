using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SahovskaFederacija.Forme;

namespace SahovskaFederacija
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {

        }

        private void Test_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                SahovskaFederacija.Entiteti.Sahista p = s.Load<SahovskaFederacija.Entiteti.Sahista>(4);

                MessageBox.Show(p.Ime+p.Prezime+ " zvanje:"+p.ZemljaPorekla);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnSahisti_Click(object sender, EventArgs e)
        {
            SahistiForma sf = new SahistiForma(this);
            //this.Hide();
            sf.Show();
        }

        private void btnTurniri_Click(object sender, EventArgs e)
        {
            TurniriForma tf = new TurniriForma(this);
            this.Hide();
            tf.Show();
        }

        private void btnOrganizatori_Click(object sender, EventArgs e)
        {
            OrganizatoriForma of = new OrganizatoriForma(this);
            this.Hide();
            of.Show();
        }
    }
}
