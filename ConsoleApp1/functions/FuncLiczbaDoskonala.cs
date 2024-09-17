/**
 * Autor: Agency
 * Dodatkowe zmiany przez: NotSoSilentCat (Fox-Coffee)
 * Zadanie: 2. Liczba doskonała
 * Opis: Napisz program, który sprawdzi, czy dana liczba jest liczbą doskonałą. Liczba doskonała to taka liczba, która jest równa sumie swoich dzielników właściwych (np. 6 jest liczbą doskonałą, ponieważ 1 + 2 + 3 = 6).
 * **/

namespace ConsoleApp1.functions
{
    internal class FuncLiczbaDoskonala
    {
        public static void LiczbaDoskonala()
        {
            Console.Write("Podaj liczbe a: ");
            string liczba1_string = Console.ReadLine();
            if(!int.TryParse(liczba1_string, out int liczba1))
            {
                Console.WriteLine("To nie jest liczba całkowita.");
            }
            if (liczba1 < 1)
            {
                Console.WriteLine("Liczba musi być większa od 0.");
                return;
            }

            int sumaDzielnikow = 0;

            for (int i = 1; i <= liczba1 / 2; i++)
            {
                if (liczba1 % i == 0)
                {
                    sumaDzielnikow += i;
                }
            }

            bool doskonala = sumaDzielnikow == liczba1;
            Console.WriteLine($"Liczba {liczba1} {(doskonala ? " jest" : " nie jest")} doskonała.");
        }
    }
}
