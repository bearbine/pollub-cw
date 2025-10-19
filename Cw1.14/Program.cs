/*
 * 
 * Zadanie 1.14. 
Napisz program, który wczyta od użytkownika dwie liczby całkowite a i b. Następnie 
program powinien zamienić wartości tych liczb miejscami bez użycia dodatkowej 
zmiennej, wykorzystując kolejno: 
a) dodawanie i odejmowanie (+, -), 
b) mnożenie i dzielenie (*, /), 
c) operator bitowy XOR (^). 
Po każdej zamianie program powinien wypisać wartości a i b.
 * 
 */
Console.WriteLine("Dodawanie:");
int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"{a}, {b}");

a = a - b;
Console.WriteLine($"{a}, {b}");
b = a + b ;
Console.WriteLine($"{a}, {b}");
a = b - a;
Console.WriteLine($"{a}, {b}");

Console.WriteLine("Mnożenie:");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

Console.WriteLine($"{a}, {b}");

a = a * b;
Console.WriteLine($"{a}, {b}");
b = a / b;
Console.WriteLine($"{a}, {b}");
a = a / b;
Console.WriteLine($"{a}, {b}");

Console.WriteLine("XOR:");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

a = a ^ b;
Console.WriteLine($"{a}, {b}");
b = a ^ b;
Console.WriteLine($"{a}, {b}");
a = a ^ b;
Console.WriteLine($"{a}, {b}");
