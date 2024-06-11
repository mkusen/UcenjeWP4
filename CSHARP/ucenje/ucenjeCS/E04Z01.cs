using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E04Z01
    {
        public static void Izvedi()
        {
            //korisnik unosi brojčani iznos ocjene
            Console.Write("unesi ocjenu: ");            
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Write("ocjena nedovoljan");
                    break;
                case 2:
                    Console.Write("ocjena dovoljan");
                    break;
                case 3:
                    Console.WriteLine("ocjena dobar");
                    break;
                case 4:
                    Console.WriteLine("ocjena vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("ocjena odličan");
                    break;
                default:
                    Console.WriteLine("nije ocjena");
                        break;
            }
        }
    }
}
