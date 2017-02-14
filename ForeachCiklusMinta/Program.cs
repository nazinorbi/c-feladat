using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8_MennyiANagyobb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az A számot: ");
            int a, b, c;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Adja meg a B számot: ");
                if (int.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("Adja meg a C számot: ");
                    if (int.TryParse(Console.ReadLine(), out c))
                    {
                        valami();

                        if (a > b && b > c)
                        {
                            Console.WriteLine("Sorrend: {0} > {1} > {2}", a, b, c);
                            Console.WriteLine("A legnagyobb szám: {0}", a);
                        }
                        else if (a > c && c > b)
                        {
                            Console.WriteLine("Sorrend: {0} > {1} > {2}", a, c, b);
                            Console.WriteLine("A legnagyobb szám: {0}", a);
                        }
                        else if (b > a && a > c)
                        {
                            Console.WriteLine("Sorrend: {0} > {1} > {2}", b, a, c);
                            Console.WriteLine("A legnagyobb szám: {0}", b);
                        }
                        else if (b > c && c > a)
                        {
                            Console.WriteLine("Sorrend: {0} > {1} > {2}", b, c, a);
                            Console.WriteLine("A legnagyobb szám: {0}", b);
                        }
                        else if (c > a && a > b)
                        {
                            Console.WriteLine("Sorrend: {0} > {1} > {2}", c, a, b);
                            Console.WriteLine("A legnagyobb szám: {0}", c);
                        }
                        else if (c > b && b > a)
                        {
                            Console.WriteLine("Sorrend: {0} > {1} > {2}", c, b, a);
                            Console.WriteLine("A legnagyobb szám: {0}", c);
                        }
                        else if (a == b && a > c)
                        {
                            Console.WriteLine("Nem eldönthető melyik a legnagyobb szám.");
                        }
                        else if (a == c && a > b)
                        {
                            Console.WriteLine("Nem eldönthető melyik a legnagyobb szám.");
                        }
                        else if (b == c && b > a)
                        {
                            Console.WriteLine("Nem eldönthető melyik a legnagyobb szám.");
                        }
                        else if (a == b && a < c)
                        {
                            Console.WriteLine("A legnagyobb szám: {0}", c);
                        }
                        else if (a == c && a < b)
                        {
                            Console.WriteLine("A legnagyobb szám: {0}", b);
                        }
                        else if (b == c && b < a)
                        {
                            Console.WriteLine("A legnagyobb szám: {0}", a);
                        }
                        else if (a == b && b == c)
                        {
                            Console.WriteLine("A három szám egyenlő.");
                        }
                    }
                }
            }
            Console.ReadLine();
        }

        static function valami()
        {
            int a = 5;
            int b = 54;

            return a * b;
        }
    }
}
