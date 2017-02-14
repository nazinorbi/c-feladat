//Projekt: Program és környezete (beállításai)
//Solution: Projektek gyűjteménye (általában egy projekt lesz benne)
//Property: Tulajdonságok
//Forrás (source) program: Programozási nyelven elkészített algoritmus C# -> *.cs
//Algoritmus: Feladat lépésenkénti megoldása
//Algoritmusleíró eszközök: folyamatábra, montatszerű leírás, stuktogram
//Sablon: Alkalmazás típusa, beállítási, kező forrásprogram(ok)
//Számítógépes program = algoritmus + adatszerkezet
//adatszekezet = a program által használt változók halmaza
//Compiler=Fordító  Forrásprogram->"Gépikódú" program (Program.cs -> Program.exe)

//class=osztály, speciális adattípus, programozó "fegyvere"
//osztály elemei -> tagok
//osztálytagok típusai -> metódusok (függvények), jellemzők, ...
//metódus példa: Console.Write("Hello!");
//jellemző példa: Console.Title = "Hello!";
//namespace=névtér, osztályok gyűjtője, hierarchikus felépítésű
//Metódus-> Mit csinál? Write-> Ír
//Paraméter -> Mit írjon ki? Write("Hello!") ->Hello!-t

//Vezérlési szerkezetek:
//1. Szekvencia (sorozat): Lépések egymás utáni végrehajtása
//2. Szelekció (elágazás): Feltételtől függő végrehajtás
//3. Iteráció (ismétlés): Végrehajtás ismétlése


//Gyorsbillentyűk:
//Ctrl-L -> sor törlése
//Ctrl-F5 -> program futtatása (vagy F5) Mi a különbség?
//Ctrl-Alt-Szóköz -> Intellisense működés váltása (régi/új)
//Ctrl-E, D -> Forráskód "szabványos" formázása


namespace Alapok //Saját programunk névtere
{
    class Program //Saját programunk osztálya
    {
        static void Main() //Main()-> Metódus (alprogram) 
        {//"Main"-"Fő" -> Program végrehajtás (futtatás) itt keződik (belépési pont)
            System.Console.WriteLine("Hello World"); //Kiírás parancsa (metódusa)
            System.Console.Title = "Jedlik"; // Jellemző
            System.Console.WriteLine(); //Metódus (mindíg van zárójel!)

            //Adatszerkezet alkotói: változók
            //Változók fajtái:
            //1. Egyszerű változók (egy adatot tárolnak)
            //2. Összetett változók (több adat tárolására alk.)

            //Egyszerű változók:
            //Jellemzői:
            //1. Változó típusa -> Milyen jellegű és mekkora adat tárolható.
            //2. Változó neve (azonosítója)
            //3. Változó alapértelmezett értéke 
            //4. Változó aktuális értéke
            //5. Változó kezdőértéke

            //Egyszerű változók típusa:
            //Egészek (pl.: byte -> 0-255)
            //Valós (pl.: double)
            //Logikai érték (bool -> true, false)
            //Karakter (char)
            //Karakterlánc (string)

            //Deklaráció: Változó meghatározása (típus és azonosító)
            byte x;

            //Definíció: tipus + azonosító + kezdőérték
            byte y = 6;

            char betű = 'a';
            char Betű = 'b';

            string szöveg = "Hello Jedlik!";

            //Literál: Olyan konstans, aminek nincs azonosítója
            //Megadási szabályok:
            //Egész (int): 123
            //Egész (long): 123L
            //Valós (double): 12.34D, 12.34
            //Valós (float): 12.34F
            //Karakter: 'a'
            //Karakterlánc (string): "alma"
            //Logikai: true, false
            //Null: null

            //Konstans -> állandó (típusa, azonosítója és értéke van)
            const double pi = 3.14; //Tizedes pontot kell használni!


            //Foglalt szó: Programozási nyelv szavai,
            //nem használhatóak azonosítóként

            //Értékadás:
            betű = 'w';
            double hányados;
            hányados = y / 5.0; //Mi lesz a hányados? 6/5????
            System.Console.WriteLine(hányados);

            //Értékadás kifejezés eredményeként
            //értéket_kapó_változó = operadus1 operátor operandus2;
            //operátor -> művelet, műveleti jel
            //operandus -> művelet változó(i)
            //pl.: hányados = y / 5.0; //Két operandusú művelet
            //pl.: x=-y; //Egy operandusú művelet

            int a = 3;
            int b = 4;
            byte összeg = (byte)(a + b); //Konverzió megerősítése -> típuskényszerítés

            string név;
            const string n = "Andrea";
            név = "Andrea";
            név = "Katalin";
            név = név + "Erzsébet"; //aktuális érték -> "KatalinErzsébet"
            név = n;



            //Operátorok:
            //Aritmetikai: +, -, *, /
            //Relációs: <, >, <=, >=, !=
            //Logikai: És -> &&, Vagy -> ||, Tagadás -> !

            //pl.: Megszerkeszthető háromszög:
            //Ha a+b>c && b+c>a && a+c>b akkor K=a+b+c;

            System.Console.ReadKey(); //Várokozás parancsa
        }
    }
}
