
namespace ucenjeCS
{
    internal class E01Z01
    {
        public static void Izvedi()
        {
            //korisnik unosi dva cijela broja i ispisuje njihov zbroj

            int a, b;
            Console.Write("Unesi prvi broj: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi broj: ");           
            b=int.Parse(Console.ReadLine());

            int c = a + b;

            Console.WriteLine("Zbroj unesenih brojeva je: " + c);

        }
    }
}
