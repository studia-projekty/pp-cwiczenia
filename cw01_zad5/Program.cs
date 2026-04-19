


Console.WriteLine("Podaj temperaturę:");
double temperatura = double.Parse(Console.ReadLine());

if (temperatura < 0)
{   
    Console.WriteLine("Na zewnątrz jest mróz.");

}
if (temperatura == 0)
{
    Console.WriteLine("Temperatura wynosi zero stopni.");
}
if (temperatura > 0)
{
    Console.WriteLine("Na zewnątrz jest powyżej zera.");
}