/**
 * Autor: Agency
 * Dodatkowe zmiany przez: NotSoSilentCat (Fox-Coffee)
 * Zadanie: 3. Sortowanie bąbelkowe
 * Opis: Zaimplementuj algorytm sortowania bąbelkowego, który sortuje tablicę liczb całkowitych w porządku rosnącym.
 * **/

namespace ConsoleApp1.functions
{
    internal class FuncSortowanieBombelkowe
    {
        public static void SortowanieBombelkowe()
        {
            Console.WriteLine("Podaj liczby do posortowania, oddzielone spacją:");

            // Pobranie liczb od użytkownika i zamiana ich na tablicę liczb całkowitych
            int[] liczby = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < liczby.Length; i++)
            {
                for (int j = 0; j < liczby.Length - 1; j++)
                {
                    if (liczby[j] > liczby[j + 1])
                    {
                        int temp = liczby[j];
                        liczby[j] = liczby[j + 1];
                        liczby[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Posortowane liczby:");
            foreach (int liczba in liczby)
            {
                Console.Write(liczba + " ");
            }
        }
    }
}
