int[] stan = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
int[] minimum = {10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
int[] cena = {30, 35, 40, 45, 50, 55, 60, 65, 70, 75};

int indeks_leku = 0;
int suma_kosztow = 0;
int liczba_lekow_do_domowienia = 0;
int najwiekszy_koszt = cena[0];
int indeks_najwiekszego_kosztu = 0;

for (int i = 0; i < stan.Length; i++)
{
    if(stan[i] < minimum[i])
    {
        indeks_leku = i;
        int domowienie = minimum[i] - stan[i]; 
        int koszt = domowienie * cena[i];

        Console.WriteLine("Lek numer " + indeks_leku + " Wymaga domówienia w ilości: " + domowienie + " sztuk. Koszt:" + koszt);

        suma_kosztow += koszt;
        liczba_lekow_do_domowienia++;

        if (koszt > najwiekszy_koszt)
        {
            najwiekszy_koszt = koszt;
            indeks_najwiekszego_kosztu = i;
        }
      }
    else
    {
        Console.WriteLine("Lek numer " + indeks_leku + " jest w wystarczającej ilości.");
    }
       
}
Console.WriteLine("Suma kosztów domówienia: " + suma_kosztow + "zł. Dla " + liczba_lekow_do_domowienia + " leków.");
Console.WriteLine("Największy koszt domówienia: " + najwiekszy_koszt + "zł. Lek numer: " + indeks_najwiekszego_kosztu);