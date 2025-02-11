using AppointmentBooking.Application.Dto;
using AppointmentBooking.Application.Features.AvailableSlots.Queries;
using AppointmentBooking.Shared.Incoming.Interfaces;

namespace AppointmentBooking.Shared.Incoming.Implementation
{
    internal class AvailableSlotService(GetAllAvailableSlotsHandler availableSlotHandler) : IAvailableSlotsService
    {
        public async Task<IEnumerable<TimeSlotDto?>> GetAvailableSlotsAsync()
        {
            return await availableSlotHandler.Handle(new GetAllAvailableSlotsQuery(), CancellationToken.None);
        }
    }
}
