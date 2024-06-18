using System;
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

        ponovi:
            try
            {
                Console.Write("upiši broj: ");
                int a = int.Parse(Console.ReadLine());
                for (int i = 0; i < PodaciInt.niz.Length; i++)
                {

                    if (i == a)
                    {                           
                        Console.WriteLine("ispisujem uneseni broj: " + a + "\nna tom mjestu nalazi se: " + PodaciInt.niz[i]);
                        break;
                    }


                }
                goto ponovi;
            }
            catch (Exception)
            {
                Console.WriteLine("broj nije upisan, molim upiši broj");
               
            }

            goto ponovi;
            
        }

        public static void NadjiIsteBrojeve()
        {
            //metoda traži i prikazuje jednake brojeve u array-u
            var hashSet = new HashSet<int>();
            for (int i = 0; i < PodaciInt.niz.Length; i++)
            {
               
                int count = 0;
                for (int j = 0; j < PodaciInt.niz.Length; j++)
                    if (PodaciInt.niz[i] == PodaciInt.niz[j])
                    {
                        count++;
                     
                        if (hashSet.Add(PodaciInt.niz[i]))
                        {

                          if(i%100 == 0)
                            {
                                Console.WriteLine("obrađeno: " + i);
                            }
                            
                            if (count > 1)
                            {
                                Console.WriteLine(PodaciInt.niz[i]);
                            }
                        }
                    
                    }

            }
        }
    }
}
