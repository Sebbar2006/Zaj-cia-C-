using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5dzial3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double x;
            do
            {
                Console.Write("Podaj x = ");
                x = Convert.ToDouble(Console.ReadLine());
            } while (x <= 0);
            Console.WriteLine("Wczytano liczbę x = {0}", x);
            Console.ReadKey(true);
        }

    }
}