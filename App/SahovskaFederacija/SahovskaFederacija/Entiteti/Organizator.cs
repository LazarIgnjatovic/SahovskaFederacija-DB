using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public class Organizator : Osoba
    {
        public virtual long JMBG { get; set; }
        public virtual Sudija Sudija{ get; set; }
        public virtual IList<Turnir> OrganizovaniTurniri { get; set; }

        public Organizator()
        {
            OrganizovaniTurniri = new List<Turnir>();
        }
    }
}
