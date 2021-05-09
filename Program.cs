using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Delta d1 = new Delta(0,0,0);
            d1.WpiszDane();
            d1.ToString();
            Console.WriteLine(d1.ObliczDelte());
            d1.WarunekDelty();

            Console.ReadKey();
        }
    }
}
