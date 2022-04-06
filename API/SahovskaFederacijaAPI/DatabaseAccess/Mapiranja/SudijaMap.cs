using FluentNHibernate.Mapping;
using SahovskaFederacija.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Mapiranja
{
    class SudijaMap:ClassMap<Sudija>
    {
        public SudijaMap()
        {
            Table("SUDIJA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Licenca, "LICENCA");
        }

    }
}
