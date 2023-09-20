namespace OCPLibrary;

public class ExecutiveModel : IApplicantModel
{
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual IAccounts AccountProcessor { get; set; }

    public ExecutiveModel()
    {
        AccountProcessor = new ExecutiveAccounts();
    }
}