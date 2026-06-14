Dictionary<int, string> rejestr = new Dictionary<int, string>

{

};

int n = 1;


while (true)
{
    Console.WriteLine(" 1. Dodawanie studenta \n 2. wyswietl liste studentow \n 3. usun studenta ");
    string wybor = Console.ReadLine();

    // dodawanie studenta do rejestru

    if (wybor == "1")
    {
        Console.WriteLine("Podaj imie i nazwisko");
        string imieNazwisko = Console.ReadLine();
        rejestr.Add(n, imieNazwisko);
        n++;

    }

    //wyswietla liste wszystkich studentow
    if (wybor == "2")
    {

        foreach (var student in rejestr)
        {
            Console.WriteLine($"{student.Key} {student.Value}");

        }

    }
    if (wybor == "3")
    {
        Console.WriteLine("Podaj numer indeksu studenta do usuniecia");
        int numerIndeksu = int.Parse(Console.ReadLine());
        rejestr.Remove(numerIndeksu);

    }



    //usuwanie studenta po numerze indeksu


}