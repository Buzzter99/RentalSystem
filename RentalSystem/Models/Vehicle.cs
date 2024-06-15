using RentalSystem.Contracts;

namespace RentalSystem.Models
{
    public abstract class Vehicle : IVehicle
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public int RentalPeriod { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public abstract decimal CalculateInsuranceAfterCalculation();
        public abstract decimal CalculateInitialInsurance();
        public abstract int CalculateDailyRentalPrice();
        public int CalculateRentalDays() => RentalPeriod - (EndDate - ReturnDate).Days;
        public decimal CalculateTotalRent()
        {
            if (ReturnDate >= StartDate && ReturnDate < EndDate)
            {
                int fullDays = CalculateRentalDays();
                int halfPriceDays = (EndDate - ReturnDate).Days;
                decimal rentalCost = fullDays * CalculateDailyRentalPrice() + halfPriceDays * (CalculateDailyRentalPrice() / 2.0m);
                return rentalCost;
            }
            return CalculateTotalRentWithoutDiscount();
        }

        public decimal CalculateTotalRentWithoutDiscount()
        {
            return CalculateDailyRentalPrice() * RentalPeriod;
        }

        public decimal CalculateTotalInsuranceWithoutDiscount()
        {
            return CalculateInsuranceAfterCalculation() * RentalPeriod;
        }

        public decimal CalculateTotalInsurance()
        {
            if (ReturnDate >= StartDate && ReturnDate < EndDate)
            {
                int fullDays = CalculateRentalDays();
                decimal insuranceCost = fullDays * CalculateInsuranceAfterCalculation();
                return insuranceCost;
            }
            return CalculateTotalInsuranceWithoutDiscount();
        }

        public void PrintInvoice(string customer, IVehicle vehicle)
        {
            Console.WriteLine(new string('X',10));
            Console.WriteLine("Date: " + vehicle.EndDate);
            Console.WriteLine($"Customer Name: {customer}");
            Console.WriteLine($"Rented Vehicle: {vehicle.Brand} {vehicle.Model}");
            Console.WriteLine();
            Console.WriteLine($"Reservation start date: {vehicle.StartDate:yy-MM-dd}");
            Console.WriteLine($"Reservation end date: {vehicle.EndDate:yy-MM-dd}");
            Console.WriteLine($"Reserved rental days: {(vehicle.EndDate - vehicle.StartDate).Days} days");
            Console.WriteLine();
            Console.WriteLine($"Actual Return date: {vehicle.ReturnDate:yy-MM-dd}");
            Console.WriteLine($"Actual rental days: {vehicle.CalculateRentalDays()}");
            Console.WriteLine();
            Console.WriteLine($"Rental cost per day: ${vehicle.CalculateDailyRentalPrice():f2}");
            if (vehicle.CalculateInitialInsurance() != vehicle.CalculateInsuranceAfterCalculation())
            {
                string operation = vehicle.GetType().Name == nameof(Motorcycle) ? "addition" : "discount";
                Console.WriteLine($"Initial insurance per day: {vehicle.CalculateInitialInsurance():f2}");
                Console.WriteLine($"Insurance {operation} per day: {Math.Abs(vehicle.CalculateInsuranceAfterCalculation() - vehicle.CalculateInitialInsurance()):f2}");
            }
            Console.WriteLine($"Insurance per day: ${vehicle.CalculateInsuranceAfterCalculation():f2}");
            Console.WriteLine();
            if (vehicle.CalculateTotalRentWithoutDiscount() - vehicle.CalculateTotalRent() != 0)
            {
                Console.WriteLine($"Early return discount for rent: ${(vehicle.CalculateTotalRentWithoutDiscount() - vehicle.CalculateTotalRent()):f2}");
            }
            if (vehicle.CalculateTotalInsuranceWithoutDiscount() - vehicle.CalculateTotalInsurance() != 0)
            {
                Console.WriteLine($"Early return discount for insurance: ${(vehicle.CalculateTotalInsuranceWithoutDiscount() - vehicle.CalculateTotalInsurance()):f2}");
                Console.WriteLine();
            }
            Console.WriteLine($"Total rent: ${vehicle.CalculateTotalRent():f2}");
            Console.WriteLine($"Total insurance: ${vehicle.CalculateTotalInsurance():f2}");
            Console.WriteLine($"Total: ${vehicle.CalculateCost():f2}");
            Console.WriteLine(new string('X', 10));
            Console.WriteLine();
        }

        public decimal CalculateCost()
        {
            return CalculateTotalInsurance() + CalculateTotalRent();
        }
        
    }
}
