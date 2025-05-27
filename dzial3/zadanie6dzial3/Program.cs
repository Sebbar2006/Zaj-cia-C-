using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6dzial3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            double a, b;
            do
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - oblicz pole prostokata");
                Console.WriteLine("2 - oblicz pole kwadratu");
                Console.WriteLine("3 - oblicz pole trojkata");
                Console.WriteLine("0 - koniec");
                Console.Write("Twoj wybor: ");
                wybor = Convert.ToInt32(Console.ReadLine());
                switch (wybor)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Podaj długość boku a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj długość boku b = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole prostokąta wynosi = {0}", a * b);
                        break;
                    case 2:
                        Console.Write("Podaj długość boku a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole kwadratu wynosi = {0}", a * a);
                        break;
                    case 3:
                        Console.Write("Podaj długość podstawy a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj długość wysokości h = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole trojkąta wynosi = {0}", a * b / 2.0);
                        break;
                    default:
                        Console.WriteLine("Błąd: Nieznany wybor");
                        break;
                }
            } while (wybor != 0);
        }
    }
}
