using RentalSystem.Contracts;

namespace RentalSystem.Models
{
    internal class CargoVan : Vehicle,ICargoVan
    {
        public CargoVan(string brand,
            string model,
            int drivingExperience,
            decimal value,
            DateTime startDate,
            DateTime endDate,
            DateTime returnDate)
        {
            Brand = brand;
            Model = model;
            DrivingExperience = drivingExperience;
            Value = value;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = returnDate;
            RentalPeriod = (EndDate - StartDate).Days;
        }
        public int DrivingExperience { get; set; }

        public override decimal CalculateInitialInsurance()
        {
            return Value * (0.03m / 100);
        }

        public override int CalculateDailyRentalPrice()
        {
            if (RentalPeriod <= 7)
            {
                return 50;
            }
            return 40;
        }
        public override decimal CalculateInsuranceAfterCalculation()
        {
            decimal result = CalculateInitialInsurance();
            if (DrivingExperience > 5)
            {
                result -= (result * 0.15m);
            }
            return result;
        }
    }
}
