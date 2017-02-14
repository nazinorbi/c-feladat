using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thury_Katalin
{
    class Program
    {
        static bool smallAs3(int x)
        {
            if (x < 3)
            {
                return true;
            }
            return false;
        }
        static bool primSzám(int x)
        {
            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool páros(int x)
        {
            if (x%2==0)
            {
                return true;
            } return false;
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

            //szum: 34p -> 5

            //A megoldásokat a feladatok utánni sorokba írjad!


            //1. feladat:
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)
            int elemSzám;
            do
            {
                try
                {
                    Console.WriteLine("Kérem adjon meg egy számot 5 és 10 között!");
                    Console.Write("\nA megadott szám:");
                    elemSzám = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    elemSzám = 0;
                }
            } while (elemSzám < 5 || elemSzám > 10);
            Console.WriteLine();

            //2. feladat:
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!
            int[] viktor= new int[elemSzám];

            //3. feladat:
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!
            Random rnd = new Random();

            //4. Feladat:
            //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
            //egyjegyű számokkal 1..9-ig!
            for (int i = 0; i < elemSzám; i++)
            {
                viktor[i] = rnd.Next(1, 10);
            }


            //5. feladat:
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;
            for (int i = elemSzám-1; i >= 0; i--)
            {
                Console.Write("i{0}->{1}; ", i, viktor[i]);
            }
            Console.WriteLine();
            //5. feladat:
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!
            int páratlanSzum = 0;
            foreach (var i in viktor)
            {
                if (!(páros(i)))
                {
                    páratlanSzum = páratlanSzum + i;
                }
            }
            Console.WriteLine("\nA páratlan számok összege:{0}",páratlanSzum);

            //6. feladat:
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)
            int primDb = 0;
            foreach (var i in viktor)
            {
                if (primSzám(i)) primDb++;
            }
            Console.WriteLine("\nA vektorban {0} db prímszám található!", primDb);

            //7. feladat: 4p
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!
            foreach (var i in viktor)
            {
                if (smallAs3(i))
                {
                    Console.WriteLine("\nA vektorban található 3-nál kisebb szám, mely értéke:{0}",i);
                    break;
                }
                
            }

            Console.ReadKey();
        }
    }
}
