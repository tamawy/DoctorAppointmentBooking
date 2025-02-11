namespace AppointmentBooking.Application.Interfaces.Repositories
{
    public interface IAppointmentRepository
    {
        Task<Guid?> BookAppointmentAsync(Guid slotId, Guid patientId, string patientName);
    }
}
