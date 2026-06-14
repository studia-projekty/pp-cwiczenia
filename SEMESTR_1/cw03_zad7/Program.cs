//CW03 Zadanie 7

Console.WriteLine("Podaj zakres liczb dla których przeprowadzone będzie sprawdzanie czy dana liczba należy do liczb pierwszych:");


int zakres = int.Parse(Console.ReadLine());

for(int i = 2; i < zakres; i++)
{
    bool czyPierwsza = true;

    for (int j = 2; j < i; j++)
    {
        if(i % j == 0)
        {
            czyPierwsza = false;
            break;
        }
    }

    if (czyPierwsza == true)
    {
        Console.WriteLine(i);
    }
}