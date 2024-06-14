using RentalSystem.Contracts;

namespace RentalSystem.Models
{
    internal class Car : Vehicle, ICar
    {
        public Car(string brand, 
            string model,
            int safetyRating,
            decimal value,
            DateTime startDate,
            DateTime endDate,
            DateTime returnDate)
        {
            Brand = brand;
            Model = model;
            SafetyRating = safetyRating;
            Value = value;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = returnDate;
            RentalPeriod = (EndDate - StartDate).Days;
        }
        public int SafetyRating { get; set; }
        public override decimal CalculateInitialInsurance()
        {
            return Value * (0.01m / 100);
        }

        public override int CalculateDailyRentalPrice()
        {
            if (RentalPeriod <= 7)
            {
                return 20;
            }
            return 15;
        }
        public override decimal CalculateInsuranceAfterCalculation()
        {
            decimal result = CalculateInitialInsurance();
            if (SafetyRating >= 4 && SafetyRating <= 5)
            {
                result -= (result * 0.10m);
            }
            return result;
        }
    }
}
