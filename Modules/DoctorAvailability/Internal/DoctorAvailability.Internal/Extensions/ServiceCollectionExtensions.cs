using DoctorAvailability.Internal.DAL;
using DoctorAvailability.Internal.EF;
using DoctorAvailability.Internal.Handlers.Commands;
using DoctorAvailability.Internal.Handlers.Queries;
using DoctorAvailability.Shared.Interfaces;
using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorAvailability.Internal.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureDoctorAvailabilityDb(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseInMemoryDatabase("DoctorAvailabilityDb");
            });
        }

        public static void AddDoctorAvailability(this IServiceCollection services)
        {
            // Register mapster
            var config = TypeAdapterConfig.GlobalSettings;
            services.AddSingleton(config);
            services.AddScoped<IMapper, Mapper>();

            services.AddScoped<DoctorsDal>();
            services.AddScoped<TimeSlotsDAL>();
            services.AddScoped<ITimeSlotCommand, TimeSlotCommandHandler>();
            services.AddScoped<ITimeSlotQuery, TimeSlotQueryHandler>();
        }
    }
}
