using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src._3_Notifications
{

    public abstract class NotificationDecorator : INotification
    {
        protected readonly INotification _notification;

        protected NotificationDecorator(INotification notification)
        {
            _notification = notification;
        }

        public virtual void Send(
            string to,
            string message,
            NotificationOptions? options = null)
        {
            _notification.Send(to, message, options);
        }
    }

}
