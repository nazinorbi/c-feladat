using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valicsek_Andrea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dolgozat: 2016.10.26
            //Minden feladat 5-pontot ér (7 * 5 = 35pont)!
            //0  - 17 -> 1
            //18 - 21 -> 2
            //22 - 25 -> 3
            //26 - 29 -> 4
            //30 - 35 -> 5

            //szum: 28 -> 4

            //A megoldásokat a feladatok utánni sorokba írjad!


            //1. feladat: 5p
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)





            bool szamHelyes = true;
            int elemszam = 0;
            do
            {
                Console.WriteLine("Kérek egy számot 1 és 5 között");
                elemszam = int.Parse(Console.ReadLine());
                if (elemszam < 1 || elemszam > 5)
                {
                    szamHelyes = false;
                    Console.WriteLine("A szám nem helyes próbáld újra.");
                }
                else
                {
                    szamHelyes = true;
                }
            } while (!szamHelyes);

            //2. feladat: 5p
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!

            int[] viktor = new int[elemszam];
          



            //3. feladat: 5p
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!

            Random rnd = new Random();


            //4. Feladat: 5p
            //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
            //egyjegyű számokkal 1..9-ig!

            for (int i = 0; i < viktor.Length; i++)
            {
                viktor[i] = rnd.Next(1, 10);
            }


            //5. feladat: 0p
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;

            



            //5. feladat: 5p
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!

           int paratlanOsszeg = 0;
            for (int i = 0; i < viktor.Length; i++)
            {
                if (viktor[i] % 2 != 0)
                {
                    paratlanOsszeg += viktor[i];
                }
            }

            Console.WriteLine("páratlan számok összege:" + paratlanOsszeg);




            //6. feladat: 5p
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)

            int primSzamok = 0;
            for (int i = 0; i < viktor.Length; i++)
            {
                if (viktor[i] == 2 || viktor[i] == 3 || viktor[i] == 5 || viktor[i] == 7)
                {
                    primSzamok++;
                }
            }



            //7. feladat: 3p
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!

            bool kissebbHarom = false;
            for (int i = 0; i < viktor.Length; i++)
            {
                if (viktor[i] < 3)
                {
                    kissebbHarom = true;
                    break; // megtörjük a folyamatot
                }
            }
        }
    }
}









