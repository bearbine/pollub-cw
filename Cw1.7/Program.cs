/*
 * 
 * Zadanie 1.8. 
Napisz program, który wczyta od użytkownika dowolny napis, a następnie wyświetli 
go w konsoli zapisany wielkimi literami. 
Wskazówka: do zamiany liter na wielkie możesz użyć metody ToUpper. 
*/

Console.WriteLine("Wpisz coś:");
string napis = Console.ReadLine();
Console.WriteLine($"{napis.ToUpper()}");