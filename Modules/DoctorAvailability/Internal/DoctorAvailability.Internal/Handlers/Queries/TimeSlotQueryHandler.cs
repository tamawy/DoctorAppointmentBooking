using DoctorAvailability.Internal.DAL;
using DoctorAvailability.Shared.Interfaces;
using DoctorAvailability.Shared.Models;
using MapsterMapper;

namespace DoctorAvailability.Internal.Handlers.Queries
{
    internal class TimeSlotQueryHandler(TimeSlotsDAL timeSlotDal, IMapper mapper) : ITimeSlotQuery
    {
        public IEnumerable<TimeSlotDTO> GetAllTimeSlots()
        {
            var timeSlots = timeSlotDal.GetTimeSlots();
            var timeSlotDto = mapper.From(timeSlots).AdaptToType<IEnumerable<TimeSlotDTO>>();
            return timeSlotDto;
        }

        public IEnumerable<TimeSlotDTO> GetAvailableTimeSlot()
        {
            var timeSlots = timeSlotDal.GetTimeSlots();
            var timeSlotDto = mapper.From(timeSlots).AdaptToType<IEnumerable<TimeSlotDTO>>();
            return timeSlotDto
                .Where(ts => !ts.IsReserved);
        }
    }
}
