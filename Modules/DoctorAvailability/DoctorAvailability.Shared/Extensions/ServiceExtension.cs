using DoctorAvailability.Internal.DAL;
using DoctorAvailability.Internal.EF;
using DoctorAvailability.Shared.Handlers.Commands;
using DoctorAvailability.Shared.Handlers.Queries;
using DoctorAvailability.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorAvailability.Shared.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDoctorAvailabilityDb(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseInMemoryDatabase("DoctorAvailabilityDb");
            });
        }
        public static void ConfigureDoctorAvailabilityScope(this IServiceCollection services)
        {
            services.AddScoped<DoctorsDal>();
            services.AddScoped<TimeSlotsDAL>();
            services.AddScoped<ITimeSlotCommand, TimeSlotCommandHandler>();
            services.AddScoped<ITimeSlotQuery, TimeSlotQueryHandler>();
        }
    }
}
