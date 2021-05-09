using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Delta
    {
        private double a;
        private double b;
        private double c; 

        public Delta(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public void WpiszDane()
        {
            Console.WriteLine("Wpisz A:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz B:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz C: ");
            c = double.Parse(Console.ReadLine()); 
        }
        public override string ToString()
        {
            return $"Wzór równania kwadratowego: \n{a}x^2 {b}x {c}";
        }
        public double ObliczDelte()
        {
            return  Math.Pow(b, 2) - 4 * a * c;
        }
        public void WarunekDelty()
        {
            if(ObliczDelte()<0)
            {
                Console.WriteLine("Delta jest mniejsza od 0. Funckja nie posiada miejsc zerowych");
                Console.WriteLine(ToString());
            }
            else if(ObliczDelte()==0)
            {
                Console.WriteLine("Delta jest równa 0. Funkcja posiada jedno miejsce zerowe");
                Console.WriteLine(ToString());
                Console.WriteLine("Miejsce zerowe: {0}",(0 - b) / 2 * a);
            }
            else if(ObliczDelte()>0)
            {
                Console.WriteLine("Delta jest dodatnia. Funkcja posiada dwa miejsca zerowe");
                Console.WriteLine(ToString());
                Console.WriteLine("Pierwsze miejsce zerowe: {0}", Math.Round((0 - b) - Math.Sqrt(ObliczDelte()) / 2 * a),4);
                Console.WriteLine("Drugie miejsce zerowe: {0}", Math.Round((0 - b) + Math.Sqrt(ObliczDelte()) / 2 * a),4);  
            }
        }
    }
}
