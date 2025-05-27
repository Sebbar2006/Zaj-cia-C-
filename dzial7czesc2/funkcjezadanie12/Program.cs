using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję, która posiada parametr będący liczbą naturalną zapisaną w systemie
//dziesiętnym, zamienia go na liczbę zapisaną w systemie ósemkowym i zwraca wyznaczoną
//liczbę jako wartość funkcji. Napisz program testujący utworzoną funkcję.

namespace funkcjezadanie12
{
    internal class Program
    {
        static int osiem(int x)
        {
            if (x == 0) return 0; // pokrycie dla wprowadzenia liczby równej zero
            int i = 0;
            int[] tab = new int[1000];
            while ((x / 8 != 0) || ((x / 8 == 0) && (x % 8 != 0)))
            {
                tab[i++] = x % 8;
                x /= 8;
            }
            int octal = 0;
            int multiplier = 1;
            for (int j = 0; j < i; j++)
            {
                octal += tab[j] * multiplier;
                multiplier *= 10;
            }
            return octal;

        }
        
        
        
        
        
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(osiem(834));
        }
    }
}
