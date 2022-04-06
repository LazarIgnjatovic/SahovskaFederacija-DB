using FluentNHibernate.Mapping;
using SahovskaFederacija.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Mapiranja
{
    class SahistaMap:ClassMap<Sahista>
    {
        public SahistaMap()
        {
            Table("SAHISTA");
            DiscriminateSubClassesOnColumn("")
                .Formula("CASE WHEN JEMAJSTOR=1 THEN 3 WHEN JEKANDIDAT=1 THEN 2 ELSE 1 END");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Broj, "BROJ");
            Map(x => x.RegBroj, "REG_BROJ");
            Map(x => x.ZemljaPorekla, "ZEMLJA_POREKLA");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.BrojPasosa, "BROJ_PASOSA");
            Map(x => x.DatumUclanjenja, "DATUM_UCLANJENJA");

        }
    }
    class SahistaObicanMap: SubclassMap<SahistaObican>
    {
        public SahistaObicanMap()
        {
            DiscriminatorValue('1');
        }
    }
    class SahistaKandidatMap : SubclassMap<SahistaKandidat>
    {
        public SahistaKandidatMap()
        {
            DiscriminatorValue('2');
            Map(x => x.BrojNedostalih, "BR_NEDOST_PARTIJA");
        }
    }
    class SahistaMajstorMap : SubclassMap<SahistaMajstor>
    {
        public SahistaMajstorMap()
        {
            DiscriminatorValue('3');
            Map(x => x.Zvanje, "ZVANJE");
            Map(x => x.DatumSticanja, "DATUM_STICANJA");

            References(x => x.Sudija).Column("SUDIJA").Unique();
        }
    }
}
