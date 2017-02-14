using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgóczi_Roland
{
    class Program
    {
        static bool páros(int x)
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

        static bool Prím(int x)
        {
            for (int i = 2; i <= (x / 2); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
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

            //szum: 32p -> 5

            //A megoldásokat a feladatok utánni sorokba írjad!

            //1. feladat:
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)
            int n = 0;
            do
            {
                Console.Write("Kérem a vektor méretét (5-10): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 5 || n > 10);
            //2. feladat:
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!
            int[] Viktor = new int[n];
            Viktor = new int[n];
            //3. feladat:
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!
            Random rnd = new Random();

            //4. Feladat:
            //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
            //egyjegyű számokkal 1..9-ig!
            for (int i = 0; i < Viktor.Length; i++)
            {
                Viktor[i] = rnd.Next(1, 10);
            }

            //5. feladat:
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;
            for (int i = 0; i < n; i++)

            {
                Console.Write("i[{0}]={1}; ", i, Viktor[i]);
            }

            //5. feladat:
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!
            int dbpáratlan = 0;
            foreach (var i in Viktor)
            {
                if (!páros(i))
                {
                    dbpáratlan = dbpáratlan + i;

                }

            }
            Console.WriteLine();
            Console.WriteLine("\nA páratlan számok összege: {0}", dbpáratlan);

            //6. feladat:
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)
            int db = 0;
            foreach (var i in Viktor)
            {
                if (!Prím(i)) db++;
                               
            }
            Console.WriteLine("\nA prímek darabszáma: {0}",db);


            //7. feladat: 2p
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!

            foreach (var i in Viktor)
            {
                if (i < 3)
                {

                    Console.WriteLine("\nVan 3-nál kisebb elem!!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nNincs 3-nál kisebb szám!!");
                    break;
                }
            }




            Console.ReadKey();
        }
    }
}
