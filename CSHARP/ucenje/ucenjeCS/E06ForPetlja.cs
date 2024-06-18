using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS;

namespace ucenjeCS
{
    internal class E06ForPetlja
    {
        public static void Izvedi()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + ". Osijek");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            //zbroj prvih 100 brojeva
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }

            Console.WriteLine(suma);

            //ispiši sve parne brojeve od 3 do 29
            //loše rješenje
            for (int i = 4; i < 29; i = i + 2)
            {
                Console.WriteLine(i);
            }

            //dobro rješenje
            Console.WriteLine("ispiši parne brojeve");
            int brojOd = 3;
            int brojDo = 29;
            for (int i = brojOd; i < brojDo; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }


            Console.WriteLine("ispiši niz");
            int[] niz = { 1, 2, 3, 5, 8, 4, 69, 25, 512, 4487 };

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }

            Console.WriteLine("ispiši brojeve unazad");

            //ispiši brojeve od 20 do 10

            for (int i = 20; i >= 10; i--)
            {
                Console.WriteLine(i);
            }

            //ispiši sve prim brojeve od 2 do 14
            bool prim;
            int ukupno = 0;
            for (int i = 2; i <= 1400; i++)
            {
                prim = true;

                for (int j = 2; j < i; j++)
                {
                    //Console.WriteLine("{0} % {1} = {2}", i,j,i%j);
                    if (i % j == 0)
                    {
                        prim = false;

                        //break;

                    }
                    if (!prim)
                    {

                        ++ukupno;
                        //Console.WriteLine("nepotrebno izvođenje " + ++ukupno);
                    }
                }
                if (prim)
                {
                    Console.WriteLine("prim broj je: " + i);
                }
                {

                }
            }

            Console.WriteLine("*****************************");
            //preskakanje petlje

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(i * j);
                    //želim prekinuti vanjsku petlju: variabli i
                    goto labela;
                }

            labela:
                Console.WriteLine("****************");

                //beskonačna petlja
                //unesi broj između 1 i 10

                //int broj;
                //for (; ; )
                //{
                //    Console.WriteLine("unesi broj od 1 do 10");
                //    broj=int.Parse(Console.ReadLine());
                //    if (broj < 1 || broj > 10)
                //    {
                //        Console.WriteLine("nisi unio traženi broj");
                //        continue;
                //    }
                //    break;
                //}

                //Console.WriteLine(broj );
                 
              

            }

            Console.WriteLine("****************");

            niz = PodaciInt.niz;

            Console.WriteLine(niz.Length);

            for (int i = 0; i < niz.Length; i++)
            {

                if (i % 10000 == 0)
                {
                    Console.Write("*");
                }
               for (int j=i+1; j < niz.Length; j++)
                {
                    if (niz[i] == niz[j]) {
                        Console.WriteLine(niz[i]);
                        goto kraj;
                    }
                }
            }

            kraj:

            Console.WriteLine(  "*****************");



        }
    }
}
