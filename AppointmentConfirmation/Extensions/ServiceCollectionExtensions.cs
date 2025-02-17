using AppointmentBooking.Shared.OutGoing;
using AppointmentConfirmation.EventHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentConfirmation.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAppointmentConfirmation(this IServiceCollection services)
        {
            services.AddScoped<IEventHandler, PatientNotificationHandler>();
            services.AddScoped<IEventHandler, DoctorNotificationHandler>();

        }
    }
}
