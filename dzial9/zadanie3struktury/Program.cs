using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3struktury
{
    struct Osoba
    {
        public string imie, nazwisko;
        public int rok_urodzenia;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o;

            Console.Write("Podaj imię: ");
            o.imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            o.nazwisko = Console.ReadLine();
            Console.Write("Podaj rok urodzenia: ");
            o.rok_urodzenia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {1} urodzili się w {2} roku.", o.imie, o.nazwisko, o.rok_urodzenia);
            Console.ReadKey(true);
        }
    }
}