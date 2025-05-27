using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać funkcję o nazwie NWW zwracającą wartość najmniejszej wspólnej wielokrotności dla
//jej dwóch argumentów będących liczbami naturalnymi.
//Napisz program testujący utworzoną funkcję.
//Wskazówka: NWW(a, b) = a * b / NWD(a, b).
namespace funkcjezadanie11
{
    internal class Program
    {
        static int NWW(int a, int b) 
        {
            int min = 0;
            if (a > b) { min = b; } else { min = a; }
            for (int i = min; i <= min; i--)
                if (a % i == 0 && b % i == 0)
            
            { return a * b / i; } return a * b;
        
        }
        
        
        
        static void Main(string[] args)

        { Console.WriteLine(NWW(12, 16));
        }
    }
}
