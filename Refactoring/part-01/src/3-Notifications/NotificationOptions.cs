using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src._3_Notifications
{
    public sealed class NotificationOptions
    {
        public bool IsUrgent { get; init; }

        public DateTime? SendAt { get; init; }
    }
}
