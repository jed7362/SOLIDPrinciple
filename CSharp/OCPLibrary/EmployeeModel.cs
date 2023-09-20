namespace OCPLibrary;

public class EmployeeModel
{
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual string EmailAddress { get; set; }
    public virtual bool IsManager { get; set; }
    public virtual bool IsExecutive { get; set; }

    public EmployeeModel()
    {
        IsManager = false;
        IsExecutive = false;
    }
}