using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E18KonzolnaAplikacija
{
    internal class Pomocno
    {
        internal static float? UcitajDecimalniBroj(string poruka, int min, float max)
        {
            float b;
            while (true) {
                try
                {
                    Console.Write(poruka + ": ");

                    b=float.Parse(Console.ReadLine());
                    if(b<min || b > max)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Decimalni broj mora biti u rasponu {0} i {1}", min, max);
                    throw;
                }
            
            }
        }

        internal static int UcitajRasponBroja(string poruka, int min, int max)
        {
            int b;

            while (true) {

                try
                {
                    Console.Write(poruka + ": ");
                    b =int.Parse(Console.ReadLine());  
                    
                    if (b <min || b> max) {
                        throw new Exception();
                    
                    }
                    return  b;
                }
                catch (Exception)
                {

                    Console.WriteLine("unos nije dobar, unos mora biti u rasponu {0} do {1}", min, max);
                }
            
            }

        }

        internal static string UcitajString(string poruka, int max, bool obavezno)
        {
            string s;
            while (true)
            {
                Console.Write(poruka + ": ");
                s= Console.ReadLine().Trim();
                if ((obavezno && s.Length==0 )|| s.Length >max) {
                    Console.WriteLine("Unos obavezan, maksimalno dozvoleno {0} znakova", max);
                    continue;

                }
                return s;
            }
        }
    }
}
