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
            if (car.CalculateInitialInsurance() != car.CalculateInsuranceAfterCalculation())
            {
                Console.WriteLine($"Initial insurance per day: {car.CalculateInitialInsurance():f2}");
                Console.WriteLine($"Insurance discount per day: {(car.CalculateInsuranceAfterCalculation() - car.CalculateInitialInsurance()):f2}");
            }
            Console.WriteLine($"Insurance per day: ${car.CalculateInsuranceAfterCalculation():f2}");
            Console.WriteLine();
            Console.WriteLine($"Total rent: ${car.CalculateTotalRent():f2}");
            Console.WriteLine($"Total insurance: ${car.CalculateTotalInsurance():f2}");
            Console.WriteLine($"Total: ${car.CalculateCost():f2}");
            Console.WriteLine(symbol);
            //motorcycle

            string brandMotor = "Triumph";
            string modelMotor = "Tiger Sport 660";
            string customerMotor = "Mary Johnson";
            int valueMotor = 10000;
            int riderAge = 20;
            DateTime startDateMotor = DateTime.ParseExact("03-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime returnDateMotor = DateTime.ParseExact("13-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDateMotor = DateTime.ParseExact("13-06-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            IVehicle motor = new Motorcycle(brandMotor, modelMotor, riderAge, valueMotor, startDateMotor, endDateMotor, returnDateMotor);
            Console.WriteLine(symbol);
            Console.WriteLine("Date: " + motor.EndDate);
            Console.WriteLine($"Customer Name: {customerMotor}");
            Console.WriteLine($"Rented Vehicle: {motor.Brand} {motor.Model}");
            Console.WriteLine();
            Console.WriteLine($"Reservation start date: {motor.StartDate}");
            Console.WriteLine($"Reservation end date: {motor.EndDate}");
            Console.WriteLine($"Reserved rental days: {(motor.EndDate - motor.StartDate).Days} days");
            Console.WriteLine();
            Console.WriteLine($"Actual Return date: {motor.ReturnDate}");
            Console.WriteLine($"Actual rental days: {motor.CalculateRentalDays()}");
            Console.WriteLine();
            Console.WriteLine($"Rental cost per day: ${motor.CalculateDailyRentalPrice():f2}");
            if (motor.CalculateInitialInsurance() != motor.CalculateInsuranceAfterCalculation())
            {
                Console.WriteLine($"Initial insurance per day: ${motor.CalculateInitialInsurance():f2}");
                Console.WriteLine($"Insurance discount per day: ${(motor.CalculateInsuranceAfterCalculation() - motor.CalculateInitialInsurance()):f2}");
            }
            Console.WriteLine($"Insurance per day: ${motor.CalculateInsuranceAfterCalculation():f2}");
            Console.WriteLine();
            Console.WriteLine($"Total rent: ${motor.CalculateTotalRent():f2}");
            Console.WriteLine($"Total insurance: ${motor.CalculateTotalInsurance():f2}");
            Console.WriteLine($"Total: ${motor.CalculateCost():f2}");
            Console.WriteLine(symbol);

        }
    }
}
