// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// https://www.youtube.com/watch?v=VFlk43QGEgc

using OCPLibrary;

// Create Applicants
List<IApplicantModel> applicants = new()
{
    new PersonModel(){ FirstName= "Jeiden", LastName = "Sena"},
    new ManagerModel(){ FirstName= "Ada", LastName = "Sena"},
    new ExecutiveModel(){ FirstName= "Jeizer", LastName = "Sena"}
};

List<EmployeeModel> employees = new();

// Create employee for each applicants
foreach (var person in applicants)
{
    employees.Add(person.AccountProcessor.Create(person));
}

// Display all employees
foreach (var emp in employees)
{
    Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
}

Console.ReadLine();