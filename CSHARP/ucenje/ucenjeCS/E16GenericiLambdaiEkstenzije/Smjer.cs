using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E16GenericiLambdaiEkstenzije
{
    internal class Smjer: Entitet, ISucelje, IComparable<Smjer> 
    {
      
        public string? Naziv { get; set; }

        public int CompareTo(Smjer? other)
        {
            return Naziv?.CompareTo(other?.Naziv) ?? 0;
        }

        public void Posao()
        {
            Console.WriteLine("Radim na klasi smjer, naziv je: " + Naziv);
        }

        public override void predstaviSe()
        {
            Console.WriteLine(Sifra + " " + Naziv);
        }

        public override string ToString()
        {
           // return Sifra + " " + Naziv;

            return new StringBuilder().Append(Sifra).Append(" - ").Append(Naziv).ToString();
        }
    }
}
