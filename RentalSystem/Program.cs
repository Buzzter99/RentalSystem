using RentalSystem.Contracts;
using RentalSystem.Models;
using System.Globalization;

namespace RentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol = new string('X',10);
            string brand = "Mitsubishi";
            string model = "Mirage";
            string customer = "John Doe";
            int value = 15000;
            int securityRating = 3;
            DateTime startDate = DateTime.ParseExact("03-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime returnDate = DateTime.ParseExact("13-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact("13-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            IVehicle car = new Car(brand, model, securityRating, value,startDate,endDate,returnDate);
            Console.WriteLine(symbol);
            Console.WriteLine("Date: " + car.EndDate);
            Console.WriteLine($"Customer Name: {customer}");
            Console.WriteLine($"Rented Vehicle: {car.Brand} {car.Model}");
            Console.WriteLine();
            Console.WriteLine($"Reservation start date: {car.StartDate}");
            Console.WriteLine($"Reservation end date: {car.EndDate}");
            Console.WriteLine($"Reserved rental days: {(car.EndDate - car.StartDate).Days} days");
            Console.WriteLine();
            Console.WriteLine($"Actual Return date: {car.ReturnDate}");
            Console.WriteLine($"Actual rental days: {car.CalculateRentalDays()}");
            Console.WriteLine();
            Console.WriteLine($"Rental cost per day: ${car.CalculateDailyRentalPrice():f2}");
            Console.WriteLine($"Insurance per day: ${car.CalculateInsurance():f2}");
            Console.WriteLine();
            Console.WriteLine($"Total rent: ${car.CalculateTotalRent():f2}");
            Console.WriteLine($"Total insurance: ${car.CalculateTotalInsurance():f2}");
            Console.WriteLine($"Total: ${car.CalculateCost():f2}");
            Console.WriteLine(symbol);
        }
    }
}
