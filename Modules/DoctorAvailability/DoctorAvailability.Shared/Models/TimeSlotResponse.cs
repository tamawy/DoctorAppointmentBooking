using DoctorAvailability.Internal.Models;

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
        public static TimeSlotResponse FromTimeSlot(TimeSlot timeSlot)
        {
            return new TimeSlotResponse
            {
                Id = timeSlot.Id,
                Time = timeSlot.Time,
                DoctorId = timeSlot.DoctorId,
                Name = timeSlot.Doctor.Name,
                Cost = timeSlot.Cost,
                IsReserved = timeSlot.IsReserved
            };
        }
    }
}
