using System;
using System.Globalization;

namespace curso_csharp.Entities;

public class Invoice
{
    public double BasicPayment { get; set; }
    public double Tax { get; set; }

    public Invoice(double tax, double basicPayment)
    {
        Tax = tax;
        BasicPayment = basicPayment;
    }

    public double TotalPayment
    {
        get
        {
            return BasicPayment + Tax;
        }
    }

    public override string ToString()
    {
        return $"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
        $"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}\n" +
        $"Total payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}\n";
    }
}
