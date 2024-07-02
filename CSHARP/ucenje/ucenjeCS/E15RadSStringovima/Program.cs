using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenjeCS.E15RadSStringovima
{
    internal class Program
    {

        //konstruktor
        public Program() 
        {
            //string je immutable - nepromjenjiv
            var s = "Edunova";
            Console.WriteLine(s.GetHashCode() + " " + s);

            s = "Osijek";

            Console.WriteLine(s.GetHashCode() + " " + s);

            var sb=new StringBuilder();

            sb.AppendLine("Edunova");
            sb.Clear();
            sb.AppendLine("Osijek");
            Console.WriteLine(s.GetHashCode() + " " + sb);

            //u radu s stringovima se preporuča koristiti StringBuilder klasu

            sb=new StringBuilder();
            sb.Append('a');
            sb.Append("b");
            sb.Append('c');

            Console.WriteLine(sb);

            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            s = "Osijek";
            Console.WriteLine(s.Substring(1,2 ));
            s = "    ana marija";
            Console.WriteLine(">{0}<", s);
            Console.WriteLine(">{0}<", s.Trim());
            Console.WriteLine(s.Replace('a','b'));
            //veliko A zamijenio s malim b
            Console.WriteLine(s.Replace("a","b",true,CultureInfo.CurrentCulture));

            

        }    

    }
}
