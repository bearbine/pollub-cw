/*
 * Zadanie 1.7. 
Napisz program, który wczyta dwie liczby całkowite i obliczy ich sumę, różnicę,
iloczyn, iloraz (dzielenie całkowite), resztę z dzielenia oraz średnią arytmetyczną. 
Program powinien wyświetlić w konsoli wynik każdego działania.
*/

Console.WriteLine("Wpisz dwie liczby całkowite:");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());

Console.WriteLine($"ich suma:{a+b}");
Console.WriteLine($"ich róznica:{a - b}");
Console.WriteLine($"ich iloczyn:{a * b}");
Console.WriteLine($"ich iloraz:{a / b}");
Console.WriteLine($"ich reszta z dzielenia:{a % b}");
Console.WriteLine($"ich średnia arytmetyczna:{(a + b)/2}");

