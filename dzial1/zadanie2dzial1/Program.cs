using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2dzial1
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
            Console.Write("Podaj swoje imię: ");
            imie = Console.ReadLine();
            Console.WriteLine("Witaj {0}!", imie);
            Console.ReadKey(true);
        }
    }
}
