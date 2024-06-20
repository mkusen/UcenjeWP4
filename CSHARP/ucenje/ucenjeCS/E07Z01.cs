using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E07Z01
    {
        public static void Izvedi()
        {
            Console.Write("upisi broj: ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("upisao si: "+a);
            int i = 1;
            int b= a % 2;

            while (i <=a)
            {
                if(b == 0)
                {
                    i++;
                    Console.WriteLine(i);
                }
            }

        }

    }
}
