using DoctorAvailability.Shared.Interfaces;
using DoctorAvailability.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointmentBooking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorAvailabilityController : ControllerBase
    {
        private readonly ITimeSlotCommand timeSlotCommandApi;
        private readonly ITimeSlotQuery timeSlotQueryApi;

        public DoctorAvailabilityController
            (ITimeSlotCommand timeSlotCommandApi, ITimeSlotQuery timeSlotQueryApi)
        {
            this.timeSlotCommandApi = timeSlotCommandApi;
            this.timeSlotQueryApi = timeSlotQueryApi;
        }
        // GET: api/<DoctorAvailabilityController>
        [HttpGet]
        public IEnumerable<TimeSlotResponse> Get()
        {
            return timeSlotQueryApi.GetAllTimeSlots();
        }

        // POST api/<DoctorAvailabilityController>
        [HttpPost]
        public void Post([FromBody] TimeSlotRequest value)
        {
            timeSlotCommandApi.AddTimeSlot(value);
        }
    }
}