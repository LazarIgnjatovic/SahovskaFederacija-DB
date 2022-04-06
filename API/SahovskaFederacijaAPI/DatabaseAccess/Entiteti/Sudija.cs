using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public class Sudija
    {
        public virtual int Id { get; protected set; }
        public virtual string Licenca { get; set; }
    }
}
