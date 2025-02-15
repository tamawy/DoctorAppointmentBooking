using DoctorAvailability.Internal.DAL;
using DoctorAvailability.Shared.Interfaces;
using DoctorAvailability.Shared.Models;
using MapsterMapper;

namespace DoctorAvailability.Internal.Handlers.Queries
{
    internal class TimeSlotQueryHandler(TimeSlotsDAL timeSlotDal, IMapper mapper) : ITimeSlotQuery
    {
        public IEnumerable<TimeSlotResponse> GetAllTimeSlots()
        {
            var timeSlots = timeSlotDal.GetTimeSlots();
            var timeSlotResponse = mapper.From(timeSlots).AdaptToType<List<TimeSlotDto>>();
            return timeSlotResponse
                .Select(TimeSlotResponse.FromTimeSlot);
        }

        public IEnumerable<TimeSlotResponse> GetAvailableTimeSlot()
        {
            var timeSlots = timeSlotDal.GetTimeSlots();
            var timeSlotResponse = mapper.From(timeSlots).AdaptToType<List<TimeSlotDto>>();
            return timeSlotResponse
                .Where(ts => !ts.IsReserved)
                .Select(TimeSlotResponse.FromTimeSlot);
        }
    }
}
