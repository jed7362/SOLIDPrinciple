namespace LSPLibrary;

public class Employee
{
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual Employee Manager { get; set; } = null;
    public virtual decimal Salary { get; set; }

    public virtual void AssignManager(Employee manager)
    {
        // Simulate doing other task here - otherwise, this should be a property set statement, not a method.
        Manager = manager;
    }

    public virtual void CalculatePerHourRate(int rank)
    {
        decimal baseAmount = 12.50M;

        Salary = baseAmount + (rank * 2);
    }
}
