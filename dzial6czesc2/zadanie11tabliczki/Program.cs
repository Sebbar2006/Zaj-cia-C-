using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie ósemkowym
namespace zadanie11tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i = 0, j, liczba;

            Console.WriteLine("Podaj liczbę naturalną");
            liczba = Convert.ToInt32(Console.ReadLine());

            while ((liczba / 8 != 0) || ((liczba / 8 == 0) && (liczba % 8 != 0)))
            {
                tab[i++] = liczba % 8;
                liczba /= 8;
            }


            for (j = i - 1; j >= 0; j--) Console.Write(tab[j]);
            Console.ReadKey();
        }
    }
}
