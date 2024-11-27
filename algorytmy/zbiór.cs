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

            string[] input = Console.ReadLine().Split(' ');
            int[] liczby = Array.ConvertAll(input, int.Parse);

            int min = FindMin(liczby);
            int max = FindMax(liczby);

            Console.WriteLine($"Najmniejszy element: {min}");
            Console.WriteLine($"Największy element:  {max}");

        }
        private static int FindMin(int[] liczby)
        {
            int min = liczby[0];
            foreach (int liczba in liczby)
            {
                if (liczba < min)
                    min = liczba;
            }
            return min;
        }



        private static int FindMax(int[] liczby)
        {
            int max = liczby[0];
            foreach (int liczba in liczby)
            {
                if (liczba > max)
                    max = liczba;
            }
            return max;
        }

    }
}

