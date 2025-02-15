using AppointmentBooking.Application.Interfaces.Services;
using AppointmentBooking.Infrastructure.Persistence;

namespace AppointmentBooking.Infrastructure.Repositories
{
    public class AppointmentRepository(AppDbContext context) : IAppointmentRepository
    {
        public async Task<Guid?> BookAppointmentAsync(Guid slotId, Guid patientId, string patientName)
        {
            if (IsSlotReserved(slotId)) return null;
            var reservedAppointment = new Appointment
            {
                Id = Guid.NewGuid(),
                PatientId = patientId,
                PatientName = patientName,
                SlotId = slotId,
            };
            context.Appointments.Add(reservedAppointment);
            await context.SaveChangesAsync();
            return reservedAppointment.Id;
        }

        private bool IsSlotReserved(Guid slotId)
            => context.Appointments.Any(s => s.SlotId == slotId);

    }
}
