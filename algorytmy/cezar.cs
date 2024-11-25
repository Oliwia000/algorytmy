using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    public static class cezar
    {
        public static void Run()
        {
            Console.WriteLine("Podaj tekst do  zaszyfrowania");
            string tekst = Console.ReadLine();

            Console.WriteLine("Podaj klucz do szyfrowania(liczba całkowita):");
            int klucz = int.Parse(Console.ReadLine());

            string zaszyfrowanyTekst = Encrypt(tekst, klucz);

            Console.WriteLine($"Zaszyfrowany tekst: {zaszyfrowanyTekst}");
        }

        private static string Encrypt(string tekst, int klucz)
        {
            char[] zaszyfrowane = new
                char[tekst.Length];
            for (int i = 0; i < tekst.Length; i++)
            {
                char litera = tekst[i];
                if (char.IsLetter(litera))
                {
                    char offset = char.IsUpper(litera);
                   

                }

            }

        }

        
    }
}
