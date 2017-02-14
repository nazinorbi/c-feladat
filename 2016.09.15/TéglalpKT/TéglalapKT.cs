using System; //névtér

namespace TéglalpKT
{
    class TéglalapKT
    {
        static void Main()
        {
            Console.Title = "Ez az ablakom címe";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Téglalap kerülete és területe");
            //int a; //deklaráció (típus + azonosító)
            //int b = 0; //definíció ((típus + azonosító + érték)
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int T = a * b;
            int K = 2 * (a + b);
            Console.WriteLine("T={0} K={1}", T, K);
            Console.ReadKey(); 
        }
    }
}
