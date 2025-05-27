using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
//powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb. Przetestuj działanie
//utworzonej funkcji.
namespace funkcjezadanie5
{
    internal class Program
    {
        static int pierwsza(int liczba)
        {
            int i;
            for (i = 2; i < liczba / 2; i++) 
            
                if (liczba % i == 0) return 0;
                return 1;
            
            
        
        
        
        }
        
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            int a;
            a = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("{0}", pierwsza(a));
        }
    }
}
