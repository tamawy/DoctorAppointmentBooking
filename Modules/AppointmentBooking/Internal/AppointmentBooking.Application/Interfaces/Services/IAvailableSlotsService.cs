using AppointmentBooking.Application.Dto;

namespace AppointmentBooking.Application.Interfaces.Services
{
    public interface IAvailableSlotsService
    {
        Task<IEnumerable<TimeSlotDto?>> GetAvailableSlotsAsync();
    }
}
