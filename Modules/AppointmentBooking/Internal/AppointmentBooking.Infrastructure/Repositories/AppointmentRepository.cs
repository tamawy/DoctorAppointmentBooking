using AppointmentBooking.Application.Interfaces.Services;
using AppointmentBooking.Infrastructure.Persistence;

namespace AppointmentBooking.Infrastructure.Repositories
{
    public class AppointmentRepository(AppDbContext context) : IAppointmentRepository
    {
        public async Task<Appointment?> BookAppointmentAsync(Guid slotId, Guid patientId, string patientName, string doctorName)
        {
            if (IsSlotReserved(slotId)) return null;
            var reservedAppointment = Appointment.Book(slotId, patientId, patientName, doctorName, DateTime.Now);
            // Event has been raised
            context.Appointments.Add(reservedAppointment);
            await context.SaveChangesAsync();
            return reservedAppointment;
        }

        private bool IsSlotReserved(Guid slotId)
            => context.Appointments.Any(s => s.SlotId == slotId);

    }
}
