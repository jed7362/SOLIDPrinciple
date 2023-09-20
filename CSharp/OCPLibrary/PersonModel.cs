namespace OCPLibrary;

public class PersonModel
{
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual EmployeeType TypeOfEmployee { get; set; }

    public PersonModel()
    {
        TypeOfEmployee = EmployeeType.Staff;
    }
}