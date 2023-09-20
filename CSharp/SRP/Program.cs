﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using SRP;

Console.WriteLine("Welcome to my application!");

// Ask for user information
Person user = new();

Console.WriteLine("What is your first name: ");
user.FirstName = Console.ReadLine();

Console.WriteLine("What is your last name: ");
user.LastName = Console.ReadLine();

// Check to be sure the first name and last name are valid
if (string.IsNullOrWhiteSpace(user.FirstName))
{
    Console.WriteLine("You did not give us a valid first name!");
    Console.ReadLine();
    return;
}

if (string.IsNullOrWhiteSpace(user.LastName))
{
    Console.WriteLine("You did not give us a valid last name!");
    Console.ReadLine();
    return;
}

// Create a username for the person
Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");

Console.ReadLine();