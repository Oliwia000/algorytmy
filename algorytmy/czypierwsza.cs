using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class czypierwsza
{
    public static void Run()
    {
        Console.WriteLine("Podaj liczbę do sprawdzenia"); // Wyświetla prośbę o podanie liczby
       int liczba = int.Parse(Console.ReadLine());     // Pobiera liczbę od użytkownika i zmiennia ją na typ całkowity

        if (IsPrime(liczba)) // Sprawdza, czy liczba jest pierwsza
        {
            Console.WriteLine($"Liczba {liczba} jest liczbą pierwszą.");
        }
        else
        {
            Console.WriteLine($"Liczba {liczba}  nie jest liczbą pierwszą.");
        }
    }

    private static bool IsPrime(int liczab)
    {
        if (liczab < 2)
            return false;
        for (int i = 2; i <= Math.Sqrt(liczab); i++)
        {
            if (liczab % i == 0) // Jeśli liczba jest podzielna przez i, nie jest pierwsza
                return false;
        }
        return true;   // Jeśli nie znaleziono podzielników, liczba jest pierwsza
    }
}


