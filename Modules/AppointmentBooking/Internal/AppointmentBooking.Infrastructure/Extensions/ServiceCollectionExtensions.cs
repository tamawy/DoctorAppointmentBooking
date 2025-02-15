using AppointmentBooking.Application.Features.AppointmentBooking.Commands;
using AppointmentBooking.Application.Features.AvailableSlots.Queries;
using AppointmentBooking.Application.Interfaces.Repositories;
using AppointmentBooking.Infrastructure.Persistence;
using AppointmentBooking.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentBooking.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAppointmentBookingInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseInMemoryDatabase("DoctorAvailabilityDb"));

            var assembly = typeof(ServiceCollectionExtensions).Assembly;
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            services.AddScoped<BookAppointmentHandler>();
            services.AddScoped<GetAllAvailableSlotsHandler>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        }
    }
}
