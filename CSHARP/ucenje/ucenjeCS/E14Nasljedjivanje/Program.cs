using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E14Nasljedjivanje
{

    //konstruktor - posebna vrsta metode koja se poziva prilikom kreiranja instance klase - objekta
    //keyword new
    //konstruktor se naziva kao i klasa

    internal class Program
    {

        public Program() {
            Console.WriteLine("Hello world");
            Smjer s=new Smjer();
            s.Naziv = "web programiranje";
            Console.WriteLine(s); //ovdje se poziva metoda .toString na objektu s

            var p = new Polaznik()
            { Ime="Pero", 
            Sifra=1};

            Console.WriteLine(p);
            //apstraktna klasa se ne može instancirati 
            // var e = new Entitet(); //e je instanca klase Entitet

            var sd = new StraniDrzavljanin();
            Obrada[] poslovi = new Obrada[2];
            poslovi[0] = new ObradaIzlazniRacun();
            poslovi[1] = new ObradaUlazniRacun();

            //polimorfizam: predstava - realizacija

            foreach (Obrada o in poslovi)
            {
                o.Procesuiraj(); //polimorfizam
            }
            

        }    
        //za konstruktor vrijedi pravilo method overloading

        public Program(string s) {
            Console.WriteLine(s);

        }
    }
}
