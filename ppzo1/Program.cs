
using System.Diagnostics;

class Program
{
    static double calcFunc()
    {

        Console.WriteLine("\nPodaj pierwsza liczbe: ");
        double numb1;
        while (!double.TryParse(Console.ReadLine(), out numb1))
        {
            Console.WriteLine("Nieprawidlowa wartosc. Podaj liczbe: ");
        };

        Console.WriteLine("\nPodaj druga liczbe: ");
        double numb2;
        while (!double.TryParse(Console.ReadLine(), out numb2))
        {
            Console.WriteLine("Nieprawidlowa wartosc. Podaj liczbe: ");
        };

        while (true)
        {


            Console.WriteLine("\nPodaj dzialanie ktore chcesz wykonac: ");
            Console.WriteLine("+: Dodawanie");
            Console.WriteLine("-: Odejmowanie: ");
            Console.WriteLine("*: Mnozenie");
            Console.WriteLine("/: Dzielenie");


            string operationChoice = Console.ReadLine() ?? "5";

            if (operationChoice == "+")
            {
                return numb1 + numb2;
            }
            else if (operationChoice == "-")
            {
                return numb1 - numb2;
            }
            else if (operationChoice == "*")
            {
                return numb1 * numb2;
            }
            else if (operationChoice == "/")
            {
                if (numb2 == 0)
                {
                    Console.WriteLine("\nNie mozna dzielic przez 0");
                    return double.NaN;
                }
                return numb1 / numb2;
            }

        }
    }

    static void Main()
    {
        string choiceMain;
        bool switchExit = false;
        while (switchExit == false)
        {
            Console.WriteLine("Input (1: Zadanie 1, 2: Zadanie 2, 3: Zadanie 3, pozostale symbole to wyjscie z konsoli)");
            choiceMain = Console.ReadLine() ?? "0";
            switch (choiceMain)
            {
                case "1":
                    double resultCalc = calcFunc();
                    Console.WriteLine("Wynik to: " + resultCalc);
                    break;
                default:
                    switchExit = true;
                    break;

            }
        }
    }
}