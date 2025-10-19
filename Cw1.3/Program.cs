/*
 * Zadanie 1.3. 
Napisz program, który wczyta od użytkownika liczbę całkowitą, a następnie wypisze 
w konsoli jej kwadrat i sześcian. 
Wskazówka: do obliczeń możesz użyć mnożenia lub funkcji Math.Pow(p, w), gdzie p 
to podstawa, a w – wykładnik. 
 *
 *
 */
Console.WriteLine("Wpisz dowolną liczbę całkowitą i będziesz miał ją kwadrat i sześcian:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine($"Kwadrat A = {Math.Pow(a, 2)}, a sześcian A = {Math.Pow(a, 3)}");