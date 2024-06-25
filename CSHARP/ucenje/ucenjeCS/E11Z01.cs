using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E11Z01
    {
        //za dva učitana broja koja unosi korisnik ispiši broj

        public static void Izvedi() {
            int b1 = Pomocno.UcitajCijeliBroj("unesi prvi broj");
            int b2 = Pomocno.UcitajCijeliBroj("unesi drugi broj");
            Console.WriteLine(b1+b2);

        }
    }
}
