/**
 * Autor: Agency
 * Dodatkowe zmiany przez: NotSoSilentCat (Fox-Coffee)
 * Zadanie: 7. Rzut dwoma kostkami
 * Opis: Napisz program, który symuluje rzucanie kośćmi. Program powinien symulować rzut dwoma kośćmi i wyświetlić sumę wyrzuconych oczek. Dodaj opcję ponownego rzutu.
 * **/

namespace ConsoleApp1.functions
{
    internal class FuncRzutDwomaKostkami
    {
        public static void RzutDwomaKostkami()
        {
            Random random = new Random();
            int kostka1 = random.Next(1, 7);
            int kostka2 = random.Next(1, 7);

            Console.WriteLine($"Wyrzucono {kostka1} i {kostka2}.");
            Console.WriteLine($"Suma oczek: {kostka1 + kostka2}");

            Console.WriteLine("Czy chcesz rzucić ponownie? (T/N)");
            string ponownyRzut = Console.ReadLine().ToUpper();
            switch (ponownyRzut)
            {
                case "T":
                case "TAK":
                case "1":
                    RzutDwomaKostkami();
                    break;
                case "N":
                case "NIE":
                case "0":
                    break;
                default:
                    Console.WriteLine("Niepoprawna odpowiedź.");
                    break;
            }
        }
    }
}
