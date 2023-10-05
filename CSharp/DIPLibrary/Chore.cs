namespace DIPLibrary;

public class Chore
{
    public string ChoreName { get; set; }
    public Person Owner { get; set; }
    public double HoursWorked { get; set; }
    public bool IsComplete { get; set; }

    public void PerformedWork(double hours)
    {
        HoursWorked += hours;
        Logger log = new();
        log.Log($"Performed work on {ChoreName}");
    }

    public void CompleteChore()
    {
        IsComplete = true;

        Logger log = new();
        log.Log($"Completed {ChoreName}.");

        Emailer emailer = new();
        emailer.SendEmail(Owner, $"The chore {ChoreName} is complete.");
    }
}