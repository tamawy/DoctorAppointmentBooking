using AppointmentBooking.Application.Dto;

namespace AppointmentBooking.Shared.Incoming.Interfaces
{
    public interface IAvailableSlotsService
    {
        public Task<IEnumerable<TimeSlotDto?>> GetAvailableSlotsAsync();
    }
}
