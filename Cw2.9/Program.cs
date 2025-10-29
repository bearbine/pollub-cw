/*
 * 
 * Zadanie 2.9 

Przygotuj pięć pytań o zwierzętach i przyjmij od użytkownika odpowiedzi „tak” lub 
„nie”, zlicz liczbę poprawnych odpowiedzi i wypisz ocenę: 5 – „Perfekcyjnie!”, 3–4 – 
„Nieźle!”, 0–2 – „Musisz się podszkolić!”.
 */

using System.ComponentModel.Design;

string[] test = new string[5];
bool[] toceny = new bool[5];
string[] pytania = new string[5];
pytania[0] = "blabla";
pytania[1] = "blabla1";
pytania[2] = "blabla2";
pytania[3] = "blabla3";
pytania[4] = "blabla4";
int ocena = 0;
for  (int i = 0; i < test.Length; i++)
{
    Console.WriteLine(pytania[i]);
    test[i] = Console.ReadLine();
    if (test[i] == "tak")
    {
        ocena++;
    }
    else
   Console.WriteLine("Nieprawidlowo");
}
if (ocena == 5)
    Console.WriteLine("Perfekcyjnie");
else if (ocena >= 3)
            Console.WriteLine("Nieżle");
else
    Console.WriteLine("Musisz się podszkolić");

