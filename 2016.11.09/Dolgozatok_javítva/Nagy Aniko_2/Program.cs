using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagy_Aniko
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

            //szum: 18p -> 2

            //A megoldásokat a feladatok utánni sorokba írjad!


            //1. feladat: 0p
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)
            Console.WriteLine(t.Length);
            v2[0] = 5;
                v2[1] = 6;
            v2[2] = 7;
            v2[3] = 8;
            v2[4] = 9;
            v2[5] = 10;
            v2[6] = 11;
            v2[7] = 12;
            v2[8] = 13;
            v2[9] = 14;
            v2[10] = 15;
                
            for (int i = 0; i <= t.Length - 11; i++)
                byte[] t11 = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};






            //2. feladat: 5p
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!

            const int viktor = 15;
            int[] v = new int[viktor];




            //3. feladat: 5p
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!
            Random r = new Random();
            for (int i = 0; i < v2.Length; i++)


                //4. Feladat: 2p
                //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
                //egyjegyű számokkal 1..9-ig!
                byte[] t1 = new byte[9];
                Random r = new Random(); 
                for (int i = 0; i < t1.Length; i++) t1[i] = r.Next(1, 9);


            //5. feladat: 0p
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;



            //5. feladat 3p
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!

            int db = 0;
            foreach (var i in v)
            {
                if ((i) && Páratlan(i)) db++;
            }
            Console.WriteLine("\nviktor vektorban lévő páratlan számok összege: {0} db", db);

            //6. feladat: 1p
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)

            Console.WriteLine("Prím számok darabszáma")
                Console.Write("X=");
            int x = int.Parse(Console.ReadLine());




            //7. feladat: 4p
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!

            bool vanIlyenSzám = false;
            foreach (var i in v)
            {
                if (i == 3>)
                {
                    vanIlyenSzám = true;
                    break;
                }
            }

            if (vanIlyenSzám) Console.WriteLine("Van benne 3-nál kisebb szám!");
            else Console.WriteLine("Nincs benne 3-nál kisebb szám!");

            Console.ReadKey();
        }
    }
}
