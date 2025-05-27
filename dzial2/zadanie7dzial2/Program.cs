using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę arabską od 1 do 3999: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 3000) { a -= 3000; Console.Write("MMM"); }
            else if (a >= 2000) { a -= 2000; Console.Write("MM"); }
            else if (a >= 1000) { a -= 1000; Console.Write("M"); }

            if (a >= 900) { a -= 900; Console.Write("CM"); }
            else if (a >= 800) { a -= 800; Console.Write("DCCC"); }
            else if (a >= 700) { a -= 700; Console.Write("DCC"); }
            else if (a >= 600) { a -= 600; Console.Write("DC"); }
            else if (a >= 500) { a -= 500; Console.Write("D"); }
            else if (a >= 400) { a -= 400; Console.Write("CD"); }
            else if (a >= 300) { a -= 300; Console.Write("CCC"); }
            else if (a >= 200) { a -= 200; Console.Write("CC"); }
            else if (a >= 100) { a -= 100; Console.Write("C"); }

            if (a >= 90) { a -= 90; Console.Write("XC"); }
            else if (a >= 80) { a -= 80; Console.Write("LXXX"); }
            else if (a >= 70) { a -= 70; Console.Write("LXX"); }
            else if (a >= 60) { a -= 60; Console.Write("LX"); }
            else if (a >= 50) { a -= 50; Console.Write("L"); }
            else if (a >= 40) { a -= 40; Console.Write("XL"); }
            else if (a >= 30) { a -= 30; Console.Write("XXX"); }
            else if (a >= 20) { a -= 20; Console.Write("XX"); }
            else if (a >= 10) { a -= 10; Console.Write("X"); }

            switch (a)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;
            }
            Console.ReadKey(true);
            switch (a)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;
                default: Console.Write(""); break;
            }
            Console.ReadKey(true);




        }
    } 
}

