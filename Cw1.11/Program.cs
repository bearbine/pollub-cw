/*
 * 
 * Zadanie 1.11. 
Napisz program, który wczyta od użytkownika liczbę całkowitą. Następnie sprawdź, 
czy liczba ta jest parzysta czy nieparzysta. Wynik przedstaw w formie 
odpowiedniego komunikatu, np.: „Liczba 9 jest nieparzysta.” 
 * 
 */

Console.WriteLine("Wpisz liczbę całkowitą:");
int liczba = int.Parse(Console.ReadLine());
if (liczba % 2 == 0)
{
    Console.WriteLine("Liczba jest parzystą");
}
else
{
    Console.WriteLine("Liczba jest nieparzystą");
}

