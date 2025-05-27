using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcjezadanie15
{
    internal class Program
    {
        // Procedura rysująca choinkę
        static void RysujChoinke(int wysokosc)
        {
            for (int i = 1; i <= wysokosc; i++)
            {
                // Spacje przed gwiazdkami
                for (int j = 0; j < wysokosc - i; j++)
                    Console.Write(" ");
                // Gwiazdki
                for (int j = 0; j < 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        // Program testujący
        static void Main(string[] args)
        {
            Console.Write("Podaj wysokość choinki: ");
            int wysokosc = int.Parse(Console.ReadLine());
            RysujChoinke(wysokosc);
        }
    }
}