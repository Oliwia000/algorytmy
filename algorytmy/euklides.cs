using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{

    public static class euklides
    {
        /// Główna metoda uruchamiająca proces obliczania NWD.
        /// Prosi użytkownika o wprowadzenie dwóch liczb, a następnie wyświetla wynik.
       public static void Run()
        {
            Console.WriteLine("Podaj pierwszą liczbę");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę");

            int b = int.Parse(Console.ReadLine());

            int nwd = CalculateGCD(a, b); // Oblicza NWD za pomocą metody CalculateGCd

            Console.WriteLine($"Największy wspólny dzielnik (NWD) liczb {a} i {b} to:{nwd}");


        }

        private static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b; // Przechowuje wartość b tymczasowo
                b = a % b;  // Oblicza resztę z dzielenia a przez b
                a = temp;  // Przypisuje wartość tymczasową do a
            }
            return a;  // Zwraca NWD
        }
    }
}