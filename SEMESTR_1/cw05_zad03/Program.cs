List<(string day, string subject, string time)> scheduleList = new();


scheduleList.Add(("Poniedziałek", "Matematyka", "8:00"));
scheduleList.Add(("Poniedziałek", "Informatyka", "9:00"));
scheduleList.Add(("Wtorek", "Jez. Polski", "9:00"));
scheduleList.Add(("Środa", "Jez. Angielski", "10:00"));
scheduleList.Add(("Czwartek", "Geografia", "11:00"));
scheduleList.Add(("Piątek", "Historia", "12:00"));
scheduleList.Add(("Sobota", "Biologia", "13:00"));
scheduleList.Add(("Niedziela", "Chemia", "14:00"));
string functionDay(string day)
{

    string wiadomosc = "Nie ma zajęć tego dnia";
    int znalezionoZajec = 0;

    foreach (var item in scheduleList)
    {

        if (day == item.day)
        {
            Console.WriteLine(item.subject + " " + item.time);
            znalezionoZajec++;
        }

    }
    if (znalezionoZajec == 0)
    {
        return "nie znaleziono zajęć";
    }

    return "";
}

while (true)
{
    
    Console.WriteLine("Podaj dzień tygodnia:");
    string input = Console.ReadLine();
    Console.WriteLine(functionDay(input));

}