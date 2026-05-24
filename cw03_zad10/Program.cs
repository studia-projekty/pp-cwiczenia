
int liczba = 1;

while (liczba > 0)
{
    Console.WriteLine("Podaj wysokość trójkąta do narysowania: (0 kończy program)");
    liczba = int.Parse(Console.ReadLine());

    for (int i = 0; i < liczba; i++)
    {
        if (i == 0)
        {
            Console.Write(new string(' ', liczba));
            Console.Write("*");
            Console.WriteLine();
        }
        else
        {
            int gwiazdki = i * 2 + 1;
            int spacje = liczba - i;
            Console.Write(new string(' ', spacje));
            Console.Write(new string('*', gwiazdki));
            Console.WriteLine();
        }

    }

}