using AppointmentBooking.Shared.Dto;

namespace AppointmentBooking.Shared.Incoming.Interfaces
{
    public interface IAvailableSlots
    {
        public Task<IEnumerable<TimeSlotDto?>> GetAvailableSlotsAsync();
    }
}
