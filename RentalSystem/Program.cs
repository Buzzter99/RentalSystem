using RentalSystem.Contracts;
using RentalSystem.Models;
using System.Globalization;

namespace RentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brand = "Mitsubishi";
            string model = "Mirage";
            string customer = "John Doe";
            int value = 15000;
            int securityRating = 3;
            DateTime startDate = DateTime.ParseExact("2024-06-03", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime returnDate = DateTime.ParseExact("2024-06-13", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact("2024-06-13", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            IVehicle car = new Car(brand, model, securityRating, value,startDate,endDate,returnDate);
            car.PrintInvoice(customer,car);
            string brandMotor = "Triumph";
            string modelMotor = "Tiger Sport 660";
            string customerMotor = "Mary Johnson";
            int valueMotor = 10000;
            int riderAge = 20;
            DateTime startDateMotor = DateTime.ParseExact("2024-06-03", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime returnDateMotor = DateTime.ParseExact("2024-06-13", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime endDateMotor = DateTime.ParseExact("2024-06-13", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            IVehicle motor = new Motorcycle(brandMotor, modelMotor, riderAge, valueMotor, startDateMotor, endDateMotor, returnDateMotor);
            motor.PrintInvoice(customerMotor, motor);
            string brandVan = "Citroen";
            string modelVan = "Jumper";
            string customerVan = "John Markson";
            int valueVan = 20000;
            int drivingExperience = 8;
            DateTime startDateVan = DateTime.ParseExact("2024-06-03", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime returnDateVan = DateTime.ParseExact("2024-06-13", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime endDateVan = DateTime.ParseExact("2024-06-18", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            IVehicle van = new CargoVan(brandVan, modelVan, drivingExperience, valueVan, startDateVan, endDateVan, returnDateVan);
            van.PrintInvoice(customerVan,van);
        }
    }
}
