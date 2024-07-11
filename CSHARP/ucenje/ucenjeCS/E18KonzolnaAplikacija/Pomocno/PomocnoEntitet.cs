using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E18KonzolnaAplikacija.Pomocno
{
    internal abstract class PomocnoEntitet
    {

        public ObradaSmjer obradaSmjer { get; set; }
        public ObradaPolaznik obradaPolaznik { get; set; }
        public ObradaGrupa obradaGrupa { get; set; }

        public PomocnoIzbornik pomocnoIzbornik { get; set; }

    }
}
