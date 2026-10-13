using RefactoringLab.Part01.src._3_Notifications;

namespace RefactoringLab;


public class EmailNotification : INotification
{
    public void Send(
        string to,
        string message,
        NotificationOptions? options = null)
    {
        options ??= new NotificationOptions();

        string prefix = options.IsUrgent ? "[URGENT] " : "";

        if (options.SendAt is DateTime sendAt)
        {
            Console.WriteLine(
                $"[email scheduled {sendAt:g}] {to}: {prefix}{message}");
        }
        else
        {
            Console.WriteLine($"[email] {to}: {prefix}{message}");
        }
    }
}

public class SmsNotification : INotification
{
    public void Send(
        string to,
        string message,
        NotificationOptions? options = null)
    {
        options ??= new NotificationOptions();

        string prefix = options.IsUrgent ? "[URGENT] " : "";

        Console.WriteLine($"[sms] {to}: {prefix}{message}");
    }
}




