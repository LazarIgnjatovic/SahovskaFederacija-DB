using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using SahovskaFederacija.Entiteti;
namespace SahovskaFederacija
{
    public class DTOManager
    {
        public static List<SahistaPregled> vratiSveSahiste()
        {
            List<SahistaPregled> sahisti = new List<SahistaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<SahovskaFederacija.Entiteti.Sahista> sviSahisti = from o in s.Query<SahovskaFederacija.Entiteti.Sahista>()
                                                                              select o;

                foreach (SahovskaFederacija.Entiteti.Sahista so in sviSahisti)
                {
                    if (so.GetType() == typeof(SahistaObican))
                        sahisti.Add(new SahistaObicanPregled(so.Id, so.Ime, so.Prezime, so.Grad, so.Ulica, so.Broj, so.RegBroj, so.ZemljaPorekla, so.DatumRodjenja, so.BrojPasosa, so.DatumUclanjenja));
                    if (so.GetType() == typeof(SahistaKandidat))
                    {
                        SahistaKandidat sk = (SahistaKandidat)so;
                        sahisti.Add(new SahistaKandidatPregled(so.Id, so.Ime, so.Prezime, so.Grad, so.Ulica, so.Broj, so.RegBroj, so.ZemljaPorekla, so.DatumRodjenja, so.BrojPasosa, so.DatumUclanjenja, sk.BrojNedostalih));
                    }

                    if (so.GetType() == typeof(SahistaMajstor))
                    {
                        SahistaMajstor sm = (SahistaMajstor)so;
                        sahisti.Add(new SahistaMajstorPregled(so.Id, so.Ime, so.Prezime, so.Grad, so.Ulica, so.Broj, so.RegBroj, so.ZemljaPorekla, so.DatumRodjenja, so.BrojPasosa, so.DatumUclanjenja, sm.Zvanje, sm.DatumSticanja));
                    }

                }

                s.Close();
            }
            catch (Exception ec)
            {
                System.Console.WriteLine(ec.Message);
            }

