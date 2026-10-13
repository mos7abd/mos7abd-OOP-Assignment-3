using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src
{
    public interface IShippingCarrier
    {
        decimal CalculateCost(decimal weightKg);
    }
}
