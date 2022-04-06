using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public abstract class Osoba
    {
        public virtual int Id { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Broj { get; set; }
    }
}
