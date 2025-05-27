using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych (dodatnich i ujemnych) i
//wypisujący wczytane liczby na ekranie.
namespace zadanie1tabliczki
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ile chcesz podać cyfr?");
            int c = Convert.ToInt32(Console.ReadLine());
            int[] Z = new int[c];
                
            for (int i = 0; i < Z.Length; i++)

               {
                Console.WriteLine("Podaj liczbę");
                Z[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Liczby, które podałeś to: ");
            for (int i = 0; i < Z.Length; i++)
            {
                Console.Write("{0} ", Z[i]);
            }



        }
    }
}
