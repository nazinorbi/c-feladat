using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Elojel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjon meg egy egész számot: ");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("A szám pozitív.");
            }
            else if(a==0)
            {
                Console.WriteLine("A szám nulla.");
            }
            else Console.WriteLine("A szám negatív.");
            Console.ReadLine();
        }
    }
}
