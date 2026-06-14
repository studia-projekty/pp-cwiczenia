


int iloscPracownikow = 0;

int numerPracownika = 1;


for (int i = 1; i <6; i++)
{
    Console.WriteLine("Czy pracownik numer " + numerPracownika + " jest obecny? (tak/nie)");
    string czyObecny1 = Console.ReadLine();

    if (czyObecny1 == "tak")
    {
        iloscPracownikow++;
        numerPracownika++;
    }
    if (czyObecny1 == "nie")
    {
        numerPracownika++;
        Console.WriteLine("Pracownik numer " + numerPracownika + " jest nieobecny.");
    }

}

Console.WriteLine("Liczba obecnych pracowników: " + iloscPracownikow);