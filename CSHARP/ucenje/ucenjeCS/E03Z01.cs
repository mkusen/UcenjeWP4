using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E03Z01
    {
        public static void Izvedi()
        {
            //program od korisnika traži unos broja godina koje ima korisnik
            //program ispisuje da li je korisnik punoljetna osoba ili ne

            try
            {
                Console.Write("upiši koliko imaš godina: ");
                var g = int.Parse(Console.ReadLine());
                Console.WriteLine("imaš " + g + " godina");

                if (g >= 18)
                {
                    Console.WriteLine("punoljetan si");
                }
                else { Console.WriteLine("nisi punoljetan"); }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());


            }
        }
    }
}
