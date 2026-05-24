//CW03 Zadanie 8

Console.WriteLine("Podaj ile liczb z ciągu fibonacciego wyświetlić");

int n = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;

int nastepna = 0;


for (int i = 0; i < n; i++)
{

    nastepna = a + b;

    a = b;
    b = nastepna;

    Console.WriteLine(nastepna);
}







// 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946,