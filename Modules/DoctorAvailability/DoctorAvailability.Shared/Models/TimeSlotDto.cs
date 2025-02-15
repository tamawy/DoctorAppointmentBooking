namespace DoctorAvailability.Shared.Models
{
    public class TimeSlotDto
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public Guid DoctorId { get; set; }
        public bool IsReserved { get; set; }
        public decimal Cost { get; set; }
        public DoctorDto Doctor { get; set; }
    }
}
