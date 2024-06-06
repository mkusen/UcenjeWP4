
namespace ucenjeCS
{
    internal class E01Z03   
    {
        public static void Izvedi()
        {
            //za uneseni cijeli broj ispisati TRUE ako je parni ili FALSE ako je neparni

            int a;
            Console.Write("Unesi cijeli broj: ");
            a=int.Parse(Console.ReadLine());

            int modulo = a % 2;

            Console.WriteLine(modulo);



        }
    }
}
