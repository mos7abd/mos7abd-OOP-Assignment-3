using RefactoringLab.Part01.src;

namespace RefactoringLab;

public class ShippingCostCalculator
{
    public decimal Calculate(IShippingCarrier carrier, decimal weightKg)
    {
        return carrier.CalculateCost(weightKg);
    }
}
