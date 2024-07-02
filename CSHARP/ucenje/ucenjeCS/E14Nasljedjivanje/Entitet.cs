using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E14Nasljedjivanje
{

    //apstraktna klasa je ona koja nema implementaciju
    //kreira se kako bi sadržavala zajedničke metode i svojstva koja će koristiti 
    //klase koje je nasljeđuju
    internal abstract class Entitet: object //sve klase, htjele ili ne, nasljeđuju klasu object
    {
        public int? Sifra { get; set; }

        protected int VidiSeUPodklasi =7;

        private int VidiSeUKlasiUkojojJeDefinirano = 2;

        public override string ToString()
        {
            return Sifra.ToString();
        }
    }
}
