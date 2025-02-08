using AppointmentBooking.Application.Interfaces;
using MediatR;

namespace AppointmentBooking.Application.Commands.BookingAppointmentCase.Command
{
    internal class BookAppointmentCommand : IRequest<Guid?>
    {
        public Guid slotId { get; set; }
        public Guid PatientId { get; set; }
        public string PatientName { get; set; }
    }
    internal class BookAppointmentHandler(IAppointmentRepository appointmentRepository) : IRequestHandler<BookAppointmentCommand, Guid?>
    {
        public async Task<Guid?> Handle(BookAppointmentCommand request, CancellationToken cancellationToken)
        {
            var appointmentId =
                await appointmentRepository.BookAppointmentAsync(request.slotId, request.PatientId,
                    request.PatientName);
            if (appointmentId == null) throw new InvalidOperationException();
            return appointmentId;
        }
    }
}