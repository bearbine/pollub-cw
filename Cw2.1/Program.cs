/*
 *  
 * Zadanie 2.1  
Napisz program, który pobierze wiek użytkownika i wypisze komunikat: „Jesteś 
pełnoletni” lub „Nie jesteś pełnoletni”, korzystając z operatora ?:.
 * 
 */
Console.Write("Podaj wiek:");
double utemp = double.Parse(Console.ReadLine());

string komunikat = (utemp >= 18) ? "Jesteś pełnoletni" : "Nie jesteś pełnoletni";
Console.WriteLine(komunikat);