using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi()
        {
            //eng.Arrays ili polja na HR
            // jednodimenzionalni niz
            // AltGr + F = []
            int[] godine = new int[12];

            godine[0] = 43; //element na indexu 0 poprima vijednost 43

            godine[godine.Length - 1] = 25; //na zadnji element postavlja vrijednost 25

            Console.WriteLine(godine);




        }
    }
}
