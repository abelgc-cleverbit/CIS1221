// FILE: SOLID.CSX
// This script demonstrates the SOLID principles in C#.
// To run this file interactively using C# Interactive (csi), follow these steps:
// 1. Open a terminal.
// 2. Navigate to the directory containing this file.
// 3. Run the C# Interactive shell by typing `csi`.
// 4. Load this file using `#load "Solid.csx"`.
// 5. Create instances of the classes and call their methods to see the results.

using System;
using System.Collections.Generic;

// Single Responsibility Principle (SRP)
// This class is responsible for handling user data only.
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}

// Open/Closed Principle (OCP)
// This class is open for extension but closed for modification.
public abstract class Notification
{
    public abstract void Send(User user, string message);
}

public class EmailNotification : Notification
{
    public override void Send(User user, string message)
    {
        Console.WriteLine($"Sending Email to {user.Email}: {message}");
    }
}

public class SMSNotification : Notification
{
    public override void Send(User user, string message)
    {
        Console.WriteLine($"Sending SMS to {user.Name}: {message}");
    }
}

// Liskov Substitution Principle (LSP)
// Derived classes should be substitutable for their base classes.
public class NotificationService
{
    private readonly List<Notification> _notifications;

    public NotificationService()
    {
        _notifications = new List<Notification>();
    }

    public void AddNotification(Notification notification)
    {
        _notifications.Add(notification);
    }

    public void Notify(User user, string message)
    {
        foreach (var notification in _notifications)
        {
            notification.Send(user, message);
        }
    }
}

// Interface Segregation Principle (ISP)
// Clients should not be forced to depend on interfaces they do not use.
public interface IEmailSender
{
    void SendEmail(User user, string message);
}

public interface ISMSSender
{
    void SendSMS(User user, string message);
}

public class EmailSender : IEmailSender
{
    public void SendEmail(User user, string message)
    {
        Console.WriteLine($"Sending Email to {user.Email}: {message}");
    }
}

public class SMSSender : ISMSSender
{
    public void SendSMS(User user, string message)
    {
        Console.WriteLine($"Sending SMS to {user.Name}: {message}");
    }
}

// Dependency Inversion Principle (DIP)
// High-level modules should not depend on low-level modules. Both should depend on abstractions.
public class NotificationManager
{
    private readonly IEmailSender _emailSender;
    private readonly ISMSSender _smsSender;

    public NotificationManager(IEmailSender emailSender, ISMSSender smsSender)
    {
        _emailSender = emailSender;
        _smsSender = smsSender;
    }

    public void SendNotifications(User user, string message)
    {
        _emailSender.SendEmail(user, message);
        _smsSender.SendSMS(user, message);
    }
}

public class Program
{
    public static void Main()
    {
        User user = new User { Name = "John Doe", Email = "john.doe@example.com" };

        // Using NotificationService with LSP
        NotificationService notificationService = new NotificationService();
        notificationService.AddNotification(new EmailNotification());
        notificationService.AddNotification(new SMSNotification());
        notificationService.Notify(user, "Hello, John!");

        // Using NotificationManager with DIP
        IEmailSender emailSender = new EmailSender();
        ISMSSender smsSender = new SMSSender();
        NotificationManager notificationManager = new NotificationManager(emailSender, smsSender);
        notificationManager.SendNotifications(user, "Hello, John!");
    }
}