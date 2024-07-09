using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ucenjeCS.DomacaZadaca
{
    internal class DZ02LjubavniKalkulator
    {
        public static void LjubavniKalk()
        {

            Console.Write("upiši prvo ime: ");
            var imePrvo = Console.ReadLine();

            Console.Write("upiši drugo ime: ");
            var imeDrugo = Console.ReadLine();

            var obaImena = imePrvo + imeDrugo;
            List<string> listObaImena = new List<string>();

            listObaImena.Add(obaImena);
            



        }
    }
}
