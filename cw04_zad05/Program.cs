

Dictionary<string, int> magazyn = new Dictionary<string, int>
{
    { "nazwa1", 10 }
};

while (wybor != 4)
{
    if (wybor == 1)
    {
        Console.WriteLine("Podaj nazwę produktu:");
        string nazwa = Console.ReadLine();
        Console.WriteLine("Podaj ilość:");
        int ilosc = int.Parse(Console.ReadLine());
        magazyn.Add(nazwa, ilosc);

     }

    //jesli istnieje to dodaj ilosc
    if (magazyn.ContainsKey("nazwa1"))
    {
        magazyn["nazwa1"] += 5;

    }


    //stan magazynu
    foreach (var produkt in magazyn)
    {
        Console.WriteLine($"Produkt: {produkt.Key}, Ilość: {produkt.Value}");
    }


}
