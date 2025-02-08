using DoctorAvailability.Shared.Models;

namespace DoctorAvailability.Shared.Interfaces
{
    public interface ITimeSlotCommand
    {
        void AddTimeSlot(TimeSlotRequest timeSlots);
        Task MarkSlotAsReserved(Guid? slotId);
    }
}
