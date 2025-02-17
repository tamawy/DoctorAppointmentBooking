
using AppointmentBooking.Shared.Events;
using AppointmentBooking.Shared.OutGoing;

namespace AppointmentBooking.Infrastructure.Repositories;

public class PublishingService(IEventHandler<IAppointmentBookingEvent> eventHandler) : IEventPublisher
{
    public void Publish(IAppointmentBookingEvent bookingEvent)
    {
        eventHandler.Handle(bookingEvent);
    }
}