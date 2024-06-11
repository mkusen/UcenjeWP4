using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E04UvjetnoGrananjeSwitch
    {
        public static void Izvedi()
        {
            //ako je i = 0 ispiši 1.DOBAR, 2.LOŠ, 3.ZAO
            int i = 0;
            switch (i)
            {
                case 0:
                    Console.WriteLine("dobar");
                    break;
                    case 1: 
                    Console.WriteLine("loš");
                    break;
                    case 2:
                    Console.WriteLine("zao");
                    break;
                    default: 
                    Console.WriteLine("nije definirano");
                    break;
            }

        }
    }
}
