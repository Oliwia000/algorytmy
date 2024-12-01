using System;

namespace algorytmy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /// Główna funkcja programu, umożliwiająca wybór algorytmu do uruchomienia.

            Console.WriteLine(" Wybierz Algorytm:  ");
            Console.WriteLine("1 - Sprawdzanie,czy liczba jest liczbą pierwszą");
            Console.WriteLine("2 - Algorytm Euklidesa (NWD)");
            Console.WriteLine("3 - Szyfr Cezara");
            Console.WriteLine("4 - Znajdowanie liczb Fibonacciego");
            Console.WriteLine("5 - Rozkład liczby na czynniki pierwsze");
            Console.WriteLine("6 - Znajdowanie najmniejszego oraz największego elementu w\r\nzbiorze");
            Console.WriteLine("7 - Sortowanie bąbelkowe");
            Console.WriteLine("8 - Sortowanie przez wybór");
            Console.WriteLine("9 - Sortowanie przez wstawianie");
            Console.WriteLine("10 - Wyjście");


            int wybor = int.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    czypierwsza.Run();
                break;

                case 2:
                    euklides.Run();
                break;

                case 3:
                    cezar.Run();
                break;
                case 4:
                    fibonacci.Run();
                break;

                case 5:
                    rozkladliczpierwsze.Run();
                break;

                case 6:
                    zbiór.Run();
                break;
                case 7:
                    bąbelkowe.Run();
                break;
                case 8:
                    wybór.Run();
                break;
                case 9:
                    wstawianie.Run();
                break;

                case 10:
                    Console.WriteLine("Zamykanie programu.");
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór");
                    break;

            }


        }


    }
}

