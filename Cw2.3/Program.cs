/*
 * 
 * Zadanie 2.3  
Przyjmij od użytkownika siedem temperatur w stopniach Celsjusza, dla każdej 
wypisz, czy jest ujemna, dodatnia czy równa zero, oblicz średnią temperaturę i 
wypisz, ile dni miało temperaturę powyżej średniej.
 */

double[] temperatury = new double[7];
double suma = 0;
for (int i = 0; i < temperatury.Length; i++)
{
    Console.WriteLine($"Podaj temperaturę ({i}): ");
    temperatury[i] = double.Parse(Console.ReadLine());
    suma += temperatury[i];
}

double srednia = suma / temperatury.Length;
int powyzej = 0;
foreach (double t in temperatury)
{
    if (t > srednia)
    {
        powyzej++;
    }

    if (t > 0)
        Console.WriteLine($"{t} -> dodatnia");
    else if (t < 0)
        Console.WriteLine($"{t} -> ujemną");
    else
        Console.WriteLine($"{t} -> 0");
}
Console.WriteLine($"\nŚrednia temperatura: {srednia}");
Console.WriteLine($"Liczba dni z temp. powyżej średniej: {powyzej}");