using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E16GenericiLambdaiEkstenzije
{
    internal abstract class Entitet
    {

        public abstract void predstaviSe();
        
        public int? Sifra { get; set; }

    }
}
