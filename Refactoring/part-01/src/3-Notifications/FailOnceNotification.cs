using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src._3_Notifications
{


    public class FailOnceNotification : INotification
    {
        private int _attempts;

        public void Send(
            string to,
            string message,
            NotificationOptions? options = null)
        {
            _attempts++;

            Console.WriteLine($"Attempt {_attempts}");

            if (_attempts == 1)
            {
                throw new InvalidOperationException(
                    "Simulated sending failure.");
            }

            Console.WriteLine($"[success] {to}: {message}");
        }
    }


}
