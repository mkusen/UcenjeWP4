using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E09ForEachPetlja
    {
        public static void Izvedi()
        {
            //foreach je skraćeni for
            //ispiši svaki znak iz riječi jedno ispod drugog

            string rijec = "Osijek";

            for (int i = 0; i < rijec.Length; i++)
            {
                Console.WriteLine(rijec[i]);
            }

            Console.WriteLine("\n********************");

            foreach (var znak in rijec)
            {
                Console.WriteLine(znak);
            }

            Console.WriteLine("\n********************");

            Console.WriteLine("broj: ");
            int a = int.Parse(Console.ReadLine());
            string b  = a.ToString();    
            foreach (var n in b)
            {
                Console.WriteLine(n.ToString());
            }



        }
    }
}
