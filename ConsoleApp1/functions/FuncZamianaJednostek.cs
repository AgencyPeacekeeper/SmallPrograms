/**
 * Autor: Agency
 * Dodatkowe zmiany przez: NotSoSilentCat (Fox-Coffee)
 * Zadanie: 6. Zamiana jednostek
 * Opis: Napisz program, który zamieni temperaturę w stopniach Celsjusza na Fahrenheita i odwrotnie, w zależności od wyboru użytkownika.
 * **/

namespace ConsoleApp1.functions
{
    internal class FuncZamianaJednostek
    {
        public static void ZamianaJednostek()
        {
            Console.WriteLine("Podaj temperaturę:");
            string temperatura_string = Console.ReadLine();
            if(!double.TryParse(temperatura_string, out double temperatura))
            {
                Console.WriteLine("To nie jest liczba.");
                return;
            }
            Console.WriteLine("Podaj jednostkę (C/F):");
            string jednostka = Console.ReadLine().ToUpper();

            double wynik = 0;
            if (jednostka == "C")
            {
                wynik = temperatura * 9 / 5 + 32;
                Console.WriteLine($"Temperatura w stopniach Fahrenheita: {wynik}");
            }
            else if (jednostka == "F")
            {
                wynik = (temperatura - 32) * 5 / 9;
                Console.WriteLine($"Temperatura w stopniach Celsjusza: {wynik}");
            }
            else
            {
                Console.WriteLine("Nieprawidłowa jednostka.");
            }
        }
    }
}
