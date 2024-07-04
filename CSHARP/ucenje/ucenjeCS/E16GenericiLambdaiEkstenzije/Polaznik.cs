using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E16GenericiLambdaiEkstenzije
{
    internal class Polaznik: Entitet
    {
       
        public String? Ime { get; set; }    
        public String? Prezime { get; set;}

        public override void predstaviSe()
        {
            Console.WriteLine(Sifra + " - " + Ime 
                 + " " + Prezime);
        }
    }
}
