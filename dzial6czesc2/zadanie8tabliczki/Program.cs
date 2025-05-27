using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący ciąg n (1<=n<=1000) liczb naturalnych i wypisujący na ekranie
//wszystkie parzyste liczby w kolejności niemalejącej. Do wypisywania elementów tablicy użyj
//pętli foreach.
namespace zadanie8tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int c, tmp;                 
            Console.WriteLine("podaj ile ma być liczb");
            c = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[c];                                 

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj liczbę");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            int parzCount = 0;                                  //przeliczenie ile jest liczb parzystych
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 0)
                    parzCount++;
            }
            int[] parzyste = new int[parzCount];            // nowa tablica dla liczb parzystych
            int index = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 0)
                    parzyste[index++] = tab[i];
            }
            for (int i = 0; i < parzyste.Length - 1; i++)           //sortowanie bąbelkowe
            {
                for (int j = i + 1; j < parzyste.Length; j++)
                {
                    if (parzyste[i] < parzyste[j])
                    {
                        tmp = parzyste[i];
                        parzyste[i] = parzyste[j];
                        parzyste[j] = tmp;
                    }
                }
            }


            foreach (int liczba in parzyste)
            { Console.Write("{0} ",liczba); }

        }
    }
}
