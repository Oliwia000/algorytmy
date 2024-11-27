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

            int liczba = int.Parse(Console.ReadLine());

            Console.WriteLine("Czynniki pierwsze: ");
            Factorize(liczba);

        }

        private static void Factorize(int liczba)
        {
            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                while (liczba % i == 0)
                {
                    Console.WriteLine(i);
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
