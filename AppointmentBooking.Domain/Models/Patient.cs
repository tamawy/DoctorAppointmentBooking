namespace AppointmentBooking.Domain.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
