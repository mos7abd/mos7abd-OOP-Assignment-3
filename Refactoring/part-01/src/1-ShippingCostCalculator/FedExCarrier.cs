using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src._1_ShippingCostCalculator
{
    public class FedExCarrier : IShippingCarrier
    {
        public decimal CalculateCost(decimal weightKg)
        {
            return weightKg * 15m;
        }
    }
}
