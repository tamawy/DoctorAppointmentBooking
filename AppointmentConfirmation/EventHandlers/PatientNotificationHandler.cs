using AppointmentBooking.Shared.Events;
using AppointmentBooking.Shared.OutGoing;

namespace AppointmentConfirmation.EventHandlers
{
    internal class PatientNotificationHandler : IEventHandler
    {
        public void Handle(IAppointmentBookingEvent bookingEvent)
        {
            if (bookingEvent is AppointmentBookingEvent appointmentBookingEvent)
                Console.WriteLine($"Hi {appointmentBookingEvent.PatientName}, your appointment with doctor {appointmentBookingEvent.DoctorName} at {appointmentBookingEvent.AppointmentTime}");
        }
    }
}
