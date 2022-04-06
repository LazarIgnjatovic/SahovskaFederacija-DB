using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public abstract class Sahista : Osoba
    {
        public virtual int RegBroj { get; set; }
        public virtual string ZemljaPorekla { get; set; }
        public virtual DateTime? DatumRodjenja { get; set; }
        public virtual int? BrojPasosa { get; set; }
        public virtual DateTime? DatumUclanjenja { get; set; }
        public virtual Sahista Self { get { return this; } }
    }


}
