//using AppointmentBooking.Application.Features.AvailableSlots.Queries;

//namespace AppointmentBooking.Application.Implementation
//{
//    internal class AvailableSlotService(GetAllAvailableSlotsHandler availableSlotHandler) : IAvailableSlotsService
//    {
//        public async Task<IEnumerable<TimeSlotDto?>> GetAvailableSlotsAsync()
//        {
//            return await availableSlotHandler.Handle(new GetAllAvailableSlotsQuery(), CancellationToken.None);
//        }
//    }
//}
