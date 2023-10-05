namespace DIPLibrary;

public class Texter : IMessageSender
{
    public void SendEmail(IPerson person, string message)
    {
        Console.WriteLine($"I am texting {person.FirstName} to say {message}");
    }
}