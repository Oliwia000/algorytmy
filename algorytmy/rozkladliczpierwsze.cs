using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    public static class rozkladliczpierwsze
    {
        public static void Run()
        {
            Console.WriteLine("Podaj liczbę do rozkładu na czynniki pierwsze : ");

            // Odczytanie danych wejściowych i zminna na liczbę całkowitą.
            int liczba = int.Parse(Console.ReadLine());

            Console.WriteLine("Czynniki pierwsze: ");  // Wyświetlenie nagłówka wyników.
            Factorize(liczba);   // Wywołanie metody Factorize, która rozkłada liczbę na czynniki pierwsze.

        }

        private static void Factorize(int liczba)
        {
            // Pętla iterująca przez możliwe dzielniki od 2 do pierwiastka z liczby.
            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                while (liczba % i == 0)  // Sprawdzenie, czy liczba jest podzielna przez i
                {
                    Console.WriteLine(i);   // Wypisanie czynnika pierwszego i podzielenie liczby przez i.
                    liczba /= i;
                }
            }
            if (liczba > 1)
            {
                Console.WriteLine(liczba);
            }

        }
    }
}
