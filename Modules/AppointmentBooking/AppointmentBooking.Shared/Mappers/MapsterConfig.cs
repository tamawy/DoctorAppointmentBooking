using AppointmentBooking.Shared.Dto;
using DoctorAvailability.Shared.Models;
using Mapster;

namespace AppointmentBooking.Shared.Mappers
{
    internal class MapsterConfig
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<TimeSlotDTO, TimeSlotDto>.NewConfig();
        }
    }
}
