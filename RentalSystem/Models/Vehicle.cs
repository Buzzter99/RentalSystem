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
        public decimal CalculateCost()
        {
            return CalculateTotalInsurance() + CalculateTotalRent();
        }
        
    }
}
