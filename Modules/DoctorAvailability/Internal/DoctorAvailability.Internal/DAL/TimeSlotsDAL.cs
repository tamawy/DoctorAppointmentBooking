using DoctorAvailability.Internal.EF;
using DoctorAvailability.Internal.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Internal.DAL
{
    public class TimeSlotsDAL
    {
        private ApplicationDbContext _context;

        public TimeSlotsDAL(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<TimeSlot> GetTimeSlots()
        {
            return [.. _context.TimeSlots.Include(s => s.Doctor)];
        }
        public void AddTimeSlot(TimeSlot timeSlot)
        {
            _context.TimeSlots.Add(timeSlot);
            _context.SaveChanges();
        }
    }
}
