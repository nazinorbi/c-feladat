using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_KisebbNagyobb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az A egész számot: ");
            int a, b;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                //if (a > 0)        //Szám A pozitív(Be se kéri B-t)
                //{
                    Console.Write("Adja meg a B egész számot: ");
                    if (int.TryParse(Console.ReadLine(), out b))
                    {
                        //if (b > 0)        //Szám B pozitív
                        //{
                            if (a > 0 && b > 0)     //Mind a kettő szám pozitív
                            {
                                if (a > b)
                                {
                                    Console.WriteLine("Az A szám nagyobb.");
                                }
                                if (a < b)
                                {
                                    Console.WriteLine("A B szám nagyobb.");
                                }
                                if (a == b)
                                {
                                    Console.WriteLine("A két szám egyenlő.");
                                }
                            }
                        //}
                        else Console.WriteLine("Pozitív egész számot kérek.");
                    }
                    else Console.WriteLine("Nem egész számot adott meg.");
                //}
                //else Console.WriteLine("Pozitív egész számot kérek.");
            }
            else Console.WriteLine("Nem egész számot adott meg.");

            Console.ReadLine();
        }
    }
}
