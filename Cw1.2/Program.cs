/*
 * 
 * 
 * Zadanie 1.2. 
Napisz program, który wczyta od użytkownika dwie liczby całkowite. Następnie, 
korzystając z metody Math.Max, wyznacz większą z tych liczb i wypisz ją w konsoli.
 * 
 * 
 */
Console.WriteLine("Wpisz dwie liczby całkowite:");
double a = Double.Parse(Console.ReadLine());
double b = Double.Parse(Console.ReadLine());

Console.WriteLine($"{Math.Max(a, b)} będzie większą liczbą");