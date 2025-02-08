using DoctorAvailability.Internal.DAL;
using DoctorAvailability.Internal.Models;
using DoctorAvailability.Shared.Interfaces;
using DoctorAvailability.Shared.Models;

namespace DoctorAvailability.Shared.Handlers.Commands
{
    internal class TimeSlotCommandHandler : ITimeSlotCommand
    {
        private readonly TimeSlotsDAL timeSlotDAL;
        private readonly DoctorsDAL doctorsDAL;

        public TimeSlotCommandHandler(TimeSlotsDAL timeSlotDAL, DoctorsDAL doctorsDAL)
        {
            this.timeSlotDAL = timeSlotDAL;
            this.doctorsDAL = doctorsDAL;
        }

        public void AddTimeSlot(TimeSlotRequest timeSlot)
        {
            timeSlotDAL.AddTimeSlot(new TimeSlot()
            {
                Id = Guid.NewGuid(),
                DoctorId = doctorsDAL.GetCurrentDoctorId(),
                Time = timeSlot.Time,
                IsReserved = false,
                Cost = timeSlot.Cost
            });
        }
    }
}
