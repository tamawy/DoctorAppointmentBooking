using AppointmentBooking.Shared.Dto;

namespace AppointmentBooking.Shared.OutGoing
{
    public interface IDoctorAvailabilityService
    {
        Task<IEnumerable<TimeSlotDto>> GetAllAvailableSlots();
    }
}