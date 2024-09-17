/**
 * Autor: Agency
 * Dodatkowe zmiany przez: NotSoSilentCat (Fox-Coffee)
 * Zadanie: 5. Kalkulator średniej ocen
 * Opis: Napisz program, który obliczy średnią ocen ucznia na podstawie danych wprowadzonych przez użytkownika. Program powinien pozwolić na wprowadzenie dowolnej liczby ocen.
 * **/

namespace ConsoleApp1.functions
{
    internal class FuncKalkulatorSredniejOcen
    {
        public static void KalkulatorSredniejOcen()
        {
            Console.WriteLine("Podaj oceny oddzielone spacją:");
            int[] oceny = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            double suma = 0;
            foreach (int ocena in oceny)
            {
                suma += ocena;
                if(ocena < 1 || ocena > 6)
                {
                    Console.WriteLine("Ocena musi być z zakresu 1-6.");
                    return;
                }
            }

            double srednia = suma / oceny.Length;
            Console.WriteLine($"Średnia ocen: {srednia}");
        }
    }
}
