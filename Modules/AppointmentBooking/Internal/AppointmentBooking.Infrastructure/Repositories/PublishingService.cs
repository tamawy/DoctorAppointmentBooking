
using AppointmentBooking.Shared.Events;
using AppointmentBooking.Shared.OutGoing;

namespace AppointmentBooking.Infrastructure.Repositories;

public class PublishingService(IEnumerable<IEventHandler> eventHandlers) : IEventPublisher
{
    public void Publish(IAppointmentBookingEvent bookingEvent)
    {
        foreach (var eventHandler in eventHandlers)
        {
            eventHandler.Handle(bookingEvent);
        }

    }
}