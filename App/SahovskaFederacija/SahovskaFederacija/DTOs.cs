using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SahovskaFederacija.Entiteti;

namespace SahovskaFederacija
{
    #region SahistaPregled
    public class OsobaPregled
    {
        public OsobaPregled(int id, string ime, string prezime, string grad, string ulica, string broj)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Grad = grad;
            Ulica = ulica;
            Broj = broj;
        }
        public OsobaPregled() { }
        public virtual int Id { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Broj { get; set; }
    }
    public class SahistaPregled
    {
        public virtual int sahistaId { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Broj { get; set; }
        public virtual int RegBroj { get; set; }
        public virtual string ZemljaPorekla { get; set; }
        public virtual DateTime? DatumRodjenja { get; set; }
        public virtual int? BrojPasosa { get; set; }
        public virtual DateTime? DatumUclanjenja { get; set; }
        public SahistaPregled(int id, string ime, string prezime, string grad, string ulica, string broj, int rbr, string zp, DateTime? datumRodjenja, int? brPasosa, DateTime? datumUclanjenja)
        {
            sahistaId = id;
            Ime = ime;
            Prezime = prezime;
            Grad = grad;
            Ulica = ulica;
            Broj = broj;
            RegBroj = rbr;
            ZemljaPorekla = zp;
            DatumRodjenja = datumRodjenja;
            BrojPasosa = brPasosa;
            DatumUclanjenja = datumUclanjenja;
        }
        public SahistaPregled() { }
    }
    #endregion
    #region SahistaObicanPregled
    public class SahistaObicanPregled : SahistaPregled
    {
        public SahistaObicanPregled() { }
        public SahistaObicanPregled(int id, string ime, string prezime, string grad, string ulica, string broj, int rbr, string zp, DateTime? datumRodjenja, int? brPasosa, DateTime? datumUclanjenja)
            : base(id, ime, prezime, grad, ulica, broj, rbr, zp, datumRodjenja, brPasosa, datumUclanjenja)
        {

        }
    }
    #endregion
    #region SahistaKandidatPregled
    public class SahistaKandidatPregled : SahistaPregled
    {
        public virtual int BrojNedostalih { get; set; }
        public SahistaKandidatPregled() { }

        public SahistaKandidatPregled(int id, string ime, string prezime, string grad, string ulica, string broj, int rbr, string zp, DateTime? datumRodjenja, int? brPasosa, DateTime? datumUclanjenja,
            int brNedostalih)
            : base(id, ime, prezime, grad, ulica, broj, rbr, zp, datumRodjenja, brPasosa, datumUclanjenja)
        {
            BrojNedostalih = brNedostalih;
        }
    }
    #endregion
    #region SahistaMajstorPregled
    public class SahistaMajstorPregled : SahistaPregled
    {
        public virtual string Zvanje { get; set; }
        public virtual DateTime DatumSticanja { get; set; }
        public SahistaMajstorPregled() { }

        public SahistaMajstorPregled(int id, string ime, string prezime, string grad, string ulica, string broj, int rbr, string zp, DateTime? datumRodjenja, int? brPasosa, DateTime? datumUclanjenja,
            string zvanje, DateTime datumSticanja)
            : base(id, ime, prezime, grad, ulica, broj, rbr, zp, datumRodjenja, brPasosa, datumUclanjenja)
        {
            Zvanje = zvanje;
            DatumSticanja = datumSticanja;
        }
    }
    #endregion
    #region OrganizatorPregled
    public class OrganizatorPregled
    {
        public virtual int organizatorId { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Broj { get; set; }
        public virtual string JMBG { get; set; }
        public OrganizatorPregled() { }
        public OrganizatorPregled(int id, string ime, string prezime, string grad, string ulica, string broj, string jmbg)
        {
            organizatorId = id;
            Ime = ime;
            Prezime = prezime;
            Grad = grad;
            Ulica = ulica;
            Broj = broj;
            JMBG = jmbg;
        }

    }
    #endregion
    #region PartijaPregled
    public class PartijaPregled
    {
        public virtual int partijaId { get; protected set; }
        public virtual DateTime Datum { get; set; }
        public virtual DateTime Vreme { get; set; }
        public virtual int Trajanje { get; set; }
        public virtual string Ishod { get; set; }
        public virtual string BeliSahista { get; set; }
        public virtual string CrniSahista { get; set; }

        public PartijaPregled() { }
        public PartijaPregled(int id, DateTime datum, DateTime vreme, int trajanje, string ishod, string beli, string crni)
        {
            partijaId = id;
            Datum = datum;
            Vreme = vreme;
            Trajanje = trajanje;
            Ishod = ishod;
            BeliSahista = beli;
            CrniSahista = crni;
        }
    }

    #endregion
    #region PotezPregled
    public class PotezPregled
    {
        public virtual int potezId { get; protected set; }
        public virtual int Broj { get; set; }
        public virtual string Odigrano { get; set; }
        public virtual DateTime Vreme { get; set; }
        public PotezPregled() { }
        public PotezPregled(int id, int br, string odigrano, DateTime vreme)
        {
            potezId = id;
            Broj = br;
            Odigrano = odigrano;
            Vreme = vreme;
        }
    }

