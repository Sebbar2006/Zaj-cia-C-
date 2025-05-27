using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzial8
{
    internal class Program
    {
        
        static long silnia(int n)
        {
            if (n == 0) return 1;
            else return n * silnia(n - 1);
        }
       
        static void Main(string[] args)
        {
            Console.Write("Podaj n=");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Błędny argument!");
            else Console.WriteLine("{0}!={1}", n, silnia(n));
            Console.ReadKey(true); 
        }
    }
}