/*
 * Zadanie 2.6  
Przyjmij od użytkownika trzy liczby rzeczywiste, oblicz ich sumę, średnią i iloczyn, 
wypisz, które liczby są większe od średniej, a jeśli wszystkie są identyczne, wypisz 
komunikat „Wszystkie wartości są identyczne!”. */

using System.Diagnostics.CodeAnalysis;

double[] liczby = new double[3];

double suma = 0, iloczyn = 1;

for (int i = 0; i < liczby.Length; i++)
{
    Console.WriteLine("Wpisz trzy liczby rzeczywiste:");
    liczby[i] = double.Parse(Console.ReadLine());
     suma += liczby[i];
     iloczyn *= liczby[i];
}
double srednia = suma / liczby.Length;

Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Średnia: {srednia}");
Console.WriteLine($"Iloczyn: {iloczyn}");

if (liczby[0] == liczby[1] && liczby[1]  == liczby[2])
    Console.WriteLine("wszystkie wartości są identyczne");
else 
{
    for (int i = 0; i < liczby.Length; i++)
    {
        if (liczby[i] > srednia)
            Console.WriteLine($"{liczby[i]} jest większą od średnią");
    }

}

