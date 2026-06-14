int aktualnyRok = DateTime.Now.Year;
Console.WriteLine("Podaj swój rok urodzenia:");
int rokUrodzenia = int.Parse(Console.ReadLine());

int wiek = aktualnyRok - rokUrodzenia;
if (wiek >= 18)
{
    Console.WriteLine("Jesteś pełnoletni.");
}
else
{
    Console.WriteLine("Nie jesteś pełnoletni.");
}