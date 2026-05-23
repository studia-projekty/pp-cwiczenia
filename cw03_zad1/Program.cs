using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Podaj liczbę n:");
int liczba = int.Parse(Console.ReadLine());
int suma = 0;

for(int i=1; i<liczba; i++)
{
    suma += i;
}

Console.WriteLine("");
Console.WriteLine("Suma liczb od 1 do n wynosi: " + suma); 