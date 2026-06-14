
while (true)
{
    Dictionary<string, string> slownik = new Dictionary<string, string>
        {
            { "kot", "cat" },
            { "dom", "house" },
            { "owoc", "fruit" }
        };

    Console.WriteLine("Wprowadz szukane słowo po polsku");

    string slowo = Console.ReadLine();

    ;

    if (slownik.TryGetValue(slowo, out string slowoAng))
    {
        Console.WriteLine($"Tłumaczenie słowa {slowo} to {slowoAng}");
    }
}