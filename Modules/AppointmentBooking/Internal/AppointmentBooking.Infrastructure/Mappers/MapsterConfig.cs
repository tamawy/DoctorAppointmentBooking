using AppointmentBooking.Application.Dto;
using DoctorAvailability.Shared.Models;
using Mapster;

namespace AppointmentBooking.Infrastructure.Mappers
{
    internal class MapsterConfig
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<TimeSlotDTO, TimeSlotDto>.NewConfig();
        }
    }
}
