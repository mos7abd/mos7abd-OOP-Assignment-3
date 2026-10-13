using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src._3_Notifications
{

    public class ScheduledDecorator : NotificationDecorator
    {
        private readonly DateTime _sendAt;

        public ScheduledDecorator(
            INotification notification,
            DateTime sendAt)
            : base(notification)
        {
            _sendAt = sendAt;
        }

        public override void Send(
            string to,
            string message,
            NotificationOptions? options = null)
        {
            options ??= new NotificationOptions();

            var updatedOptions = new NotificationOptions
            {
                IsUrgent = options.IsUrgent,
                SendAt = _sendAt
            };

            _notification.Send(to, message, updatedOptions);
        }
    }

}


