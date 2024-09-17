/**
 * Autor: Agency
 * Dodatkowe zmiany przez: NotSoSilentCat (Fox-Coffee)
 * Zadanie: 8. Kalkulator równań kwadratowych
 * Opis: Napisz program, który rozwiązuje równania kwadratowe w postaci ax^2 + bx + c = 0 i wyświetla ich pierwiastki. Upewnij się, że program obsługuje różne przypadki, takie jak brak rozwiązań lub jeden podwójny pierwiastek.
 * **/

namespace ConsoleApp1.functions
{
    internal class FuncKalkulatorRownanKwadratowych
    {
        public static void KalkulatorRownanKwadratowych()
        {
            Console.WriteLine("Podaj wartość a:");
            string a_string = Console.ReadLine();
            if(!double.TryParse(a_string, out double a))
            {
                Console.WriteLine("Podana wartość a nie jest liczbą.");
                return;
            }

            Console.WriteLine("Podaj wartość b:");
            string b_string = Console.ReadLine();
            if (!double.TryParse(b_string, out double b))
            {
                Console.WriteLine("Podana wartość b nie jest liczbą.");
                return;
            }

            Console.WriteLine("Podaj wartość c:");
            string c_string = Console.ReadLine();
            if (!double.TryParse(c_string, out double c))
            {
                Console.WriteLine("Podana wartość c nie jest liczbą.");
                return;
            }

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Równanie ma dwa pierwiastki:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Równanie ma jeden podwójny pierwiastek:");
                Console.WriteLine("x = " + x);
            }
            else
            {
                Console.WriteLine("Równanie nie ma rozwiązań.");
            }
        }
    }
}
