/* 
 Temat zadania: Kalkulator wydatków domowych
 Opis zadania: 
	Napisz aplikację konsolową w języku C#, która pozwoli użytkownikowi zarządzać swoimi wydatkami domowymi. Program powinien umożliwiać:
	Dodawanie wydatków (nazwa wydatku i kwota).
	Wyświetlanie listy wszystkich wydatków.
	Obliczanie łącznej kwoty wydatków.
	Znalezienie wydatku o najwyższej wartości.
	Wyjście z programu.

Wymagania funkcjonalne:
	Program powinien działać w pętli, dopóki użytkownik nie wybierze opcji wyjścia.
	Wydatki powinny być przechowywane w odpowiedniej strukturze danych (np. lista).
	Użytkownik wybiera operację z menu za pomocą odpowiedniego numeru.

Szczegóły implementacyjne:
	Użytkownik wpisuje nazwę wydatku i jego kwotę (kwota może być liczbą zmiennoprzecinkową).
	W przypadku wyświetlania wydatków należy pokazać ich nazwę i kwotę.
	Dla opcji obliczania łącznej kwoty program powinien zwrócić sumę wszystkich wydatków.
	Dla opcji znalezienia największego wydatku należy zwrócić nazwę wydatku i jego kwotę.
	Program kończy działanie, gdy użytkownik wybierze opcję wyjścia.

Kryteria oceny:
	Poprawność działania wszystkich funkcji.
	Czytelność kodu (w tym stosowanie odpowiednich nazw zmiennych i komentarzy).
	Obsługa błędów (np. walidacja wprowadzonej kwoty, obsługa pustej listy wydatków przy wyborze opcji 2, 3 lub 4).
	Działające menu z możliwością powrotu do głównego ekranu po każdej operacji.
*/

int opcjaInput;

List<(string nazwa, decimal kwota)> listaWydatkow = new();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(
		"======================================\n" +
		"==== Kalkulator wydatków domowych ====\n" +
		"======================================\n"
    );
	Console.ResetColor();
	Console.WriteLine(
        "1.Dodaj wydatek \n" +
		"2.Wyświetl listę wydatków \n" +
		"3.Oblicz łączną kwotę wydatków \n" +
		"4.Znajdź największy wydatek \n" +
		"5.Wyjdź \n"
	);
	
    //pobranie opcji od uzytkownika i walidacja czy jest intem, jesli nie to zwraca false czyli 0.
    Console.Write("Wybierz opcję: "); int.TryParse(Console.ReadLine(), out opcjaInput); 

	switch (opcjaInput)
	{			  ///////////////////////////
		default: // opcje poza zakresem 1-5
				////////////////////////////
            Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\nNiepoprawny wybór. Wybierz opcje od 1 do 5. \n");
            Console.ResetColor();
            break;
				 /////////////////////
		case 1: // dodawanie wydatku
			   //////////////////////
            Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(
			"\n" +
			"------------------------\n" +
			"---- Dodaj wydatek -----\n" +
			"------------------------\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("aby cofnąć wpisz \"anuluj\"\n");
            Console.ResetColor();

            Console.Write("\nWpisz nazwę wydatku (np. pizza): ");
			 
            // pobranie nazwy od uzytkownika
            string wydatekNazwaInput = Console.ReadLine();

            //walidacja czy uzytkownik chce anulowac dodawanie wydatku
            if (wydatekNazwaInput == "anuluj") 
			{
				break;
			}
			
			Console.Write("Wpisz kwotę wydatku (np, 12.99): ");

			while (true)// petla po to zeby moc wpisac kwote ponownie w przypadku bledu
			{
                 
                // pobranie kwoty od uzytkownika
                var kwotaInput = Console.ReadLine();
				var kwotaZamienPrzecinek = kwotaInput.Replace(",", ".");

				var parsujKwote = decimal.TryParse(kwotaZamienPrzecinek, out decimal decimalKwotaInput);

                if (kwotaInput == "anuluj")
                {
                    break;
                }
                else if (parsujKwote == false || decimalKwotaInput < 0)//walidacja czy kwota jest poprawna
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nieprawidłowa kwota. Spróbuj ponownie lub wpisz \"anuluj\", aby cofnąć.");
					Console.ResetColor();
				}
                else //dodaje wydatek do listy jesli kwota poprawna i brejkuje petle
                {
					listaWydatkow.Add((wydatekNazwaInput, decimalKwotaInput));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nWpis dodany pomyślnie. \n");
					Console.ResetColor();
					break;
				}
			}
			break;
				  //////////////////
		case 2:  // lista wydatków
				//////////////////
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(
			"\n" +
			"--------------------\n" +
			"-- Lista wydatków --\n" +
			"--------------------\n"
			);
			Console.ResetColor();
            int wydatekID = 0;
            if (listaWydatkow.Count == 0) //jesli ilosc elementow na liscie wynosi 0 to:
			{
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Brak wpisów. \n");
                Console.ResetColor();
            }
			else
			{
				foreach (var item in listaWydatkow)
				{
                    wydatekID++;//zwieksza numer pozycji na liscie
					Console.WriteLine($"{wydatekID}. {item.nazwa} | {item.kwota:F2}zł");
				}
				
			}

            Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego...\n");
            Console.ResetColor();

            Console.ReadKey();
            break;
			 
				  /////////////////
        case 3:  // Suma wydatkow
				/////////////////
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(
            "\n" +
            "-------------------\n" +
            "-- Suma wydatków --\n" +
            "-------------------\n"
            );
			Console.ResetColor();
            if (listaWydatkow.Count == 0) //jesli ilosc elementow na liscie wynosi 0 to:
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
					Console.WriteLine("Brak wpisów. \n");
				Console.ResetColor();
            } 
			else
			{
                decimal sumaWydatkow = 0;

                foreach (var item in listaWydatkow)
                {
					sumaWydatkow += item.kwota;
                }
				
                Console.Write($"Suma wydatków: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write($" {sumaWydatkow:F2}zł \n");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego...\n");
            Console.ResetColor();

            Console.ReadKey();
            break;
				  /////////////////////
        case 4:  // Największy wydatek
				/////////////////////
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(
            "\n" +
            "------------------------\n" +
            "-- Największy wydatek --\n" +
            "------------------------\n"
            );
			Console.ResetColor();

            //jesli ilosc elementow na liscie wynosi 0 to:
            if (listaWydatkow.Count == 0) 
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Brak wpisów. \n");
                Console.ResetColor();
            }
			else
			{
				var najwiekszyWydatek = listaWydatkow[0];
                //sprawdzanie najwiekszego wydatku w liscie
                foreach (var item in listaWydatkow)
				{
					if (najwiekszyWydatek.kwota < item.kwota) //sprawdza czy aktualny najwiekszy wydatek jest mniejszy od itemka z listy
					{
						najwiekszyWydatek = item;
					}
				}

				Console.Write($"Największy wydatek: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write($"{najwiekszyWydatek.kwota:F2}zł \n");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.WriteLine("Pozycje o tej kwocie:");
				Console.ResetColor();


                //wypisanie wszystkich pozycji o tej samej kwocie co najwyzsza
                foreach (var item in listaWydatkow)
				{
					if (item.kwota == najwiekszyWydatek.kwota)
					{
						Console.Write($" - ");
						Console.Write($"{item.nazwa} \n");
                    }
				}
			}
            Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego...\n");
            Console.ResetColor();
            Console.ReadKey();
            break;
				  ///////////
		case 5:  // wyjscie
				///////////
            break;
    }

} while (opcjaInput != 5);