    #endregion
    #region SponzorPregled
    public class SponzorPregled
    {
        public virtual int sponozrId { get; protected set; }
        public virtual string Naziv { get; set; }

        public SponzorPregled() { }
        public SponzorPregled(int id, string naziv)
        {
            sponozrId = id;
            Naziv = naziv;
        }
    }

    #endregion
    #region SudijaPregled
    public class SudijaPregled
    {
        public SudijaPregled(int sudijaId, Osoba sudi)
        {
            this.sudijaId = sudijaId;
            Sudi = sudi;
        }
        public SudijaPregled() { }

        public virtual int sudijaId { get; protected set; }
        public virtual Osoba Sudi { get; set; }
    }
    #endregion
    #region TurniriPregled
    public abstract class TurnirPregled
    {
        protected TurnirPregled(int turnirId, string naziv, string zemlja, string grad, int? godina, DateTime? pocetak, DateTime? kraj)
        {
            this.turnirId = turnirId;
            Naziv = naziv;
            Zemlja = zemlja;
            Grad = grad;
            Godina = godina;
            Pocetak = pocetak;
            Kraj = kraj;
        }
        protected TurnirPregled() { }

        public virtual int turnirId { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Zemlja { get; set; }
        public virtual string Grad { get; set; }
        public virtual int? Godina { get; set; }
        public virtual DateTime? Pocetak { get; set; }
        public virtual DateTime? Kraj { get; set; }
        /*
        public virtual IList<Organizator> Organizatori { get; set; }
        public virtual IList<Partija> OdigranePartije { get; set; }
        public virtual IList<Sponzor> Sponzori { get; set; }
        */


    }

    public abstract class TurnirEgzibicioniPregled : TurnirPregled
    {
        public TurnirEgzibicioniPregled() { }
        public TurnirEgzibicioniPregled(int turnirId, string naziv, string zemlja, string grad, int? godina, DateTime? pocetak, DateTime? kraj)
            : base(turnirId, naziv, zemlja, grad, godina, pocetak, kraj)
        { }
    }

    public class TurnirHumanitarniBPPregled : TurnirEgzibicioniPregled
    {
        public TurnirHumanitarniBPPregled() { }
        public TurnirHumanitarniBPPregled(int turnirId, string naziv, string zemlja, string grad, int? godina, DateTime? pocetak, DateTime? kraj, int suma, string primalac, int vreme)
            : base(turnirId, naziv, zemlja, grad, godina, pocetak, kraj)
        {
            Suma = suma;
            Primalac = primalac;
            Vreme = vreme;
        }

        public virtual int Suma { get; set; }
        public virtual string Primalac { get; set; }
        public virtual int Vreme { get; set; }

    }
    public class TurnirHumanitarniNPregled : TurnirEgzibicioniPregled
    {
        public TurnirHumanitarniNPregled(int turnirId, string naziv, string zemlja, string grad, int? godina, DateTime? pocetak, DateTime? kraj, int suma, string primalac)
            : base(turnirId, naziv, zemlja, grad, godina, pocetak, kraj)
        {
            Suma = suma;
            Primalac = primalac;
        }

        public virtual int Suma { get; set; }
        public virtual string Primalac { get; set; }

    }
    public class TurnirPromotivniBPPregled : TurnirEgzibicioniPregled
    {
        public TurnirPromotivniBPPregled(int turnirId, string naziv, string zemlja, string grad, int? godina, DateTime? pocetak, DateTime? kraj, int vreme)
            : base(turnirId, naziv, zemlja, grad, godina, pocetak, kraj)
        {
            Vreme = vreme;
        }
        public virtual int Vreme { get; set; }
    }
    public class TurnirPromotivniNPregled : TurnirEgzibicioniPregled
    {
        public TurnirPromotivniNPregled(int turnirId, string naziv, string zemlja, string grad, int? godina, DateTime? pocetak, DateTime? kraj)
            : base(turnirId, naziv, zemlja, grad, godina, pocetak, kraj)
        {
        }
    }
    public class TurnirTakmicarskiBPPregled : TurnirPregled
    {
        public TurnirTakmicarskiBPPregled(int turnirId, string naziv, string zemlja, string grad, int? godina, DateTime? pocetak, DateTime? kraj, int vreme, string znacaj)
            : base(turnirId, naziv, zemlja, grad, godina, pocetak, kraj)
        {
            Znacaj = znacaj;
            Vreme = vreme;
        }
        public virtual string Znacaj { get; set; }
        public virtual int Vreme { get; set; }
    }
    public class TurnirTakmicarskiNPregled : TurnirPregled
    {
        public TurnirTakmicarskiNPregled(int turnirId, string naziv, string zemlja, string grad, int? godina, DateTime? pocetak, DateTime? kraj, string znacaj)
            : base(turnirId, naziv, zemlja, grad, godina, pocetak, kraj)
        {
            Znacaj = znacaj;
        }
        public virtual string Znacaj { get; set; }
    }
    #endregion
}
