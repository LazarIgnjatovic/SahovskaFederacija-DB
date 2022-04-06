using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public class SahistaMajstor:Sahista
    {
        public virtual string Zvanje { get; set; }
        public virtual DateTime DatumSticanja { get; set; }

        public virtual Sudija Sudija { get; set; }
    }
}
