using AppointmentBooking.Application.Features.AppointmentBooking.Commands;
using AppointmentBooking.Application.Features.AvailableSlots.Queries;
using AppointmentBooking.Application.Interfaces.Services;
using AppointmentBooking.Infrastructure.Persistence;
using AppointmentBooking.Infrastructure.Repositories;
using AppointmentBooking.Shared.Events;
using AppointmentBooking.Shared.Incoming.Implementation;
using AppointmentBooking.Shared.Incoming.Interfaces;
using Mapster;
using MapsterMapper;
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
            services.AddScoped<IAvailableSlotsService, AvailableTimeSlotsService>();
            services.AddScoped<IAvailableSlots, AvailableSlotService>();
            services.AddScoped<IEventPublisher, PublishingService>();
            // Register mapster
            var config = TypeAdapterConfig.GlobalSettings;
            services.AddSingleton(config);
            services.AddScoped<IMapper, Mapper>();
        }
    }
}
