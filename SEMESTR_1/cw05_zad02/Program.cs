//lista 

using System.Security.Authentication.ExtendedProtection;


double wartosc = 0;
List<(string nazwa, double cena, int ilosc)> lista = new();


lista.Add((nazwa: "produktA", cena: 10.00, ilosc: 1));
lista.Add((nazwa: "produktB", cena: 20.00, ilosc: 2));
lista.Add((nazwa: "produktC", cena: 30.00, ilosc: 2));
lista.Add((nazwa: "produktD", cena: 40.00, ilosc: 3));



foreach (var produkt in lista)
    {

        wartosc = wartosc + (produkt.cena * produkt.ilosc);

    Console.WriteLine("Nazwa: " + produkt.nazwa + " Cena: " + produkt.cena + " Ilość: " + produkt.ilosc + "\n");
    }



    Console.WriteLine($"Wartość: {wartosc}");





