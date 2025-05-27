using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
//wypisujący posortowane liczby na ekranie.
namespace zadanie3tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            int i, j;
            int n, tmp;
            Console.WriteLine("Podaj ile ma być liczb");
            c = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[c];
            n = c;

            for (i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj liczbę");
                tab[i] = Convert.ToInt32(Console.ReadLine());   
            }
            for (i = 0; i < n; i++)                     // te zapętlone for-y to sortowanie bąbelkowe
            {
                for (j = i + 1; j < n; j++)
                {
                    if (tab[i] > tab[j])
                    {
                        tmp = tab[i]; tab[i] = tab[j]; tab[j] = tmp;
                    }
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", tab[i]);
            }
            Console.ReadKey();
        }
    }
}
