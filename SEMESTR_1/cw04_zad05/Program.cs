Dictionary<string, int> magazyn = new Dictionary<string, int>
{
    { "nazwa1", 10 }
};

int wybor = 0;


while (wybor != 4)
{
    Console.WriteLine("1. Dodaj produkt\n2. Stan magazynu\n3. Usun produkt");
    Console.Write("Wybór: "); wybor = int.Parse(Console.ReadLine());
    

    if (wybor == 1)
        {
            Console.WriteLine("\nPodaj nazwę produktu:");
            string nazwa = Console.ReadLine();

            Console.WriteLine("Podaj ilość:");
            int ilosc = int.Parse(Console.ReadLine());
            magazyn.Add(nazwa, ilosc);

            //jesli istnieje to dodaj ilosc
            if (magazyn.ContainsKey("nazwa1"))
            {
                magazyn["nazwa1"] += 5;
            Console.WriteLine($"Dodano {nazwa} w ilośći {ilosc} \n");
            }

        }

        if (wybor == 2)
        {
            Console.WriteLine("\nStan Magazynu:");


            //stan magazynu
            foreach (var produkt in magazyn)
            {
                Console.WriteLine($"Produkt: {produkt.Key}, Ilość: {produkt.Value}\n");
            }

        }

        if (wybor == 3)
    {
        string nazwa = Console.ReadLine();
        Console.WriteLine("\nUsuń produkt. Wpisz nazwę:");
        magazyn.Remove(nazwa);

        Console.WriteLine($"Produkt {nazwa} usunięto ");
        

    }
    
}
