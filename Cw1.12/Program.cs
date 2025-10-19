/*
 * 
 * Zadanie 1.12. 
Napisz program, który wczyta od użytkownika temperaturę w stopniach Celsjusza i 
przeliczy ją na stopnie Fahrenheita według następującego wzoru: 
 * 
 */

Console.WriteLine("Wpisz stopni Celsjusza:");
double temp = double.Parse(Console.ReadLine());
Console.WriteLine($"W stopniach Fahrenheita to: {(9/5*temp)+32}");
