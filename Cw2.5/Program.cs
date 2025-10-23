/*
 * 
 * Zadanie 2.5  
Przyjmij od użytkownika osiem liczb całkowitych, wypisz tylko te, które mieszczą się 
w zakresie od 10 do 100, zlicz ile liczb jest w zakresie i ile poza nim, a dla każdej liczby 
spoza zakresu wypisz komunikat „Poza limitem!”.
 * 
 * 
 */
int[] liczby = new int[8];
int a = 0;
for (int i = 0; i < liczby.Length; i++)
{
    Console.WriteLine($"wpisz liczbę{i}:");
    liczby[i] = int.Parse(Console.ReadLine());

    /*  while (true)
      {
          liczby[i] = int.Parse(Console.ReadLine());
          if (liczby[i] > 10 && liczby[i] < 100)
          {
              break;
          }
          else
          {
              Console.WriteLine("Błąd");
          }

     }
    */


}
int k = 0, l = 0;
foreach (int t in liczby)
{

    if (t > 10 && t < 100)
    {
        Console.WriteLine(t);
        k++;
        
    }
    else
    {
        Console.WriteLine(t);
        l++;
    }


}
Console.WriteLine($"\nLiczb w zakresie: {k} i poza: {l}");





