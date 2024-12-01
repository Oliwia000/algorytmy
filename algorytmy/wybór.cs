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

            // Wywołanie metody sortującej.
            Sort(liczby);

            // Wyświetlenie posortowanych liczb.
            Console.WriteLine("Posortowane liczby:");
            Console.WriteLine(string.Join(" ", liczby));
        }

        private static void Sort(int[] liczby)
        {
            int n = liczby.Length;
            // Pętla po wszystkich elementach tablicy (oprócz ostatniego).
            for (int i = 0; i < n - 1; i++)
            {
                // Założenie, że bieżący element to najmniejszy.
                int minIndex = i;

                // Pętla wewnętrzna szukająca najmniejszego elementu w pozostałej części tablicy.
                for (int j = i + 1; j < n; j++)
                {
                    if (liczby[j] < liczby[minIndex])
                    {
                        minIndex = j;   // Zaktualizowanie indeksu najmniejszego elementu.
                    }
                }

                // Zamiana znalezionego najmniejszego elementu z aktualnym elementem.
                int temp = liczby[minIndex];
                liczby[minIndex] = liczby[i];
                liczby[i] = temp;
            }
        }
    }
}

