/*
 * 
 * Zadanie 1.4. 
Napisz program, który wyznaczy obwód i pole prostokąta. Długości boków a oraz b 
powinny być podane przez użytkownika z klawiatury. Ponadto w rozwiązaniu należy 
założyć, że zmienne a, b, obwod oraz pole mają typ double (rzeczywisty). Wyświetl 
otrzymane wyniki w konsoli z dokładnością do dwóch miejsc po przecinku (:F2). 
 * 
 */
Console.WriteLine("Wpisz dlugości boków prostokąta:");

double a = Double.Parse(Console.ReadLine());
double b = Double.Parse(Console.ReadLine());

double obwod = 2*(a + b);
double pole = a * b;

Console.WriteLine($"obwod: {obwod:F2}, pole: {pole:F2}");