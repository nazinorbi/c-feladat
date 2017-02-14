using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4_Eletkor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az életkorát: ");
            int a;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                if (a > 0 && a < 8)
                {
                    Console.WriteLine("Ön gyerek.");
                }
                else if (a > 8 && a < 18)
                {
                    Console.WriteLine("Ön fiatalkorú.");
                }
                else if (a > 18 && a < 60)
                {
                    Console.WriteLine("Ön felnőtt.");
                }
                else if (a > 60 && a < 120)
                {
                    Console.WriteLine("Ön nyugdíjas.");
                }
                else Console.WriteLine("Ön nem létezik.");
            }
            else Console.WriteLine("Ön nem számot adott meg.");

            Console.ReadLine();
        }
    }
}
