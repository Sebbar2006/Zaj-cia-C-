using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
//zadanych jako argumenty tej funkcji. Napisz program wykorzystujący funkcję max.
namespace funkcjezadanie2
{
    internal class Program
    {

        static double Maksimum(double a, double b)
        {
            if (a > b)
                return a;
            else  return b;
            
        }
        
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Maksimum z liczb 18 i 25 to {0}", Maksimum(18, 25));
        }
    }
}
