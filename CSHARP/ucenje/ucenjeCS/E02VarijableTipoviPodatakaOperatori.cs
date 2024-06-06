

namespace ucenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {
        public static void Izvedi()
        {
            //deklaracija varijabli
            int broj;

            //dodjeljivanje vrijednosti;
            broj = 7;

            Console.Write("Unesi broj: ");
            broj = int.Parse(Console.ReadLine());

            //korištenje varijabli
            Console.WriteLine(broj + 1);

            Console.Write("Unesi decimalni broj: ");

            decimal db=decimal.Parse(Console.ReadLine());
            Console.WriteLine(db/10);

            //modulo: ostatak nakon cjelobrojnog dijeljenja

            int modulo = 5 % 2;

            Console.WriteLine(modulo);

            int i = 5;
            int j = 3;

            Console.WriteLine(i/(float)j);  //float je cast

            bool logickaVrijednost = true; //SQL bit

            Console.WriteLine(i==j);

            int k = 2, l = 1; //istovjetno linijama 32 i 33

            var ime = "Edunova"; //desna strana određuje tip

            //increment, decrement

            int b = 0;

            //uvećati za 1

            b = b + 1;
            b += 1;
            b++;//3
            ++b;//4

            Console.WriteLine(++b); 
            Console.WriteLine(b++);
            Console.WriteLine(b);
            
            //isto vrijedi za decrement --

            int x=1, y=2;

            x = ++y;
            y = x - --y;

            Console.WriteLine(x+y);



        }
    }
}
