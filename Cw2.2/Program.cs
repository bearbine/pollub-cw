/*
 * 
 * Zadanie 2.2  
Napisz program, który pobierze od użytkownika dwie liczby całkowite, a następnie 
wyświetli informację, która z nich jest większa (lub że są równe). Do rozwiązania 
zastosuj operator warunkowy ?:.
 * 
 * 
 */


Console.WriteLine("Wpisz dwie liczby:");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

string result = (a > b) ? $"{a}" : (a < b) ? $"{b}" : $"{a}={b}";    

Console.WriteLine(result);