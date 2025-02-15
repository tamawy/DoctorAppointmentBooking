//using DoctorAvailability.Shared.Interfaces;
//using DoctorAvailability.Shared.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace DoctorAppointmentBooking.Api.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class DoctorAvailabilityController(ITimeSlotCommand timeSlotCommandApi, ITimeSlotQuery timeSlotQueryApi)
//        : ControllerBase
//    {
//        // GET: api/<DoctorAvailabilityController>
//        [HttpGet]
//        public IEnumerable<TimeSlotResponse> Get()
//        {
//            return timeSlotQueryApi.GetAllTimeSlots();
//        }

//        // POST api/<DoctorAvailabilityController>
//        [HttpPost]
//        public void Post([FromBody] TimeSlotRequest value)
//        {
//            timeSlotCommandApi.AddTimeSlot(value);
//        }


//    }
//}