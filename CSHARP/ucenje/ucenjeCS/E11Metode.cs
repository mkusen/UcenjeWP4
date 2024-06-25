using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E11Metode
    {
        public static void Izvedi()
        {
            //poziv metode Tip1
            //for (int i = 1; i < 56; i++) {
            //    Console.WriteLine("red " + i);
            //    Tip1();
            //}

            //Tip2("edunova");
            //Console.WriteLine("unesi ime: ");
            //string ime = Console.ReadLine();
            //Console.WriteLine("unesi prezime: ");
            //string prezime = Console.ReadLine();
            //Tip2(ime, prezime);



            //for (int i = 0; i < 10; i++)
            //{
            //    int broj = Tip3();
            //    Console.WriteLine(broj);
            //}

            //Console.WriteLine(Tip4(2, 10)); 

            //ispiši sve prim brojeve od dva unesena broja

            int odBroja = Pomocno.UcitajCijeliBroj("unesi od broja");
            int doBroja = Pomocno.UcitajCijeliBroj("unesi do broja");

            for (int i = odBroja; i < doBroja; i++)
            {
                if (primBroj(i)){
                    Console.WriteLine(i);
                }
            }
           
        }

        //tip 1 metoda ne prima i ne vraća vrijednost
        private static void Tip1()
        {
            Console.WriteLine("hello iz metode koja ne prima parametre i ne vraća vrijednost");
            Console.WriteLine("drugi red");
            Console.WriteLine("treći red");
        }

        //tip 2 prima parametar, ali ne vraća vrijednost

        static void Tip2(string ime) {
            Console.WriteLine("Hello {0}", ime);
        }

        static void Tip2(string ime, string prezime)
        {
            Console.WriteLine("hello {0} {1}", ime, prezime);
        }

        //tip 3 metoda ne prima parametre i vraća vrijednost

        static int Tip3()
        {
            return new Random().Next(20,30); 

            //return '7'; //vraća prema ASCII tablici
        }

        //tip 4, prima parametar i vraća vrijednost

        /// <summary>
        /// Metoda za dva primljena cijela broja, vraća zbroj svih brojeva između njih
        /// </summary>
        /// <param name="odBroja">Broj od kojeg se kreće uključujući taj broj</param>
        /// <param name="doBroja">Broj do kojeg se ide uključujući taj broj</param>
        /// <returns>Zbroj brojeva između dva primljena</returns>
        protected static int Tip4(int odBroja, int doBroja) 
        {

            int suma = 0;
            for (int i = odBroja; i <= doBroja; i++)
            {
                suma += 1;
            }

            return suma;
            //throw new NotImplementedException(); može i ovako
        }

        //primjer metode s više return izraza

        static bool primBroj(int broj) 
        {

            for (int i = 2; i < broj; i++)
            {

                if (broj%i==0)
                {
                    return false;
                }


            }


            return true;
        }








    }
}
