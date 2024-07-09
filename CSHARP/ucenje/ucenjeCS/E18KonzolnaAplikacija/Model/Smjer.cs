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
        public int? Trajanja { get; set; }

        public float? Cijena { get; set; }
        public DateTime? izvodiSeOd { get; set; }
        public bool? Verificiran { get; set; }
    }
}
