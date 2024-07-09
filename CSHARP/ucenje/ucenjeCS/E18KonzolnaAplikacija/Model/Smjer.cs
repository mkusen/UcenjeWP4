using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E18KonzolnaAplikacija.Model
{
    internal class Smjer: Entitet
    {
        public string? Naziv { get; set; }
        public int? Trajanje { get; set; }

        public float? Cijena { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        public bool? Verificiran { get; set; }

        public override string ToString()
        {
            return "Sifra = " + Sifra + "\nNaziv = " + Naziv + "\nTrajanje = " + Trajanje +
                "\nCijena = " + Cijena  +
                "\nIzvodi se od = " + IzvodiSeOd + "\nVerificiran = " + Verificiran;
        }
    }

   
}
