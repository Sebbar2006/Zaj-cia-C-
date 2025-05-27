using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję o nazwie czy_kw, która stwierdza, czy zadana jako parametr liczba całkowita
//jest kwadratem pewnej liczby całkowitej. Liczby będące kwadratami liczb całkowitych to 1, 4,
//9, 16, 25, itd. Wartością funkcji ma być jeden, jeśli liczba spełnia warunek lub zero w
//przeciwnym przypadku. Napisz program testujący utworzoną funkcję czy_kw.
//Proszę nie korzystać z funkcji matematycznej Math.Sqrt().
namespace funkcjezadanie13
{
    internal class Program
    {
        static int czy_kw(int n)
        {
            if (n < 0) return 0;            // x^2 >= 0
            if (n == 0) return 1;               // 0^2 = 0
        
        for (int i = 1; i * i <= n; i++)            // i * i < n        ==> n to podata liczba a i to pierwiastek z n
            {
                if ( i * i ==n) return 1;           // tylko wtedy jest prawda
            }

            return 0;                               // return 0 dla pozostałych wartości
        }


        static void Main(string[] args)
        {
            int[] testy = { 1, 14, 256, 196, 300, 449, 81, 6761, 441 };
            foreach (int i in testy)                        // wypisanie każdego po kolei
            {
                int wynik = czy_kw(i);
                Console.WriteLine($"czy_kw(i) = {wynik}");

            }
        }
    }
}
