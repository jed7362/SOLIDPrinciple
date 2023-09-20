// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// https://www.youtube.com/watch?v=5RwhyZnVRS8

using SRP;

StandardMessages.WelcomeMessage();

Person user = PersonDataCapture.Capture();

bool isUserValid = PersonValidator.Validate(user);

if (!isUserValid)
{
    StandardMessages.EndApplication();
    return;
}

AccountGenerator.CreateAccount(user);

StandardMessages.EndApplication();