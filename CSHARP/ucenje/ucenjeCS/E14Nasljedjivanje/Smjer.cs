using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E14Nasljedjivanje
{
    internal class Smjer:Entitet
    {
        public string? Naziv { get; set; }



        //prepisivanje (override) metode iz nadklase
        public override string ToString()
        {

            Console.WriteLine(VidiSeUPodklasi);
            return this.Naziv;
        }
    }
}
