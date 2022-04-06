using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaFederacija.Entiteti
{
    public class SahistaKandidat:Sahista
    {
        public virtual int BrojNedostalih { get; set; }
    }
}
