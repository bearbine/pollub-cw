/*
 * Zadanie 1.13. 
Napisz program, który wczyta od użytkownika trzy znaki (char). Program powinien 
wypisać Unicode dla tych znaków, a następnie policzyć i wyświetlić średnią wartość 
tych kodów.
 * 
 */

Console.WriteLine("Wpisz trzy znaki po kolei");
char a = char.Parse(Console.ReadLine());
char b = char.Parse(Console.ReadLine());
char c = char.Parse(Console.ReadLine());

Console.WriteLine($"Kod unicode: U+{(int)a:X4}");
Console.WriteLine($"Kod unicode: U+{(int)b:X4}");
Console.WriteLine($"Kod unicode: U+{(int)c:X4}");