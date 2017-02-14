using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakl_Christopher_13KE
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

            // Szum: 32 -> 5

            //A megoldásokat a feladatok utánni sorokba írjad!


            //1. feladat: 5p
            //Kérjed be és tárold egy változóban a tömb (vektor) elemszámát, ami 5 és 10 közötti egész szám lehet!
            //Ha a szám nem megfelelő, akkor ismételd a bekérést!
            //(konverziós hibát nem kell kezelni)

      
            int szam=0;
            do {

                Console.WriteLine("Kérem adjon meg egy 5 és 10 közötti értéket! ( Vektor Mérete)");
                szam = int.Parse(Console.ReadLine());
             

            } while (!(szam > 5 && szam < 10));



            //2. feladat: 5p
            // Deklarálj és definiálj az első feladatban bekért méretű, int típusú vektort!
            //a vektor azonosítója "viktor" legyen!

            int[] viktor = new int[szam];


            //3. feladat: 5p
            //Véletlenszámok előállítására példányosíts egy Random osztályt,
            //az objektum azonosítója "rnd" legyen!

            Random rnd = new Random();


            //4. Feladat: 5p
            //Töltsed fel a 2. feladatban létrehozott viktor vektort véletlenszerűen, 
            //egyjegyű számokkal 1..9-ig!

            for (int i = 0; i < szam; i++)
            { viktor[i] = rnd.Next(1, 9); }

            //5. feladat: 3p
            //Írjad ki a vektor elemeinek az értékét visszafele a képernyőre a következő formában:
            //pl. ha 5 elemű a vektor:
            //viktor: i4->5; i3->2; i2->8; i1->3; i0->9;

            int inv; // visszafelé számoláshoz (invert)

            for (int i = 0; i < szam; i++)
            {
                inv = szam-i-1; 

                Console.WriteLine("viktor[" + inv + "] = " + viktor[inv] );
            }

            //5. feladat: 4p
            //Határozd és írjad ki a képernyőre a viktor vektorban lévő páratlan számok összegét!


            int paratlan = 0; 
            for (int i = 0; i < szam; i++)
            { if (!(viktor[i] % 2 == 0)) { paratlan += viktor[i]; }  }

            Console.WriteLine("Páratlan számok összege a tömbben = " + paratlan);

            //6. feladat: 5p
            //Határozd meg és írjad ki a képernyőre a prím számok darabszámát
            //a viktor vektorban!
            //(egyjegyű prímek: 2,3,5,7)

            byte prim=0;
            for (int i = 0; i < szam; i++)    // Mivel csak 4 féle lehetőség van, talán felesleges lenne bonyolultabb ellenőrzés..
            {
                if (viktor[i] == 2 || viktor[i] == 3 || viktor[i] == 5 || viktor[i] == 7)
                { prim++;
                    // Mivel a "darab" szám kell nem a "Hány féle" ezért gondolom két ugyanolyan azt nyugodtan számolhatja 2 nek.


                }
            }

            Console.WriteLine("A viktor nevű Tömbben " + prim + " darab prím szám van!");


            //7. feladat: 5p
            //Dönsed el, hogy van-e 3-nál kisebb szám a vektorban!
            //Ha találtál egy ilyen számot, akkor ne folytasd a keresést!

            bool talal = false; // feltételezem nem talál..
            for (int i = 0; i < szam; i++)
            {
                if (viktor[i] < 3) { Console.WriteLine("A vektorban találtam egy 3-nál kisebb számot a(z) " + i + ". helyen!");
                    talal = true;   // talált
                    break;  }

                }

               if(talal==false) Console.WriteLine("Nem találtam 3 nál kisebb számot a viktor vektorában.");

                Console.ReadKey();


        }
    }
}
