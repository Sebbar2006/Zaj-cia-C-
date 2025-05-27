using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3dzial3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, suma = 0;
            Console.Write("Podaj a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b = ");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while (i <= b)
            {
                suma += i;
                i++;
            }
            Console.WriteLine("{0}+...+{1}={2}", a, b, suma);
            Console.ReadKey(true);
        }
    }
}
