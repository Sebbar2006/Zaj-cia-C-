using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
//informację ile liczb jest dodatnich, ujemnych i równych zero.
namespace zadanie10tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("Ile ma być liczb");
            c = Convert.ToInt32(Console.ReadLine());
            int[] liczby = new int[c];

            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine("Podaj liczbę");
                liczby[i] = Convert.ToInt32(Console.ReadLine());    
            }
            int dodatnie = 0;
            int ujemne = 0;
            int zero = 0;

            for (int i = 0; i < liczby.Length; i++) 
            { if (liczby[i] > 0 )
                    dodatnie += 1;
              if (liczby[i] < 0)
                    ujemne += 1;
                if (liczby[i] == 0)
                    zero += 1;
            }
            for (int i = 0; i < 1; i++)
                Console.Write("Liczb dodatnich jest {0}, ujemnych {1}, a liczb zero {2}", dodatnie, ujemne, zero); 
        }
    }
}
