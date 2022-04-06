using FluentNHibernate.Mapping;
using SahovskaFederacija.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Mapiranja
{
    class SponzorMap:ClassMap<Sponzor>
    {
        public SponzorMap()
        {
            Table("SPONZOR");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");

            References(x => x.Turnir).Column("TURNIR");
        }
    }
}
