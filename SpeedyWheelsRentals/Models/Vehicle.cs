namespace SpeedyWheelsRentals.Models
{
    public class Vehicle
    {
        public Guid VehicleId { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? RegistrationNumber { get; set; }
        public VehicleStatus Status { get; set; }

        // Navigation property for reservations
        public virtual ICollection<Reservation>? Reservations { get; set; }
    }

    public enum VehicleStatus
    {
        Available,
        Rented
    }

}
