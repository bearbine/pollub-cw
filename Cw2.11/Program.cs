/*
 * 
 * 
 * Zadanie 2.11  
Przyjmij od użytkownika wiek czterech pracowników, określ kategorię wieku każdego 
pracownika (<30, 30–50, >50), oblicz średni wiek grupy i wypisz liczbę pracowników 
w każdej kategorii. 
*/

int n = 50;
int[] wiek = new int[n];
int mlodzi = 0, sredni = 0, starsi = 0;
int suma1=0, suma2=0, suma3=0;

Random random = new Random(2);

for  (int i = 0; i < n; i++)
{
    wiek[i] = random.Next(18, 66);
}