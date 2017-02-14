using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_Haromszog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az A oldalt: ");
            int a, b, c;
            if (int.TryParse(Console.ReadLine(), out a) && a > 0)
            {
                Console.Write("Adja meg a B oldalt: ");
                if (int.TryParse(Console.ReadLine(), out b) && b > 0)
                {
                    Console.Write("Adja meg a C oldalt: ");
                    if (int.TryParse(Console.ReadLine(), out c) && c > 0)
                    {
                        if ((a + b) > c && (a + c) > b && (b + c) > a)
                        {
                            Console.WriteLine("A háromszög szerkeszthető.");
                        }
                        else Console.WriteLine("A háromszög nem szerkeszthető.");
                    }
                    else Console.WriteLine("Ön nem számot vagy nem pozitív számot adott meg.");
                }
                else Console.WriteLine("Ön nem számot vagy nem pozitív számot adott meg.");
            }
            else Console.WriteLine("Ön nem számot vagy nem pozitív számot adott meg.");

            Console.ReadLine();
        }
    }
}
