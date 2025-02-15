using AppointmentBooking.Application.Dto;
using AppointmentBooking.Application.Interfaces.Services;
using MediatR;

namespace AppointmentBooking.Application.Features.AvailableSlots.Queries
{
    public class GetAllAvailableSlotsQuery : IRequest<IEnumerable<TimeSlotDto?>>
    {
    }
    public class GetAllAvailableSlotsHandler(IAvailableSlotsService availableSlots) : IRequestHandler<GetAllAvailableSlotsQuery, IEnumerable<TimeSlotDto?>>
    {
        public async Task<IEnumerable<TimeSlotDto?>> Handle(GetAllAvailableSlotsQuery request, CancellationToken cancellationToken)
        {
            var available = await availableSlots.GetAvailableSlotsAsync();
            return available;
        }
    }
}