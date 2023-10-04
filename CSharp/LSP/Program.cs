// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// https://www.youtube.com/watch?v=-3UXq2krhyw

using LSPLibrary;

IManager accountingVP = new Manager();

accountingVP.FirstName = "Jeiden";
accountingVP.LastName = "Sena";
accountingVP.CalculatePerHourRate(5);

IManaged emp = new Manager();

emp.FirstName = "Ada";
emp.LastName = "Sena";
emp.AssignManager(accountingVP);
emp.CalculatePerHourRate(55);

Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");
Console.ReadLine();