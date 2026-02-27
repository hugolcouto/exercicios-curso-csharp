using System;

namespace curso_csharp.Services;

public class IuguService : IOnlinePaymentService
{
    private double FeePercentage = 0.04;
    private double MonthlyInterest = 0.02;

    public double PaymentFee(double amount)
    {
        return amount * FeePercentage;
    }
    public double Interest(double amount, int months)
    {
        return amount * MonthlyInterest * months;
    }
}
