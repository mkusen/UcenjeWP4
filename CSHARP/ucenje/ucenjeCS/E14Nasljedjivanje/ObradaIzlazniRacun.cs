using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E14Nasljedjivanje
{
    internal class ObradaIzlazniRacun : Obrada
    {
        public override void Procesuiraj()
        {
            Console.WriteLine("1. Vidi tko je kupac");
            Console.WriteLine("2. Pošalji račun");
        }
    }
}
