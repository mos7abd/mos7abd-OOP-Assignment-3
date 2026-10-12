using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src._3_Notifications
{

    public class RetryDecorator : NotificationDecorator
    {
        private readonly int _maxAttempts;

        public RetryDecorator(
            INotification notification,
            int maxAttempts = 3)
            : base(notification)
        {
            if (maxAttempts < 1)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(maxAttempts),
                    "Max attempts must be at least 1.");
            }

            _maxAttempts = maxAttempts;
        }

        public override void Send(
            string to,
            string message,
            NotificationOptions? options = null)
        {
            for (int attempt = 1; attempt <= _maxAttempts; attempt++)
            {
                try
                {
                    _notification.Send(to, message, options);
                    return;
                }
                catch when (attempt < _maxAttempts)
                {
                    // Retry the notification.
                }
            }
        }
    }


}
