using DoctorAvailability.Internal.DAL;
using DoctorAvailability.Shared.Interfaces;
using DoctorAvailability.Shared.Models;

namespace DoctorAvailability.Shared.Handlers.Queries
{
    internal class TimeSlotQueryHandler : ITimeSlotQuery
    {
        private TimeSlotsDAL _timeSlotDal;

        public TimeSlotQueryHandler(TimeSlotsDAL timeSlotDal) => _timeSlotDal = timeSlotDal;
        public IEnumerable<TimeSlotResponse> GetAllTimeSlots()
        {
            return _timeSlotDal
                .GetTimeSlots()
                .Select(TimeSlotResponse.FromTimeSlot);
        }

        public IEnumerable<TimeSlotResponse> GetAvailableTimeSlot()
        {
            return _timeSlotDal.GetTimeSlots()
                .Where(s => !s.IsReserved)
                .Select(TimeSlotResponse.FromTimeSlot);
        }
    }
}
