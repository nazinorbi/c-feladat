using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegyes
{
    class Program
    {
        static void Main()
        {
            //2. feladat:
            byte[] v = new byte[80];
            Random r = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = (byte)r.Next(1, 16);
            }

            //3. feladat:
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0) v[i] = 0;
            }

            //4. feladat:
            for (int i = 0; i < 3; i++) //i=0..2
            {
                v[i] = 0;
                v[v.Length-1-i] = 0;
            }

            //5. feladat:
            //Hexadecimális: 0,1,2,..,9,A,B,C,D,E,F
            char[] hex = { '0', '1', '2', '3', '4',
                           '5', '6', '7', '8', '9',
                           'A', 'B', 'C', 'D', 'E', 'F' };
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(hex[v[i]]);
            }
            Console.WriteLine(); //soremelés

            //5. feladat másik megoldása:
            foreach (var i in v)
            {
                //"A" karakter ASCII kódja: 65 (55+10)
                //"a" karakter ASCII kódja: 97
                //"0" karakter ASCII kódja: 48
                //"CR" vezérlő karakter: 13
                //"LF" vezérlő karakter: 10

                if (i < 10) Console.Write(i);
                else Console.Write((char)(55+i));
            }
            Console.WriteLine();

            //6. feladat: hegyek száma  "0B0" -> hegy
            int hegyekSzáma = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(v[0]); //Első elem csak víz lehet
            for (int i = 1; i < v.Length-1; i++)
            {
                if (v[i-1] == 0 && v[i] != 0 && v[i + 1] == 0)
                {
                    hegyekSzáma++;
                    Console.ForegroundColor = ConsoleColor.Red;
                } else Console.ForegroundColor = ConsoleColor.White;
                Console.Write(hex[v[i]]); //11->B 13->D 15->F
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(v[v.Length-1]); //Utolsó elem csak víz lehet

            Console.WriteLine("Hegyek száma a vektorban: {0} db",hegyekSzáma);




            Console.ReadKey();
        }
    }
}
