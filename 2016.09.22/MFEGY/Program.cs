using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEGY
{
    class Program
    {
       
        static void Main()
        {
            Console.WriteLine("Másodfokú egyenlet gyökei");
            Console.WriteLine("Kérem az együtthatókat!");
            double a = BekérEgyüttható("a");
            double b = BekérEgyüttható("b");
            double c = BekérEgyüttható("c");

            if (a != 0)
            {
                //Diszkrimináns
                //double d = b * b - 4 * a * c;
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0) Console.WriteLine("Nincs megoldás!");
                if (d==0)
                {
                    Console.WriteLine("Egy megoldás!");
                    double x1 = -b / (2 * a);
                    Console.WriteLine("x1=" + x1);
                }
                if (d>0)
                {
                    Console.WriteLine("Két megoldás!");
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("x1=" + x1);
                    Console.WriteLine("x2=" + x2);
                }
            }
            else
            {
                Console.WriteLine("Nem másodfokú!");
            }

            Console.ReadKey();
        }

        static double BekérEgyüttható(string egyutthatoNeve)
        {
            Console.Write(egyutthatoNeve + "= ");
            string input = Console.ReadLine();
            return double.Parse(input);
        }
    }
}
