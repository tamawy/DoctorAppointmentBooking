using AppointmentBooking.Shared.Incoming.Interfaces;
using AppointmentBooking.Application.Features.AppointmentBooking.Commands;

namespace AppointmentBooking.Shared.Incoming.Implementation
{
    internal class AppointmentService(BookAppointmentHandler appointmentBooking) : IAppointmentServices
    {
        public async Task<Guid?> BookAppointmentAsync(Guid slotId, Guid patientId, string patientName)
        {
            var command = new BookAppointmentCommand
            {
                SlotId = slotId,
                PatientId = patientId,
                PatientName = patientName
            };

            return await appointmentBooking.Handle(command, CancellationToken.None);
        }
    }
}
