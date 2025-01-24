using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorAvailability.Internal.Models
{
    public class TimeSlot
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        [ForeignKey("Course")]
        public Guid DoctorId { get; set; }
        public bool IsReserved { get; set; }
        public decimal Cost { get; set; }
        public Doctor Doctor { get; set; } // Navigation property
    }
}
