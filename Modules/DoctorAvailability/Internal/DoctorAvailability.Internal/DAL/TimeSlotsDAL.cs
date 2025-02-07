using DoctorAvailability.Internal.EF;
using DoctorAvailability.Internal.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Internal.DAL
{
    public class TimeSlotsDAL(ApplicationDbContext context)
    {
        public List<TimeSlot> GetTimeSlots()
        {
            return [.. context.TimeSlots.Include(s => s.Doctor)];
        }
        public void AddTimeSlot(TimeSlot timeSlot)
        {
            context.TimeSlots.Add(timeSlot);
            context.SaveChanges();
        }

        // public void GetAvailableTimeSlot()
    }
}
