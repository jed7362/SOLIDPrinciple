namespace DIPLibrary;

public class Person : IPerson
{
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual string PhoneNumber { get; set; }
    public virtual string EmailAddress { get; set; }
}