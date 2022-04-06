using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public class Sponzor
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual Turnir Turnir { get; set; }
    }
}
