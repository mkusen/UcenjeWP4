using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E13KlasaObjekt
{
    internal class Osoba
    {
        //klasa sadrži svojstva (eng.property)
        public string? Ime { get; set; } // OOP princit učahurivanja
        public string? Prezime { get; set; }

        public int Sifra { get; set; } // ne može biti null

        public Mjesto? Mjesto { get; set; }

        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }
    }
}
