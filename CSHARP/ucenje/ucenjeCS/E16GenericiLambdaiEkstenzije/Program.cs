using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ucenjeCS.E16GenericiLambdaiEkstenzije
{
    internal class Program
    {
        public Program() 
        {
            //problem nizova: unaprijed moramo znati koliko će imati elemenata
            //u nastavku nastave i u stavrnom životu koristiti ćemo liste (list)
            //generička lista cijelih brojeva (int)
            List<int> brojevi = new List<int>();

            brojevi.Add(1);
            brojevi.Add(2);

            Console.WriteLine(brojevi[0]);

            foreach(int i in brojevi)
            {
                Console.WriteLine(i);
            }

            List<string> imena = new List<string>();
            imena.Add("Pero");
            imena.Add("Marko");
            imena.Add("Ivo");
            imena.Add("Đuro");

            //functional programing

            imena.ForEach(Console.WriteLine);

            List<Smjer> smjerovi = new List<Smjer>();

            smjerovi.Add(new() { Sifra = 1, Naziv = "Web programiranje" });

            smjerovi.ForEach(Console.WriteLine);

            Obrada < Smjer > os = new Obrada<Smjer>();

            os.ObjektObrade = smjerovi[0];
            os.Obradi();

            Obrada<Polaznik> op = new Obrada<Polaznik>();

            op.ObjektObrade = new() { Sifra = 1, Ime = "Marko", Prezime = "Perić" };
            op.Obradi();


            //Lambda expressions
            //klasika
            Console.WriteLine(KlasicnaMetoda(2,2));

            var Zbroj = (int a, int b) => a + b;

            Console.WriteLine(Zbroj(2,2));

            var algoritam = (int x, int y) => 
            {
                var t = ++x-y; return t+y; 
            };
            Console.WriteLine(algoritam(2,2));
            Console.WriteLine(algoritam(1,1));

            //ekstenzije
            //smjerovi[0].OdradiPosao();
            Smjer s =new Smjer();
            s.Naziv = "WP";
            s.OdradiPosao();

            smjerovi.Add(new() { Sifra = 2, Naziv = "Java programiranje" });

            smjerovi.ForEach(Console.WriteLine);
            smjerovi.Sort();
            Console.WriteLine("***************");
            smjerovi.ForEach(Console.WriteLine);

            os.Lista = smjerovi;
            os.IspisStavaka(mojIspis);

            os.IspisStavaka(drugaMetoda);

            os.IspisStavaka((s) => {
                Console.WriteLine("nisam znao nazvati metodu");
            });

        }

        private void drugaMetoda (Smjer smjer)
        {
            Console.WriteLine(smjer.Sifra);
        }
        private void mojIspis (Smjer s)
        {
            Console.WriteLine("Prilagođeni ispis " + s.Naziv);
        }

        private int KlasicnaMetoda(int a, int b)
        {
            return a + b;
        }
    }
}
