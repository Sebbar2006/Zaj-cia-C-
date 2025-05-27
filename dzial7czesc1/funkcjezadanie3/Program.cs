using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca
//obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola.
namespace funkcjezadanie3
{
    internal class Program
    {
        static double pole(double r)
        {
            return Math.PI * r * r;
        }
        
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("podaj promień");
            double r;
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole okręgu o promieniu {0} to {1}", r, pole(r));
        }
    }
}
