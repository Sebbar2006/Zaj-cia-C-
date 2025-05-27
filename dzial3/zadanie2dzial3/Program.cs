using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2dzial3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, an, i;
            Console.Write("Podaj n = ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= n)
            {
                an = 2 * i - 1;
                Console.WriteLine("a({0})={1}", i, an);
                i++;
            }
            Console.ReadKey(true);
        }
    }
}