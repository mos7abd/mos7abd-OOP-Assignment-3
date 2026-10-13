using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src._2_OrderProcessor
{
    public interface IEmailSender
    {
        void Send(string to, string body);
    }
}
