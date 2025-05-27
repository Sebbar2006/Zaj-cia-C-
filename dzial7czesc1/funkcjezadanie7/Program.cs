using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcjezadanie7
{
   // Napisz funkcję posiadającą dwa argumenty: p, q – długości przekątnych deltoidu. Funkcja ma
  //  zwracać pole deltoidu dla zadanych argumentów.Napisz program testujący utworzoną
 //   funkcję.
 
    internal class Program
    {
        static int deltoid(int p, int q)
        {
            return ( p * q / 2);

        }
        
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("pole deltoidu o przekątnych 4 i 8 to {0}", deltoid(4, 8));
        }
    }
}
