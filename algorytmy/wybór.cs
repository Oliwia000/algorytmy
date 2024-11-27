using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    public static class wybór
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
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (liczby[j] < liczby[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = liczby[minIndex];
                liczby[minIndex] = liczby[i];
                liczby[i] = temp;
            }
        }
    }

