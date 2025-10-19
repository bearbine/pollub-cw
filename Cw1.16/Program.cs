/*
 * 
 * Zadanie 1.16. 
Napisz program, który pobiera od użytkownika datę w formacie RRRR-MM-DD, a 
następnie wyznacza i wyświetla dzień tygodnia odpowiadający tej dacie.
 * 
 * 
 */

Console.WriteLine("Wpisz datę w formacie RRRR-MM-DD");
DateOnly date = DateOnly.Parse(Console.ReadLine());
Console.WriteLine($"{date.DayOfWeek}");
