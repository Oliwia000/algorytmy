using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    public static class euklides
    {
        public static void Run()
        {
            Console.WriteLine("Podaj pierwszą liczbę");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę");

            int b = int.Parse(Console.ReadLine());

            int nwd = CalculateGCD(a, b);

            Console.WriteLine($"Największy wspólny dzielnik (NWD) liczb {a} i {b} to:{nwd}");


        }

        private static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}