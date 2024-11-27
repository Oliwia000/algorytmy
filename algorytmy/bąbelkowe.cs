using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    public static class bąbelkowe
    {
        public static void Run()
        {
            Console.WriteLine("Podaj liczby do posortowania oddzielone spacjami:");
            string[] input = Console.ReadLine().Split(' ');
            int[] liczby = Array.ConvertAll(input, int.Parse);

            Sort(liczby);

            Console.WriteLine("Posortowane liczby:");
            Console.WriteLine(string.Join(" ", liczby));
        }

        private static void Sort(int[] liczby)
        {
            int n = liczby.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (liczby[j] > liczby[j + 1])
                    {
                        int temp = liczby[j];
                        liczby[j] = liczby[j + 1];
                        liczby[j + 1] = temp;
                    }
                }
            }
        }
    }
}
