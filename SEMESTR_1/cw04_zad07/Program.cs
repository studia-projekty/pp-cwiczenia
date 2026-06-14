
//Funkcje programu:

//Dodanie nowego zamówienia:
    //Dodaj zamówione danie do listy.
    //Zaktualizuj liczbę zamówionych sztuk w słowniku.

//Wyświetlenie wszystkich zamówień w kolejności składania.
//Wyświetlenie liczby zamówionych sztuk każdego dania.
//Usunięcie zamówienia z listy i aktualizacja słownika.
//Uwaga: Program powinien obsługiwać błędy, np. usuwanie zamówienia, które nie istnieje.


// zamowienia i ich kolejnosc 
List<string> zamowieniaLista = [];

//key nazwa dania, value liczba zamowionych sztuk
Dictionary<string, int> slownikZamowien = [];

int opcja = 0;
int numerZamowieniaDoUsuniecia = 0;
do
{
    Console.WriteLine(
        "Wybierz opcje: \n" +
        "1. Dodanie nowego zamówienia \n" +
        "2. Wyświetlanie wszystkich zamówień \n" +
        "3. Wyświetlanie liczby sztuk zamówionych dań \n" +
        "4. Usunięcie zamówienia z listy \n" +
        "5. Wyjście z programu \n");

    int.TryParse(Console.ReadLine(), out opcja);

    switch (opcja)
    {
        case 1://Dodanie nowego zamówienia

            Console.WriteLine("Dodawanie zamówienia.");
            Console.Write("Podaj nazwę dania: "); string wpisUzytkownika = Console.ReadLine();

            zamowieniaLista.Add(wpisUzytkownika);

            if (slownikZamowien.ContainsKey(wpisUzytkownika))
            {
                slownikZamowien[wpisUzytkownika]++;
            }
            else
            {
                slownikZamowien.Add(wpisUzytkownika, 1);
            }

            Console.WriteLine("Dodano zamówienie. \n");

            break;



        case 2://Wyświetlanie wszystkich zamówień
            Console.WriteLine("Wyświetlanie wszystkich zamówień. \n");

            int numerZamowienia = 1;

            foreach (var zamowienie in zamowieniaLista)
            {
                Console.WriteLine($"Numer zamówienia: {numerZamowienia++} | Danie: {zamowienie} \n");
            }

            break;


        case 3://Wyświetlanie liczby zamówionych sztuk każdego dania
            Console.WriteLine("Wyświetlanie liczby zamówionych sztuk każdego dania. \n");

            foreach (var slownik in slownikZamowien)
            {
                Console.WriteLine($"Danie: {slownik.Key} | Liczba zamówionych sztuk: {slownik.Value} \n");
            }

            break;


        case 4://Usunięcie zamówienia z listy i aktualizacja słownika
            Console.WriteLine("Usunięcie zamówienia z listy. \n");
            Console.Write("Podaj numer zamówienia do usunięcia: "); int.TryParse(Console.ReadLine(), out numerZamowieniaDoUsuniecia);
            int indeks = numerZamowieniaDoUsuniecia - 1;
            if (indeks < 0 || indeks >= zamowieniaLista.Count)
            {
                Console.WriteLine("Nie ma takiego zamówienia. \n");
            }
            else
            {
                zamowieniaLista.RemoveAt(indeks);
                Console.WriteLine("Zamowienie usunięte. \n");
            }
            

            break;

        case 5://Wyjście z programu
            Console.WriteLine("Wyjście z programu. \n");
            break;

    }

} while (opcja != 5);

