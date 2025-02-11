using AppointmentBooking.Application.Dto;

namespace AppointmentBooking.Application.Interfaces.Services
{
    public interface IDoctorAvailabilityService
    {
        Task<IEnumerable<TimeSlotDto>> GetAllAvailableSlots();
    }
}