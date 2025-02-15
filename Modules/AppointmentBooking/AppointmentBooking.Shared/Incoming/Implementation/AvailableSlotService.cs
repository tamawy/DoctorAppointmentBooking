using AppointmentBooking.Shared.Dto;
using AppointmentBooking.Shared.Incoming.Interfaces;
using DoctorAvailability.Shared.Interfaces;
using MapsterMapper;

namespace AppointmentBooking.Shared.Incoming.Implementation
{
    public class AvailableSlotService(ITimeSlotQuery timeSlotQuery, IMapper mapper) : IAvailableSlots
    {
        public async Task<IEnumerable<TimeSlotDto?>> GetAvailableSlotsAsync()
        {
            var availableSlots = timeSlotQuery.GetAvailableTimeSlot();
            var availableSlotsDto = mapper.From(availableSlots).AdaptToType<IEnumerable<TimeSlotDto>>();
            return availableSlotsDto;
        }
    }
}
