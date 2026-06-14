

string zdanie = Console.ReadLine();
string[] slowa = zdanie.Split(' ');

Dictionary<string, int> slownik = new Dictionary<string, int>();


//petla lecaca przez tablice zrobiona z rozbitego zdania
foreach (string slowo in slowa)
{

    if (slownik.ContainsKey(slowo))
    {
        slownik[slowo]++;

    } else
    {
        slownik.Add(slowo, 1);
    }
}

//petla lecaca przez slownik
foreach (var slowo in slownik)
{
    Console.WriteLine($"Słowo: {slowo.Key}, Ilość wystąpień: {slowo.Value}");
}






