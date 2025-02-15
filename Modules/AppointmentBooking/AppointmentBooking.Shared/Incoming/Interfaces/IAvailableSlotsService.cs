
using AppointmentBooking.Shared.Dto;

namespace AppointmentBooking.Shared.Incoming.Interfaces
{
    public interface IAvailableSlotsService
    {
        public Task<IEnumerable<TimeSlotDto?>> GetAvailableSlotsAsync();
    }
}
