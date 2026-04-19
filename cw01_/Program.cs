using System.Reflection;

internal class Program
{
    public static void Main(string[] args)
    {
        int proba = 1; 
        while (proba <=3)
        {
            
            Console.WriteLine("Podaj nazwę użytkownika: ");
            string login = Console.ReadLine();
            Console.WriteLine("Podaj hasło użytkownika: ");
            string password = Console.ReadLine();  


            if (login.Length >= 5 && password.Length >=8 && password.Any(char.IsDigit))
            {
                Console.WriteLine("Logowanie zakończone sukcesem");
                break;
            } 
            else
            {   
             if (proba <= 3)
            {
                proba++;
                Console.WriteLine("Dane niepoprawne.");   
            }  
                if (proba == 4)     
                {
                    Console.WriteLine("Przekroczono limit prób logowania, konto zablokowane");
                }
            }
    }
    }



}