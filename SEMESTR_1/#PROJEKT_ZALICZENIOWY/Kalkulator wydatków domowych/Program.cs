/*
📌 Temat zadania: Kalkulator wydatków domowych
📝 Opis zadania: Napisz aplikację konsolową w języku C#, która pozwoli użytkownikowi zarządzać swoimi wydatkami domowymi. Program powinien umożliwiać:
	Dodawanie wydatków (nazwa wydatku i kwota).
	Wyświetlanie listy wszystkich wydatków.
	Obliczanie łącznej kwoty wydatków.
	Znalezienie wydatku o najwyższej wartości.
	Wyjście z programu.

⚙️ Wymagania funkcjonalne:
	Program powinien działać w pętli, dopóki użytkownik nie wybierze opcji wyjścia.
	Wydatki powinny być przechowywane w odpowiedniej strukturze danych (np. lista).
	Użytkownik wybiera operację z menu za pomocą odpowiedniego numeru.

💻 Przykładowe menu: 
	1. Dodaj wydatek 
	2. Wyświetl listę wydatków 
	3. Oblicz łączną kwotę wydatków 
	4. Znajdź największy wydatek 
	5. Wyjdź Wybierz opcję:

🔍 Szczegóły implementacyjne:
	Użytkownik wpisuje nazwę wydatku i jego kwotę (kwota może być liczbą zmiennoprzecinkową).
	W przypadku wyświetlania wydatków należy pokazać ich nazwę i kwotę.
	Dla opcji obliczania łącznej kwoty program powinien zwrócić sumę wszystkich wydatków.
	Dla opcji znalezienia największego wydatku należy zwrócić nazwę wydatku i jego kwotę.
	Program kończy działanie, gdy użytkownik wybierze opcję wyjścia.

🚀 Przykład działania: 
	1. Dodaj wydatek
	2. Wyświetl listę wydatków
	3. Oblicz łączną kwotę wydatków
	4. Znajdź największy wydatek
	5. Wyjdź Wybierz opcję: 1
 
	Podaj nazwę wydatku: Jedzenie
	Podaj kwotę wydatku: 150.50
 
	1. Dodaj wydatek
	2. Wyświetl listę wydatków
	3. Oblicz łączną kwotę wydatków
	4. Znajdź największy wydatek
	5. Wyjdź Wybierz opcję: 2
 
	Lista wydatków:
	1. Jedzenie - 150.50

📊 Kryteria oceny:
	Poprawność działania wszystkich funkcji.
	Czytelność kodu (w tym stosowanie odpowiednich nazw zmiennych i komentarzy).
	Obsługa błędów (np. walidacja wprowadzonej kwoty, obsługa pustej listy wydatków przy wyborze opcji 2, 3 lub 4).
	Działające menu z możliwością powrotu do głównego ekranu po każdej operacji.
*/


int opcjaInput;

List<(string nazwa, decimal kwota)> listaWydatkow = new();


do
{
	Console.Write(
		"======================================\n" +
		"==== Kalkulator wydatków domowych ====\n" +
		"======================================\n"
    );
	Console.WriteLine(
        "1.Dodaj wydatek \n" +
		"2.Wyświetl listę wydatków \n" +
		"3.Oblicz łączną kwotę wydatków \n" +
		"4.Znajdź największy wydatek \n" +
		"5.Wyjdź \n"
	);

    Console.Write("Wybierz opcję: "); int.TryParse(Console.ReadLine(), out opcjaInput); //pobranie opcji od uzytkownika i walidacja czy jest intem

	switch (opcjaInput)
	{
		default: // opcje poza zakresem 1-5
            Console.WriteLine("\nNiepoprawny wybór. Wybierz opcje od 1 do 5. \n");
			break;

		case 1: // dodawanie wydatku

            Console.Write(
			"\n" +
			"-------------------\n" +
			"-- Dodaj wydatek --\n" +
			"-------------------\n"
			);
			Console.Write("Wpisz nazwę wydatku (np. jedzenie): ");

            string wydatekNazwaInput = Console.ReadLine();// pobranie nazwy od uzytkownika
            				
			if (wydatekNazwaInput == "anuluj") //walidacja czy uzytkownik chce anulowac dodawanie wydatku
			{
				break;
			}
			
			Console.Write("Wpisz kwotę wydatku (np, 150.50): ");

			while (true)// petla po to zeby moc wpisac kwote ponownie w przypadku bledu
			{
				var kwotaInput = Console.ReadLine();
				var parsujKwote = decimal.TryParse(kwotaInput, out decimal decimalKwotaInput);

                if (kwotaInput == "anuluj")
                {
                    break;
                }
                else if (parsujKwote == false)//walidacja czy kwota jest poprawna
                {
					Console.WriteLine("Nieprawidłowa kwota. Spróbuj ponownie lub wpisz \"anuluj\", aby cofnąć.");
				}
				else
				{
					 listaWydatkow.Add((wydatekNazwaInput, decimalKwotaInput));
					Console.WriteLine("Wpis dodany pomyślnie. \n");
					break; //brejkuje najbliższą petle jesli kwota poprawna.
				}
			}
			break;

		case 2: // lista wydatków
            Console.Write(
			"\n" +
			"--------------------\n" +
			"-- Lista wydatków --\n" +
			"--------------------\n"
			);
            int wydatekID = 0;
            if (listaWydatkow.Count == 0) //jesli ilosc elementow na liscie wynosi 0 to:
			{
				Console.WriteLine("Brak wpisów. \n");
			}
			else
			{
				foreach (var item in listaWydatkow)
				{
                    
                    wydatekID++;//zwieksza numer pozycji na liscie
					Console.WriteLine($"{wydatekID}. {item.nazwa} | {item.kwota:F2}zł");
				}
				Console.WriteLine();
			}
			

            break;


        case 3: // Suma wydatkow
            Console.Write(
            "\n" +
            "-------------------\n" +
            "-- Suma wydatków --\n" +
            "-------------------\n"
            );
            if (listaWydatkow.Count == 0) //jesli ilosc elementow na liscie wynosi 0 to:
            {
                Console.WriteLine("Brak wpisów. \n");
            } 
			else
			{

			}
			break;

        case 4: // Największy wydatek
            Console.Write(
            "\n" +
            "-------------------------\n" +
            "-- Największy wydatków --\n" +
            "-------------------------\n"
            );
            if (listaWydatkow.Count == 0) //jesli ilosc elementow na liscie wynosi 0 to:
            {
                Console.WriteLine("Brak wpisów. \n");
            }
            break;

		case 5: // wyjscie
            break;
    }

} while (opcjaInput != 5);