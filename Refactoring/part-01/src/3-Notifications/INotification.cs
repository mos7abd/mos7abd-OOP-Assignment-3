using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src._3_Notifications
{
    public interface INotification
    {
        void Send(
            string to,
            string message,
            NotificationOptions? options = null);
    }
}
