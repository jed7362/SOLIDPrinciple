namespace OCPLibrary;

public class ExecutiveAccounts : IAccounts
{
    public EmployeeModel Create(IApplicantModel person)
    {
        EmployeeModel output = new();

        output.FirstName = person.FirstName;
        output.LastName = person.LastName;
        output.EmailAddress = $"{person.FirstName}.{person.LastName}@cbcorp.com";

        output.IsManager = true;
        output.IsExecutive = true;

        return output;
    }
}