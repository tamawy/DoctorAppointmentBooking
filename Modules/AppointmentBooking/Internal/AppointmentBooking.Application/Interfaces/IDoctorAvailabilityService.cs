using AppointmentBooking.Application.Dto;

namespace AppointmentBooking.Application.Interfaces
{
    public interface IDoctorAvailabilityService
    {
        Task<IEnumerable<TimeSlotDto>> GetAllAvailableSlots();
    }
}
