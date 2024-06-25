using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E12Rekurzija
    {
        //rekurzija je kada metoda poziva samu sebe

        public static void Izvedi()
        {
            do
            {
           
            Console.WriteLine(Zbroj(Pomocno.UcitajCijeliBroj("unesi broj za sumu brojeva do tog broja")));

            } while (Pomocno.UcitajCijeliBroj("-1 za prekid") != -1);
        }

        private static int Zbroj(int broj)
        {
            //uvijek prvo napraviti uvijet prekida rekurzije 

            if(broj == 0)
            {
                return broj;
            }

           return broj + Zbroj(broj -1);
        }

        static void LosaMetoda()
        {
            LosaMetoda(); //stackoverflow exception
        }
    }
}
