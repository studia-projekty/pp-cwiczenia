string[] nazwa = new string[100];
int[] ilosc = new int[100];
int[] cena = new int[100];

nazwa[0] = "rzecz";
ilosc[0] = 10;
cena[0] = 100;

nazwa[1] = "rzecz2";
ilosc[1] = 20;
cena[1] = 200;

int wybor = 0;
int ileZaMalo = 0;

int portfel = 0;

while (wybor != 4)
{
    Console.WriteLine("Wybierz opcję:");
    Console.WriteLine("1. Kup produkt");
    Console.WriteLine("2. Dodaj produkt");
    Console.WriteLine("3. Portfel");
    Console.WriteLine("4. Wyjdz");

    wybor = int.Parse(Console.ReadLine());

    if (wybor == 1)
    {
        bool zaMalo = false;
        bool istnieje = false;

        //podaj nazwe
        Console.WriteLine("Podaj Nazwe:");
        string podanaNazwa = Console.ReadLine();

        //sprawdz wszystkie elementy tablicy
        for (int i = 0; i < nazwa.Length; i++)
        {
            //sprawdz czy  nazwa istnieje
            if (podanaNazwa == nazwa[i])
            {
                //jezeli nazwa istnieje to 
                istnieje = true;
                // podaj ilosc
                Console.WriteLine("Podaj ilość:");
                int podanaIlosc = int.Parse(Console.ReadLine());

                if (ilosc[i] >= podanaIlosc)
                {
                    // odejmij z ilosci wpisana wartosc
                    ilosc[i] -= podanaIlosc;
                    //dodaj koszt transakcji (cena * ilosc) do portfela
                    portfel += cena[i] * podanaIlosc;

                    Console.WriteLine("Aktualna ilosc:" + ilosc[i] + " Portfel: " + portfel);

                    break;
                }
                else if (ilosc[i] < podanaIlosc)
                {
                    zaMalo = true;
                    ileZaMalo = ilosc[i];
                    break;
                }

            }
        }
        //jezeli produkt nie istnieje - wyswietl komunikat / jezeli niewystarczajaca ilosc - wyswietl komunikat
        if (zaMalo == true)
        {
            Console.WriteLine("Brak wystarczającej ilości na magazynie: " + ileZaMalo);

        }
        if (istnieje == false)
        {
            Console.WriteLine("Produkt o podanej nazwie nie istnieje");
        }

    }
    //dodaj produt
    if (wybor == 2)
    {
        bool istnieje = false;

        //podaj nazwe produktu
        Console.WriteLine("Podaj nazwę produktu do dodania:");
        string podanaNazwa = Console.ReadLine();

        for (int i = 0; i < nazwa.Length; i++)
        {
            //jezeli istnieje, to podaj liczbe do dodania
            if (podanaNazwa == nazwa[i])
            {
                istnieje = true;

                //podaj liczbe do dodania
                Console.WriteLine("Podaj ilość");
                int podanaIlosc = int.Parse(Console.ReadLine());

                //dodaj podana liczbe do ilosci produktu na stanie
                ilosc[i] += podanaIlosc;

                Console.WriteLine("Dodano. Aktualny stan " + nazwa[i] + " to: " + ilosc[i]);
                break;
            }
        }

        // jezeli nie istnieje to podaj liczbe oraz cene
        if (istnieje == false)
        {
            //podaj liczbe do dodania
            Console.WriteLine("Podaj ilosć do dodania:");
            int podanaIlosc = int.Parse(Console.ReadLine());

            //podaj cene do dodania
            Console.WriteLine("Podaj cenę do dodania:");
            int podanaCena = int.Parse(Console.ReadLine());

            //petla
            for (int i = 0; i < nazwa.Length; i++)
            {
                //sprawdz czy jest wolne miejsce w tablicy
                if (nazwa[i] == null)
                {
                    // dodaj nazwe, ilosc i cene nowego produktu do tablic
                    nazwa[i] = podanaNazwa;
                    ilosc[i] = podanaIlosc;
                    cena[i] = podanaCena;

                    Console.WriteLine("Dodano: " + nazwa[i] + " " + ilosc[i] + " " + cena[i]);
                    break;

                }
            }



        }


    }
    if (wybor == 3)
    {
        //pokaz portfel
        Console.WriteLine("Pokaż portfel: " + portfel + "\n");
    }    

    
}
