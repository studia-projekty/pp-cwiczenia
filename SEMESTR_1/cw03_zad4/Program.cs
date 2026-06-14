//CW03 Zadanie 4
Console.WriteLine("Podaj liczbę, dla której chcesz obliczyć silnię:");

int liczba = int.Parse(Console.ReadLine());

int mnoznik = 1;

int wynik = 1;


do
{
    wynik = wynik * mnoznik;
    mnoznik++;

} while (mnoznik <= liczba);


Console.WriteLine($"Silnia z {liczba} wynosi {wynik}");