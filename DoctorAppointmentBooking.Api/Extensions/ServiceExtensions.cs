using DoctorAvailability.Shared.Extensions;

namespace DoctorAppointmentBooking.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDoctorAvailability(this IServiceCollection service)
        {
            service.ConfigureDoctorAvailabilityDb();
            service.ConfigureDoctorAvailabilityScope();
        }

    }
}
