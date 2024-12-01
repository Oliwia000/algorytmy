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

            Console.WriteLine("Podaj liczbę n (elem.cięgu Fibonacciego):");  // Odczytanie liczby n, czyli liczby elementów ciągu Fibonacciego, do których chcemy obliczyć wartości.
            int n = int.Parse(Console.ReadLine());    // Pętla, która iteruje od 0 do n, wyświetlając dla każdego indeksu i wartość F(i) ciągu Fibonacciego.
            for (int i = 0; i <= n; i++)  
            {
                // Wyświetlenie obliczonej wartości F(i)
                Console.WriteLine($"F({i})={CalculateFibonacci(i)}");
            }
        }

        public static int CalculateFibonacci(int n)
        {
            // Warunek zakończenia : jeśli n jest mniejsze lub równe 1, zwróć wartość n.
            if (n <= 1)
                return n;
            //Wywołanie dla dwóch poprzednich elementów: F(n-1) i F(n-2), a następnie zwrócenie ich sumy.
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2); 
        }
    }
}
