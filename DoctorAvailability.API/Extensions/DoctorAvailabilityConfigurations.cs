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

        
    }
}
