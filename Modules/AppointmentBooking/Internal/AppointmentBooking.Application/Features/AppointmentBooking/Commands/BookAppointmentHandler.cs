using AppointmentBooking.Application.Interfaces.Repositories;
using MediatR;

namespace AppointmentBooking.Application.Features.AppointmentBooking.Commands
{
    public class BookAppointmentCommand : IRequest<Guid?>
    {
        public Guid SlotId { get; set; }
        public Guid PatientId { get; set; }
        public required string PatientName { get; set; }
    }
    public class BookAppointmentHandler(IAppointmentRepository appointmentRepository) : IRequestHandler<BookAppointmentCommand, Guid?>
    {
        public async Task<Guid?> Handle(BookAppointmentCommand request, CancellationToken cancellationToken)
        {
            var appointmentId =
                await appointmentRepository.BookAppointmentAsync(request.SlotId, request.PatientId,
                    request.PatientName);
            if (appointmentId == null) throw new InvalidOperationException();
            // Notify that a slot has been booked
            return appointmentId;
        }
    }
}