/*
 * Zadanie 1.17. 
Napisz program, który pobiera bieżącą datę i godzinę przy użyciu klasy DateTime, a 
następnie wyświetla poszczególne właściwości tej daty: rok, miesiąc, dzień, dzień 
tygodnia, dzień roku, godzina, minuta, sekunda oraz milisekunda.
 * 
 */
using System.Globalization;


DateTime date = DateTime.Now;
Console.WriteLine(date.Year);
Console.WriteLine(date.Month);
Console.WriteLine(date.Day);
Console.WriteLine(date.DayOfWeek);
Console.WriteLine(date.Hour);
Console.WriteLine(date.Minute);
Console.WriteLine(date.Second);
Console.WriteLine(date.Millisecond);