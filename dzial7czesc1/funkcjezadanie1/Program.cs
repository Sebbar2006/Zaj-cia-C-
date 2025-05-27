using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
//całkowitymi.Napisz program wykorzystujący funkcję suma.
namespace funkcje1
{
    internal class Program
    {

        static int SumUP(int a, int b) 
        {
            return a + b;
        }
        
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(("2 + 6 = {0}"), SumUP(2, 6));
        }
    }
}
