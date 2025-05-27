using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję, która posiada jeden parametr będący rokiem. Ma ona zwracać wartość 1, jeśli
//rok jest przestępny i 0 w pozostałych przypadkach. Napisz program testujący utworzoną
//funkcję.

namespace funkcjezadanie8
{
  
    
    internal class Program
    {

        static int przestepny (int rok)
        {
            while ((rok % 4 == 0 && !(rok % 100 == 0)) || (rok % 400 == 0))
                return 1; 
            return 0;

        }










        static void Main(string[] args)
        {
            Console.WriteLine(przestepny(4));
        }
    }
}
