    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
//najmniejszą i największą wczytaną liczbę.
namespace zadanie7tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile ma być liczb");
            int c;
            c = Convert.ToInt32(Console.ReadLine());
            int[] liczba = new int[c];

            for (int i = 0; i < liczba.Length; i++)
            {
                Console.WriteLine("Podaj liczbę");
                liczba[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = liczba[0];
                int max = liczba[0];
            
            for (int i = 0; i < liczba.Length; i++)
            {
                if (liczba[i] < min)
                    min = liczba[i];    
                if (liczba[i] > max)
                    max = liczba[i];
            }
            Console.WriteLine("Liczba najmniejsza to {0}, a największa to {1}", min, max);
            Console.ReadKey();
        }
    }
}
