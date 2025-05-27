using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2dzial2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("liczba {0} jest dodatnia.", a);
            else if (a < 0)
                Console.WriteLine("liczba {0} jest ujemna.", a);
            else
                Console.WriteLine("liczba {0} jest równa zero.", a);
            Console.ReadKey(true);
        }
    }
}
