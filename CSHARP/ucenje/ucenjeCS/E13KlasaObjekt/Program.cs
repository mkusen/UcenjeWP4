using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E13KlasaObjekt
{

    internal class Program
    {
        public static void Izvedi()
        {
            //objekt je instanca (pojavnost) klase
            //Osoba je klasa
            //osoba je instanca klase (objekt, varijabla)
            Osoba osoba = new Osoba();
            osoba.Ime = "Pero"; //DZ napraviti metodu Pomocno.UcitajString koja osigurava unos
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.ImePrezime());

            Osoba ravnatelj = new Osoba
            {
                Ime = "Eduard",
                Prezime = "Kuzma"
            };

            var direktor = new Osoba { Prezime = "Kas" };
            //
            Console.WriteLine(direktor.Ime?.ToUpper());

            Osoba o = new()
            {
                Ime = "Ana",
                Prezime = "Kiš"
            };

            o.Mjesto = new() { PostanskiBroj = "31000", Zupanija=new() { Drzava = new() { Naziv = "Hrvatska" } } };

            Console.WriteLine(o.Mjesto?.Naziv?.ToUpper());

            Console.WriteLine(o.Mjesto?.Naziv ?? "Nema");
            Console.WriteLine(o.Mjesto?.Zupanija?.Drzava?.Naziv ?? "ne znam");

        }
    }
}



  

