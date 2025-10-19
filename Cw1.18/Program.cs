/*
 * 
 * Zadanie 1.18. 
Napisz program, w którym zostanie zdefiniowany typ wyliczeniowy: 
enum Kierunek { Polnoc, Poludnie, Wschod, Zachod } 
Program powinien wczytać z klawiatury numer kierunku (0 - 3), a następnie wypisać 
komunikat w postaci „Idziesz na poludnie”. 
 * 
 */
internal class Program
{
    enum Kierunek { Polnoc, Poludnie, Wschod, Zachod }
    private static void Main(string[] args)
    {
        int wybor = int.Parse(Console.ReadLine());
        // Rzutowanie liczby na enum
        Kierunek strona = (Kierunek)wybor;
        // Tablica nazw po polsku w kolejności enum
        string[] nazwy = { "Północ", "Południe", "Wschód", "Zachód" };
        if (wybor >= 0 && wybor < nazwy.Length)
        {
            Console.WriteLine($"Wybrana strona swiata: {nazwy[(int)strona]}");
        }
        else
        {
            Console.WriteLine("Niepoprawny numer strony świata!");
        }
    }
}