namespace AppointmentBooking.Shared.Incoming.Interfaces
{
    public interface IAppointmentServices
    {
        public Task<Guid?> BookAppointmentAsync(Guid slotId, Guid patientId, string patientName);
    }
}
