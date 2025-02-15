
using DoctorAvailability.Shared.Models;

namespace DoctorAvailability.Shared.Interfaces
{
    public interface ITimeSlotQuery
    {
        IEnumerable<TimeSlotDTO> GetAllTimeSlots();
        IEnumerable<TimeSlotDTO> GetAvailableTimeSlot();
    }
}
