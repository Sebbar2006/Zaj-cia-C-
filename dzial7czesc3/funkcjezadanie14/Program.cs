using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję, która stwierdza, czy zadana jako argument liczba całkowita kończy się swoim
//pierwiastkiem. Liczby kończące się swoim pierwiastkiem to np.: 25, 625.Wartością funkcji ma
//być jeden, jeśli liczba spełnia warunek lub zero w przeciwnym przypadku.
//Napisz program testujący utworzoną funkcję.
namespace funkcjezadanie14
{
    internal class Program
    {
        static int CzyKonczySiePierwiastkiem(int n)
        {
            if (n < 1) return 0;

            // Szukamy pierwiastka całkowitego
            int pierwiastek = 0;
            for (int i = 1; i * i <= n; i++)
            {
                if (i * i == n)
                {
                    pierwiastek = i;                //zdefiniowanie pierwiastka
                    break;
                }
            }

            if (pierwiastek == 0) return 0; // Brak pierwiastka całkowitego

            // Sprawdzamy, czy liczba kończy się swoim pierwiastkiem (bez konwersji na string)
            int liczba = n;
            int pozostalosc = 1;
            int temp = pierwiastek;

            // Obliczamy pozostałość (np. dla 25 → pozostałość = 100, dla 625 → pozostałość = 1000)
            while (temp != 0)
            {
                pozostalosc *= 10;
                temp /= 10;
            }

            return (n % pozostalosc == pierwiastek) ? 1 : 0;
        }

        static void Main()
        {
            Console.WriteLine("Testowanie funkcji CzyKonczySiePierwiastkiem:");
            int[] testy = { 25, 625, 1, 5, 16, 36, 100, 121, 144, 169, 200, 225, 76, 77, 1000 };

            foreach (int liczba in testy)
            {
                int wynik = CzyKonczySiePierwiastkiem(liczba);
                Console.WriteLine($"{liczba} → {wynik} ({(wynik == 1 ? "TAK" : "NIE")})");
            }
        }
    }
}