using DoctorAvailability.Internal.Models;
using DoctorAvailability.Shared.Models;
using Mapster;

namespace DoctorAvailability.Internal.Mappers
{
    public static class MapsterConfig
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<TimeSlot, TimeSlotDto>.NewConfig();
            TypeAdapterConfig<TimeSlotDto, TimeSlot>.NewConfig();
        }
    }
}
