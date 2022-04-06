using FluentNHibernate.Mapping;
using SahovskaFederacija.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Mapiranja
{
    class TurnirMap:ClassMap<Turnir>
    {
        public TurnirMap()
        {
            Table("TURNIR");

            DiscriminateSubClassesOnColumn("")
                .Formula("CASE " +
                "WHEN JENORMALNI=1 AND JEEGZIBICIONI=1 AND JEHUMANITARNI=1 THEN 1 " +
                "WHEN JENORMALNI=1 AND JEEGZIBICIONI=1 AND JEPROMOTIVNI=1 THEN 2 " +
                "WHEN JENORMALNI=1 AND JEEGZIBICIONI=0 THEN 3 " +
                "WHEN JEBRZOPOTEZNI=1 AND JEEGZIBICIONI=1 AND JEHUMANITARNI=1 THEN 4 " +
                "WHEN JEBRZOPOTEZNI=1 AND JEEGZIBICIONI=1 AND JEPROMOTIVNI=1 THEN 5 " +
                "WHEN JEBRZOPOTEZNI=1 AND JEEGZIBICIONI=0 THEN 6 " +
                "ELSE 0 END");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Zemlja, "ZEMLJA");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Godina, "GODINA");
            Map(x => x.Pocetak, "DATUM_POC");
            Map(x => x.Kraj, "DATUM_KRAJ");


            HasManyToMany(x => x.Organizatori)
                .Table("ORGANIZUJE")
                .ParentKeyColumn("TURNIR")
                .ChildKeyColumn("ORGANIZATOR")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.OdigranePartije).KeyColumn("TURNIR").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Sponzori).KeyColumn("TURNIR").LazyLoad().Cascade.All().Inverse();

        }
    }

    class TurnirHumanitarniNMap : SubclassMap<TurnirHumanitarniN>
    {
        public TurnirHumanitarniNMap()
        {
            DiscriminatorValue('1');

            Map(x => x.Primalac, "PRIMALAC");
            Map(x => x.Suma, "SUMA");

        }
    }
    class TurnirPromotivniNMap : SubclassMap<TurnirPromotivniN>
    {
        public TurnirPromotivniNMap()
        {
            DiscriminatorValue('2');
        }
    }
    class TurnirTakmicarskiNMap : SubclassMap<TurnirTakmicarskiN>
    {
        public TurnirTakmicarskiNMap()
        {
            DiscriminatorValue('3');

            Map(x => x.Znacaj, "ZNACAJ");
        }
    }
    class TurnirHumanitarniBPMap : SubclassMap<TurnirHumanitarniBP>
    {
        public TurnirHumanitarniBPMap()
        {
            DiscriminatorValue('4');

            Map(x => x.Primalac, "PRIMALAC");
            Map(x => x.Suma, "SUMA");

            Map(x => x.Vreme, "VREME");

        }
    }
    class TurnirPromotivniBPMap : SubclassMap<TurnirPromotivniBP>
    {
        public TurnirPromotivniBPMap()
        {
            DiscriminatorValue('5');
            Map(x => x.Vreme, "VREME");
        }
    }
    class TurnirTakmicarskiBPMap : SubclassMap<TurnirTakmicarskiBP>
    {
        public TurnirTakmicarskiBPMap()
        {
            DiscriminatorValue('6');

            Map(x => x.Znacaj, "ZNACAJ");
            Map(x => x.Vreme, "VREME");
        }
    }
}
