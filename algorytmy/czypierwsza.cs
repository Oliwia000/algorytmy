using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class czypierwsza
{
    public static void Run()
    {
        Console.WriteLine("Podaj liczbę do sprawdzenia");
        int liczba = int.Parse(Console.ReadLine());

        if (IsPrime(liczba))
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
            if (liczab % i == 0)
                return false;
        }
        return true;
    }
}

//}
