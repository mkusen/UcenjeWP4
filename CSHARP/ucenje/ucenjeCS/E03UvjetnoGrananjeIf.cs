using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {
        public static void Izvedi()
        {

            int i = 8;
            //uvjetno grananje if radi s bool tipom podatka

            bool uvjet = i == 7;
            Console.WriteLine(uvjet);

            //minimalna if sintaksa

            if (uvjet) // u if granu se ulazi ako je vrijednost true
            {
                Console.WriteLine("1. ušao sam u if granu");
            }
            //dodatak (neobavezni dio) if grananja
            else
            {
                Console.WriteLine("2. uvjet nije zadovoljen, otišao u else granu");
            }

            //uobičajena sintaksa što se tiče uvjeta
            if (i > 2) // ako nema {} odnosi se na prvu sljedeću lijniju
                Console.WriteLine("3. ušao u if bez {}");
            Console.WriteLine("4. ovo se izvodi bez obzira na gornji if");

            var j = 2;

            //dodatni operatori & (and), &&, | (or), ||, ! (not)

            if (i < 2 && j == 2)
            {
                Console.WriteLine("5. logičko &");
            }

            //& provjerava oba uvjeta bez obzira što možda prvi bude false
            //&& ukoliko prvi uvjet bude false, drugi se ne provjerava

            if (j == 2 || i < 2)
            {
                Console.WriteLine("6. logičko or |");
            }

            // | provjerava oba uvjeta bez obzira što prvi bude true
            // || ukoliko prvi uvjet bude true drugi se ne provjerava

            if (i != 5)
            {
                Console.WriteLine("7. i nema vrijednost 5");
            }

            var ocjena = 4;

            if (ocjena == 1)
            {
                Console.WriteLine("8. nedovoljan");
            }
            else if (ocjena == 2)
            {
                Console.WriteLine("9. dovoljan");
            }
            else
            {
                Console.WriteLine("10. Ocjena nije dobra");
            }

            //inline if

            if (ocjena == 4)
            {
                Console.WriteLine("11. vrlo dobar si (1)");
            }
            else { Console.WriteLine("12. OK si (1)"); }


            Console.WriteLine(ocjena==4 ? "11. Vrlo dobar si (2)" : "12. OK si (2)");

            //if se može gnjezditi

            if (i>0) 
            {
                if (ocjena==4) 
                {
                    Console.WriteLine("13. ugnjezdio se");
                }
            }

        }

    }
}
