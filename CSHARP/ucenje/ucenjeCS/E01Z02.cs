
namespace ucenjeCS
{
    internal class E01Z02   
    {
        public static void Izvedi()
        {
            //korisnik će unijeti dvoznamenkasti broj
            //ispisuje se prva znamenka

            int a;
            Console.Write("Unesi dvoznamenkasti broj: ");
            a=int.Parse(Console.ReadLine());    

            Console.WriteLine(a/10);



        }
    }
}
