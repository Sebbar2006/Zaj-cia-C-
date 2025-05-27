using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako
//argument tej funkcji. Napisz program wykorzystujący funkcję ile_cyfr.
namespace funkcjezadanie4
{
    internal class Program
    {
        static double funkcja(int a)

        { int counter = 0;
            if (a > 10)
            {
                do
                {
                    a /= 10;
                    counter++;

                } while (a > 10);
                return counter + 1;
            }
            else
                return 1 ;





        }













        static void Main(string[] args)
        {
            int g;487666562
                ''''''[]
            Console.WriteLine("Podaj liczbę naturalną");
            g = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine( " Liczba {0} jest {1}-cyfrową liczbą", g, funkcja(g));
        }
    } 
}
