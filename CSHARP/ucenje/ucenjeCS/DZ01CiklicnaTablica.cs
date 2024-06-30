using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;



namespace ucenjeCS
{
    internal class DZ01CiklicnaTablica
    {

        public static void Matrix1()
        {

            try
            {

                Console.Write("upiši prvi broj: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("upiši drugi broj: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("broj redova je {0}, broj stupaca je {1}", a, b);

                Console.WriteLine("***************\nmoj kod \n***************");

                int numA = a;
                int numB = b * a;
                //određuje broj redova
                for (int i = 1; i <= a; i++)
                {
                    Console.Write(numA-- + " ");
                    Console.Write("");
                    //određuje broj stupaca
                    for (int j = 1; j < b; j++)
                    {
                        Console.Write(numB-- + " ");
                    }
                    Console.WriteLine();
                }

                Matrix2();

            }
            catch (Exception e)
            {
                Console.WriteLine("nisi upisao broj\n" + e.Message);
            }


        }


        public static void Matrix2()
        {


            try
            {



                Console.Write("upiši prvi broj: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("upiši drugi broj: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("broj redova je {0}, broj stupaca je {1}", a, b);

                Console.WriteLine("***************\nkod s copilot-a \n***************");

                int numLine = a;
                int numColunm = b;

                int[,] table = new int[numLine, numColunm];
                int maxValue = numLine * numColunm;

                //popunjavanje tablice brojevima od najvećeg prema najmanjem
                for (int i = 0; i < numLine; i++)
                {

                    for (int j = 0; j < numColunm; j++)
                    {
                        table[i, j] = maxValue--;
                    }

                }

                //ispis tablice
                for (int i = 0; i < numLine; i++)
                {
                    for (int j = 0; j < numColunm; j++)
                    {
                        Console.Write(table[i, j] + " ");
                    }
                    Console.WriteLine();
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("nisi upisao broj\n" + e.Message);
            }


        }
    }
}
