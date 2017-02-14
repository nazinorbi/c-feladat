using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6_DolgozatSzazalek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az elért pontszámot: ");
            int elert, max;
            double szazalek;
            if (int.TryParse(Console.ReadLine(), out elert))
            {
                Console.Write("Adja meg a max pontszámot: ");
                if (int.TryParse(Console.ReadLine(), out max))
                {
                    szazalek = (double)elert / (double)max * 100;
                    if (szazalek < 50)
                    {
                        Console.WriteLine("Elégtelen.");
                    }
                    else if (szazalek < 60)
                    {
                        Console.WriteLine("Elégséges.");
                    }
                    else if (szazalek < 70)
                    {
                        Console.WriteLine("Közepes.");
                    }
                    else if (szazalek < 80)
                    {
                        Console.WriteLine("Jó.");
                    }
                    else Console.WriteLine("Kitűnő.");

                    Console.WriteLine("Elért százalék: {0}", szazalek);
                }
                else Console.WriteLine("Ön nem számot adott meg.");
            }
            else Console.WriteLine("Ön nem számot adott meg.");

            Console.ReadLine();
        }
    }
}
