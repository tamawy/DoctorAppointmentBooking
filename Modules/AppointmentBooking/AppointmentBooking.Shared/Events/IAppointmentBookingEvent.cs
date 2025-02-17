namespace AppointmentBooking.Shared.Events;

public interface IAppointmentBookingEvent
{
}

public record AppointmentBookingEvent(string PatientName, string DoctorName, DateTime? AppointmentTime) : IAppointmentBookingEvent;