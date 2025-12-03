namespace CarRentalManagemnet.Domain
{
    public class Vehicle: BaseDomainModel
    {
        public int Year { get; set; }
        public string? LicensePLateNumber { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int ColourId { get; set; }
    }
}
