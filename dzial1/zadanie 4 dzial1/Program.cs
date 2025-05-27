using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Podaj pierwszy bok prostokąta a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugi bok prostokąta b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole = {0}", a * b);
            Console.WriteLine("Obwód = {0}", 2 * a + 2 * b);
            Console.ReadKey(true);
        
        }
    }
}
