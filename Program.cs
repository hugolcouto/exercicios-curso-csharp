using System.Globalization;
using curso_csharp.Entities;
using curso_csharp.Services;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter contract data");

        System.Console.WriteLine("Number:");
        int number = int.Parse(Console.ReadLine()!);

        System.Console.WriteLine("Date (dd/MM/yyyy):");
        DateTime date = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        System.Console.WriteLine("Contract value:");
        double contractValue = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        System.Console.WriteLine("Enter number of installments:");
        int installments = int.Parse(Console.ReadLine()!);

        Contract myContract = new Contract(number, date, contractValue);

        ContractService contractService = new ContractService(new IuguService());

        contractService.ProcessContract(myContract, installments);

        Console.WriteLine("INSTALLMENTS:");
        foreach (Installment installment in myContract.Installments)
        {
            System.Console.WriteLine(installment);
        }
    }
}