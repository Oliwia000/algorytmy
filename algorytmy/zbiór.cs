using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    public static class zbiór
    {
        public static void Run()
        {
            Console.WriteLine("Podaj liczby oddzielone spacjami:");

            // Odczytanie danych wejściowych i podzielenie ich na tablicę ciągów znaków.

            string[] input = Console.ReadLine().Split(' ');
            int[] liczby = Array.ConvertAll(input, int.Parse);

            // Wywołanie metod do znalezienia najmniejszego i największego elementu w zbiorze.
            int min = FindMin(liczby);
            int max = FindMax(liczby);

            // Wyświetlenie wyników.
            Console.WriteLine($"Najmniejszy element: {min}");
            Console.WriteLine($"Największy element:  {max}");

        }
        private static int FindMin(int[] liczby)
        {
            int min = liczby[0];
            foreach (int liczba in liczby) //porównanie każdej liczby z aktualnym minimalnym elementem.
            {
                if (liczba < min)
                    min = liczba;
            }
            return min; // Zwrócenie najmniejszego elementu.
        }



        private static int FindMax(int[] liczby)
        {
            int max = liczby[0];
            //porównanie każdej liczby z aktualnym maksymalnym elementem.
            foreach (int liczba in liczby)
            {
                if (liczba > max)
                    max = liczba;
            }
            return max;  // Zwrócenie największego elementu.
        }

    }
}

