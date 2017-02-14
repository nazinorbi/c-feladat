using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5_TesttomegIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a magasságát méterben: ");
            int tomeg;
            double magassag;
            double BMI;
            if (double.TryParse(Console.ReadLine(), out magassag) && magassag > 0)
            {
                Console.Write("Adja meg a testtömegét: ");
                if (int.TryParse(Console.ReadLine(), out tomeg) && tomeg > 0)
                {
                    BMI = (tomeg / (magassag * magassag));
                    if (BMI < 16)
                    {
                        Console.WriteLine("Ön kórosan sovány. {0}", BMI);
                    }
                    else if (BMI < 17)
                    {
                        Console.WriteLine("Ön mérsékelt sovány.{0}", BMI);
                    }
                    else if (BMI < 18.5)
                    {
                        Console.WriteLine("Ön enyhén sovány.{0}", BMI);
                    }
                    else if (BMI < 25)
                    {
                        Console.WriteLine("Ön normális.{0}", BMI);
                    }
                    else if (BMI < 30)
                    {
                        Console.WriteLine("Ön túlsúlyos.{0}", BMI);
                    }
                    else if (BMI < 35)
                    {
                        Console.WriteLine("I. fokú elhízés.{0}", BMI);
                    }
                    else if (BMI < 40)
                    {
                        Console.WriteLine("II. fokú elhízás.{0}", BMI);
                    }
                    else Console.WriteLine("III. fokú elhízás.{0}", BMI);
                }
                else Console.WriteLine("Ön nem pozitív számot vagy nem számot adott meg.");
            }
            else Console.WriteLine("Ön nem pozitív számot vagy nem számot adott meg.");
            Console.ReadLine();
        }
    }
}
