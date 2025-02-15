using AppointmentBooking.Application.Features.AvailableSlots.Queries;
using AppointmentBooking.Shared.Dto;
using AppointmentBooking.Shared.Incoming.Interfaces;

namespace AppointmentBooking.Application.Implementation
{
    internal class AvailableSlotService(GetAllAvailableSlotsHandler availableSlotHandler) : IAvailableSlotsService
    {
        public async Task<IEnumerable<TimeSlotDto?>> GetAvailableSlotsAsync()
        {
            return await availableSlotHandler.Handle(new GetAllAvailableSlotsQuery(), CancellationToken.None);
        }
    }
}
