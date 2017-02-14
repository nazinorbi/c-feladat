using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSzámok
{
    class Program
    {
        static void Main()
        {
            //Véletlenszámokat a Random osztály felhasználásával készítjük
            //Statikus osztályok: Console, Math
            //Dinamikus osztály: Random
            //Dinamikus osztályokat használat előtt
            //példányosítani kell:
            Random rnd = new Random();

            //Vektor deklaráció + inicializáció
            int[] t = new int[10];

            //Bejárás + feltöltés:
            for (int i = 0; i < t.Length; i++)
            {
                //Veltöltés véletlen szerűen kétjegyű számokkal
                t[i] = rnd.Next(10, 500);
            }
            //Vektor elemeinek kiírása foreach ciklussal:
            foreach (var i in t)
            {
                Console.Write("{0,-4}",i);
                //",3" -> kiírás minimum szélessége 
                //",-3 -> balra is igazít "34 "
            }

            int összeg = 0;
            foreach (var i in t)
            {
                összeg = összeg + i;
            }
            Console.WriteLine(); //ugrás a következő sorra
            Console.WriteLine("Számok összege: {0}", összeg);

            Console.ReadKey();
        }
    }
}
