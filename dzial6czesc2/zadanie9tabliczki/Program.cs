using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
//sumę kwadratów wczytanych liczb.
namespace zadanie9tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("Podaj ile ma być liczb");
            c = Convert.ToInt32(Console.ReadLine());
            int[] liczby = new int[c];
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine("Podaj liczbę");
                liczby[i] = Convert.ToInt32(Console.ReadLine());

            }
            int[] kwadraty = new int[c];    
            for (int i = 0; i < liczby.Length; i++) 
            {
                kwadraty[i] = liczby[i] * liczby[i];
            }
            int pomocnicza = 0;
            for ( int i = 0; i < kwadraty.Length; i++)
            pomocnicza += kwadraty[i];
            Console.WriteLine(pomocnicza);
        }
    }
}
