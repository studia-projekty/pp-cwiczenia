
List<int> listaLiczb = new List<int> { };



Console.WriteLine("Podaj 5 liczb po kolei");

Console.WriteLine("Podaj pierwsza liczbe");
var elementUzytkownika = int.Parse(Console.ReadLine());
listaLiczb.Add(elementUzytkownika);

Console.WriteLine("Podaj pierwsza liczbe");
var elementUzytkownika2 = int.Parse(Console.ReadLine());
listaLiczb.Add(elementUzytkownika2);

Console.WriteLine("Podaj pierwsza liczbe");
var elementUzytkownika3 = int.Parse(Console.ReadLine());
listaLiczb.Add(elementUzytkownika3);

Console.WriteLine("Podaj pierwsza liczbe");
var elementUzytkownika4 = int.Parse(Console.ReadLine());
listaLiczb.Add(elementUzytkownika4);

Console.WriteLine("Podaj pierwsza liczbe");
var elementUzytkownika5 = int.Parse(Console.ReadLine());
listaLiczb.Add(elementUzytkownika5);



foreach (int liczba in listaLiczb)
{
    if (liczba % 2 == 0)
    {
        Console.WriteLine(liczba);
    }
}


