using AppointmentBooking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBooking.Infrastructure.Persistence
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
