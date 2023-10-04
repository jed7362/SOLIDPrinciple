namespace LSPLibrary;

public abstract class BaseEmployee : IEmployee
{
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual decimal Salary { get; set; }

    public virtual void CalculatePerHourRate(int rank)
    {
        decimal baseAmount = 12.50M;

        Salary = baseAmount + (rank * 2);
    }
}