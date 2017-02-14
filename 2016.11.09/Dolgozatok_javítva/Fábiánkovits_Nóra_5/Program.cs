using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fábiánkovits_Nóra
{
    class Program
    {
        static void Main()
        {
            //Dolgozat: 2016.10.26
            //Minden feladat 5-pontot ér (7 * 5 = 35pont)!
            //0  - 17 -> 1
            //18 - 21 -> 2
            //22 - 25 -> 3
            //26 - 29 -> 4
            //30 - 35 -> 5

            //szum: 35p -> 5

            //A megoldásokat a feladatok utánni sorokba írjad!

            //1. feladat: 5p
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)
            byte elemszám;
            do
            {
                Console.Write("Vektor elemszáma(5-10): ");
                elemszám = byte.Parse(Console.ReadLine());
            } while (!(elemszám <= 10 && elemszám >= 5));

            //2. feladat: 5p
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!
            int[] viktor = new int[elemszám];
             
            //3. feladat: 5p
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!
            Random rnd = new Random();

            //4. Feladat: 5p
            //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
            //egyjegyű számokkal 1..9-ig!
            for (int i = 0; i < elemszám; i++)
            {
                viktor[i] = rnd.Next(1, 10);
            }

            //5. feladat: 5p
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;
            Console.Write("viktor: ");
            for (int i = elemszám - 1; i >= 0; i--)
            {
                Console.Write("i{0}->{1}; ", i, viktor[i]);
            }

            //5. feladat: 5p
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!
            int páratlanÖsszeg = 0;
            for (int i = 0; i < elemszám; i++)
            {
                if (viktor[i] % 2 == 1) páratlanÖsszeg += viktor[i];
            }
            Console.WriteLine("\nPáratlan számok összege: " + páratlanÖsszeg);
            //6. feladat: 5p
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)
            byte prímDb = 0;
            for (int i = 0; i < elemszám; i++)
            {
                byte maradékosOsztó = 0;
                for (int j = 1; j <= viktor[i]; j++)
                {
                    if (viktor[i] % j == 0) maradékosOsztó++;
                }
                if (maradékosOsztó == 2) prímDb++;
            }
            Console.WriteLine("Prím számok darabszáma: " + prímDb);

            //7. feladat: 5p
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!
            bool van3 = false;
            for (int i = 0; i < elemszám; i++)
            {
                if (viktor[i] < 3)
                {
                    van3 = true;
                    break;
                }
            }
            if (van3) Console.WriteLine("Van benne 3-nál kisebb szám");
            else Console.WriteLine("Nincs benne 3-nál kisebb szám");
            Console.ReadKey();
        }
    }
}
