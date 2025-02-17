using AppointmentBooking.Application.Interfaces.Services;
using AppointmentBooking.Shared.Events;
using MediatR;

namespace AppointmentBooking.Application.Features.AppointmentBooking.Commands
{
    public class BookAppointmentCommand : IRequest<Guid?>
    {
        public Guid SlotId { get; set; }
        public Guid PatientId { get; set; }
        public required string PatientName { get; set; }
    }
    public class BookAppointmentHandler(IAppointmentRepository appointmentRepository, IEventPublisher publisher) : IRequestHandler<BookAppointmentCommand, Guid?>
    {
        public async Task<Guid?> Handle(BookAppointmentCommand request, CancellationToken cancellationToken)
        {
            var appointment =
                await appointmentRepository.BookAppointmentAsync(request.SlotId, request.PatientId,
                    request.PatientName);
            if (appointment == null) throw new InvalidOperationException();
            // Notify that a slot has been booked
            foreach (var appointmentEvent in appointment.DomainEvents)
            {
                publisher.Publish(appointmentEvent);
            }
            return appointment.Id;
        }
    }
}