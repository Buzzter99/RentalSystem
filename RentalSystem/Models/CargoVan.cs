using RentalSystem.Contracts;

namespace RentalSystem.Models
{
    internal class CargoVan : ICargoVan, IVehicle
    {
        public int DrivingExperience { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Value { get; set; }
        public int RentalPeriod { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal CalculateCost()
        {
            throw new NotImplementedException();
        }

        public int CalculateDailyRentalPrice()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateInsurance()
        {
            throw new NotImplementedException();
        }

        public int CalculateRentalDays()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateTotalRent()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateTotalInsurance()
        {
            throw new NotImplementedException();
        }
    }
}
