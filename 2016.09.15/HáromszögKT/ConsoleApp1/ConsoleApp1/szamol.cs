using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszögSzamol
{
    class szamol
    {
        public int a;
        public int b;
        public int c;
        string newCalc;

        public szamol()
        {
            this.HáromszögTK();
        }

        public void HáromszögTK() {
            this.Beker();

            if (this.a + this.b > this.c && this.b + this.c > this.a && this.c + this.a > this.b)
            {
                this.Szam(this.a, this.b, this.c);
                Console.ReadKey();

            }
            else
            {
                Console.Write("Ez nem háromszög");
                this.Beker();
                this.Szam(this.a, this.b, this.c);
            }
            Console.Write("Számoljunk ujjat?");
            
            Console.Write("newCalc=");
            this.newCalc = Console.ReadLine();

            if(this.newCalc == "Igen")
            {
                this.HáromszögTK();        
                Console.Write("A program véget ért");
                Console.ReadKey();
            } else
            {
                Console.Write("A program véget ért");
                Console.ReadKey();
            }

            return;

        }

        public void Szam(int a, int b, int c)
        {
            int k = a + b + c;
            double s = k / 2;
            double t = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("A háromszög kerülete: {0}", k);
            Console.WriteLine("A háromszög területe: {0:F3}", t);

        }

        public void Beker()
        {
            Console.WriteLine("A három szög területe kerülete");

            Console.Write("a=");
            this.a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b=");
            this.b = Convert.ToInt32(Console.ReadLine());

            Console.Write("a=");
            this.c = Convert.ToInt32(Console.ReadLine());
        }
    }
}
