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

            Console.WriteLine(string.Join(",", godine));

            string[] gradovi = { "Osijek", "Valpovo", "Vukovar", "Vinkovci" };

            Console.WriteLine(gradovi[2]);

            int[,] ints = 
                { 
                 
                { 0, 1, 2, 3 }, 
                { 4, 5, 6, 7 }, 
                { 8, 9, 10, 11 }, 
                { 12, 13, 14, 15 } 
            };
            Console.WriteLine(ints[1,2]);


        }
    }
}
