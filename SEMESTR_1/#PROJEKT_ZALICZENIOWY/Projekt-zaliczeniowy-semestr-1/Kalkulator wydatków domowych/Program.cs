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


string opcja = "";
do
{

	Console.Write(
		"=====================================\n" +
		"==== Kalkulator wydatków domowyc ====\n" +
		"=====================================\n"
    );
	Console.WriteLine(
		"1.Dodaj wydatek \n" +
		"2.Wyświetl listę wydatków \n" +
		"3.Oblicz łączną kwotę wydatków \n" +
		"4.Znajdź największy wydatek \n" +
		"5.Wyjdź \n"
	);

	Console.Write("Wybierz opcję: "); opcja = Console.ReadLine();


} while (opcja != "5");