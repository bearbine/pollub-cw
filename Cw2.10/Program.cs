/*
 * 
 * Zadanie 2.10  
Przyjmij od użytkownika długości boków prostokąta i trójkąta, oblicz pola obu figur i 
wypisz, która figura ma większe pole lub że pola są równe.
 * 
 */

using System.Net.Http.Headers;

double pa, pb, ta, tb, tc;

Console.WriteLine("wpisz boki prostokąta:");
pa = double.Parse(Console.ReadLine());
pb = double.Parse(Console.ReadLine());
Console.WriteLine("wpisz boki trójkąta:");
ta = double.Parse(Console.ReadLine());
tb = double.Parse(Console.ReadLine());
tc = double.Parse(Console.ReadLine());
double p = (ta + tb + tc) / 2;
double troj = Math.Sqrt(p*(p-ta)*(p-tb)*(p-tc));

double prost = pa * pb;

if (prost > troj)
{
    Console.WriteLine($"prostokąt ma większe pole: {prost} > {troj}");
}
else if (prost < troj)
    Console.WriteLine($"trójkąt ma wieksze pole: {troj} > {prost}");
else
    Console.WriteLine($"prostokąt równi się trójkątu {prost} = {troj}");
