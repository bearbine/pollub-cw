/*Zadanie 2.7  
Przyjmij od użytkownika nazwy pięciu sprzedawców i ich miesięczne wyniki 
sprzedaży, wypisz najwyższy i najniższy wynik, oblicz średni wynik oraz pokaż,
którzy sprzedawcy mieli wynik powyżej średniej, a jeśli wynik sprzedawcy wynosi 
dokładnie zero, wypisz komunikat „Brak sprzedaży!”.
*/
using System;
using System.Diagnostics.CodeAnalysis;

string[] pracownicy = new string[5];
int[] wyniki = new int[5];
int suma = 0;
for (int i = 0; i < wyniki.Length; i++)
{
    Console.WriteLine("Wpisz nazwę dla sprzedawcy a pózniej podaj go wynik za miesiąc:");
    pracownicy[i] = Console.ReadLine();
    wyniki[i] = int.Parse(Console.ReadLine());
    suma += wyniki[i];
}
double srednia = (double)suma / (double)wyniki.Length;
for (int i = 0; i < wyniki.Length; i++)
{
    if (wyniki[i] > srednia)
        Console.WriteLine($"Wynik {pracownicy[i]}: wynosi wiecej średniej {wyniki[i]} od {srednia}");
    else if (wyniki[i] == 0)
        Console.WriteLine($"Wynik {pracownicy[i]}: wynosi {wyniki[i]} == 0 BRAK SPRZEDAŻY");


}
Console.WriteLine($"Maksymalny wynik wynosi {wyniki.Max()}, a minimalny {wyniki.Min()}.");

