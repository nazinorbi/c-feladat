using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sólya_Babett_Vivien
{
    // szum: 20p -> 2

    class Program
    {
        static void Main(string[] args)
        {
            //1. feladat: 5p
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)
            int elemszám = 0;
            do
                try
                {
                    Console.WriteLine("Kérem a tömb elemszámát: [5-10] ");
                    elemszám = int.Parse(Console.ReadLine());

                    if (elemszám < 5) throw new Exception("Nem lehet 5-nél kevesebb!");
                    if (elemszám > 10) throw new Exception("Nem lehet 10-nél több!");
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            while (elemszám < 5 || elemszám > 10);




            //2. feladat: 5p
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!
            int[] viktor = new int[elemszám];

            //3. feladat: 5p
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!
            Random rnd = new Random();



            //4. Feladat: 2p
            //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
            //egyjegyű számokkal 1..9-ig!
            int i = 0;
            viktor[i] = rnd.Next(1, 9);

            //5. feladat: 3p
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;

            
            do
            {
                i = elemszám;
                Console.Write("i{0}-> {1} ", i, viktor[i]);

                i++;
            } while (!(i <= elemszám));

            //5. feladat:
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!


            //6. feladat:
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)


            //7. feladat:
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!

            Console.ReadKey();

        }
    }

}
