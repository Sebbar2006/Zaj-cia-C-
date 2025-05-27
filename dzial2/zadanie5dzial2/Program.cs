using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5dzial2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.Write("Podaj rok: ");
            rok = Convert.ToInt32(Console.ReadLine());
            if (((rok % 4 == 0) && (rok % 100 != 0)) || (rok % 400 == 0))
                Console.WriteLine("Rok {0} jest przestępny.", rok);
            else
                Console.WriteLine("Rok {0} nie jest przestępny.", rok);
            Console.ReadKey(true);
        }
    }
}
