using AppointmentBooking.Application.Dto;
using AppointmentBooking.Application.Interfaces.Services;
using AppointmentBooking.Shared.Incoming.Interfaces;
using MapsterMapper;

namespace AppointmentBooking.Infrastructure.Repositories
{
    public class AvailableTimeSlotsService(IAvailableSlots availableSlotsService, IMapper mapper) : IAvailableSlotsService
    {
        public async Task<IEnumerable<TimeSlotDto?>> GetAvailableSlotsAsync()
        {
            var availableSlots = await availableSlotsService.GetAvailableSlotsAsync();
            var result = mapper.From(availableSlots).AdaptToType<IEnumerable<TimeSlotDto>>();
            return result;
        }
    }
}
