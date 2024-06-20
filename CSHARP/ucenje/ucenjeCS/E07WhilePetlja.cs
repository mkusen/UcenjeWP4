using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E07WhilePetlja
    {
        public static void Izvedi()
        {
            //u for petlju se ne mora ući

            int brojDo = 1;
            for (int i = 1; i < brojDo; i++)
            {
                Console.WriteLine("kod u petlju");
            }

            //u while petlju se ne mora ući

            int b = 1;
            while (b<brojDo) {
                Console.WriteLine("kod u petlji while");
                    }

            //while radi s bool tipom podatka

            while (true)
            {
                Console.WriteLine("kod u beskonačnoj petlji while");
                break; //continue radi isto kao u for petlji
            }

            //ispiši prvih 10 brojeva

            b = 0;
            while (b++<10) {
                Console.WriteLine(b);
            }
            Console.WriteLine("nakon petlje: " + b);

            Console.WriteLine("*************************");

            brojDo = 10;
            b = 1;
            int j = 2;

            while (j>b && j<brojDo) {

                Console.WriteLine(j++);
            }

            Console.WriteLine("****************");

            //isto se gnjezdi iznutra prema van s goto label




        }
    }
}
