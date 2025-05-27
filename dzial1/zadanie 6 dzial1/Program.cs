using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//działania matematyczne
namespace zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, suma, różnica, iloczyn, iloraz1, iloraz2;
            Console.WriteLine("Podaj a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            różnica = a - b;
            iloczyn = a * b;
            iloraz1 = a / b;
            iloraz2 = b / a;
            Console.WriteLine($" {a} + {b} = {suma}");
            Console.WriteLine($" {a} - {b} = {różnica}");
            Console.WriteLine($" {a} * {b} = {iloczyn}");
            Console.WriteLine($" {a} / {b} = {iloraz1}");
            Console.WriteLine($" {b} / {a} = {iloraz2}");
            Console.ReadKey(true);
        
        }
    }
}
