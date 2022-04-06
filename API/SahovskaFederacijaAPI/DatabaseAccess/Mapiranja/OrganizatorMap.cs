using FluentNHibernate.Mapping;
using SahovskaFederacija.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Mapiranja
{
    class OrganizatorMap : ClassMap<Organizator>
    {
        public OrganizatorMap()
        {
            Table("ORGANIZATOR");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Broj, "BROJ");
            Map(x => x.JMBG, "JMBG");

            HasManyToMany(x => x.OrganizovaniTurniri)
                .Table("ORGANIZUJE")
                .ParentKeyColumn("ORGANIZATOR")
                .ChildKeyColumn("TURNIR")
                .Cascade.All();

            References(x => x.Sudija).Column("SUDIJA").Unique();
        }
    }
}
