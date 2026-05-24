
Random rand = new Random();
int liczba = rand.Next(1, 101); // Losuje liczbę od 1 do 100

int liczbaUzytkownika = 0;


do
{
    Console.WriteLine($"Zgaduj randomowa liczbę - {liczba}");
    liczbaUzytkownika = int.Parse(Console.ReadLine());
    if (liczbaUzytkownika < liczba)
    {
        Console.WriteLine("Za mało!");
    }
    else if (liczbaUzytkownika > liczba)
    {
        Console.WriteLine("Za dużo!");
    }

} while (liczbaUzytkownika != liczba);

Console.WriteLine($"Twoja liczba {liczbaUzytkownika} zgadza się z wylosowaną liczbą {liczba}");

