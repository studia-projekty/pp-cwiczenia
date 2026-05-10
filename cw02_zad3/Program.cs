
string[] nazwa = new string[10];
int[] ilosc_magazyn = new int[10];
int[] cena = new int[10];

nazwa[0] = "przedmiot1";
nazwa[1] = "przedmiot2";
nazwa[2] = "przedmiot3";

ilosc_magazyn[0] = 10;
ilosc_magazyn[1] = 5;
ilosc_magazyn[2] = 2;

cena[0] = 1;
cena[1] = 2;
cena[2] = 3;

int portfel = 0;
int wybor = 0;
bool znaleziono = false;

Console.WriteLine("1. Kup produkt");
Console.WriteLine("2. Dodaj produkt do magazynu");
Console.WriteLine("3. Wyświetl sumę zakupów");
Console.WriteLine("4. Wyjście");

wybor = int.Parse(Console.ReadLine());

while (wybor != 4)
{
    if(wybor == 1)
    {
        Console.WriteLine("Podaj nazwę produktu:");
        string nazwa_produktu = Console.ReadLine();
        Console.WriteLine("Podaj ilość: ");
        int ilosc_produktow = int.Parse(Console.ReadLine());

        

        for (int i = 0; i < nazwa.Length; i++)
        {
            if (nazwa[i] == nazwa_produktu)
            {
                znaleziono = true;          

            }
            if (znaleziono == true)
            {
                if (ilosc_magazyn[i] >= ilosc_produktow)
                {
                    portfel += cena[i] * ilosc_produktow;
                    ilosc_magazyn[i] -= ilosc_produktow;
                    Console.WriteLine("Zakupiono " + ilosc_produktow + " sztuk " + nazwa_produktu);
                }
                else
                {
                    Console.WriteLine("Nie ma wystarczającej ilości produktu w magazynie.");
                }
            }
        
        }
        if (znaleziono == false)
        {
            Console.WriteLine("Nie znaleziono produktu.");
        }




    }

}



    