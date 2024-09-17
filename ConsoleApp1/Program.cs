/**
 * C# - podstawy. Zadania
 * Autor: Agency
 * Dodatkowe zmiany przez: NotSoSilentCat (Fox-Coffee)
**/

using static ConsoleApp1.functions.FuncKalkulator;
using static ConsoleApp1.functions.FuncLiczbaDoskonala;
using static ConsoleApp1.functions.FuncSortowanieBombelkowe;
using static ConsoleApp1.functions.FuncLiczbyPierwsze;
using static ConsoleApp1.functions.FuncKalkulatorSredniejOcen;
using static ConsoleApp1.functions.FuncZamianaJednostek;
using static ConsoleApp1.functions.FuncRzutDwomaKostkami;
using static ConsoleApp1.functions.FuncKalkulatorRownanKwadratowych;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Wybierz program:");
                Console.WriteLine("1. Kalkulator");
                Console.WriteLine("2. Liczba doskonała");
                Console.WriteLine("3. Sortowanie bąbelkowe");
                Console.WriteLine("4. Liczby pierwsze");
                Console.WriteLine("5. Kalkulator średniej ocen");
                Console.WriteLine("6. Zamiana jednostek");
                Console.WriteLine("7. Rzut dwoma kostkami");
                Console.WriteLine("8. Kalkulator równań kwadratowych");
                Console.WriteLine("");

                var program = Console.ReadLine();
                switch (program)
                {
                    case "1":
                        Kalkulator();
                        break;
                    case "2":
                        LiczbaDoskonala();
                        break;
                    case "3":
                        SortowanieBombelkowe();
                        break;
                    case "4":
                        LiczbyPierwsze();
                        break;
                    case "5":
                        KalkulatorSredniejOcen();
                        break;
                    case "6":
                        ZamianaJednostek();
                        break;
                    case "7":
                        RzutDwomaKostkami();
                        break;
                    case "8":
                        KalkulatorRownanKwadratowych();
                        break;
                    default:
                        Console.WriteLine("Nie ma takiego programu.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("BŁĄD: " + ex.Message);
            }
        }
    }
}
