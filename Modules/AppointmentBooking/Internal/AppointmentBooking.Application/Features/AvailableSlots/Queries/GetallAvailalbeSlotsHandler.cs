﻿using AppointmentBooking.Shared.Dto;
using AppointmentBooking.Shared.OutGoing;
using MediatR;

namespace AppointmentBooking.Application.Features.AvailableSlots.Queries
{
    public class GetAllAvailableSlotsQuery : IRequest<IEnumerable<TimeSlotDto?>>
    {
    }
    public class GetAllAvailableSlotsHandler(IDoctorAvailabilityService doctorAvailability) : IRequestHandler<GetAllAvailableSlotsQuery, IEnumerable<TimeSlotDto?>>
    {
        public async Task<IEnumerable<TimeSlotDto?>> Handle(GetAllAvailableSlotsQuery request, CancellationToken cancellationToken)
        {
            var availableSlots = await doctorAvailability.GetAllAvailableSlots();
            return availableSlots;
        }
    }
}