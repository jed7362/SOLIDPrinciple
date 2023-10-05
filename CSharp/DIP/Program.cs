// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//https://www.youtube.com/watch?v=NnZZMkwI6KI

using DIPLibrary;

Person owner = new()
{
    FirstName = "Jeiden",
    LastName = "Sena",
    EmailAddress = "jeiden@sena.com",
    PhoneNumber = "123321"
};

Chore chore = new()
{
    ChoreName = "Take out the trash",
    Owner = owner
};

chore.PerformedWork(3);
chore.PerformedWork(1.5);
chore.CompleteChore();

Console.ReadLine();