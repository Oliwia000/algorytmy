﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    /// Główna funkcja uruchamiająca algorytm szyfrowania Cezara.
    /// Użytkownik podaje tekst i klucz do zaszyfrowania.

    public static class cezar
    {
        public static void Run()
        {
            Console.WriteLine("Podaj tekst do  zaszyfrowania");
            string tekst = Console.ReadLine();

            Console.WriteLine("Podaj klucz do szyfrowania(liczba całkowita):");  // Liczba określająca o ile miejsc przesunąć litery.
            int klucz = int.Parse(Console.ReadLine());

            string zaszyfrowanyTekst = Encrypt(tekst, klucz); // Wywołanie funkcji szyfrującej

            Console.WriteLine($"Zaszyfrowany tekst: {zaszyfrowanyTekst}");
        }

        /// Szyfruje tekst poprzez przesunięcie liter o określoną liczbę miejsc w alfabecie.

        private static string Encrypt(string tekst, int klucz)
        {
            char[] zaszyfrowane = new
                char[tekst.Length];
            for (int i = 0; i < tekst.Length; i++)
            {
                char litera = tekst[i];
                if (char.IsLetter(litera))
                {
                    char offset = char.IsUpper(litera) ? 'A' : 'a';
                    zaszyfrowane[i] = (char)(((litera + klucz - offset) % 26) + offset);
                }
                else
                {
                    zaszyfrowane[i] = litera;
                } 
            }

            return  new string(zaszyfrowane);
        }
        
    }
}
