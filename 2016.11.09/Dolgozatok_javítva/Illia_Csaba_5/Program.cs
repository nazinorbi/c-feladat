using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illia_Csaba
{
    class Program
    {
        static bool ParatlanSzam(int x)
        {
            if (x % 2 == 1)
                return true;
            else
                return false;

        }

        static bool Primszam(int x)
        {
            int osztokDb = 0;
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                    osztokDb++;
            }

            if (osztokDb == 1)
                return true;
            else
                return false;

        }


        static void Main(string[] args)
        {
            //Dolgozat: 2016.10.26
            //Minden feladat 5-pontot ér (7 * 5 = 35pont)!
            //0  - 17 -> 1
            //18 - 21 -> 2
            //22 - 25 -> 3
            //26 - 29 -> 4
            //30 - 35 -> 5

            //szum:32p -> 5

            //A megoldásokat a feladatok utánni sorokba írjad!


            //1. feladat:
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)
            int tombElemszama;

            do
            {
                Console.WriteLine("Kérem a tömb elemszámát [5-10]:");
                tombElemszama = int.Parse(Console.ReadLine());

            } while (tombElemszama < 5 || tombElemszama > 10);

            //2. feladat:
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!

            int[] viktor = new int[tombElemszama];


            //3. feladat:
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!

            Random rnd = new Random();

            //4. Feladat:
            //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
            //egyjegyű számokkal 1..9-ig!

            for (int i = 0; i < viktor.Length; i++)
            {
                viktor[i] = rnd.Next(1, 10);
            }

            //5. feladat: 4p
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;

            for (int i = viktor.Length-1; i >= 0; i--)
            {
                Console.WriteLine("viktor: i{0}->{1};", i, viktor[i]);
            }

            //5. feladat:
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!
            int paratlanSzamokOsszege = 0;

            foreach (var i in viktor)
            {
                if (ParatlanSzam(i))
                    paratlanSzamokOsszege = paratlanSzamokOsszege + i;
            }

            Console.WriteLine("Páratlan számok összege = {0}", paratlanSzamokOsszege);

            //6. feladat:
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)
            int primszamokDarabszama = 0;

            foreach (var i in viktor)
            {
                if (Primszam(i))
                    primszamokDarabszama++;
            }

            Console.WriteLine("Primszámok darabszáma = {0}", primszamokDarabszama);
    
            //7. feladat: 3p
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!

            foreach (var i in viktor)
            {
                if (i < 3)
                {
                    Console.WriteLine("Háromnál kisebb szám: {0}", i);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
