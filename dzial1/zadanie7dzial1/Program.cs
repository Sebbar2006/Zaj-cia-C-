using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7dzial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}/{1}={2} r {3}", a, b, a / b, a % b);
            Console.ReadKey(true);
        }
    }
}
