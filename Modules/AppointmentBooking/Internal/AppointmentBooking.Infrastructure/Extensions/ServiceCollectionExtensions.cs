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

            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        }
    }
}
