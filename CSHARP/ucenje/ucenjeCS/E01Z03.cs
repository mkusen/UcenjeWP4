
using System.Linq.Expressions;

namespace ucenjeCS
{
    internal class E01Z03   
    {
        public static void Izvedi()
        {
            //za uneseni cijeli broj ispisati TRUE ako je parni ili FALSE ako je neparni
                      
            try
            {
                Console.Write("Upiši cijeli broj: ");
                int a = int.Parse(Console.ReadLine());
                if ((a % 2) == 0)
                {
                    Console.WriteLine("TRUE - upisani broj " + a + " je paran broj");
                }
                else
                {
                    Console.WriteLine("FALSE - upisani broj " + a + " je neparan broj");
                }
            }
            catch 
            {
                Console.WriteLine("Greška. Nije upisan cijeli broj!4");
            }
                
        }
    }
}
