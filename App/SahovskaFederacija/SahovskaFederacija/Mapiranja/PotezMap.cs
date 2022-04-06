using FluentNHibernate.Mapping;
using SahovskaFederacija.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Mapiranja
{
    class PotezMap:ClassMap<Potez>
    {
        public PotezMap()
        {
            Table("POTEZ");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Broj, "BROJ");
            Map(x => x.Odigrano, "POTEZ");
            Map(x => x.Vreme, "VREME");

            References(x => x.Partija).Column("PARTIJA");

        }
    }
}
