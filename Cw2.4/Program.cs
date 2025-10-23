/*
 * 
 * Zadanie 2.4  
Przyjmij od użytkownika sześć ocen w skali 1–6, oblicz średnią ocen i wypisz ocenę 
semestralną według skali: poniżej 3 – niedostateczny, 3–3,9 – dostateczny, 4–4,9 – 
dobry, 5 i więcej – bardzo dobry, a jeśli średnia wynosi dokładnie 6, wypisz komunikat 
„Wzorowy uczeń!”.
 * 
 * 
 */
using System.ComponentModel.Design;

double[] oceny = new double[6];
double cala = 0;
for (int i = 0; i < oceny.Length; i++)
{
    while (true) // WALIDACJA DANYCH 
    {
        Console.WriteLine($"Podaj ocenę {i}:");
        oceny[i] = double.Parse(Console.ReadLine());
        if (oceny[i] >= 1 && oceny[i] <= 6)
        {
            cala += oceny[i];
            break;

        }
        else
            Console.WriteLine("Błąd");
    }
    
}
double srednia = cala/oceny.Length;
string koncowa = "";
// foreach (double t in oceny) 
   // „Dla każdego elementu t w tablicy oceny, wykonaj poniższy blok kodu.”
   // Czyli kod wewnątrz { ... } zostanie wykonany 6 razy (bo tablica ma 6 ocen).
//{
    if (srednia == 6)
        koncowa = "Wzorowy uczeń";
    else if (srednia >= 5)
        koncowa = "Bardzo dobry";
    else if (srednia >= 4)
        koncowa = "dobry";
    else if (srednia >= 3)
        koncowa = "Dostateczny";
    else
        koncowa = "Niedostateczny";

// }
Console.WriteLine($"SREDNIA: {srednia:F2}");
Console.WriteLine($"KONCOWA: {koncowa}");