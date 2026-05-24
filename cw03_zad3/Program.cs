//odszukiwani eliczb parzystych i nieparzystych od 1 do 50

int liczba = 1;
bool czyParzysta = true;
int parzysta = 0;
int nieparzysta = 0;

Console.WriteLine("Liczby Parzyste: ");
while (parzysta <= 50)
{
    if (parzysta % 2 == 0)
    {
        Console.WriteLine(parzysta);
    }
    parzysta++;

}

Console.WriteLine("Liczby niearzyste: ");
while (nieparzysta <= 50)
{
    if (nieparzysta % 2 != 0)
    {
        Console.WriteLine(nieparzysta);
    }
    nieparzysta++;


}





