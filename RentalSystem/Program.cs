using RentalSystem.Contracts;
using RentalSystem.Models;
using System.Globalization;

namespace RentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //car
             string symbol = new string('X',10);
            // string brand = "Mitsubishi";
            // string model = "Mirage";
            // string customer = "John Doe";
            // int value = 15000;
            // int securityRating = 3;
            // DateTime startDate = DateTime.ParseExact("03-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            // DateTime returnDate = DateTime.ParseExact("13-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            // DateTime endDate = DateTime.ParseExact("13-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            // IVehicle car = new Car(brand, model, securityRating, value,startDate,endDate,returnDate);
            // Console.WriteLine(symbol);
            // Console.WriteLine("Date: " + car.EndDate);
            // Console.WriteLine($"Customer Name: {customer}");
            // Console.WriteLine($"Rented Vehicle: {car.Brand} {car.Model}");
            // Console.WriteLine();
            // Console.WriteLine($"Reservation start date: {car.StartDate}");
            // Console.WriteLine($"Reservation end date: {car.EndDate}");
            // Console.WriteLine($"Reserved rental days: {(car.EndDate - car.StartDate).Days} days");
            // Console.WriteLine();
            // Console.WriteLine($"Actual Return date: {car.ReturnDate}");
            // Console.WriteLine($"Actual rental days: {car.CalculateRentalDays()}");
            // Console.WriteLine();
            // Console.WriteLine($"Rental cost per day: ${car.CalculateDailyRentalPrice():f2}");
            // if (car.CalculateInitialInsurance() != car.CalculateInsuranceAfterCalculation())
            // {
            //     Console.WriteLine($"Initial insurance per day: {car.CalculateInitialInsurance():f2}");
            //     Console.WriteLine($"Insurance discount per day: {Math.Abs(car.CalculateInsuranceAfterCalculation() - car.CalculateInitialInsurance()):f2}");
            // }
            // Console.WriteLine($"Insurance per day: ${car.CalculateInsuranceAfterCalculation():f2}");
            // Console.WriteLine();
            // Console.WriteLine($"Total rent: ${car.CalculateTotalRent():f2}");
            // Console.WriteLine($"Total insurance: ${car.CalculateTotalInsurance():f2}");
            // Console.WriteLine($"Total: ${car.CalculateCost():f2}");
            // Console.WriteLine(symbol);
            //motorcycle

            // string brandMotor = "Triumph";
            // string modelMotor = "Tiger Sport 660";
            // string customerMotor = "Mary Johnson";
            // int valueMotor = 10000;
            // int riderAge = 20;
            // DateTime startDateMotor = DateTime.ParseExact("03-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            // DateTime returnDateMotor = DateTime.ParseExact("13-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            // DateTime endDateMotor = DateTime.ParseExact("13-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            // IVehicle motor = new Motorcycle(brandMotor, modelMotor, riderAge, valueMotor, startDateMotor, endDateMotor, returnDateMotor);
            // Console.WriteLine(symbol);
            // Console.WriteLine("Date: " + motor.EndDate);
            // Console.WriteLine($"Customer Name: {customerMotor}");
            // Console.WriteLine($"Rented Vehicle: {motor.Brand} {motor.Model}");
            // Console.WriteLine();
            // Console.WriteLine($"Reservation start date: {motor.StartDate}");
            // Console.WriteLine($"Reservation end date: {motor.EndDate}");
            // Console.WriteLine($"Reserved rental days: {(motor.EndDate - motor.StartDate).Days} days");
            // Console.WriteLine();
            // Console.WriteLine($"Actual Return date: {motor.ReturnDate}");
            // Console.WriteLine($"Actual rental days: {motor.CalculateRentalDays()}");
            // Console.WriteLine();
            // Console.WriteLine($"Rental cost per day: ${motor.CalculateDailyRentalPrice():f2}");
            // if (motor.CalculateInitialInsurance() != motor.CalculateInsuranceAfterCalculation())
            // {
            //     Console.WriteLine($"Initial insurance per day: ${motor.CalculateInitialInsurance():f2}");
            //     Console.WriteLine($"Insurance discount per day: ${Math.Abs(motor.CalculateInsuranceAfterCalculation() - motor.CalculateInitialInsurance()):f2}");
            // }
            // Console.WriteLine($"Insurance per day: ${motor.CalculateInsuranceAfterCalculation():f2}");
            // Console.WriteLine();
            // Console.WriteLine($"Total rent: ${motor.CalculateTotalRent():f2}");
            // Console.WriteLine($"Total insurance: ${motor.CalculateTotalInsurance():f2}");
            // Console.WriteLine($"Total: ${motor.CalculateCost():f2}");
            // Console.WriteLine(symbol);

            //van
            string brandVan = "Citroen";
            string modelVan = "Jumper";
            string customerVan = "John Markson";
            int valueVan = 20000;
            int drivingExperience = 8;
            DateTime startDateVan = DateTime.ParseExact("03-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime returnDateVan = DateTime.ParseExact("13-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDateVan = DateTime.ParseExact("18-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            IVehicle van = new CargoVan(brandVan, modelVan, drivingExperience, valueVan, startDateVan, endDateVan, returnDateVan);
            Console.WriteLine(symbol);
            Console.WriteLine("Date: " + van.EndDate);
            Console.WriteLine($"Customer Name: {customerVan}");
            Console.WriteLine($"Rented Vehicle: {van.Brand} {van.Model}");
            Console.WriteLine();
            Console.WriteLine($"Reservation start date: {van.StartDate}");
            Console.WriteLine($"Reservation end date: {van.EndDate}");
            Console.WriteLine($"Reserved rental days: {(van.EndDate - van.StartDate).Days} days");
            Console.WriteLine();
            Console.WriteLine($"Actual Return date: {van.ReturnDate}");
            Console.WriteLine($"Actual rental days: {van.CalculateRentalDays()}");
            Console.WriteLine();
            Console.WriteLine($"Rental cost per day: ${van.CalculateDailyRentalPrice():f2}");
            if (van.CalculateInitialInsurance() != van.CalculateInsuranceAfterCalculation())
            {
                Console.WriteLine($"Initial insurance per day: ${van.CalculateInitialInsurance():f2}");
                Console.WriteLine($"Insurance discount per day: ${Math.Abs(van.CalculateInsuranceAfterCalculation() - van.CalculateInitialInsurance()):f2}");
            }
            Console.WriteLine($"Insurance per day: ${van.CalculateInsuranceAfterCalculation():f2}");
            Console.WriteLine();
            if (van.CalculateTotalRentWithoutDiscount() - van.CalculateTotalRent() != 0)
            {
                Console.WriteLine($"Early return discount for rent: ${(van.CalculateTotalRentWithoutDiscount() - van.CalculateTotalRent()):f2}");
            }
            if (van.CalculateTotalInsuranceWithoutDiscount() - van.CalculateTotalInsurance() != 0)
            {
                Console.WriteLine($"Early return discount for insurance: ${(van.CalculateTotalInsuranceWithoutDiscount() - van.CalculateTotalInsurance()):f2}");
                Console.WriteLine();
            }
            Console.WriteLine($"Total rent: ${van.CalculateTotalRent():f2}");
            Console.WriteLine($"Total insurance: ${van.CalculateTotalInsurance():f2}");
            Console.WriteLine($"Total: ${van.CalculateCost():f2}");
            Console.WriteLine(symbol);
        }
    }
}
