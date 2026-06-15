using System.ComponentModel.DataAnnotations;

var dane = (name: "Jan Kowalski", phone: "123-456-789");

Console.WriteLine($"Imię i nazwisko: {dane.name} | Numer Telefonu: {dane.phone}");