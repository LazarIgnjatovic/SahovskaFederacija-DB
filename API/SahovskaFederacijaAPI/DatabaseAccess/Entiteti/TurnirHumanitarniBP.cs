using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public class TurnirHumanitarniBP:TurnirEgzibicioni
    {
        public virtual int Suma { get; set; }
        public virtual string Primalac { get; set; }
        public virtual int Vreme { get; set; }
    }
}
