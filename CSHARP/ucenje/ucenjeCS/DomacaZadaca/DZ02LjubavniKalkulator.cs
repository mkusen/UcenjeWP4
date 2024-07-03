using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.DomacaZadaca
{
    internal class DZ02LjubavniKalkulator
    {
        public static void LjubavniKalk()
        {

            Console.Write("upiši prvo ime: ");
            var imePrvo=Console.ReadLine();

            Console.Write("upiši drugo ime: ");
            var imeDrugo = Console.ReadLine();

            var brojPrvi=0; 
            string[] nizImePrvo = new string[imePrvo.Length];

            var brojDrugi=0;
            string[] nizImeDrugo = new string[imeDrugo.Length];

            for (var i = 0; i < imePrvo.Length; i++)
            {
                brojPrvi++; 
                nizImePrvo[i] = imePrvo[i].ToString(); // ubacuje slova u niz
                Console.WriteLine($"Character {brojPrvi}: {nizImePrvo[i]}");
            }

            for (var j  = 0; j < imeDrugo.Length; j++)
            {
                brojDrugi++;
                nizImeDrugo[j] = imeDrugo[j].ToString(); // ubacuje slova u niz
                Console.WriteLine($"Character {brojDrugi}: {nizImeDrugo[j]}");
            }

        }
    }
}
