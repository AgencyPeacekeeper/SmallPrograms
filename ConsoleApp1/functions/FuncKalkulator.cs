/**
 * Autor: Agency
 * Dodatkowe zmiany przez: NotSoSilentCat (Fox-Coffee)
 * Zadanie: 1. Kalkulator
 * Opis: Napisz program konsolowy, który poprosi użytkownika o dwie liczby i rodzaj operacji (dodawanie, odejmowanie, mnożenie, dzielenie), a następnie wyświetli wynik. Upewnij się, że program obsługuje błędy, takie jak dzielenie przez zero.
 * **/

namespace ConsoleApp1.functions
{
    internal class FuncKalkulator {
        public static void Kalkulator()
        {
            Console.Write("Podaj liczbe a: ");
            string liczba1_string = Console.ReadLine();

            //program sprawdza czy liczba2_string jest liczbą całkowitą i konwertuje ją na integer
            if (!int.TryParse(liczba1_string, out int liczba1))
            {
                Console.WriteLine("To nie jest liczba całkowita.");
                return;
            }

            Console.Write("Podaj liczbe b: ");
            string liczba2_string = Console.ReadLine();

            //program sprawdza czy liczba2_string jest liczbą całkowitą i konwertuje ją na integer
            if (!int.TryParse(liczba2_string, out int liczba2))
            {
                Console.WriteLine("To nie jest liczba całkowita.");
                return;
            }



            ////



            Console.WriteLine("Jaka operacja arytmetyczna?");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Dzielenie");
            Console.WriteLine("4. Mnożenie");

            string znak = Console.ReadLine();
            int wynik = 0;

            switch (znak)
            {
                case "1":
                    wynik = liczba1 + liczba2;
                    break;
                case "2":
                    wynik = liczba1 - liczba2;
                    break;
                case "3":
                    if (liczba2 == 0)
                    {
                        // sprawdza czy liczba2 jest równa 0 i wypisuje komunikat o błędzie
                        Console.WriteLine("Dzielenie przez 0 nie jest zdefiniowane.");
                        return;
                    }
                    wynik = liczba1 / liczba2;
                    break;
                case "4":
                    wynik = liczba1 * liczba2;
                    break;
                default:
                    Console.WriteLine(znak + " to nie jest prawidłowy wybór.");
                    return;
            }
            Console.WriteLine($"Wynik: {wynik}");
        }

    }
}