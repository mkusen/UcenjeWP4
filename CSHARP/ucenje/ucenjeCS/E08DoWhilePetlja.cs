﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS
{
    internal class E08DoWhilePetlja
    {
        public static void Izvedi()
        {
            //do while izdvaja činjenica da će se on barem jednom izvesti

            int i =0;

            do 
            {
                Console.WriteLine(i);
            } 
            while (i > 0);  
        }
    }
}
