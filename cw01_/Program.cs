internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj nazwę użytkownika: ");
       string login = Console.ReadLine();

       if (login.Length >= 5)
        {
          Console.WriteLine("Nazwa użytkownika poprawna");
        } 
        else
        {
          Console.WriteLine("Nazwa użytkownika jest za krótka");  
        }


    }

}