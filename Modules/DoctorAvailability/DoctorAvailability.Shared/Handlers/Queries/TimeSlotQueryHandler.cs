using DoctorAvailability.Internal.DAL;
using DoctorAvailability.Shared.Interfaces;
using DoctorAvailability.Shared.Models;

namespace DoctorAvailability.Shared.Handlers.Queries
{
    internal class TimeSlotQueryHandler : ITimeSlotQuery
    {
        private readonly TimeSlotsDAL timeSlotDAL;

        public TimeSlotQueryHandler(TimeSlotsDAL timeSlotDAL)
        {
            this.timeSlotDAL = timeSlotDAL;
        }
        public IEnumerable<TimeSlotResponse> GetAllTimeSlots()
        {
            return timeSlotDAL
                .GetTimeSlots()
                .Select(TimeSlotResponse.FromTimeSlot);
        }
    }
}
