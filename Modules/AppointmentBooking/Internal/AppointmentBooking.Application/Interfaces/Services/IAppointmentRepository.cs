namespace AppointmentBooking.Application.Interfaces.Services
{
    public interface IAppointmentRepository
    {
        Task<Appointment?> BookAppointmentAsync(Guid slotId, Guid patientId, string patientName, string doctorName);
    }
}
