using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzabadosDavid
{
    class Program
    {
        static bool Prím(int x)
        {
            for (int i = 2; i <= Math.Abs(x) / 2; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool Páros(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            //Dolgozat: 2016.10.26
            //Minden feladat 5-pontot ér (7 * 5 = 35pont)!
            //0  - 17 -> 1
            //18 - 21 -> 2
            //22 - 25 -> 3
            //26 - 29 -> 4
            //30 - 35 -> 5

            //szum: 29  -> 4


            //A megoldásokat a feladatok utánni sorokba írjad!


            //1. feladat:
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)
            int db;
            do
            {
                Console.WriteLine("Kérlek adj meg egy számot 5 és 10 között!");
                try
                {
                    Console.Write("\nA vektor érték: ");
                    db = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    db = 0;
                }
            } while (db < 5 || db > 10);
            Console.WriteLine();

            //2. feladat: 4p
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!
            const int viktor = 10;
            int[] t = new int[viktor];

            //3. feladat:
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!
            Random rnd = new Random();

            //4. Feladat:
            //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
            //egyjegyű számokkal 1..9-ig!
            for (int i = 0; i < db; i++)
            {
                t[i] = (int)rnd.Next(1, 10);
            }

            //5. feladat:
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;

            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("i{0}->{1}", i, t[i]);
            }
            //5. feladat:
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!
            int páratlanSzum = 0;
            foreach (var i in t)
            {
                if (!Páros(i))
                {
                    páratlanSzum = páratlanSzum + i;
                }
            }
            Console.WriteLine("\nA páratlan számok összege: {0}", páratlanSzum);

            //6. feladat: 2p
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)

            foreach (var i in t)
            {
                if (Prím(i))
                {
                    Console.WriteLine(" egyjegyű prímek: {0}", i);

                }
            }

            //7. feladat: 3p
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!
            bool vanIlyenSzám = false;
            foreach (var i in t)
            {
                if (i == 3)
                {
                    vanIlyenSzám = true;
                    break;
                }
            }

            if (vanIlyenSzám) Console.WriteLine("Van benne 3-as!");
            else Console.WriteLine("Nincs benne 3-as!");
            Console.ReadKey();
        }
    }
}

