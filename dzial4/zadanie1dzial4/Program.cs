using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1dzial4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;
            Console.Write("Podaj a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b = ");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while (i <= b)
            {
                if (i % 2 == 0) Console.Write("{0}, ", i);
                i++;
            }
            Console.ReadKey(true);
        }
    }
}