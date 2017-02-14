using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorosFeladat1
{
    class VektorosFeladat1
    {
        static bool Háromjegyű(int x)
        {
            //if (x < 1000 && x > 99) return true;
            //return false;
            return x.ToString().Length == 3;
            //ToString() metódus a számot szövegre konvertálja
            //Length jellemző a szöveg hosszát adja
        }

        static bool Páratlan(int x)
        { //az "x" a metódus (függvény) formális paramétere 
            if (x % 2 == 1)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static void Main()
        {
            //1. Deklarálj és inicializálj egy 15 elemű, int típusú vektort, azonosítója legyen "v"
            const int elemekSzáma = 15;
            int[] v = new int[elemekSzáma];

            //2. Töltsed fel a "v" azonosítójú vektort 10-999-ig számokkal véletlen szerűen
            Random r = new Random();
            for (int i = 0; i < elemekSzáma; i++)
            {
                v[i] = r.Next(10, 1000);
            }

            //3. Írjad ki a számokat a minta szerint: v[0..14]={12;345;123;...;77;56;89}
            //v[0..14]={
            Console.Write("v[0..{0}]={{",elemekSzáma);
            //"{{" "elnyomjuk" a kapcsos zárójel speciális szerepét

            //12;345;123;...;77;56;89}
            for (int i = 0; i < elemekSzáma; i++)
            {
                if (i<elemekSzáma-1)
                {//közbenső elem: 345;
                    Console.Write("{0};",v[i]);
                } else
                { //ha az utolsó elem jön: 89}
                    Console.WriteLine("{0}}}", v[i]);
                }
            }


            //4. Határozd meg a háromjegyű páratlan számok darabszámát
            int db = 0;
            foreach (var i in v)
            {
                if (Háromjegyű(i) && Páratlan(i)) db++;
            }
            Console.WriteLine("\nHáromjegyű páratalan számok darabszáma: {0} db",db);
            // "\n" -> új sor vezérlő karakter
            //4+ feladat: Háromjegyű páros számokat szorozzuk kettővel,
            //ha azok háromjegyűek maradnak!

            //5. Határozd meg, hogy a vektorban a kétjegyű 
            //vagy a háromjegyű számok darabszáma több!

            //6. Döntsed el, hogy a 100 megtalálható-e a
            //vektorban. Ha a 100-at megtaláltad, akkor ne folytasd a keresést!
            //ciklus megszakítása a break utasítással!
            //teszthez generálás után: v[5]=100;

            //7. Keresd meg a legkisebb háromjegyű számot!
            //Indexét és érékét írjad a ki!
            Console.ReadKey();
        }
    }
}
