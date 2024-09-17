/**
 * Autor: Agency
 * Dodatkowe zmiany przez: NotSoSilentCat (Fox-Coffee)
 * Zadanie: 4. Liczby pierwsze
 * Opis: Napisz program, który wygeneruje wszystkie liczby pierwsze mniejsze niż podana liczba n.
 * **/

namespace ConsoleApp1.functions
{
    internal class FuncLiczbyPierwsze
    {
        public static void LiczbyPierwsze()
        {
            Console.Write("Podaj liczbę: ");
            string liczba_string = Console.ReadLine();
            if (!int.TryParse(liczba_string, out int liczba))
            {
                Console.WriteLine("To nie jest liczba całkowita.");
                return;
            }

            Console.WriteLine($"Liczby pierwsze mniejsze od {liczba}:");

            for (int i = 2; i < liczba; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
