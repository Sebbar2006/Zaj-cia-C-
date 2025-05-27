using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący wczytane
//liczby w odwrotnej kolejności na ekranie.
namespace zadanie2tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("Podaj ile ma być liczb");
            c = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[c];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj liczbę");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            } Console.WriteLine("te liczby to: ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(" {0}", 1.0 / tab[i]);
            }
        
        }

    }
}
