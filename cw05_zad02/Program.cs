//lista 

using System.Security.Authentication.ExtendedProtection;


    double wartosc = 0;
    List<(string nazwa, double cena, int ilosc)> lista = new List<(string nazwa, double cena, int ilosc)>

{
(nazwa: "ProduktA", cena: 10.00, ilosc: 1),
(nazwa: "ProduktB", cena: 20.00, ilosc: 1),
(nazwa: "ProduktC", cena: 30.00, ilosc: 1),
(nazwa: "ProduktD", cena: 40.00, ilosc: 1),
(nazwa: "ProduktE", cena: 50.00, ilosc: 1)

};


    foreach (var produkt in lista)
    {

        wartosc = wartosc + (produkt.cena * produkt.ilosc);

    }

    Console.WriteLine(wartosc);





