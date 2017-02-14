using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikusok
{
    class Program
    {
        static void KiírLista(string s, List<int> l)
        {
            Console.Write(s);
            foreach (var i in l)
            {
                Console.Write("{0}, ",i);
            }
            Console.WriteLine(); //Soremelés
        }
        static void Main()
        {
            //Generikusok -> Speciális összetett adatszerkezetek
            //Fontosabb fajtái:
            //1. Listák (List)
            //2. Halmazok (HashSet)
            //3. Szótárak (Dictionary)
            //4. Sorok (Queue)
            //5. Vermek (Stack)
            //6. Láncolt listák (LinkedList)

            //Érték (value) és referencia típusok
            //Érték típus 
            //(egyszerű változók, 
            //felsorolt típusok, struktúrák):
            int x1 = 4;
            int x2 = 4;
            Console.WriteLine("x1==x2 -> {0}", x1 == x2);
            //Referencia típus (összetett változók, generikusok, osztályok):
            int[] v1 = { 1, 2, 3 };
            int[] v2 = { 1, 2, 3 };
            Console.WriteLine("v1==v2 -> {0}", v1 == v2);

            //Kivétel a szting típus
            string s1 = "alma";
            string s2 = "alma";
            Console.WriteLine("s1==s2 -> {0}", s1 == s2);
            //A sztring referencia típus (karakter vektor),
            //de úgy viselkedik, mintha érték típus lenne

            //1. Listák: Tömbszerű összetett adatszerkezet
            //1.1 Inicializáció
            List<int> lista = new List<int>();
            List<int> lista2 = new List<int>(100); //100->Kapacitás

            //1.2 Adat elhelyezése a lista "végén"
            lista.Add(2); //index: 0
            lista[0] = lista[0] + 3;
            //Nem hivatkozhatunk nem létező elemre!!!
            //lista[5] = 23;

            lista.Add(34); //index: 1
            lista.Add(72); //index: 2
            lista.Add(56); //index: 3

            //1.3 Lista elemszáma:
            //Count jellemző
            Console.WriteLine("Lista elemszáma: {0}", lista.Count); //4

            //1.4 Meghatározott tulajdonságú elemek száma
            //Count() metódus
            //Pozitív számok darabszáma:
            Console.WriteLine("Pozitív számok darabszáma: {0}", lista.Count(x => x > 0)); //4
            //Páros értékű elemek darabszáma:
            Console.WriteLine("Páros számok darabszáma: {0}", lista.Count(x => x % 2 == 0)); //3

            //1.5 Lista bejárása
            Console.Write("Lista bejárása foreach: ");
            foreach (var i in lista)
            {
                Console.Write("{0}, ",i);
            }

            Console.Write("\nLista bejárása for: ");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0}, ", lista[i]);
            }
            Console.WriteLine(); //Soremelés

            //1.6 Elem törlése listából:
            lista.RemoveAt(2); //2-es indexű elemet törli


            //1.7 Összes 123-as törlése
            lista.Add(123);
            lista.Add(123);
            lista.RemoveAll(x => x == 123);

            //1.8 töröl a 0. indexű elemtől 2 db elemet a listából
            lista.Add(5); //index: 0
            lista.Add(34); //index: 1
            lista.Add(72); //index: 2
            lista.Add(56); //index: 3
            lista.RemoveRange(0, 2); //hányadiktól, hány darabot

            //1.9 Rendezés a Sort() metódusal
            lista.Sort();
            KiírLista("Rendezés Sort()-al: ", lista);

            //1.10 Lista megfordítása
            lista.Reverse();
            KiírLista("Lista megfordítása: ", lista);

            //1.10 Lista rendezése az OrderBy() metódusal
            lista.Add(99);
            lista=lista.OrderBy(x => x).ToList();
            KiírLista("Lista rend. OrderBy(): ", lista);
            //Fordított rendezés:
            lista=lista.OrderByDescending(x => x).ToList();
            KiírLista("Lista rend. OrderByDescending(): ", lista);

            //1.11 Beszúrás listába
            lista.Insert(1, 999);
            lista.Insert(lista.Count, 888);
            //lista.Add(888);
            KiírLista("Beszúrás [999,888]: ", lista);

            //1.12 Keresett elem első előfordulásának indexe:
            int elsőIndex = lista.IndexOf(100);
            //-1 -> nincs 100-as érték a listában
            elsőIndex = lista.IndexOf(999);
            // 1 -> 999 első előfordulásának az indexe
            int utolsóIndex = lista.LastIndexOf(999);
            // 1 -> 999 utolsó előfordulásának az indexe

            //1.13 Vektor átalakítása listává:
            int[] v = { 43, 45, 65, 58};
            List<int> lv = new List<int>(v);

            //1.14 Lista átalakítása vektorrá (tömb->array):
            v = lv.ToArray();

            //1.15 Összes elem törlése
            lista.Clear();
            

            //2. Példák halmazokra:
            //2.1 Halmaz inicializálása:
            HashSet<int> myHalmaz = new HashSet<int>();

            //2.2 Halmaz elemszáma:
            Console.WriteLine("Halamaz elemszáma: {0}",myHalmaz.Count);

            //2.3 Elem hozzáadása a halmazhoz:
            myHalmaz.Add(123);
            myHalmaz.Add(123);
            myHalmaz.Add(123);
            myHalmaz.Add(123);

            //5-ös lottó számok előállítása:
            myHalmaz.Clear(); //minden elem törlése a halmazból
            Random r = new Random();
            while (myHalmaz.Count < 5)
            {
                myHalmaz.Add(r.Next(1, 91));
            }

            //Halamazok definiálása
            HashSet<int> A = new HashSet<int>() { 2, 3, 6, 4, 9};
            HashSet<int> B = new HashSet<int>() { 3, 6, 8, 7 };

            //Halmazok metszete:
            A.IntersectWith(B); //Halmazok metszete az "A" halmazba kerül

            //Halmazok únója:
            HashSet<int> C = new HashSet<int>(A);
            C.UnionWith(B); //így nem vesznek el "A" halaz elemei

            //Halmazok különbsége:
            A.ExceptWith(B);


            //3. Szótár -> Adatpárok kezelésre alkalmas 
            //adatszerkezet (pár: kulcs (key) és érték (value)
            //Vektor esetében: Kulcs: Index 0..N-1, adat pl.: t[0]

            //3.1 Szótárak inicializációja:
            Dictionary<string, byte> Napos = new Dictionary<string, byte>();

            //3.2 Szótár bővítése:
            Napos.Add("január", 31);
            Napos.Add("február", 28);
            Napos.Add("március", 31);
            Napos.Add("április", 30);

            //3.3 Hivatkozás a szótár adataira:
            bool szökőév = true;
            if (szökőév) Napos["február"] = 29;
            Console.WriteLine(Napos["február"]);

            //3.4 Szótár definíció:
            Dictionary<string, byte> Évszakok =
                new Dictionary<string, byte>()
                { {"Ősz",9}, {"Tél",12},
                    {"Tavasz",3}, {"Nyár",6}};

            //3.5 Szótár bejárása:
            foreach (var i in Évszakok)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }

            //4. Sor (Queue) adatszerkezet: (FIFO szervezésű)
            //Inicializálása:
            Console.WriteLine("Sor - Queue");
            Queue<string> sor = new Queue<string>();

            //Elemek hozzáadása
            sor.Enqueue("Dávid");
            sor.Enqueue("Laci");
            sor.Enqueue("Krisztina");
            sor.Enqueue("Attila");

            //Sor elején lévő elem "kivétele"
            Console.WriteLine(sor.Dequeue());

            //Sor elején lévő elem lekérdezése
            Console.WriteLine(sor.Peek());

            //Sorból minden elem kivétele feldolgozással
            while (sor.Count>0)
            {
                Console.WriteLine(sor.Dequeue());
            }
            //vagy sor.Clear(); //minden elem törlése

            //5. Verem adatszerkezet (LIFO szervezésű)
            Console.WriteLine("Verem - Stack");
            Stack<char> Verem = new Stack<char>();

            //5.1 Elem tárolása a veremben (PUSH)
            Verem.Push('A');
            Verem.Push('B');
            Verem.Push('C');

            //5.2 Mi van a verem tetején?
            Console.WriteLine(Verem.Peek());

            //5.3 Elemek kivétele a veremből (POP):
            Console.WriteLine("Elemek a veremből: LIFO");
            while (Verem.Count>0)
            {
                Console.WriteLine(Verem.Pop());
            }


            //6. Láncolt listák
            Console.WriteLine("Láncolt listák:");
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(10);
            ll.AddLast(99);
            ll.AddLast(88);

            LinkedListNode<int> akt;

            //Láncolt lista bejárása
            akt = ll.First; //akt=lánc első elemével
            while (akt!=null)
            {
                Console.WriteLine(akt.Value);
                akt = akt.Next; //akt.K
            }

            Console.ReadKey();

        }
    }
}
