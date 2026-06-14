//CW03 Zadanie 2

for (int wiersz = 1; wiersz <= 10; wiersz++)
{
    for (int kolumna = 1; kolumna <= 10; kolumna++)
    {       
        int wynik = wiersz * kolumna;

        Console.WriteLine($"{wiersz} x {kolumna} = {wynik}");
    }
}                                         