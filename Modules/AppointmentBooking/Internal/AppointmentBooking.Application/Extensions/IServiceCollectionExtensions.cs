﻿using Microsoft.Extensions.DependencyInjection;

namespace AppointmentBooking.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAppointmentBookingApplication(this IServiceCollection services)
        {
            var assembly = typeof(ServiceCollectionExtensions).Assembly;
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
        }
    }
}
