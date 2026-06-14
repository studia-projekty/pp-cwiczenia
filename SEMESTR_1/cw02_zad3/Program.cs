
string[] nazwa = new string[10];
int[] ilosc = new int[10];
int[] cena = new int[10];

nazwa[0] = "przedmiot1";
nazwa[1] = "przedmiot2";
nazwa[2] = "przedmiot3";

ilosc[0] = 10;
ilosc[1] = 5;
ilosc[2] = 2;

cena[0] = 10;
cena[1] = 20;
cena[2] = 30;

int wybor = 0;

int portfel = 0;
int wartoscZakupu = 0;

bool znalezionoProdukt = false;

/////////////
//petla menu
while (wybor != 4)
{

    //////////
    // menu
    Console.WriteLine("1. Kup produkt");
    Console.WriteLine("2. Dodaj produkt do magazynu");
    Console.WriteLine("3. Wyświetl sumę zakupów");
    Console.WriteLine("4. Wyjście");

    //////////////
    //wybor opcji
    wybor = int.Parse(Console.ReadLine());

    ///////////////////   
    //wybrano opcje 1
    if(wybor == 1)
    {
        ////////
        /// podanie nazwy
        /// 
        Console.WriteLine("Podaj nazwę produktu:");
        string nazwaPodana = Console.ReadLine();



        //////////////
        /// Pętla, żeby przelecieć wszystkie produkty w poszukiwaniu wpisanego
        /// 
        for (int i = 0; i < nazwa.Length; i++)
        {       
            
            ///////////
            /// Jezeli wpisana nazwa znajduje sie w tablicy
            /// 
            if (nazwaPodana == nazwa[i])
            {
                ///////////
                /// Zaznacz, że znaleziono produkt o podanej nazwie
                /// 
                znalezionoProdukt = true;

                /////////
                /// podajemy ilosc
                Console.WriteLine("Podaj ilość: ");
                int iloscPodana = int.Parse(Console.ReadLine());      

                ///////////
                /// sprawdz czy jest odpowiednia ilosc w magazynie
                /// 
                if(ilosc[i] >= iloscPodana)
                {
                    ////////////
                    /// oblicz wartosc zakupu i dodaj wartosc do portfela
                    ///  
                    wartoscZakupu = cena[i] * iloscPodana;
                    portfel = portfel + wartoscZakupu;
                    ilosc[i] -= iloscPodana;

                    Console.WriteLine("Do portfela dodano wartość zakupu: " + wartoscZakupu);
                    Console.WriteLine("Na magazynie zostało " + ilosc[i] + " " + nazwa[i]);
                    Console.WriteLine("");

                    break;
                }
                else if (ilosc[i] < iloscPodana)
                {
                    Console.WriteLine("Na magazynie nie ma wystarczającej ilośći produktu.");
                    Console.WriteLine("");
                }
                            
            }

        }

        if(znalezionoProdukt == false)
        {
            Console.WriteLine("Nie znaleziono produktu");
            
        }
        
    }
    if (wybor == 2)
    {
        Console.WriteLine("Wpisz nazwe produktu do dodania: ");
        string produktDoDodania = Console.ReadLine();

        for (int i = 0; i < nazwa.Length; i++)
        {
            //////////////
            /// Jeżeli produkt istnieje, to tylko zwieksz jego ilosc
            /// 
            if (nazwa[i] == produktDoDodania)
            {   
                //////////////////
                /// zwieksz ilosc istniejacego produktu
                /// 
                Console.WriteLine("Wpisz ilość do dodania");
                int iloscDoDodania = int.Parse(Console.ReadLine());

                ilosc[i] += iloscDoDodania;
                Console.WriteLine(" produkt dodany");
                Console.WriteLine("");
                break;
            }
            /////////////
            /// Jeżeli produkt nie istnieje, a jest miejsce to dodaj nazwe, ilosc i cene.
            /// 
            else if (nazwa[i] != produktDoDodania && nazwa[i] == null)
            {
                    Console.WriteLine("Wpisz ilość do dodania");
                    int iloscDoDodania = int.Parse(Console.ReadLine());

                    Console.WriteLine("Wpisz cenę produktu do dodania");
                    int cenaDoDodania = int.Parse(Console.ReadLine());

                nazwa[i] = produktDoDodania;
                ilosc[i] = iloscDoDodania; 
                cena[i] = cenaDoDodania;
                break;
            } else if (nazwa[i])
            {
                Console.WriteLine("Brak miejsca na nowe produkty.");
                break;
            }

        }


        // nazwa
        // ilosc
        // cena


    }

}



    