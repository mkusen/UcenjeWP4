using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class Pomocno
    {
        public static int UcitajCijeliBroj(){

            while (true)
            {
                try
                {
                    Console.Write("unesi cijeli broj: ");
                    return int.Parse(Console.ReadLine());   
                }
                catch (Exception)
                {
                    Console.WriteLine("pogreška prilikom unosa");
                }
            }
                    
        }

        public static int UcitajCijeliBroj(string poruka)
        {

            while (true)
            {
                try
                {
                    Console.Write(poruka + ": ");
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("pogreška prilikom unosa");
                }
            }

        }

    }
}
