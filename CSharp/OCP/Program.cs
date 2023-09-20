// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// https://www.youtube.com/watch?v=VFlk43QGEgc

using OCPLibrary;

// Create Applicants
List<PersonModel> applicants = new()
{
    new(){ FirstName= "Jeiden", LastName = "Sena"},
    new(){ FirstName= "Ada", LastName = "Sena", TypeOfEmployee=EmployeeType.Manager},
    new(){ FirstName= "Jeizer", LastName = "Sena", TypeOfEmployee =EmployeeType.Executive}
};

List<EmployeeModel> employees = new();
Accounts accountProcessor = new();

// Create employee for each applicants
foreach (var person in applicants)
{
    employees.Add(accountProcessor.Create(person));
}

// Display all employees
foreach (var emp in employees)
{
    Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
}

Console.ReadLine();