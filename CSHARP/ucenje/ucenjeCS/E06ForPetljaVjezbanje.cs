using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ucenjeCS
{
    internal class E06ForPetljaVjezbanje
    {
        public static void Izvedi()
        {          

            //metoda vraća podatak koji se nalazi na indexu jednakom unosu korisnika
            System.Console.WriteLine("Vjezbanje for loop");

            Console.Write("upiši broj: ");

            do
      
            {
                try
                {
                    int a = int.Parse(Console.ReadLine());

                    for (int i = 0; i < PodaciInt.niz.Length; i++)
                    {

                        if (i == a)
                        {
                            Console.WriteLine("ispisujem uneseni broj: " + a + "\nna tom mjestu nalazi se: " + PodaciInt.niz[i]);
                            break;
                        }
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("broj nije upisan, molim upiši broj");

                }


            } while (true);
          

            
        }

        public static void NadjiIsteBrojeve()
        {
            //metoda traži i prikazuje jednake brojeve u array-u

            var startTime = DateTime.Now;
            Console.WriteLine("program je počeo u: " + startTime);

            var a = PodaciInt.niz.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y =>  y.Key)
              .ToList();

            foreach (var b in a)
            {
                Console.WriteLine("broj koji se pojavljuje više od jednom: " + b);
               var endTime=DateTime.Now;
                Console.WriteLine("program je završio u: " + endTime);
                Console.WriteLine("program se izvodio: " + (endTime-startTime));
                
            }

        }


        public static void multiplicationTable()
        {

            do
            {
                try
                {
                    Console.Write("upiši prvi broj: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("upiši drugi broj: ");
                    int b = int.Parse(Console.ReadLine());
                    
                    for (int i = 1; i <= a; i++)
                    {
                        if (i <=a)
                        {
                            Console.Write(i + " ");

                        }if (i 
                            ==a)
                        {
                            Console.Write("\n" + (i * a) + " ");


                        }







                    }
                    Console.WriteLine("");
                    for (int j = 1; j <= b; j++)
                    {
                        //Console.Write((j * b) + " ");
                    }
                    Console.WriteLine("");
                }
                catch (Exception)
                {
                    Console.WriteLine("nisi upisao broj! molim, upiši broj");
                }

            } while (true);
               
           
        }
    }
}
