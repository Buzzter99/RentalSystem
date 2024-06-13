namespace RentalSystem.Contracts
{
    public interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        decimal Value { get; set; }
        int RentalPeriod { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        DateTime ReturnDate { get; set; }
        decimal CalculateCost();
        int CalculateDailyRentalPrice();
        decimal CalculateInsurance();
        int CalculateRentalDays();
        decimal CalculateTotalRent();
        decimal CalculateTotalInsurance();
    }
}
