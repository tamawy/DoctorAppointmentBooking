﻿using AppointmentBooking.Application.Dto;
using AppointmentBooking.Application.Interfaces;
using MediatR;

namespace AppointmentBooking.Application.Features.AvailableSlots.Queries
{
    public class GetAllAvailableSlotsQuery : IRequest<IEnumerable<TimeSlotDto?>>
    {
    }
    internal class GetAllAvailableSlotsHandler(IDoctorAvailabilityService doctorAvailability) : IRequestHandler<GetAllAvailableSlotsQuery, IEnumerable<TimeSlotDto?>>
    {
        public async Task<IEnumerable<TimeSlotDto?>> Handle(GetAllAvailableSlotsQuery request, CancellationToken cancellationToken)
        {
            var availableSlots = await doctorAvailability.GetAllAvailableSlots();
            return availableSlots;
        }
    }
}