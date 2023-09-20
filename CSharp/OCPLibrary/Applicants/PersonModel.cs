namespace OCPLibrary;

public class PersonModel : IApplicantModel
{
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual IAccounts AccountProcessor { get; set; }

    public PersonModel()
    {
        AccountProcessor = new Accounts();
    }
}