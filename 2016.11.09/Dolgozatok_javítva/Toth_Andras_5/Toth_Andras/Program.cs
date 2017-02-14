using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toth_Andras
{
    class Program
    {
        private static bool Paros(int x)
        {
            return x % 2 == 0;
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

            //szum: 33p -> 5
            //A megoldásokat a feladatok utánni sorokba írjad!


            //1. feladat: 5p
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)
            const int min = 5;
            const int max = 10;

            int elementsCountOfArray;

            do
            {
                Console.Write("Add meg a tömb elemeinek számát (5 - 10): ");

                elementsCountOfArray = int.Parse(Console.ReadLine());
            } while (elementsCountOfArray < min || elementsCountOfArray > max);


            //2. feladat: 5p
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!
            int[] viktor = new int[elementsCountOfArray];

            //3. feladat: 5p
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!
            Random rnd = new Random();

            //4. Feladat: 5p
            //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
            //egyjegyű számokkal 1..9-ig!
            const int rndMin = 1;
            const int rndMax = 10;

            for (int i = 0; i < elementsCountOfArray; i++)
            {
                viktor[i] = rnd.Next(rndMin, rndMax);
            }

            //5. feladat: 5p
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;
            Console.WriteLine();

            Console.Write("viktor:");

            for (int i = elementsCountOfArray - 1; i >= 0; i--)
            {
                Console.Write(" i{0}->{1};", i, viktor[i]);
            }

            Console.WriteLine();

            //5. feladat: 5p
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!
            int sum = 0;

            foreach (int element in viktor)
            {
                if (!Paros(element)) sum += element;  //Paros fuggveny feljebb talalhato
            }

            Console.WriteLine("\nPáratlan számok összege: {0}", sum);

            //6. feladat: 5p
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)
            int primeElements = 0;

            foreach (int element in viktor)
            {
                switch (element)
                {
                    case 2:
                        primeElements++;
                        break;
                    case 3:
                        primeElements++;
                        break;
                    case 5:
                        primeElements++;
                        break;
                    case 7:
                        primeElements++;
                        break;
                }
            }

            Console.WriteLine("\nPrím számok darabszáma: {0}", primeElements);

            //7. feladat: 3p
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!
            const int number = 3;

            foreach (int element in viktor)
            {
                if (element < number)
                {
                    Console.WriteLine("\nVan {0}-nál kisebb szám a vektorban: {1}", number, element);
                    break;
                }
            }

            Console.WriteLine("\nNyomj meg egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
