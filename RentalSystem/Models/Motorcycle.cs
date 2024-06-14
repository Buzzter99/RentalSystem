using RentalSystem.Contracts;

namespace RentalSystem.Models
{
    public class Motorcycle : Vehicle, IMotorcycle
    {
        public Motorcycle(string brand, 
            string model, 
            int riderAge, 
            decimal value, 
            DateTime startDate, 
            DateTime endDate, 
            DateTime returnDate)
        {
            Brand = brand;
            Model = model;
            RiderAge = riderAge;
            Value = value;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = returnDate;
            RentalPeriod = (EndDate - StartDate).Days;
        }
        public int RiderAge { get; set; }
        public override decimal CalculateInitialInsurance()
        {
            return Value * (0.02m / 100);
        }

        public override int CalculateDailyRentalPrice()
        {
            if (RentalPeriod <= 7)
            {
                return 15;
            }
            return 10;
        }

        public override decimal CalculateInsuranceAfterCalculation()
        {
            decimal result = CalculateInitialInsurance();
            if (RiderAge < 25)
            {
                result += (result * 0.20m);
            }
            return result;
        }
    }
}
