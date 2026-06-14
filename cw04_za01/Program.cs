
int wybor = 1;
List<string> listaZakupow = new List<string> { };


while (wybor != 0)
{
    Console.WriteLine(" 1. Dodaj element \n 2. Wyswietl liste \n 3. Usun element");
    wybor = int.Parse(Console.ReadLine());


    if (wybor == 1)
    {

        // dodaj przedmiot do listy
        Console.WriteLine("Podaj nazwę elementu do dodania");

        var elementUzytkownika = Console.ReadLine();

        listaZakupow.Add(elementUzytkownika);
 }
    if (wybor == 2)
    {

        // wyswietl elementy listy
        Console.WriteLine("Elementy na liscie:");
        foreach (var element in listaZakupow)
        {
            Console.WriteLine(element);
        }
    }
    if (wybor == 3)
    {

        // wyswietl elementy listy
        Console.WriteLine("Podaj element do usunięcia:");
        var elementUzytkownika = Console.ReadLine();
        listaZakupow.Remove(elementUzytkownika);        
       
    }
    }



// wyswietl cala liste zakupow

// usun przedmiot po podaniu jego nazwy




