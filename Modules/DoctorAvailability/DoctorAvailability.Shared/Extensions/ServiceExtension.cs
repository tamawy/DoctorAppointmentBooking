using Shared.Interfaces;

namespace DoctorAvailability.Shared.Extensions
{
    public interface IDoctorAvailabilityRegister : IModuleConfigurations
    {
        //void RegisterService(IServiceCollection services, IMvcBuilder builder);
    }
}
//{
//    public static class ServiceExtension
//    {
//        public static void ConfigureDoctorAvailabilityDb(this IServiceCollection services)
//        {
//            services.AddDbContext<ApplicationDbContext>(options =>
//            {
//                options.UseInMemoryDatabase("DoctorAvailabilityDb");
//            });
//        }
//        public static void ConfigureDoctorAvailabilityScope(this IServiceCollection services)
//        {
//            services.AddScoped<DoctorsDal>();
//            services.AddScoped<TimeSlotsDAL>();
//            services.AddScoped<ITimeSlotCommand, TimeSlotCommandHandler>();
//            services.AddScoped<ITimeSlotQuery, TimeSlotQueryHandler>();
//        }
//    }
//}
