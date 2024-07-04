﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E16GenericiLambdaiEkstenzije
{
    internal static class Ekstenzije
    {
        public static void OdradiPosao(this ISucelje sucelje)
        {
            Console.WriteLine("Krećem");
            sucelje.Posao();    
            Console.WriteLine("Završio");
        }
    }
}
