using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bálint_Mátyás
{
    class Program
    {
        static bool Páratlan(int x)
        {
            return x % 2 == 1;
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


            //Szum: 20p -> 2

            //A megoldásokat a feladatok utánni sorokba írjad!


            //1. feladat: 0p
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)



            //2. feladat: 5p
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!
            const int szám = 5;
            int[] viktor = new int[szám];


            //3. feladat: 5p
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!

            Random rnd = new Random();


            //4. Feladat: 5p
            //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
            //egyjegyű számokkal 1..9-ig!

            for (int i = 0; i < szám; i++)
            {
                viktor[i] = rnd.Next(1, 10);
            }

            //5. feladat: 3p
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;

            Console.Write("viktor[0..{0}]={{",szám);
            for (int i =0; i < szám; i++)
            {
                if (i < szám )
                {
                    Console.WriteLine("{0};", viktor[i]);

                }
                else
                {
                    Console.WriteLine("{0}}}", viktor[i]);
                }
            }



            //5. feladat: 2p
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!

            int db = 0;
            foreach (var i in viktor)
            {
                if (Páratlan(i)) db++;
            }
            Console.WriteLine("Háromjegyűszámok összege: {0} db", db);

            //6. feladat: 0p
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)



            //7. feladat: 0p
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!



            Console.ReadKey();
        }
    }
}
