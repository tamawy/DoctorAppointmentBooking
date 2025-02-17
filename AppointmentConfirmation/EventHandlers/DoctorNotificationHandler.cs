using AppointmentBooking.Shared.Events;
using AppointmentBooking.Shared.OutGoing;

namespace AppointmentConfirmation.EventHandlers
{
    internal class DoctorNotificationHandler : IEventHandler
    {
        public void Handle(IAppointmentBookingEvent bookingEvent)
        {
            if (bookingEvent is AppointmentBookingEvent appointmentEvent)
                Console.WriteLine($"Hi Doctor {appointmentEvent.DoctorName}, an appointment is just booked by {appointmentEvent.PatientName}.");
        }
    }
}
