using AppointmentBooking.API.Controllers;
using AppointmentBooking.Application.Extensions;
using AppointmentBooking.Infrastructure.Extensions;
using AppointmentBooking.Shared.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentBooking.API.Extensions
{
    public class AddAppointmentBooking : IAppointmentBookingRegister
    {
        public void RegisterModule(IServiceCollection services, IMvcBuilder builder)
        {
            services.AddAppointmentBookingApplication();
            services.AddAppointmentBookingInfrastructure();
            services.AddScoped<IAppointmentBookingRegister, AddAppointmentBooking>();
            builder.AddApplicationPart(typeof(AppointmentBookingController).Assembly).AddControllersAsServices();

        }
    }
}
