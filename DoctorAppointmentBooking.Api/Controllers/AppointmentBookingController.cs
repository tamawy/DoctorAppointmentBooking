using AppointmentBooking.Shared.Incoming.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointmentBooking.Api.Controllers
{
    [Route("api/AppointmentBooking")]
    [ApiController]
    public class AppointmentBookingController(IAvailableSlotsService availableSlotsService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var availableSlots = await availableSlotsService.GetAvailableSlotsAsync();
            if (availableSlots is null) return NotFound("No slots are available yet!");
            return Ok(availableSlots);
        }
    }
}
