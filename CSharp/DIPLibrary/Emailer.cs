﻿namespace DIPLibrary;

public class Emailer : IMessageSender
{
    public void SendEmail(IPerson person, string message)
    {
        Console.WriteLine($"Simulating sending an email to {person.EmailAddress}");
    }
}