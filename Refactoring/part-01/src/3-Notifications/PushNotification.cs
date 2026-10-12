using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src._3_Notifications
{

    public class PushNotification : INotification
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
                    $"[push scheduled {sendAt:g}] {to}: {prefix}{message}");
            }
            else
            {
                Console.WriteLine($"[push] {to}: {prefix}{message}");
            }
        }
    }

}
