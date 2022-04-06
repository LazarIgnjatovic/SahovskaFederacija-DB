using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public abstract class Turnir
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual string Zemlja { get; set; }
        public virtual string Grad { get; set; }
        public virtual int? Godina { get; set; }
        public virtual DateTime? Pocetak { get; set; }
        public virtual DateTime? Kraj { get; set; }
        public virtual Turnir Self { get { return this; } }
        public virtual IList<Organizator> Organizatori { get; set; }
        public virtual IList<Partija> OdigranePartije { get; set; }
        public virtual IList<Sponzor> Sponzori { get; set; }

        public Turnir()
        {
            Organizatori = new List<Organizator>();
            OdigranePartije = new List<Partija>();
            Sponzori = new List<Sponzor>();
        }
    }
}
