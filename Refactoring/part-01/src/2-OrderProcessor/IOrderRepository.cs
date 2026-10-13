using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src._2_OrderProcessor
{
    public interface IOrderRepository
    {
        void Save(int orderId, DateTime processedAt);
    }
}
