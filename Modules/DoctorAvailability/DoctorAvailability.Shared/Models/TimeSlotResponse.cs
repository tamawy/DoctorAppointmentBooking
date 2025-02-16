namespace DoctorAvailability.Shared.Models
{
    public class TimeSlotResponse
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public Guid DoctorId { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public bool IsReserved { get; set; }
        
    }
}
