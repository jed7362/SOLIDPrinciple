namespace DIPLibrary;

public class Emailer
{
    internal void SendEmail(Person person, string message)
    {
        Console.WriteLine($"Simulating sending an email to {person.EmailAddress}");
    }
}