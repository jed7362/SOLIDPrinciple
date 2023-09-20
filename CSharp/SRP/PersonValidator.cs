namespace SRP;

public class PersonValidator
{
    public static bool Validate(Person person)
    {
        // Check to be sure the first name and last name are valid
        if (string.IsNullOrWhiteSpace(person.FirstName))
        {
            StandardMessages.DisplayValidationError("first name");
            return false;
        }

        if (string.IsNullOrWhiteSpace(person.LastName))
        {
            StandardMessages.DisplayValidationError("last name");
            return false;
        }

        return true;
    }
}