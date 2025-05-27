using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
//sumę wczytanych liczb.
namespace zadanie4tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int c;
            int n;
            int suma = 0;
            Console.WriteLine("Podaj ile ma być liczb");
            c = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[c];
            n = c;

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj liczbę");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)  
            {
                suma += tab[i];
            }
            Console.WriteLine("Suma to {0}", suma);
            
        }
    }
}
