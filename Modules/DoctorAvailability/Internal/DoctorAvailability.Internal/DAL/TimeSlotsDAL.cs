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

        public async Task MarkSlotAsReserved(Guid? slotId)
        {
            var slot = await context.TimeSlots.FindAsync(slotId);
            if (slot != null)
            {
                slot.IsReserved = true;
                context.TimeSlots.Update(slot);
                await context.SaveChangesAsync();
            }
        }
    }
}
