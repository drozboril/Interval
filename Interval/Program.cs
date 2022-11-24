using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte počáteční bod intervalu");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte konečný bod intervalu");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte číslo");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            if (a <= c && c >= b) //c musí být rovno nebo větší než a ale zároveň musí být rovno nebo menší než b
            {
                Console.WriteLine("Číslo {0} nespadá do intervalu čísel {1} a {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("Číslo {0} spadá do intervalu čísel {1} a {2}", c, a, b);
            }
            Console.ReadLine();
        }
    }
}