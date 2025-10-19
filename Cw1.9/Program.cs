/*
 * 
 * Zadanie 1.9. 
Napisz program, który wczyta od użytkownika rok urodzenia. Następnie program 
powinien określić: 
a) wiek użytkownika w roku bieżącym,
b) ile lat minęło od 18 urodzin, 
c) wartość logiczną informującą, czy w bieżącym roku wiek jest „okrągły” 
(podzielny przez 10).
*/

Console.WriteLine("Wpisz swój rok urodzenia:");
int urodziny = int.Parse(Console.ReadLine());
Console.WriteLine($"Twój wiek: {DateTime.Now.Year - urodziny}");
Console.WriteLine($"Ile lat minęło od 18 urodzin: {DateTime.Now.Year - urodziny - 18}");
if ((DateTime.Now.Year - urodziny) % 10 == 0)
{

    Console.WriteLine($"Rok okrągły");

}
else
{
    Console.WriteLine($"Rok nie okrągły");
}

