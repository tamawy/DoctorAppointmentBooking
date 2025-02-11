namespace AppointmentBooking.Shared.Incoming.Interfaces
{
    internal interface IAppointmentServices
    {
        public Task<Guid?> BookAppointmentAsync(Guid slotId, Guid patientId, string patientName);
    }
}
