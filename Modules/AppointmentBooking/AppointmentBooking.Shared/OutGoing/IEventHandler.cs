using AppointmentBooking.Shared.Events;

namespace AppointmentBooking.Shared.OutGoing;

public interface IEventHandler<T> where T : IAppointmentBookingEvent
{
    void Handle(T bookingEvent);
}