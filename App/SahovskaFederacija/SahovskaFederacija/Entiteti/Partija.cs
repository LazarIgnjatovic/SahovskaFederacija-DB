using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public class Partija
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime Datum { get; set; }
        public virtual DateTime Vreme { get; set; }
        public virtual int Trajanje { get; set; }
        public virtual string Ishod { get; set; }
        public virtual Sahista BeliSahista { get; set; }
        public virtual Sahista CrniSahista { get; set; }
        public virtual Turnir Turnir { get; set; }
        public virtual Sudija Sudija { get; set; }
        public virtual IList<Potez> ListaPoteza { get; set; }

        public Partija()
        {
            ListaPoteza = new List<Potez>();
        }
    }
}
