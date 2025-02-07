using DoctorAvailability.Internal.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Internal.EF
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
