using FluentNHibernate.Mapping;
using SahovskaFederacija.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Mapiranja
{
    class PartijaMap:ClassMap<Partija>
    {
        public PartijaMap()
        {
            Table("PARTIJA");
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Datum, "DATUM");
            Map(x => x.Vreme, "VREME");
            Map(x => x.Trajanje, "TRAJANJE");
            Map(x => x.Ishod, "ISHOD");

            References(x => x.Turnir).Column("TURNIR");
            References(x => x.CrniSahista).Column("CRNI_SAHISTA");
            References(x => x.BeliSahista).Column("BELI_SAHISTA");
            References(x => x.Sudija).Column("SUDIJA");

            HasMany(x => x.ListaPoteza).KeyColumn("PARTIJA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
