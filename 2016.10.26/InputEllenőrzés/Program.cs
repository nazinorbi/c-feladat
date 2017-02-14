using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputEllenőrzés
{
    class Program
    {
        static void Main()
        {
            //Értékhatárok ellenőrzése
            int méret = 0;
            do
            {
                Console.Write("Kérem a vektor méretét [20-30]:");
                méret = int.Parse(Console.ReadLine());
            } while (méret < 20 || méret > 30);

            int[] v1 = new int[méret];



            //Értékhatárok + konverzió ellenőrzése
            //TryParse() metódussal + mikor kell ismételni logikával
            int méret2 = 0;
            bool ismétel = false; //feltételezzük, hogy nem kell ismételni
            do
            {
                Console.Write("Kérem a vektor2 méretét [20-30]:");
                ismétel = !int.TryParse(Console.ReadLine(), out méret2);
                //TryParse() visszatérési értéke logikai (bool)
                //"true" -> Sikerült az átalakítás
                //"false" -> Nem sikerült az átalakítás
            } while (méret2 < 20 || méret2 > 30 || ismétel);

            // Értékhatárok + konverzió ellenőrzése
            // TryParse() metódussal + mikor jó az input logikával
            int méret4 = 0;
            bool sikeresKonverzió; 
            do
            {
                Console.Write("Kérem a vektor4 méretét [20-30]:");
                sikeresKonverzió = int.TryParse(Console.ReadLine(), out méret4);
                //TryParse() visszatérési értéke logikai (bool)
                //"true" -> Sikerült az átalakítás
                //"false" -> Nem sikerült az átalakítás
            } while (!(méret4>=20 && méret4<=30 && sikeresKonverzió));

            //Ellenőrzés a try-catch szerkezettel
            int méret3 = 0;
            bool ismét; //feltételezzük, hogy nem kell ismételni
            do
            {
                ismét = false;
                try
                {
                    //Védett blokk
                    Console.Write("Kérem a vektor3 méretét [20-30]:");
                    méret3 = int.Parse(Console.ReadLine());
                    if (méret3 < 20) throw new Exception("Nem lehet a méret 20-nál kisebb!");
                    if (méret3 > 30) throw new Exception("Nem lehet a méret 30-nál nagyobb!");
                }
                catch (Exception e)
                {
                    //Hiba objektum "elkapása"
                    Console.WriteLine(e.Message);
                    ismét = true; //hiba volt, tehát ismételni kell
                }
            } while (ismét);


            Console.ReadKey();
        }
    }
}
