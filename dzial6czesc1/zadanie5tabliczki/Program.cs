using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym.
namespace zadanie5tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; 
            int i = 0, j, liczba;

            
            Console.Write("Podaj liczbę naturalną: ");
            liczba = Convert.ToInt32(Console.ReadLine());

            
            while ((liczba / 2 != 0) || ((liczba / 2 == 0) && (liczba % 2 != 0)))
            {
                tab[i++] = liczba % 2;
                liczba /= 2;
            }

         
            for (j = i - 1; j >= 0; j--) Console.Write(tab[j]);
            Console.ReadKey(true); 

        }
    }
}
