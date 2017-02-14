using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mógor_Szilárd
{
    class Program
    {

        static bool Prím(int x)
        {
            for (int i = 2; i <= Math.Abs(x) / 2; i++)
            {
                if (x % i==0)
                {
                    return false;
                }
            }
            return true;
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

            //szum: 35p -> 5


            //A megoldásokat a feladatok utánni sorokba írjad!


            //1. feladat:
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)
            int elemszám = 0;
            do
            {
                Console.Write("Kérem a tömb elemszámát(5-10):");
                elemszám = int.Parse(Console.ReadLine());
            } while (elemszám < 5 || elemszám > 10);

            //2. feladat:
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!
            int[] viktor = new int[elemszám];

            //3. feladat:
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!

            Random rnd = new Random();

            //4. Feladat:
            //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
            //egyjegyű számokkal 1..9-ig!

            for (int i = 0; i < elemszám; i++)
            {
                viktor[i] = (int)rnd.Next(1, 10);
            }

            //5. feladat:
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;
            for (int i = 0; i < elemszám; i++)
            {
                Console.Write("\nViktor:[{0}]={1,4}",i, viktor[i]);
            }

            //5. feladat:
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!
            int páratlanÖsszeg = 0;
            for (int i = 0; i < elemszám; i++)
            {
                if (viktor[i] % 2 == 1) páratlanÖsszeg += viktor[i];
            }
            Console.WriteLine("\nPáratlan számok összege:{0}", páratlanÖsszeg);

            //6. feladat:
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)
            int prímdb = 0;
            foreach (var i in viktor)
            {
                if (Prím(i)) prímdb++;                                                              
            }
            Console.WriteLine("\n{0}db prímszám található a vektorban.", prímdb);

            //7. feladat:
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!
            bool van = false;
            for (int i = 0; i < elemszám; i++)
            {
                if (viktor[i]<3)
                {                  
                    
                    van = true;
                    Console.WriteLine("\nVan 3-nál kisebb szám a vektorban");
                    break;                   
                }               
            }           
            if (van == false) Console.WriteLine("Nincs 3-nál kisebb szám a vektorban");
            Console.ReadKey();
        }
    }
}
