using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E16GenericiLambdaiEkstenzije
{
    internal class Obrada<T> where T : Entitet
    {

        public T? ObjektObrade { get; set; }

        public List<T>? Lista {  get; set; }

        public void Obradi()
        {
            ObjektObrade?.predstaviSe();
        }

        public void IspisStavaka(Action<T> akcija)
        {
            Lista?.ForEach(s=> akcija(s));
        }

    }
}
