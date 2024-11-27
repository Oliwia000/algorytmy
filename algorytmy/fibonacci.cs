using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    public static class fibonacci
    {
        public static void Run()
        {

            Console.WriteLine("Podaj liczbę n (elem.cięgu Fibonacciego):");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"F({i})={CalculateFibonacci(i)}");
            }
        }

        public static int CalculateFibonacci(int n)
        {
            if (n <= 1)
                return n; 

            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2); 
        }
    }
}
