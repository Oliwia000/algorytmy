using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    public static class wstawianie
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
            for (int i = 1; i < n; i++)
            {
                int key = liczby[i];
                int j = i - 1;

                while (j >= 0 && liczby[j] > key)
                {
                    liczby[j + 1] = liczby[j];
                    j--;
                }

                liczby[j + 1] = key;
            }
        }
    }

}