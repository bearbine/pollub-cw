/*
 * 
 * 
 *  
Zadanie 2.8
Przyjmij od użytkownika dowolny tekst, policz i wypisz liczbę liter, cyfr i spacji, podaj 
długość tekstu, a jeśli tekst zawiera wyraz „C#”, wypisz komunikat „Programista 
zauważony!”. */

Console.WriteLine("Wpisz dowolny tekst:");
string tekst = Console.ReadLine();

int ileliter = 0, ilecyft = 0, ileSpacji = 0;

foreach(char c in tekst)// char to pojedynczy element w string
{

    if (char.IsLetter(c))
        ileliter++;
    else if (char.IsDigit(c))
        ilecyft++;
    else if (char.IsWhiteSpace(c))
        ileSpacji++;
    else
        Console.WriteLine("Inny znak");

}
Console.WriteLine($"Długość tekstu: {tekst.Length}");
Console.WriteLine($"Ilość liter: {ileliter}");
Console.WriteLine($"Ilość cyfr: {ilecyft}");
Console.WriteLine($"Ilość spacji: {ileSpacji}");

if(tekst.Contains("C#"))
{
    Console.WriteLine("Programista zauważony");
}

