using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_Paritas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjon meg egy egész számot: ");
            int a;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                if (a % 2 == 1)
                {
                    Console.WriteLine("A szám páratlan.");
                }
                else Console.WriteLine("A szám páros.");
            }
            else Console.WriteLine("Nem egész számot adott meg.");

            Console.ReadLine();
        }
    }
}
