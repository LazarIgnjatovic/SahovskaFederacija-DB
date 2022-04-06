using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public class TurnirTakmicarskiBP : Turnir
    {
        public virtual string Znacaj { get; set; }
        public virtual int Vreme { get; set; }
    }
}
