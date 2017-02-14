using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMinta
{
    class Program
    {
        static void Main()
        {
            int n;
            do
            {
                Console.Write("Hányszor ítjam ki a neved? [1-15]:");
                try
                {
                    n = int.Parse(Console.ReadLine()); //int értékkészlete kb.: -2 milliárd.. +2 milliárd (32 bites)
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    n = 0;
                }
            } while (n <= 0 || n > 15);

            //for majd 2xTAB :-)
            //for (int i = 0; i < n; i++) //i=i+1
            //{
            //    //cw majd 2xTAB
            //    Console.WriteLine("{0}. László", i + 1);
            //}

            //Több sor megjegyzésbe tétele:
            //1. Sorok kijelölése
            //2. Ctrl-K, Ctrl-C (Comment)

            //Több sor kivétele megjegyzésből:
            //1. Sorok kijelölése
            //2. Ctrl-K, Ctrl-U (UnComment)

            // int -2milliárd..+2milliárd (Signed = előjeles)
            // uint 0..+4milliárd (UnSigned= előjel nélküli) 

            //Forráskód formázása: Ctrl-K, Ctrl-D

            //For ciklus kiváltása while ciklussal
            //(fenti ciklust váltjuk)
            int i = 0;
            while (i<n)
            {
                Console.WriteLine("{0}. László", i + 1);
                i++;
            }

            Console.ReadKey();
        }
    }
}
