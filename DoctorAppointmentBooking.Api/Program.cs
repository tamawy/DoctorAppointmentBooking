using AppointmentBooking.Shared.Extensions;
using DoctorAvailability.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
var mvcBuilder = builder.Services.AddControllers();

// Configure Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dynamically register modules
var registerTypes = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(a => a.GetTypes())
    .Where(t => typeof(IDoctorAvailabilityRegister).IsAssignableFrom(t) ||
                typeof(IAppointmentBookingRegister).IsAssignableFrom(t))
    .Where(t => !t.IsInterface && !t.IsAbstract);

foreach (var type in registerTypes)
{
    if (typeof(IDoctorAvailabilityRegister).IsAssignableFrom(type))
    {
        var instance = (IDoctorAvailabilityRegister)Activator.CreateInstance(type)!;
        instance.RegisterModule(builder.Services, mvcBuilder);
    }
    else if (typeof(IAppointmentBookingRegister).IsAssignableFrom(type))
    {
        var instance = (IAppointmentBookingRegister)Activator.CreateInstance(type)!;
        instance.RegisterModule(builder.Services, mvcBuilder);
    }
}



var app = builder.Build();

app.UseRouting(); // ✅ Required for routing
app.UseAuthorization();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
