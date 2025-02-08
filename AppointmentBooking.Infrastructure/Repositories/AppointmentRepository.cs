using AppointmentBooking.Application.Interfaces;
using AppointmentBooking.Infrastructure.Persistence;
using DoctorAvailability.Shared.Interfaces;

namespace AppointmentBooking.Infrastructure.Repositories
{
    public class AppointmentRepository(AppDbContext context, ITimeSlotCommand slotCommand, ITimeSlotQuery slotQuery) : IAppointmentRepository
    {
        public async Task<Guid?> BookAppointmentAsync(Guid slotId, Guid patientId, string patientName)
        {
            if (!IsSlotAvailable(slotId)) return null;
            var reservedAppointment = new Appointment
            {
                Id = Guid.NewGuid(),
                PatientId = patientId,
                PatientName = patientName,
                SlotId = slotId,
            };
            context.Appointments.Add(reservedAppointment);
            await context.SaveChangesAsync();
            await slotCommand.MarkSlotAsReserved(slotId);
            return reservedAppointment.Id;
        }

        private bool IsSlotAvailable(Guid slotId)
            => slotQuery.GetAvailableTimeSlot().Any(x => x.Id == slotId);

    }
}
