using System.Globalization;
using curso_csharp.Entities;
using curso_csharp.Services;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter rental data");
        System.Console.WriteLine("Car model: ");
        string model = Console.ReadLine()!;

        System.Console.WriteLine("Pickup (dd/MM/yyyy hh:mm)");
        DateTime start = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        System.Console.WriteLine("Return (dd/MM/yyyy hh:mm)");
        DateTime finish = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        System.Console.WriteLine("Enter price per hour: ");
        double hour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        System.Console.WriteLine("Enter price per day: ");
        double day = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        CarRental carRental = new CarRental(start, finish, new Vehicle(model));

        RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

        rentalService.ProcessInvoice(carRental);

        System.Console.WriteLine("INVOICE: ");
        System.Console.WriteLine(carRental.Invoice);

    }
}