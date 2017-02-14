using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga1
{
    class Program
    {
        static void Main()
        {
            int elemszam = feladat1();

            feladat2(elemszam);
        }

        static int feladat1() {

            int elemkeszama = beker();

            if(elemkeszama >= 5  && elemkeszama < 10) {
                int[] elemszam = new int[elemkeszama];
               
            } else {
                Console.WriteLine("Az elemek szám a 5 és 10 közötti lehet");
                feladat1();
  
            }
            return elemkeszama;
            Console.ReadKey();
        }

        static void feladat2(int elemszam) {

            int[] viktor = new int[elemszam];
        }

        static int beker()
        {
            Console.WriteLine("kérem az elemek számát");
            return int.Parse(Console.ReadLine());
        }
    }
}
