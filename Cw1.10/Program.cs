/*
 * 
 * Zadanie 1.10. 
Napisz program, który wczytuje masę ciała 𝑚 w kilogramach. Następnie wyznacza 
wartość siły ciężkości działającej na to ciało: 
a) na Ziemi (𝑔 = 9,81 𝑚/𝑠²), 
b) na Księżycu (𝑔 = 1,62 𝑚/𝑠²). 
Wartość siły ciężkości oblicza się ze wzoru 𝐹 = 𝑚 ⋅ 𝑔, gdzie 𝑚 to masa ciała, zaś 𝑔 
to przyspieszenie ziemskie. Wyświetl otrzymane wartości w konsoli z dokładnością 
do dwóch miejsc po przecinku (:F2).
 * 
 * 
 */

Console.WriteLine("Wpisz masę ciała w kolagramach:");
double masa = double.Parse(Console.ReadLine());
Console.WriteLine($"F Ziemska: {(masa * 9.81):F2}, F Księżycwowa: {(masa*1.62):F2}");