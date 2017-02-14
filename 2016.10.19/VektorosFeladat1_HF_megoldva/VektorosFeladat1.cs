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
            //if (x % 2 == 1)
            //{
            //    return true;
            //} else
            //{
            //    return false;
            //}
            return x % 2 == 1;
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

            //3. Írjad ki a számokat a minta szerint: 
            //v[0..14]={12;345;123;...;77;56;89}
            //v[0..14]={
            Console.Write("v[0..{0}]={{", elemekSzáma);
            //"{{" "elnyomjuk" a kapcsos zárójel speciális szerepét

            //12;345;123;...;77;56;89}
            for (int i = 0; i < elemekSzáma; i++)
            {
                if (i < elemekSzáma - 1)
                {//közbenső elem: 345;
                    Console.Write("{0};", v[i]);
                }
                else
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
            Console.WriteLine("\nHáromjegyű páratalan számok darabszáma: {0} db", db);
            // "\n" -> új sor vezérlő karakter
            //4+ feladat: Háromjegyű páros számokat szorozzuk kettővel,
            //ha azok háromjegyűek maradnak!
            //for (int i = 0; i < elemekSzáma; i++)
            //{
            //    //if (Háromjegyű(v[i]) && !Páratlan(v[i]))
            //    //{
            //    //    int újÉrték = v[i] * 2;
            //    //    if (Háromjegyű(újÉrték))
            //    //    {
            //    //        v[i] = újÉrték;
            //    //    }
            //    //}

            //    if (Háromjegyű(v[i]) && !Páratlan(v[i]) && v[i] <= 498)
            //    {
            //        v[i] = v[i] * 2; ;
            //    }
            //}


            //5. Határozd meg, hogy a vektorban a kétjegyű 
            //vagy a háromjegyű számok darabszáma több!
            int dbKétjegyű = 0;
            int dbHáromjegyű = 0;
            foreach (var i in v)
            {
                if (Háromjegyű(i)) //for -> t[i]
                {
                    dbHáromjegyű++;
                } else
                {
                    dbKétjegyű++;
                }
            }
            if (dbHáromjegyű==dbKétjegyű)
            {
                Console.WriteLine("Darabszámok eggyezőek!");
            } else if (dbHáromjegyű>dbKétjegyű)
            {
                Console.WriteLine("Háromyjegyű számok darabszám több!");
            } else
            {
                Console.WriteLine("Kétjegyű számok darabszáma több!");
            }

            


            //6. Döntsed el, hogy a 100 megtalálható-e a
            //vektorban. Ha a 100-at megtaláltad, akkor ne folytasd a keresést!
            //ciklus megszakítása a break utasítással!
            //teszthez generálás után: v[5]=100;
            //v[5] = 100;
            //Feltételezzük, hogy nincs ilyen
            bool vanIlyenSzám = false;
            foreach (var i in v)
            {
                if (i==100)
                {
                    vanIlyenSzám = true;
                    break;
                }
            }

            if (vanIlyenSzám) Console.WriteLine("Van benne 100-as!");
            else Console.WriteLine("Nincs benne 100-as!");


            //7. Keresd meg a legkisebb számot!
            //Indexét és érékét írjad a ki!

            //Legyen az első elem a legkisebb:
            int mini = 0; //Legkisebb szám indexe
            for (int i = 1; i < elemekSzáma; i++)
            {
                if (v[i] < v[mini]) mini = i;
            }
            Console.WriteLine("Legkisebb elem értéke: {0}",v[mini]);
            Console.WriteLine("Legkisebb elem indexe: {0}", mini);

            //8. Keresd meg a legkisebb háromjegyű számot!
            //Indexét és érékét írjad a ki!
            int mini3 = -1; //Indexe

            for (int i = 0; i < elemekSzáma; i++)
            {
                if (Háromjegyű(v[i]))
                {
                    if (mini3 == -1)
                    { //Első háromjegyű szám
                        mini3 = i;
                    }
                    else
                    { //már volt háromjegyű
                        if (v[i] < v[mini3]) mini3 = i;
                    }
                }
            }
            if (mini3==-1)
            {
                Console.WriteLine("Nincs háromjegyű szám a vektorban!");
            } else
            {
                Console.WriteLine("Legkisebb háromjegyű elem értéke: {0}", v[mini3]);
                Console.WriteLine("Legkisebb háromjegyű elem indexe: {0}", mini3);
            }
            Console.ReadKey();
        }
    }
}
