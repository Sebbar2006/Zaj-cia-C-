using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać funkcję, która posiada trzy argumenty będące współczynnikami a, b, c funkcji
//kwadratowej y = ax^2 + bx + c. Funkcja ma zwracać ilość pierwiastków zadanej funkcji
//kwadratowej. Napisz program testujący utworzoną funkcję.

namespace funkcjezadanie9
{
    internal class Program
    {
        static int delta(int a, int b, int c)
        {
           
            if (b * b - 4 * a * c < 0)
                return 0;
            else if (b * b - 4 * a * c == 0)
                return 1;
            else
                return 2;

        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("ilość miejsc zerowych w funkcji y = 4x^2 + 6x + 14 to {0}", delta(4, 2, 6));
        }
    }
}
