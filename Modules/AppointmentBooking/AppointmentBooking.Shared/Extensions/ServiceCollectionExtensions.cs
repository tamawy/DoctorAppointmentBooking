using AppointmentBooking.Application.Extensions;
using AppointmentBooking.Application.Features.AppointmentBooking.Commands;
using AppointmentBooking.Application.Features.AvailableSlots.Queries;
using AppointmentBooking.Application.Interfaces.Services;
using AppointmentBooking.Infrastructure.Extensions;
using AppointmentBooking.Shared.Incoming.Implementation;
using AppointmentBooking.Shared.Incoming.Interfaces;
using AppointmentBooking.Shared.OutGoing;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentBooking.Shared.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAppointmentBooking(this IServiceCollection services)
        {
            services.AddAppointmentBookingApplication();
            services.AddAppointmentBookingInfrastructure();

            services.AddScoped<IAppointmentServices, AppointmentService>();
            services.AddScoped<IAvailableSlotsService, AvailableSlotService>();
            services.AddScoped<IDoctorAvailabilityService, DoctorAvailabilityService>();

            var assembly = typeof(ServiceCollectionExtensions).Assembly;
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            services.AddScoped<BookAppointmentHandler>();
            services.AddScoped<GetAllAvailableSlotsHandler>();
        }
    }
}
