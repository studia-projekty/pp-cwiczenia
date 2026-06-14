


Console.WriteLine("Podaj temperaturę:");
double temperatura = double.Parse(Console.ReadLine());

if (temperatura < 0)
{   
    Console.WriteLine("Na zewnątrz jest mróz.");
}
else if (temperatura == 0)
{
    Console.WriteLine("Temperatura wynosi zero stopni.");
}
else
{
    Console.WriteLine("Na zewnątrz jest powyżej zera.");
}