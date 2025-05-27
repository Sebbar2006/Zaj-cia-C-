using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z
//uwzględnieniem części całkowitej i reszty z dzielenia.
namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a, b;
                Console.Write("Podaj a=");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj b=");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}/{1}={2} r {3}", a, b, a / b, a % b);
                Console.ReadKey(true); //pauza
            }
        }
    }
}