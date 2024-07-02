using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E14Nasljedjivanje
{
    internal abstract class Osoba: Entitet
    {
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
    }
}
