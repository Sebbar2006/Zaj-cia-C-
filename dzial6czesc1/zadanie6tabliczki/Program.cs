using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli
//foreach.
namespace zadanie6tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dni = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };

            foreach (string dzien in dni)
            {   Console.WriteLine(dzien);
            
            
            }
        }
    }
}
