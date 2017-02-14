using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachCiklusMinta
{
    class Program
    {
        static void Main()
        {
            //Összetett adatszerkezetek
            //Egyszerű változók -> Egy adat tárolására alkalmasak
            //Összetett változók -> Több adat tárolására alkalmasak
            //Tömb (Array) -> Összetett adatszerkezet
            //Fajtái: vektor (egy dimenziós tömb)
            //        mátrix (kétdimenziós tömb)
            int[] v; //deklaráció
            v = new int[10]; //inicializáció

            int[] v2 = new int[10]; //deklaráció + inicializáció

            //Értékadás a vektor egy elemének:
            v2[0] = 23; //első elem
            v2[1] = 32; //második elem
            v2[9] = 34; //utolsó elem
            Console.WriteLine(v2[0]);
            //vagy:
            v2[v2.Length-1] = 34;

            //Vektor elemszáma:
            Console.WriteLine(v2.Length);

            //Értékadás a vektor elemeinek bejárással
            for (int i = 0; i < v2.Length; i++)
            {
                v2[i] = 123;
                Console.WriteLine(v[i]);
            }

            //Foreach ciklussal
            int összeg = 0;
            foreach (var i in v2)
            {
                összeg = összeg + i;
            }
            //Foreach ciklus ciklusváltozója (itt: i)
            //felveszi a tömb elemeinek értékeit,
            //nem állhat értékadó kifejezés BAL oldalán,
            //azaz nem kaphat értéket,
            //azaz csak olasható!

            //A fent ciklus for ciklussal:
            int összeg2 = 0;
            for (int i = 0; i < v2.Length; i++)
            {
                összeg2 = összeg2 + v2[i];
            }

        }
    }
}
