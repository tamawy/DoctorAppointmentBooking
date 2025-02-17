namespace AppointmentBooking.Shared.Events;

public interface IEventPublisher
{
    void Publish(IAppointmentBookingEvent bookingEvent);
}