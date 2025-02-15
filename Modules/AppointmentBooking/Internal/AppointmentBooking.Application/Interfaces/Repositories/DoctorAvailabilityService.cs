//namespace AppointmentBooking.Application.Interfaces.Repositories
//{
//    public class DoctorAvailabilityService(ITimeSlotQuery slotQuery) : IDoctorAvailabilityService
//    {
//        public Task<IEnumerable<TimeSlotDto>> GetAllAvailableSlots()
//        {
//            var availableSlots = slotQuery.GetAvailableTimeSlot();
//            // TODO: This should be mapped using AutoMapper or any mapping library
//            return Task.FromResult(availableSlots.Select(slot => new TimeSlotDto
//            {
//                Id = slot.Id,
//                Cost = slot.Cost,
//                DoctorId = slot.DoctorId,
//                DoctorName = slot.Name,
//                IsReserved = slot.IsReserved,
//                Time = slot.Time
//            }));
//        }
//    }
//}