            return sahisti;
        }
        public static List<TurnirPregled> vratiSveTurnire()
        {
            List<TurnirPregled> turniri = new List<TurnirPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Turnir> sviTurniri = from o in s.Query<Turnir>() select o;

                foreach (Turnir t in sviTurniri)
                {
                    if (t.GetType() == typeof(TurnirHumanitarniBP))
                    {
                        TurnirHumanitarniBP tur = (TurnirHumanitarniBP)t;
                        turniri.Add(new TurnirHumanitarniBPPregled(t.Id, t.Naziv, t.Zemlja, t.Grad, t.Godina, t.Pocetak, t.Kraj, tur.Suma, tur.Primalac, tur.Vreme));
                    }
                    if (t.GetType() == typeof(TurnirHumanitarniN))
                    {
                        TurnirHumanitarniN tur = (TurnirHumanitarniN)t;
                        turniri.Add(new TurnirHumanitarniNPregled(t.Id, t.Naziv, t.Zemlja, t.Grad, t.Godina, t.Pocetak, t.Kraj, tur.Suma, tur.Primalac));
                    }
                    if (t.GetType() == typeof(TurnirPromotivniBP))
                    {
                        TurnirPromotivniBP tur = (TurnirPromotivniBP)t;
                        turniri.Add(new TurnirPromotivniBPPregled(t.Id, t.Naziv, t.Zemlja, t.Grad, t.Godina, t.Pocetak, t.Kraj, tur.Vreme));
                    }
                    if (t.GetType() == typeof(TurnirPromotivniN))
                    {
                        TurnirPromotivniN tur = (TurnirPromotivniN)t;
                        turniri.Add(new TurnirPromotivniNPregled(t.Id, t.Naziv, t.Zemlja, t.Grad, t.Godina, t.Pocetak, t.Kraj));
                    }
                    if (t.GetType() == typeof(TurnirTakmicarskiBP))
                    {
                        TurnirTakmicarskiBP tur = (TurnirTakmicarskiBP)t;
                        turniri.Add(new TurnirTakmicarskiBPPregled(t.Id, t.Naziv, t.Zemlja, t.Grad, t.Godina, t.Pocetak, t.Kraj, tur.Vreme, tur.Znacaj));
                    }
                    if (t.GetType() == typeof(TurnirTakmicarskiN))
                    {
                        TurnirTakmicarskiN tur = (TurnirTakmicarskiN)t;
                        turniri.Add(new TurnirTakmicarskiNPregled(t.Id, t.Naziv, t.Zemlja, t.Grad, t.Godina, t.Pocetak, t.Kraj, tur.Znacaj));
                    }
                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                return null;
            }

            return turniri;
        }
        public static List<OrganizatorPregled> vratiOrganizatore()
        {
            List<OrganizatorPregled> organizatori = new List<OrganizatorPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Organizator> sviOrganizatori = from o in s.Query<Organizator>() select o;

                foreach (Organizator o in sviOrganizatori)
                {
                    organizatori.Add(new OrganizatorPregled(o.Id, o.Ime, o.Prezime, o.Grad, o.Ulica, o.Broj, o.JMBG.ToString()));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
                return null;
            }
            return organizatori;
        }
        public static SahistaPregled vratiSahistu(int id)
        {
            SahistaPregled sp = new SahistaPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                Sahista sahistaa = s.Load<Sahista>(id);
                Sahista sahista = sahistaa.Self;
                if (sahista.GetType() == typeof(SahistaObican))
                    sp = new SahistaObicanPregled(sahista.Id, sahista.Ime, sahista.Prezime, sahista.Grad, sahista.Ulica, sahista.Broj, sahista.RegBroj, sahista.ZemljaPorekla, sahista.DatumRodjenja, sahista.BrojPasosa, sahista.DatumUclanjenja);

                if (sahista.GetType() == typeof(SahistaKandidat))
                {
                    SahistaKandidat sk = (SahistaKandidat)sahista;
                    sp = new SahistaKandidatPregled(sahista.Id, sahista.Ime, sahista.Prezime, sahista.Grad, sahista.Ulica, sahista.Broj, sahista.RegBroj, sahista.ZemljaPorekla, sahista.DatumRodjenja, sahista.BrojPasosa, sahista.DatumUclanjenja, sk.BrojNedostalih);
                }
                if (sahista.GetType() == typeof(SahistaMajstor))
                {
                    SahistaMajstor sm = (SahistaMajstor)sahista;
                    sp = new SahistaMajstorPregled(sahista.Id, sahista.Ime, sahista.Prezime, sahista.Grad, sahista.Ulica, sahista.Broj, sahista.RegBroj, sahista.ZemljaPorekla, sahista.DatumRodjenja, sahista.BrojPasosa, sahista.DatumUclanjenja, sm.Zvanje, sm.DatumSticanja);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
                return null;
            }
            return sp;
        }
        public static void azurirajSahistu(SahistaPregled sp)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Sahista sahistaa = s.Load<Sahista>(sp.sahistaId);
                Sahista sahista = sahistaa.Self;
                if (sahista.GetType() == typeof(SahistaKandidat))
                {
                    SahistaKandidat sk = (SahistaKandidat)sahista;
                    SahistaKandidatPregled skp = (SahistaKandidatPregled)sp;
                    sk.Ime = sp.Ime;
                    sk.Prezime = sp.Prezime;
                    sk.Grad = sp.Grad;
                    sk.Ulica = sp.Ulica;
                    sk.Broj = sp.Broj;
                    sk.DatumRodjenja = sp.DatumRodjenja;
                    sk.BrojPasosa = sp.BrojPasosa;
                    sk.RegBroj = sp.RegBroj;
                    sk.ZemljaPorekla = sp.ZemljaPorekla;
                    sk.BrojNedostalih = skp.BrojNedostalih;
                    sk.DatumUclanjenja = sp.DatumUclanjenja;
                    s.Update(sk);
                    s.Flush();
                    var sql = String.Format("UPDATE SAHISTA " +
                       "SET " +
                       "JeOBICAN=0, " +
                       "JeKANDIDAT=1, " +
                       "JeMAJSTOR=0 " +
                       "WHERE ID= {0}", sp.sahistaId);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                else if (sahista.GetType() == typeof(SahistaMajstor))
                {
                    SahistaMajstor sk = (SahistaMajstor)sahista;
                    SahistaMajstorPregled skp = (SahistaMajstorPregled)sp;
                    sk.Ime = sp.Ime;
                    sk.Prezime = sp.Prezime;
                    sk.Grad = sp.Grad;
                    sk.Ulica = sp.Ulica;
                    sk.Broj = sp.Broj;
                    sk.DatumRodjenja = sp.DatumRodjenja;
                    sk.BrojPasosa = sp.BrojPasosa;
                    sk.RegBroj = sp.RegBroj;
                    sk.ZemljaPorekla = sp.ZemljaPorekla;
                    sk.Zvanje = skp.Zvanje;
                    sk.DatumSticanja = skp.DatumSticanja;
                    sk.DatumUclanjenja = sp.DatumUclanjenja;
                    s.Update(sk);
                    s.Flush();
                    var sql = String.Format("UPDATE SAHISTA " +
                       "SET " +
                       "JeOBICAN=0, " +
                       "JeKANDIDAT=0, " +
                       "JeMAJSTOR=1 " +
                       "WHERE ID= {0}", sp.sahistaId);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                else
                {
                    SahistaObican sk = (SahistaObican)sahista;
                    sk.Ime = sp.Ime;
                    sk.Prezime = sp.Prezime;
                    sk.Grad = sp.Grad;
                    sk.Ulica = sp.Ulica;
                    sk.Broj = sp.Broj;
                    sk.DatumRodjenja = sp.DatumRodjenja;
                    sk.BrojPasosa = sp.BrojPasosa;
                    sk.RegBroj = sp.RegBroj;
                    sk.ZemljaPorekla = sp.ZemljaPorekla;
                    sk.DatumUclanjenja = sp.DatumUclanjenja;
                    s.SaveOrUpdate(sk);
                    s.Flush();
                    var sql = String.Format("UPDATE SAHISTA " +
                       "SET " +
                       "JeOBICAN=1, " +
                       "JeKANDIDAT=0, " +
                       "JeMAJSTOR=0 " +
                       "WHERE ID= {0}", sp.sahistaId);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                //handle exceptions
            }
        }
        public static void dodajSahistu(SahistaPregled sp)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (sp.GetType() == typeof(SahistaObicanPregled))
                {
                    SahistaObican sahista = new SahistaObican();
                    sahista.Ime = sp.Ime;
                    sahista.Prezime = sp.Prezime;
                    sahista.Grad = sp.Grad;
                    sahista.Ulica = sp.Ulica;
                    sahista.Broj = sp.Broj;
                    sahista.DatumRodjenja = sp.DatumRodjenja;
                    sahista.BrojPasosa = sp.BrojPasosa;
                    sahista.RegBroj = sp.RegBroj;
                    sahista.ZemljaPorekla = sp.ZemljaPorekla;
                    sahista.DatumUclanjenja = sp.DatumUclanjenja;
                    s.SaveOrUpdate(sahista);
                    s.Flush();
                    var sql = String.Format("UPDATE SAHISTA " +
                       "SET " +
                       "JeOBICAN=1, " +
                       "JeKANDIDAT=0, " +
                       "JeMAJSTOR=0 " +
                       "WHERE ID= {0}", sp.sahistaId);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                if (sp.GetType() == typeof(SahistaKandidatPregled))
                {
                    SahistaKandidat sahista = new SahistaKandidat();
                    SahistaKandidatPregled skp = (SahistaKandidatPregled)sp;
                    sahista.Ime = sp.Ime;
                    sahista.Prezime = sp.Prezime;
                    sahista.Grad = sp.Grad;
                    sahista.Ulica = sp.Ulica;
                    sahista.Broj = sp.Broj;
                    sahista.DatumRodjenja = sp.DatumRodjenja;
                    sahista.BrojPasosa = sp.BrojPasosa;
                    sahista.RegBroj = sp.RegBroj;
                    sahista.ZemljaPorekla = sp.ZemljaPorekla;
                    sahista.DatumUclanjenja = sp.DatumUclanjenja;
                    sahista.BrojNedostalih = skp.BrojNedostalih;
                    s.SaveOrUpdate(sahista);
                    s.Flush();
                    var sql = String.Format("UPDATE SAHISTA " +
                      "SET " +
                      "JeOBICAN=0, " +
                      "JeKANDIDAT=1, " +
                      "JeMAJSTOR=0 " +
                      "WHERE ID= {0}", sp.sahistaId);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                if (sp.GetType() == typeof(SahistaMajstorPregled))
                {
                    SahistaMajstor sahista = new SahistaMajstor();
                    SahistaMajstorPregled smp = (SahistaMajstorPregled)sp;
                    sahista.Ime = sp.Ime;
                    sahista.Prezime = sp.Prezime;
                    sahista.Grad = sp.Grad;
                    sahista.Ulica = sp.Ulica;
                    sahista.Broj = sp.Broj;
                    sahista.DatumRodjenja = sp.DatumRodjenja;
                    sahista.BrojPasosa = sp.BrojPasosa;
                    sahista.RegBroj = sp.RegBroj;
                    sahista.ZemljaPorekla = sp.ZemljaPorekla;
                    sahista.DatumUclanjenja = sp.DatumUclanjenja;
                    sahista.Zvanje = smp.Zvanje;
                    sahista.DatumSticanja = smp.DatumSticanja;
                    s.SaveOrUpdate(sahista);
                    s.Flush();
                    var sql = String.Format("UPDATE SAHISTA " +
                       "SET " +
                       "JeOBICAN=0, " +
                       "JeKANDIDAT=0, " +
                       "JeMAJSTOR=1 " +
                       "WHERE ID= {0}", sp.sahistaId);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                //handle exceptions
            }
        }
        public static void obrisiSahiste(List<int> ids)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                for (int i = 0; i < ids.Count; i++)
                {
                    Sahista sahista = s.Load<Sahista>(ids[i]);
                    s.Delete(sahista);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ex)
            {
                //handle exceptions
            }
        }
        public static List<SponzorPregled> vratiSponzoreTurnira(int turnirId)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Turnir turnir = s.Load<Turnir>(turnirId);
                IList<Sponzor> sponzori = turnir.Sponzori;
                List<SponzorPregled> sp = new List<SponzorPregled>();
                foreach (Sponzor sponzor in sponzori)
                {
                    sp.Add(new SponzorPregled(sponzor.Id, sponzor.Naziv));
                }
                s.Close();
                return sp;
            }
            catch (Exception ex)
            {
                //handle exceptions
                return null;
            }
        }
        public static void dodajOrganizatora(OrganizatorPregled o)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Organizator org = new Organizator();
                org.Ime = o.Ime;
                org.Prezime = o.Prezime;
                org.Ulica = o.Ulica;
                org.Grad = o.Grad;
                org.Broj = o.Broj;
                org.JMBG = Int64.Parse(o.JMBG);

                s.SaveOrUpdate(org);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void izmeniOrganizatora(OrganizatorPregled o)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Organizator org = s.Load<Organizator>(o.organizatorId);
                org.Ime = o.Ime;
                org.Prezime = o.Prezime;
                org.Ulica = o.Ulica;
                org.Grad = o.Grad;
                org.Broj = o.Broj;
                org.JMBG = Int64.Parse(o.JMBG);

                s.SaveOrUpdate(org);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void obrisiOrganizatora(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Organizator o = s.Load<Organizator>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void dodajTurnir(TurnirPregled tp)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Turnir t;
                if (tp.GetType() == typeof(TurnirHumanitarniBPPregled))
                {
                    TurnirHumanitarniBP tpom = new TurnirHumanitarniBP();
                    TurnirHumanitarniBPPregled tpp = (TurnirHumanitarniBPPregled)tp;
                    tpom.Vreme = tpp.Vreme;
                    tpom.Suma = tpp.Suma;
                    tpom.Primalac = tpp.Primalac;
                    t = tpom;
                    podesiTurnir(t, tp);
                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=0, " +
                        "JEBRZOPOTEZNI=1, " +
                        "JEEGZIBICIONI=1, " +
                        "JEPROMOTIVNI=0, " +
                        "JEHUMANITARNI=1 " +
                        "WHERE ID= {0}", t.Id);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                if (tp.GetType() == typeof(TurnirPromotivniBPPregled))
                {
                    TurnirPromotivniBP tpom = new TurnirPromotivniBP();
                    TurnirPromotivniBPPregled tpp = (TurnirPromotivniBPPregled)tp;
                    tpom.Vreme = tpp.Vreme;
                    t = tpom;
                    podesiTurnir(t, tp);
                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=0, " +
                        "JEBRZOPOTEZNI=1, " +
                        "JEEGZIBICIONI=1, " +
                        "JEPROMOTIVNI=1, " +
                        "JEHUMANITARNI=0 " +
                        "WHERE ID= {0}", t.Id);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                if (tp.GetType() == typeof(TurnirTakmicarskiBPPregled))
                {
                    TurnirTakmicarskiBP tpom = new TurnirTakmicarskiBP();
                    TurnirTakmicarskiBPPregled tpp = (TurnirTakmicarskiBPPregled)tp;
                    tpom.Vreme = tpp.Vreme;
                    tpom.Znacaj = tpp.Znacaj;
                    t = tpom;
                    podesiTurnir(t, tp);
                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=0, " +
                        "JEBRZOPOTEZNI=1, " +
                        "JEEGZIBICIONI=0, " +
                        "JEPROMOTIVNI=0, " +
                        "JEHUMANITARNI=0 " +
                        "WHERE ID= {0}", t.Id);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                if (tp.GetType() == typeof(TurnirHumanitarniNPregled))
                {
                    TurnirHumanitarniN tpom = new TurnirHumanitarniN();
                    TurnirHumanitarniNPregled tpp = (TurnirHumanitarniNPregled)tp;
                    tpom.Suma = tpp.Suma;
                    tpom.Primalac = tpp.Primalac;
                    t = tpom;
                    podesiTurnir(t, tp);
                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=1, " +
                        "JEBRZOPOTEZNI=0, " +
                        "JEEGZIBICIONI=1, " +
                        "JEPROMOTIVNI=0, " +
                        "JEHUMANITARNI=1 " +
                        "WHERE ID= {0}", t.Id);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                if (tp.GetType() == typeof(TurnirPromotivniNPregled))
                {
                    TurnirPromotivniN tpom = new TurnirPromotivniN();
                    TurnirPromotivniNPregled tpp = (TurnirPromotivniNPregled)tp;
                    t = tpom;
                    podesiTurnir(t, tp);
                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=1, " +
                        "JEBRZOPOTEZNI=0, " +
                        "JEEGZIBICIONI=1, " +
                        "JEPROMOTIVNI=1, " +
                        "JEHUMANITARNI=0 " +
                        "WHERE ID= {0}", t.Id);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                else
                if (tp.GetType() == typeof(TurnirTakmicarskiNPregled))
                {
                    TurnirTakmicarskiN tpom = new TurnirTakmicarskiN();
                    TurnirTakmicarskiNPregled tpp = (TurnirTakmicarskiNPregled)tp;
                    tpom.Znacaj = tpp.Znacaj;
                    t = tpom;
                    podesiTurnir(t, tp);

                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=1, " +
                        "JEBRZOPOTEZNI=0, " +
                        "JEEGZIBICIONI=0, " +
                        "JEPROMOTIVNI=0, " +
                        "JEHUMANITARNI=0 " +
                        "WHERE ID={0}", t.Id);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        private static void podesiTurnir(Turnir t, TurnirPregled tp)
        {
            t.Naziv = tp.Naziv;
            t.Zemlja = tp.Zemlja;
            t.Grad = tp.Grad;
            t.Godina = tp.Godina;
            t.Pocetak = tp.Pocetak;
            t.Kraj = tp.Kraj;
        }
        public static void izmeniTurnir(TurnirPregled tp)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Turnir t = s.Load<Turnir>(tp.turnirId);
                if (tp.GetType() == typeof(TurnirHumanitarniBPPregled))
                {
                    TurnirHumanitarniBPPregled tpp = (TurnirHumanitarniBPPregled)tp;
                    podesiTurnir(t, tp);
                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=0, " +
                        "JEBRZOPOTEZNI=1, " +
                        "JEEGZIBICIONI=1, " +
                        "JEPROMOTIVNI=0, " +
                        "JEHUMANITARNI=1, " +
                        "VREME= {1}, " +
                        "SUMA= {2}, PRIMALAC= '{3}' " +
                        "WHERE ID= {0}", tp.turnirId, tpp.Vreme, tpp.Suma, tpp.Primalac);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                if (tp.GetType() == typeof(TurnirPromotivniBPPregled))
                {
                    TurnirPromotivniBPPregled tpp = (TurnirPromotivniBPPregled)tp;
                    podesiTurnir(t, tp);
                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=0, " +
                        "JEBRZOPOTEZNI=1, " +
                        "JEEGZIBICIONI=1, " +
                        "JEPROMOTIVNI=1, " +
                        "JEHUMANITARNI=0, " +
                        "VREME= {1} " +
                        "WHERE ID= {0}", tp.turnirId, tpp.Vreme);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                if (tp.GetType() == typeof(TurnirTakmicarskiBPPregled))
                {
                    TurnirTakmicarskiBPPregled tpp = (TurnirTakmicarskiBPPregled)tp;
                    podesiTurnir(t, tp);
                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=0, " +
                        "JEBRZOPOTEZNI=1, " +
                        "JEEGZIBICIONI=0, " +
                        "JEPROMOTIVNI=0, " +
                        "JEHUMANITARNI=0, " +
                        "VREME= {1}, " +
                        "ZNACAJ= '{2}' " +
                        "WHERE ID= {0}", tp.turnirId, tpp.Vreme, tpp.Znacaj);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                if (tp.GetType() == typeof(TurnirHumanitarniNPregled))
                {
                    TurnirHumanitarniNPregled tpp = (TurnirHumanitarniNPregled)tp;
                    podesiTurnir(t, tp);
                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=1, " +
                        "JEBRZOPOTEZNI=0, " +
                        "JEEGZIBICIONI=1, " +
                        "JEPROMOTIVNI=0, " +
                        "JEHUMANITARNI=1, " +
                        "SUMA= {1}, PRIMALAC= '{2}'" +
                        "WHERE ID= {0}", tp.turnirId, tpp.Suma, tpp.Primalac);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                if (tp.GetType() == typeof(TurnirPromotivniNPregled))
                {
                    TurnirPromotivniNPregled tpp = (TurnirPromotivniNPregled)tp;
                    podesiTurnir(t, tp);
                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=1, " +
                        "JEBRZOPOTEZNI=0, " +
                        "JEEGZIBICIONI=1, " +
                        "JEPROMOTIVNI=1, " +
                        "JEHUMANITARNI=0 " +
                        "WHERE ID= {0}", tp.turnirId);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
                else
                if (tp.GetType() == typeof(TurnirTakmicarskiNPregled))
                {
                    TurnirTakmicarskiN tpom = new TurnirTakmicarskiN();
                    TurnirTakmicarskiNPregled tpp = (TurnirTakmicarskiNPregled)tp;
                    podesiTurnir(t, tp);
                    s.SaveOrUpdate(t);
                    s.Flush();
                    var sql = String.Format("UPDATE TURNIR " +
                        "SET " +
                        "JENORMALNI=1, " +
                        "JEBRZOPOTEZNI=0, " +
                        "JEEGZIBICIONI=0, " +
                        "JEPROMOTIVNI=0, " +
                        "JEHUMANITARNI=0, " +
                        "ZNACAJ='{1}' " +
                        "WHERE ID={0}", tp.turnirId, tpp.Znacaj);
                    var query = s.CreateSQLQuery(sql);
                    query.ExecuteUpdate();
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void dodajSponzora(SponzorPregled sp, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Sponzor sponzor = new Sponzor();
                sponzor.Naziv = sp.Naziv;
                Turnir turnir = s.Load<Turnir>(id);
                sponzor.Turnir = turnir;
                s.Save(sponzor);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                //handle exceptions
            }
        }
        public static void izmeniSponzora(SponzorPregled sp)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Sponzor sponzor = s.Load<Sponzor>(sp.sponozrId);
                sponzor.Naziv = sp.Naziv;
                s.SaveOrUpdate(sponzor);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                //handle exceptions
            }
        }
        public static void obrisiSponzora(SponzorPregled sp)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Sponzor sponzor = s.Load<Sponzor>(sp.sponozrId);
                s.Delete(sponzor);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                //handle exceptions
            }
        }
        public static SponzorPregled vratiSponzora(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Sponzor sponzor = s.Load<Sponzor>(id);
                SponzorPregled sp = new SponzorPregled(sponzor.Id, sponzor.Naziv);
                return sp;
            }
            catch (Exception ex)
            {
                //handle exceptions
                return null;
            }
        }
        public static void obrisiTurnir(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Turnir o = s.Load<Turnir>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static List<OrganizatorPregled> vratiOrganizatoreTurnira(int id)
        {
            List<OrganizatorPregled> organizatori = new List<OrganizatorPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Organizator> sviOrganizatori = s.Load<Turnir>(id).Organizatori;

                foreach (Organizator o in sviOrganizatori)
                {
                    organizatori.Add(new OrganizatorPregled(o.Id, o.Ime, o.Prezime, o.Grad, o.Ulica, o.Broj, o.JMBG.ToString()));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
                return null;
            }
            return organizatori;
        }
        public static void obrisiOrganizatoraTurnira(int idtur, int idorg)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Organizator o = s.Load<Organizator>(idorg);
                Turnir t = s.Load<Turnir>(idtur);
                o.OrganizovaniTurniri.Remove(t);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void dodajOrganizatoraTurnira(int idtur, int idorg)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Organizator o = s.Load<Organizator>(idorg);
                Turnir t = s.Load<Turnir>(idtur);
                if (o.OrganizovaniTurniri.Contains(t))
                {
                    s.Close();
                    return;
                }
                o.OrganizovaniTurniri.Add(t);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static List<PartijaPregled> vratiPartijeTurnira(int idTur)
        {
            List<PartijaPregled> partije = new List<PartijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Partija> svePartije = from o in s.Query<Partija>() where o.Turnir.Id == idTur select o;

                foreach (Partija o in svePartije)
                {
                    partije.Add(new PartijaPregled(o.Id, o.Datum, o.Vreme, o.Trajanje, o.Ishod, o.BeliSahista.Ime + " " + o.BeliSahista.Prezime,
                        o.CrniSahista.Ime + " " + o.CrniSahista.Prezime));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
                return null;
            }
            return partije;
        }
        public static List<SahistaMajstorPregled> vratiMajstore()
        {
            try
            {
                List<SahistaMajstorPregled> sahisti = new List<SahistaMajstorPregled>();
                ISession s = DataLayer.GetSession();

                IEnumerable<Sahista> sviSahisti = from o in s.Query<SahovskaFederacija.Entiteti.Sahista>()
                                                  select o;

                foreach (Sahista so in sviSahisti)
                {

                    if (so.GetType() == typeof(SahistaMajstor))
                    {
                        SahistaMajstor sm = (SahistaMajstor)so;
                        sahisti.Add(new SahistaMajstorPregled(so.Id, so.Ime, so.Prezime, so.Grad, so.Ulica, so.Broj, so.RegBroj, so.ZemljaPorekla, so.DatumRodjenja, so.BrojPasosa, so.DatumUclanjenja, sm.Zvanje, sm.DatumSticanja));
                    }

                }

                s.Close();
                return sahisti;
            }
            catch (Exception ec)
            {
                //handle exceptions
                return null;
            }
        }
        public static void dodajPartijuTurnira(int idTur, PartijaPregled part, int idBeli, int idCrni, bool isMajstor, int idS)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Turnir t = s.Load<Turnir>(idTur);
                Partija p = new Partija();
                p.Datum = part.Datum;
                p.Vreme = part.Vreme;
                p.Trajanje = part.Trajanje;
                p.Ishod = part.Ishod;
                p.Turnir = t;
                p.BeliSahista = s.Load<Sahista>(idBeli);
                p.CrniSahista = s.Load<Sahista>(idCrni);



                if (isMajstor)
                {
                    Sudija sud;
                    SahistaMajstor m = s.Load<SahistaMajstor>(idS);
                    if (m.Sudija != null)
                        sud = m.Sudija;
                    else
                    {
                        sud = new Sudija();
                        m.Sudija = sud;
                    }
                    p.Sudija = sud;
                    sud.Licenca = "pod stra";
                    s.SaveOrUpdate(sud);
                    s.SaveOrUpdate(m);
                    s.SaveOrUpdate(p);
                    s.Flush();

                }
                else
                {
                    Sudija sud;
                    Organizator m = s.Load<Organizator>(idS);
                    if (m.Sudija != null)
                        sud = m.Sudija;
                    else
                    {
                        sud = new Sudija();
                        m.Sudija = sud;
                    }
                    p.Sudija = sud;
                    sud.Licenca = "na divlje";
                    s.SaveOrUpdate(sud);
                    s.SaveOrUpdate(m);
                    s.SaveOrUpdate(p);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static PartijaPregled vratiPartiju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Partija p = s.Load<Partija>(id);
                PartijaPregled partija = new PartijaPregled(p.Id, p.Datum, p.Vreme, p.Trajanje, p.Ishod, p.BeliSahista.Id.ToString(), p.CrniSahista.Id.ToString());
                return partija;
            }
            catch (Exception ec)
            {
                //handle exceptions
                return null;
            }

        }
        public static string vratiSudijuPartije(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Partija p = s.Load<Partija>(id);
                SahistaMajstor majstor = (from o in s.Query<SahistaMajstor>()
                                          where o.Sudija.Id == p.Sudija.Id
                                          select o).FirstOrDefault();
                if (majstor != null)
                    return majstor.Ime + majstor.Prezime;
                Organizator org = (from o in s.Query<Organizator>()
                                   where o.Sudija.Id == p.Sudija.Id
                                   select o).FirstOrDefault();
                if (org != null)
                    return org.Ime + org.Prezime;
                return null;
            }
            catch (Exception ec)
            {
                //handle exceptions
                return null;
            }
        }
        public static void izmeniPartijuTurnira(int idTur, PartijaPregled part, int idBeli, int idCrni, bool isMajstor, int idS)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Turnir t = s.Load<Turnir>(idTur);
                Partija p = s.Load<Partija>(part.partijaId);
                p.Datum = part.Datum;
                p.Vreme = part.Vreme;
                p.Trajanje = part.Trajanje;
                p.Ishod = part.Ishod;
                p.Turnir = t;
                p.BeliSahista = s.Load<Sahista>(idBeli);
                p.CrniSahista = s.Load<Sahista>(idCrni);



                if (isMajstor)
                {
                    Sudija sud;
                    SahistaMajstor m = s.Load<SahistaMajstor>(idS);
                    if (m.Sudija != null)
                        sud = m.Sudija;
                    else
                    {
                        sud = new Sudija();
                        m.Sudija = sud;
                    }
                    p.Sudija = sud;
                    sud.Licenca = "pod stra";
                    s.SaveOrUpdate(sud);
                    s.SaveOrUpdate(m);
                    s.SaveOrUpdate(p);
                    s.Flush();

                }
                else
                {
                    Sudija sud;
                    Organizator m = s.Load<Organizator>(idS);
                    if (m.Sudija != null)
                        sud = m.Sudija;
                    else
                    {
                        sud = new Sudija();
                        m.Sudija = sud;
                    }
                    p.Sudija = sud;
                    sud.Licenca = "na divlje";
                    s.SaveOrUpdate(sud);
                    s.SaveOrUpdate(m);
                    s.SaveOrUpdate(p);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void obrisiPartiju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Partija o = s.Load<Partija>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }

        public static List<PotezPregled> vratiPotezePartije(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Partija partija = s.Load<Partija>(id);
                IList<Potez> potezi = partija.ListaPoteza;
                List<PotezPregled> pp = new List<PotezPregled>();
                foreach (Potez potez in potezi)
                    pp.Add(new PotezPregled(potez.Id, potez.Broj, potez.Odigrano, potez.Vreme));
                s.Close();
                return pp;

            }
            catch (Exception ex)
            {
                //handle exceptions
                return null;
            }
        }
        public static void dodajPotez(PotezPregled pp, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Potez potez = new Potez();
                potez.Broj = pp.Broj;
                potez.Odigrano = pp.Odigrano;
                potez.Vreme = pp.Vreme;
                Partija partija = s.Load<Partija>(id);
                potez.Partija = partija;
                s.Save(potez);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle exceptions
            }
        }
        public static void izmeniPotez(PotezPregled pp)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Potez potez = s.Load<Potez>(pp.potezId);
                potez.Broj = pp.Broj;
                potez.Vreme = pp.Vreme;
                potez.Odigrano = pp.Odigrano;
                s.SaveOrUpdate(potez);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                //handle exceptions
            }
        }
        public static void obrisiPotez(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Potez potez = s.Load<Potez>(id);
                s.Delete(potez);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                //handle exceptions
            }
        }
        public static PotezPregled vratiPotez(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Potez potez = s.Load<Potez>(id);
                PotezPregled pp = new PotezPregled(potez.Id, potez.Broj, potez.Odigrano, potez.Vreme);
                return pp;
            }
            catch (Exception ex)
            {
                //handle exceptions
                return null;
            }
        }

    }
}
