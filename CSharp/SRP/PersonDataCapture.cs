namespace SRP;

public class PersonDataCapture
{
    public static Person Capture()
    {
        // Ask for user information
        Person output = new();

        Console.WriteLine("What is your first name: ");
        output.FirstName = Console.ReadLine();

        Console.WriteLine("What is your last name: ");
        output.LastName = Console.ReadLine();

        return output;
    }
}