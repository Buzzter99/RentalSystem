using RentalSystem.Contracts;

namespace RentalSystem.Models
{
    public abstract class Vehicle : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
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
                int halfPriceDays = (ReturnDate - StartDate).Days;
                decimal rentalCost = fullDays * CalculateDailyRentalPrice() + halfPriceDays * (CalculateDailyRentalPrice() / 2.0m);
                return rentalCost;
            }
            return CalculateDailyRentalPrice() * RentalPeriod;
        }
        public decimal CalculateTotalInsurance()
        {
            if (ReturnDate >= StartDate && ReturnDate < EndDate)
            {
                int fullDays = CalculateRentalDays();
                decimal insuranceCost = fullDays * CalculateInsuranceAfterCalculation();
                return insuranceCost;
            }
            return CalculateInsuranceAfterCalculation() * RentalPeriod;
        }
        public decimal CalculateCost()
        {
            return CalculateTotalInsurance() + CalculateTotalRent();
        }
        
    }
}
