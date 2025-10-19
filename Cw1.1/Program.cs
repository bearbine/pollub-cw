using System.Security.Authentication.ExtendedProtection;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 
         * Zadanie 1.1. 
Napisz program, który obliczy obwód i pole trójkąta o bokach 6,3, 6,7 oraz 7,2. 
Do obliczenia pola zastosuj wzór Herona. Wyświetl otrzymane wyniki w konsoli z 
dokładnością do dwóch miejsc po przecinku (:F2). 
Wskazówka: do obliczenia pierwiastka kwadratowego użyj funkcji Math.Sqrt.
      */

        double a, b, c;

        a = 6.3;
        b = 6.7;
        c = 7.2;

        double obwod = a + b + c;
        double p = 0.5 * obwod;
        double pole = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        Console.WriteLine($"{obwod:F2}");
        Console.WriteLine($"{pole:F2}");

    }
}