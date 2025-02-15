using AppointmentBooking.Application.Implementation;
using AppointmentBooking.Application.Interfaces.Repositories;
using AppointmentBooking.Shared.Incoming.Interfaces;
using AppointmentBooking.Shared.OutGoing;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AppointmentBooking.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAppointmentBookingApplication(this IServiceCollection services)
        {
            var assembly = typeof(ServiceCollectionExtensions).Assembly;
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
            var applicationAssembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(applicationAssembly));
            services.AddScoped<IAppointmentServices, AppointmentService>();
            services.AddScoped<IAvailableSlotsService, AvailableSlotService>();
            services.AddScoped<IDoctorAvailabilityService, DoctorAvailabilityService>();

        }
    }
}
