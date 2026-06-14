
Console.WriteLine("Wybierz opcję:");
Console.WriteLine("1. Kontrola limitu wydatków ucznia");
Console.WriteLine("2. Kontrola poprawności numerów sal");
Console.WriteLine("3. Konkurs wiedzy (zliczanie punktów)");
Console.WriteLine("4. Kontrola długości nazw użytkowników");
int Wybor = int.Parse(Console.ReadLine());

if (Wybor == 1) 
{
    int dzien = 0;
    int sumaWydatkow = 0;
    int dniBezWydatkow = 0;
    int dniDuzychWydatkow = 0;


    for (int i = 0; i < 7; i++)
    {
        dzien++;
        Console.WriteLine($"Dzień {dzien}");
        Console.WriteLine("Podaj kwotę wydatku:");
        int kwota = int.Parse(Console.ReadLine());

        if (kwota >= 50)
        {
            
            dniDuzychWydatkow++;
            Console.WriteLine("Duży wydatek");
            
        }
        if (kwota == 0)
        {   
            dniBezWydatkow++;
            Console.WriteLine("Brak wydatków");
        }
        if (kwota < 50 && kwota > 0 )
        {
            Console.WriteLine("Normalny wydatek");
        }

        sumaWydatkow += kwota;
    }
    Console.WriteLine($"Suma wydatków: {sumaWydatkow}");
    Console.WriteLine($"Dni bez wydatków: {dniBezWydatkow}");
    Console.WriteLine($"Dni z dużymi wydatkami: {dniDuzychWydatkow}");
}
if (Wybor == 2) 
{

    int poprawneNumery = 0;

    for (int i = 0; i < 6; i++)
    {   
        Console.WriteLine("Podaj numer sali:");
        int numerSali = int.Parse(Console.ReadLine());
        if (numerSali.ToString().Length == 3)
        {
            Console.WriteLine("Poprawny numer sali");
            poprawneNumery++;
        }
        else
        {
            Console.WriteLine("Niepoprawny numer sali");
        }
    }
    Console.WriteLine($"Liczba poprawnych numerów sal: {poprawneNumery}");
}

if (Wybor == 3) 
{

    int punkty = 0;
    for (int i = 0; i < 5; i++)
    { 
        Console.WriteLine("Wpisz czy udzieliłeś odpowiedzi poprawnej na pytanie numer " + (i + 1) + ". (Wpisz 1 dla tak lub 0 dla nie):");
        int odpowiedz = int.Parse(Console.ReadLine());
        if (odpowiedz == 1)
        {
            punkty++;
        }
            
    }
    Console.WriteLine("Uczeń zdobył " + punkty + " punktów.");
    if (punkty >= 3)
    {
        Console.WriteLine("Test zaliczony");
                
    }
    else
    {
        Console.WriteLine("Test niezaliczony"); 
                       
    }
}

if (Wybor == 4) 
{

int nazwyPoprawne = 0;
int nazwyZaKrotkie = 0;
int nazwyZaDlugie = 0;

    for (int i = 0; i < 4; i++)
    { 
        Console.WriteLine("Podaj nazwę użytkownika:");
        string nazwaUzytkownika = Console.ReadLine();
        if (nazwaUzytkownika.Length < 5)
        {
            nazwyZaKrotkie++;
            Console.WriteLine("Nazwa użytkownika jest za krótka. Musi miec co najmniej 5 znaków.");
        }
        if (nazwaUzytkownika.Length >= 5 && nazwaUzytkownika.Length < 10)
        {   
            nazwyPoprawne++;
            Console.WriteLine("Nazwa użytkownika jest poprawna.");
        }
        if (nazwaUzytkownika.Length > 10)
        {
            nazwyZaDlugie++;
            Console.WriteLine("Nazwa użytkownika jest za długa.");
        }

    }
Console.WriteLine("Ilość poprawnych nazw użytkowników: " + nazwyPoprawne);
Console.WriteLine("Ilość za krótkich nazw użytkowników: " + nazwyZaKrotkie);
Console.WriteLine("Ilość zbyt długich nazw użytkowników: " + nazwyZaDlugie);

}