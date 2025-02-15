//using AppointmentBooking.Shared.Incoming.Interfaces;
//using DoctorAvailability.Shared.Models;

//namespace AppointmentBooking.Shared.Incoming.Implementation
//{
//    internal class AvailableSlotService(GetAllAvailableSlotsHandler availableSlotHandler) : IAvailableSlotsService
//    {
//        public async Task<IEnumerable<TimeSlotDto?>> GetAvailableSlotsAsync()
//        {
//            return await availableSlotHandler.Handle(new GetAllAvailableSlotsQuery(), CancellationToken.None);
//        }
//    }
//}
