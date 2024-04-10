class Program
{
    static void Main()
    {
        var address = new Address("225 w 6 s", " Rexburg", "Idaho", "USA");

        var lecture = new Lecture("Database Best Practices", "A comprehensive guide to Database development best practices.", new DateTime(2024, 4, 20), "14:00", address, "Dr Umah Godday", 100);
        var reception = new Reception("Developers Hangout", "Programming tech enthusiasts.", new DateTime(2024, 4, 22), "18:00", address, "god21010@byui.edu");
        var outdoor = new OutdoorGathering("Developer Picnic", "Regular outdoor meeting for programmers.", new DateTime(2024, 4, 25), "12:00", address, "Rainy, 35°F");

        PrintEventDetails(lecture);
        PrintEventDetails(reception);
        PrintEventDetails(outdoor);
    }

    static void PrintEventDetails(Event eventItem)
    {
        Console.WriteLine(eventItem.GetStandardDetails());
        Console.WriteLine(eventItem.GetFullDetails());
        Console.WriteLine(eventItem.GetShortDescription());
        Console.WriteLine("--------------------------------------------------");
    }
}
