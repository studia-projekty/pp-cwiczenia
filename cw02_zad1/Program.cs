
using System.Diagnostics.CodeAnalysis;

int[] klienci = {12, 18, 25, 15, 9, 30, 22, 17, 14, 19, 11, 16};

int suma = 0;
int max = klienci[0];
int index_max = 0;
bool dodatkowaObsluga = false;

for (int i=0; i < klienci.Length; i++ )
{
    suma += klienci[i]; 
    //szukanie największej wartości
    if (klienci[i] > max)
    {
        max = klienci[i];
        index_max = i;
    }
    if (klienci[i] > 20)
    {
        dodatkowaObsluga = true;
    }
    
}


Console.WriteLine($"Łącznie sklep odwiedziło : {suma}");
Console.WriteLine($"Najwiecej osób odwiedziło sklep o godzinie: {index_max} {+1}");