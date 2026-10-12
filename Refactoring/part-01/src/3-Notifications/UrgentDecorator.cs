using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src._3_Notifications
{

    public class UrgentDecorator : NotificationDecorator
    {
        public UrgentDecorator(INotification notification)
            : base(notification)
        {
        }

        public override void Send(
            string to,
            string message,
            NotificationOptions? options = null)
        {
            options ??= new NotificationOptions();

            var updatedOptions = new NotificationOptions
            {
                IsUrgent = true,
                SendAt = options.SendAt
            };

            _notification.Send(to, message, updatedOptions);
        }
    }

}
