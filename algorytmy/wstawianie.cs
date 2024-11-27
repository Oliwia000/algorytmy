using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    public static class wstawianie
    {


        /// Główna funkcja uruchamiająca algorytm sortowania przez wstawianie.
        /// Użytkownik podaje liczby, które mają zostać posortowane.
      

        public static void Run()
        {
            Console.WriteLine("Podaj liczby do posortowania oddzielone spacjami:");
            string[] input = Console.ReadLine().Split(' ');
            int[] liczby = Array.ConvertAll(input, int.Parse);

            Sort(liczby);  // Wywołanie algorytmu sortowania

            Console.WriteLine("Posortowane liczby:");
            Console.WriteLine(string.Join(" ", liczby));  // Wyświetlenie posortowanych liczb

        }

        /// Algorytm sortowania przez wstawianie.
        /// Działa poprzez wstawianie elementu do odpowiedniej pozycji w posortowanej części tablicy.

        private static void Sort(int[] liczby)
        {
            int n = liczby.Length;
            for (int i = 1; i < n; i++)
            {
                int key = liczby[i]; // Klucz to element do wstawienia

                int j = i - 1;

                // Przesuwamy elementy, które są większe od klucza

                while (j >= 0 && liczby[j] > key)
                {
                    liczby[j + 1] = liczby[j];
                    j--;
                }

                // Wstawiamy klucz w odpowiednie miejsce
                liczby[j + 1] = key;
            }
        }
    }

}