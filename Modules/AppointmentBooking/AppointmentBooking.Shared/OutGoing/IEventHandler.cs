using AppointmentBooking.Shared.Events;

namespace AppointmentBooking.Shared.OutGoing;

public interface IEventHandler
{
    void Handle(IAppointmentBookingEvent bookingEvent);
}