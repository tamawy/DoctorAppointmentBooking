using AppointmentBooking.Application.Dto;

namespace AppointmentBooking.Shared.Incoming.Interfaces
{
    internal interface IAvailableSlotsService
    {
        public Task<IEnumerable<TimeSlotDto?>> GetAvailableSlotsAsync();
    }
}
