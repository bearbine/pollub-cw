/*
 * Zadanie 1.5. 
Napisz program, który wykona następujące obliczenia: 
a) Liczbę 3456 zwiększy o 5. 
b) Następnie podzieli powyższą sumę przez 3. 
c) Obliczy resztę z dzielenia ilorazu przez 5. 
d) Na koniec wymnoży wynik z dzielenia modulo razy 7. 
Po wykonaniu każdego kroku program powinien wypisać w konsoli bieżący wynik.
 * 
 */

int liczba = 3456;
Console.WriteLine(liczba); // '+' zwiększenie 
liczba += 5;
Console.WriteLine(liczba); // '/'dzielenie
liczba /= 3;
Console.WriteLine(liczba);// '%' reszta dzielenia
liczba %= 5;
Console.WriteLine(liczba);// '*' mnożenie
liczba *= 7;
Console.WriteLine(liczba); // wynik
