using AppointmentBooking.Application.Features.AppointmentBooking.Commands;
using AppointmentBooking.Application.Features.AvailableSlots.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentBooking.API.Controllers
{
    [Route("api/AppointmentBooking")]
    [ApiController]
    public class AppointmentBookingController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var availableSlots = await availableSlotsService.GetAvailableSlotsAsync();
            var availableSlots = await mediator.Send(new GetAllAvailableSlotsQuery());
            if (availableSlots is null) return NotFound("No slots are available yet!");
            return Ok(availableSlots);
        }

        [HttpPost]
        public async Task<IActionResult> AppointmentBooking(BookAppointmentCommand? command)
        {
            var appointmentId = await mediator.Send(command!);
            if (appointmentId is null) return NotFound();
            return Ok(appointmentId);
        }

        public static class AssemblyReference
        {
        }
    }


}

