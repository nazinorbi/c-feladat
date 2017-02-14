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
                v[v.Length - 1 - i] = 0;
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
                else Console.Write((char)(55 + i));
            }
            Console.WriteLine();

            //6. feladat: hegyek száma  "0B0" -> hegy
            int hegyekSzáma = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(v[0]); //Első elem csak víz lehet
            for (int i = 1; i < v.Length - 1; i++)
            {
                if (v[i - 1] == 0 && v[i] != 0 && v[i + 1] == 0)
                {
                    hegyekSzáma++;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else Console.ForegroundColor = ConsoleColor.White;
                Console.Write(hex[v[i]]); //11->B 13->D 15->F
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(v[v.Length - 1]); //Utolsó elem csak víz lehet

            Console.WriteLine("Hegyek száma a vektorban: {0} db", hegyekSzáma);

            //7. feladat: leghosszabb hegylánc "03B0"
            int aktHossz = 0;
            int aktKezdete = 0;
            int maxHossz = 1; //azért 1, hogy a hegyeket ne minősítsük hegyláncnak
            int maxKezdete = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] != 0)
                { //hegyre vagy hegyláncra mutat az "i"
                    if (aktHossz == 0)
                    { //a hegylánc most kezdődik
                        aktKezdete = i;
                    }
                    aktHossz++; //növeljük az aktuális hegylánc hosszát
                }
                else
                {//i=0, azaz "víz" jön:
                    if (aktHossz > maxHossz)
                    {
                        maxHossz = aktHossz;
                        maxKezdete = aktKezdete;
                    }
                    aktHossz = 0; //a következő hegylánchoz kinullázuk
                }
            }
            Console.WriteLine("Max hossz: {0}", maxHossz);
            Console.WriteLine("Max kezdete: {0}", maxKezdete);
            //7. feladat: átlágos magasság
            int magasságokÖsszege = 0;
            for (int i = maxKezdete; i < maxKezdete + maxHossz; i++)
            {
                magasságokÖsszege += v[i];
                //Console.WriteLine(v[i]); //teszteléshez
            }
            double átlagosMagasság = (double)magasságokÖsszege / maxHossz;
            Console.WriteLine("Átlágaos magasság: {0:F3}", átlagosMagasság);

            //7+. Az első leghosszabb hegylánc jelenjen meg sárga színnel
            for (int i = 0; i < v.Length; i++)
            {
                if (i >= maxKezdete && i <= maxKezdete + maxHossz - 1) //"-1" teszteléssel :-)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else Console.ForegroundColor = ConsoleColor.White;
                Console.Write(hex[v[i]]);
            }
            Console.WriteLine();

            //8. feldat:
            bool[] kékek = new bool[80];
            for (int i = 1; i < v.Length - 3; i++)
            {
                if (v[i - 1] == 0 &&  //víz
                    v[i] != 0 &&  //hegy
                    v[i + 1] != 0 &&  //hegy
                    v[i + 2] != 0 &&  //hegy 
                    v[i + 3] == 0) //víz
                {
                    byte[] s = new byte[3];
                    s[0] = v[i];
                    s[1] = v[i + 1];
                    s[2] = v[i + 2];
                    Array.Sort(s); //segéd vektor rendezése növekvő rendben
                    v[i] = s[1]; //középső érték kerül előre
                    v[i + 1] = s[2]; //legnagyobb érték kerül középre
                    v[i + 2] = s[0]; //lekisebb érték kerül a végére
                    kékek[i] = true;
                    kékek[i + 1] = true;
                    kékek[i + 2] = true;
                }

            }
            //Kiírás
            for (int i = 0; i < v.Length; i++)
            {
                if (kékek[i]) Console.ForegroundColor = ConsoleColor.Blue;
                else Console.ForegroundColor = ConsoleColor.White;
                Console.Write(hex[v[i]]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
