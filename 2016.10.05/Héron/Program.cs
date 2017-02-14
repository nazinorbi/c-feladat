using System;

namespace Héron
{
    class Program
    {
        static void Main()
        {
            //Háromszög területe és kereülete
            //K=a+b+c
            //s=K/2
            //T=Gyök(s*(s-a)*(s-b)*(s-c))

            //1.feladat:
            //Írjuk ki mit csinál a program
            Console.WriteLine("Háromszög területe és kerülete Héron képletével");
            //2.feladat:
            //Adatbevitel
            //a>0 és b>0 és c>0
            //Megszerkeszthető: a+b>c és a+c>b és b+c>a
            //Ha a feltételek nem teljesülnek, akkor
            //kérjük be újra az oldalakat
            double a;
            double b;
            double c;
            do
            {
                Console.Write("a=");
                a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                b = double.Parse(Console.ReadLine());
                Console.Write("c=");
                c = double.Parse(Console.ReadLine());
                //Mikor kell megismételni?
            } while (a <= 0 || b <= 0 || c <= 0 
            || a + b <= c || a + c <= b || b + c <= a);

            //Vagy:
            //Mikor jók az adatok?
            //while (!(a>0 && b>0 && c>0 && a+b>c && a+c>b && b+c>a));
            //Itt viszont tagadni kell, met ha True (jó), akkor
            //ne ismételjen!

            //3.feladat:
            //Számítás: K, s, T
            double K = a + b + c;
            double s = K / 2;
            double T = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            //4.feladat:
            //Eredmények kiírása
            Console.WriteLine("K={0}", K);
            Console.WriteLine("T={0}", T);
            Console.ReadKey();

            //Terület ellenőrzés Pitagoraszi számhármasokkal:
            //3 4  5
            //5 12 13
            //7 24 25
            //8 15 17
            //9 40 41
        }
    }
}
