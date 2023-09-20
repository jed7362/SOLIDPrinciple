namespace OCPLibrary;

public class ManagerModel : IApplicantModel
{
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual IAccounts AccountProcessor { get; set; }

    public ManagerModel()
    {
        AccountProcessor = new ManagerAccounts();
    }
}