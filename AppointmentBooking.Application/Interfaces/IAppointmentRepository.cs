namespace AppointmentBooking.Application.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<Guid?> BookAppointmentAsync(Guid slotId, Guid patientId, string patientName);
    }
}
