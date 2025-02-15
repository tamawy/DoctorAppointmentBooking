namespace AppointmentBooking.Application.Interfaces.Services
{
    public interface IAppointmentRepository
    {
        Task<Guid?> BookAppointmentAsync(Guid slotId, Guid patientId, string patientName);
    }
}
