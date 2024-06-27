using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class DZ01CiklicnaTablica
    {

        public static void Izvedi()
        {

            do
            {
                try
                {
                    
                    Console.Write("upiši prvi broj: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("upiši drugi broj: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("prvi broj {0}, drugi broj {1}", a, b);

                    int c = a;
                    int d = b + a;
                    int e = a * b;
                    //određuje broj redova
                    for (int j = 1; j < e; j++)
                    {
                       Console.Write(j++ + "\n");
                    
                    }
                    //određuje broj stupaca
                    //for (int i = 1; i <= a; i++)
                    //{
                    //    Console.Write(c-- + " ");
                    //}


                    Console.WriteLine("");

                }
                catch (Exception e)
                {
                    Console.WriteLine( "nisi upisao broj\n" + e.Message);
                }
            } while (true);
          
        }
    }
}
