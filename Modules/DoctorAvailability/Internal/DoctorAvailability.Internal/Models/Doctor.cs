namespace DoctorAvailability.Internal.Models
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        ICollection<TimeSlot> TimeSlots { get; set; } = new HashSet<TimeSlot>();
    }
}
