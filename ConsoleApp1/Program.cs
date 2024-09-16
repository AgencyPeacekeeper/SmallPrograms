using System.Linq.Expressions;

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
                        kalkulator();
                        break;
                    case "2":
                        liczbaDoskonala();
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

                static void kalkulator()
                {
                    Console.Write("Podaj liczbe a: ");
                    var liczba1 = int.Parse(Console.ReadLine());
                    Console.Write("Podaj liczbe b: ");
                    var liczba2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Jaka operacja arytmetyczna?");
                    Console.WriteLine("1. Dodawanie");
                    Console.WriteLine("2. Odejmowanie");
                    Console.WriteLine("3. Dzielenie");
                    Console.WriteLine("4. Mnożenie");

                    var znak = Console.ReadLine();
                    var wynik = 0;

                    switch (znak)
                    {
                        case "1":
                            wynik = liczba1 + liczba2; break;
                        case "2":
                            wynik = liczba1 - liczba2; break;
                        case "3":
                            if (liczba2 == 0)
                            {
                                Console.WriteLine("Dzielenie przez 0 nie jest zdefiniowane.");
                                return;
                            }
                            wynik = liczba1 / liczba2; break;
                        case "4":
                            wynik = liczba1 * liczba2; break;
                        default:
                            Console.WriteLine(znak + " to nie jest prawidłowy wybór."); return;
                    }
                    Console.WriteLine("Wynik: ");
                    Console.Write(wynik);
                }
                static void liczbaDoskonala()
                {
                    Console.Write("Podaj liczbe a: ");
                    var liczba1 = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("Liczba " + liczba1 + (doskonala ? " jest" : " nie jest") + " doskonała.");
                }
                static void SortowanieBombelkowe()
                {
                    Console.WriteLine("Podaj liczby do posortowania, oddzielone spacją:");
                    var liczby = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    for (int i = 0; i < liczby.Length; i++)
                    {
                        for (int j = 0; j < liczby.Length - 1; j++)
                        {
                            if (liczby[j] > liczby[j + 1])
                            {
                                var temp = liczby[j];
                                liczby[j] = liczby[j + 1];
                                liczby[j + 1] = temp;
                            }
                        }
                    }

                    Console.WriteLine("Posortowane liczby:");
                    foreach (var liczba in liczby)
                    {
                        Console.Write(liczba + " ");
                    }
                }
                static void LiczbyPierwsze()
                {
                    Console.Write("Podaj liczbę: ");
                    var liczba = int.Parse(Console.ReadLine());

                    Console.WriteLine("Liczby pierwsze mniejsze od " + liczba + ":");

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
                static void KalkulatorSredniejOcen()
                {
                    Console.WriteLine("Podaj oceny oddzielone spacją:");
                    var oceny = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    double suma = 0;
                    foreach (var ocena in oceny)
                    {
                        suma += ocena;
                    }

                    double srednia = suma / oceny.Length;
                    Console.WriteLine("Średnia ocen: " + srednia);
                }
                static void ZamianaJednostek()
                {
                    Console.WriteLine("Podaj temperaturę:");
                    var temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj jednostkę (C/F):");
                    var jednostka = Console.ReadLine().ToUpper();

                    double wynik = 0;
                    if (jednostka == "C")
                    {
                        wynik = temperatura * 9 / 5 + 32;
                        Console.WriteLine("Temperatura w stopniach Fahrenheita: " + wynik);
                    }
                    else if (jednostka == "F")
                    {
                        wynik = (temperatura - 32) * 5 / 9;
                        Console.WriteLine("Temperatura w stopniach Celsjusza: " + wynik);
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowa jednostka.");
                    }
                }
                static void RzutDwomaKostkami() {
                    Random random = new Random();
                    int kostka1 = random.Next(1, 7);
                    int kostka2 = random.Next(1, 7);

                    Console.WriteLine("Wyrzucono " + kostka1 + " i " + kostka2 + ".");
                    Console.WriteLine("Suma oczek: " + (kostka1 + kostka2));

                    Console.WriteLine("Czy chcesz rzucić ponownie? (T/N)");
                    var ponownyRzut = Console.ReadLine().ToUpper();
                    if (ponownyRzut == "T")
                    {
                        RzutDwomaKostkami();
                    }
                }
                static void KalkulatorRownanKwadratowych()
                {
                    Console.WriteLine("Podaj wartość a:");
                    var a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj wartość b:");
                    var b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj wartość c:");
                    var c = double.Parse(Console.ReadLine());

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
            catch (Exception ex)
            {
                Console.WriteLine("BŁĄD: " + ex.Message);
            }
        }
    }
}
