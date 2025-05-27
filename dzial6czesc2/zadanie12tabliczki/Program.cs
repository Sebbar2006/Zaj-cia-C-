using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie12tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i = 0, j, liczba;
            Console.WriteLine("Podaj liczbę");
            liczba = Convert.ToInt32(Console.ReadLine());

            while (liczba / 16 != 0 || ((liczba / 16 == 0) && (liczba % 16 != 0)))
            { tab[i++] = liczba % 16;
                liczba /= 16; }


            for (j = i - 1; j >= 0; j--)
            {
                if (tab[j] == 15)
                { Console.Write("F"); }
                if (tab[j] == 14)
                {       Console.Write("E");
            }
                if (tab[j] == 13)
                { Console.Write("D"); }
                if (tab[j] == 12)
                {       Console.Write("C");
            }
                if (tab[j] == 11)
                { Console.Write("B"); }
                if (tab[j] == 10)
                {     Console.Write("A");
            }





                Console.Write(tab[j]);
            }

        }
    }
}
