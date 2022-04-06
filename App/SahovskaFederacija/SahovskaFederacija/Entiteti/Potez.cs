using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public class Potez
    {
        public virtual int Id { get; protected set; }
        public virtual Partija Partija { get; set; }
        public virtual int Broj { get; set; }
        public virtual string Odigrano { get; set; }
        public virtual DateTime Vreme { get; set; }

    }
}
