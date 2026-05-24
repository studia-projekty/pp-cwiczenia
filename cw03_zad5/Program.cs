
int ostatniaCyfra = 0;
int nowaLiczba = 0;

Console.WriteLine("Podaj liczbę do odwrócenia: ");
int liczba = int.Parse(Console.ReadLine());

while (liczba > 0 )
{
    ostatniaCyfra = liczba % 10;

    nowaLiczba = (nowaLiczba * 10) + ostatniaCyfra;

    liczba = liczba / 10;

}

Console.WriteLine($"Odwócona liczba to: {nowaLiczba}");