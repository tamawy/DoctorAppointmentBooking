using DoctorAvailability.API.Controllers;
using DoctorAvailability.Internal.Extensions;
using DoctorAvailability.Shared.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorAvailability.API.Extensions
{
    public class DoctorAvailabilityConfigurations : IDoctorAvailabilityRegister
    {


        public void RegisterModule(IServiceCollection services, IMvcBuilder builder)
        {
            services.AddDoctorAvailability();
            services.ConfigureDoctorAvailabilityDb();
            services.AddScoped<IDoctorAvailabilityRegister, DoctorAvailabilityConfigurations>();
            builder.AddApplicationPart(typeof(DoctorAvailabilityController).Assembly).AddControllersAsServices();
        }

        //public static void AddDoctorAvailabilityApi(this IServiceCollection services)
        //{
        //    services.AddDoctorAvailability();
        //    services.ConfigureDoctorAvailabilityDb();
        //}

        //public void AddControllers(IMvcBuilder mvcBuilder)
        //{
        //    mvcBuilder.AddApplicationPart(typeof(ServiceCollectionExtensions).Assembly);
        //}

        //public void RegisterModule(IServiceCollection services)
        //{
        //    services.ConfigureDoctorAvailabilityDb();
        //    services.AddDoctorAvailability();
        //}
    }
}
