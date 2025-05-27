using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać funkcję o nazwie NWD zwracającą wartość największego wspólnego dzielnika dla jej
//dwóch argumentów będących liczbami naturalnymi.
//Napisz program testujący utworzoną funkcję.

namespace funkcjezadanie10
{
    internal class Program
    {

        static int NWD(int a, int b)
        {
            int min = 0;
            if (a > b) {min = b;} else {min = a;}
            for (int i = min; i >= 1; i--)
            {

                if (a % i == 0 && b % i == 0)
                    return i;

            }
            return 1;
        
        
        }
        
        
        
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(NWD(80, 40));
        }
    }
}
