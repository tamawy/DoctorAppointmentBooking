using DoctorAvailability.Internal.DAL;
using DoctorAvailability.Shared.Interfaces;
using DoctorAvailability.Shared.Models;

namespace DoctorAvailability.Shared.Handlers.Queries
{
    internal class TimeSlotQueryHandler : ITimeSlotQuery
    {
        public IEnumerable<TimeSlotResponse> GetAllTimeSlots()
        {
            return timeSlotDal
                .GetTimeSlots()
                .Select(TimeSlotResponse.FromTimeSlot);
        }

        public IEnumerable<TimeSlotResponse> GetAvailableTimeSlot()
        {
            return timeSlotDal.GetTimeSlots()
                .Where(s => !s.IsReserved)
                .Select(TimeSlotResponse.FromTimeSlot);
        }
    }
}
