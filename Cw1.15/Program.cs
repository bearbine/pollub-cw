/*
 * 
 *Zadanie 1.15. 
Napisz program, który wczyta od użytkownika liczbę całkowitą. Następnie program 
powinien wypisać w konsoli: 
a) ostatnią cyfrę 
b) dwie ostatnie cyfry 
tej liczby. 
 *
 */

Console.WriteLine("Wpisz liczbę całkowitą:");
int liczba = int.Parse(Console.ReadLine());
Console.WriteLine($"Ostatina cyfra: {Math.Abs(liczba % 10)}");
Console.WriteLine($"Dwie ostatni cyfry: {Math.Abs(liczba % 100)}");