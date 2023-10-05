// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//https://www.youtube.com/watch?v=NnZZMkwI6KI

using DIP;
using DIPLibrary;

IPerson owner = Factory.CreatePerson();
owner.FirstName = "Jeiden";
owner.LastName = "Sena";
owner.EmailAddress = "jeiden@sena.com";
owner.PhoneNumber = "123321";

IChore chore = Factory.CreateChore();
chore.ChoreName = "Take out the trash";
chore.Owner = owner;

chore.PerformedWork(3);
chore.PerformedWork(1.5);
chore.CompleteChore();

Console.ReadLine();