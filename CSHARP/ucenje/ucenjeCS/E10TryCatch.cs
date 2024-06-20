using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E10TryCatch
    {
        public static void Izvedi()
        {

            int i;

            while (true) {
                Console.Write("unesi cijeli pozitivni broj: ");
                try
            {
               
                i = int.Parse(Console.ReadLine());
                    if (i > 0 && i<100)
                    {
                        break;
                    }

                    Console.WriteLine("uneseni broj nije veći od 0 i manji od 100");
                }
            catch (Exception e)
            {

                Console.WriteLine("nisi unio broj\n" + e.ToString);
            }
               
            }
            Console.WriteLine("unio si: " + i);
        }
    }
}
