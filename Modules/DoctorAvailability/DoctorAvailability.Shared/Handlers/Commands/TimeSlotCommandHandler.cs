//using DoctorAvailability.Internal.DAL;
//using DoctorAvailability.Internal.Models;
//using DoctorAvailability.Shared.Interfaces;
//using DoctorAvailability.Shared.Models;

//namespace DoctorAvailability.Shared.Handlers.Commands
//{
//    public class TimeSlotCommandHandler(TimeSlotsDAL timeSlotDal, DoctorsDal doctorsDal) : ITimeSlotCommand
//    {
//        public void AddTimeSlot(TimeSlotRequest timeSlot)
//        {
//            timeSlotDal.AddTimeSlot(new TimeSlot()
//            {
//                Id = Guid.NewGuid(),
//                DoctorId = doctorsDal.GetCurrentDoctorId(),
//                Time = timeSlot.Time,
//                IsReserved = false,
//                Cost = timeSlot.Cost
//            });
//        }

//        public async Task MarkSlotAsReserved(Guid? slotId)
//        {
//            await timeSlotDal.MarkSlotAsReserved(slotId);
//        }
//    }
//}
